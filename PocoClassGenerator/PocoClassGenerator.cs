using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

[Flags]
public enum GeneratorBehavior
{
	Default = 0x0,
	View = 0x1,
	DapperContrib = 0x2,
	Comment = 0x4,
	DapperContribExtended = 0xA,
}

public static partial class PocoClassGenerator
{
	#region Property
	private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string> {
			   { typeof(int), "int" },
			   { typeof(short), "short" },
			   { typeof(byte), "byte" },
			   { typeof(byte[]), "byte[]" },
			   { typeof(long), "long" },
			   { typeof(double), "double" },
			   { typeof(decimal), "decimal" },
			   { typeof(float), "float" },
			   { typeof(bool), "bool" },
			   { typeof(string), "string" }
	   };

	private static readonly Dictionary<string, string> QuerySqls = new Dictionary<string, string> {
			   {"sqlconnection", "select  *  from [{0}] where 1=2" },
			   {"sqlceserver", "select  *  from [{0}] where 1=2" },
			   {"sqliteconnection", "select  *  from [{0}] where 1=2" },
			   {"oracleconnection", "select  *  from \"{0}\" where 1=2" },
			   {"mysqlconnection", "select  *  from `{0}` where 1=2" },
			   {"npgsqlconnection", "select  *  from \"{0}\" where 1=2" }
	   };

	private static readonly Dictionary<string, string> TableSchemaSqls = new Dictionary<string, string> {
			   {"sqlconnection", "select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'" },
			   {"sqlceserver", "select TABLE_NAME from INFORMATION_SCHEMA.TABLES  where TABLE_TYPE = 'BASE TABLE'" },
			   {"sqliteconnection", "SELECT name FROM sqlite_master where type = 'table'" },
			   {"oracleconnection", "select TABLE_NAME from USER_TABLES where table_name not in (select View_name from user_views)" },
			   {"mysqlconnection", "select TABLE_NAME from  information_schema.tables where table_type = 'BASE TABLE'" },
			   {"npgsqlconnection", "select table_name from information_schema.tables where table_type = 'BASE TABLE'" }
	   };


	private static readonly HashSet<Type> NullableTypes = new HashSet<Type> {
			   typeof(int),
			   typeof(short),
			   typeof(long),
			   typeof(double),
			   typeof(decimal),
			   typeof(float),
			   typeof(bool),
			   typeof(DateTime)
	   };
	#endregion

	public static string GenerateAllTables(this System.Data.Common.DbConnection connection, GeneratorBehavior generatorBehavior = GeneratorBehavior.Default)
	{
		if (connection.State != ConnectionState.Open) connection.Open();

		var conneciontName = connection.GetType().Name.ToLower();
		var tables = new List<string>();
		var sql = generatorBehavior.HasFlag(GeneratorBehavior.View) ? TableSchemaSqls[conneciontName].Split("where")[0] : TableSchemaSqls[conneciontName];
		using (var command = connection.CreateCommand(sql))
		using (var reader = command.ExecuteReader())
		{
			while (reader.Read())
				tables.Add(reader.GetString(0));
		}

		var sb = new StringBuilder();
		sb.AppendLine("namespace Models { ");
		for (var index = 0; index < tables.Count; index++)
		{
			var table = tables[index];
			sb.Append(connection.GenerateClass(
				string.Format(QuerySqls[conneciontName], table), table, generatorBehavior: generatorBehavior
			));
		}

		sb.AppendLine("}");
		return sb.ToString();
	}

	public static string GenerateClass(this IDbConnection connection, string sql, GeneratorBehavior generatorBehavior)
		 => connection.GenerateClass(sql, null, generatorBehavior);

	public static string GenerateClass(this IDbConnection connection, string sql, string className = null, GeneratorBehavior generatorBehavior = GeneratorBehavior.Default)
	{
		if (connection.State != ConnectionState.Open) connection.Open();

		var builder = new StringBuilder();

		string tableName;
		//Get Table Name
		//Fix : [When View using CommandBehavior.KeyInfo will get duplicate columns �P Issue #8 �P shps951023/PocoClassGenerator](https://github.com/shps951023/PocoClassGenerator/issues/8 )
		var isFromMutiTables = false;
		using (var command = connection.CreateCommand(sql))
		using (var reader = command.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SingleRow))
		{
			var tables = reader.GetSchemaTable().Select().Select(s => s["BaseTableName"] as string).Distinct();
			tableName = string.IsNullOrWhiteSpace(className) ? tables.First() ?? "Info" : className;

			isFromMutiTables = tables.Count() > 1;

			if (generatorBehavior.HasFlag(GeneratorBehavior.DapperContrib) && !isFromMutiTables)
				builder.AppendFormat("	[Dapper.Contrib.Extensions.Table(\"{0}\")]{1}", tableName, Environment.NewLine);
			builder.AppendFormat("	public class {0}{1}", tableName.Replace(" ", ""), Environment.NewLine);
			builder.AppendLine("	{");
		}
		
		// Get Unique Columns
		var uniqueColumns = new List<string>();
		if (generatorBehavior.HasFlag(GeneratorBehavior.DapperContribExtended))
		{
			string sqlUniqueColumns = $@"SELECT 
									     ColumnName = col.name
									FROM 
									     sys.indexes ind 
									INNER JOIN 
									     sys.index_columns ic ON  ind.object_id = ic.object_id and ind.index_id = ic.index_id 
									INNER JOIN 
									     sys.columns col ON ic.object_id = col.object_id and ic.column_id = col.column_id 
									INNER JOIN 
									     sys.tables t ON ind.object_id = t.object_id 
									WHERE 
									     ind.is_primary_key = 0 
									     AND ind.is_unique = 1
										 And t.name = '{tableName}'";

			using (var command = connection.CreateCommand(sqlUniqueColumns))
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
					uniqueColumns.Add(reader.GetString(0));
			}
		}

		// get foreign key columns
		var foreignKeyColumns = new List<Tuple<string, string>>();
		if (generatorBehavior.HasFlag(GeneratorBehavior.DapperContribExtended))
		{
			string sqlForeignKeys = $@"SELECT 
										    rc.CONSTRAINT_NAME,         
										    rcu.TABLE_NAME 'ReferencingTable', 
										    rcu.COLUMN_NAME 'ReferencingColumn',
										    rcu1.TABLE_NAME 'ReferencedTable',
										    rcu1.COLUMN_NAME 'ReferencedColumn'
										FROM
										    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc
										INNER JOIN 
										    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE rcu 
										        ON rc.CONSTRAINT_CATALOG = rcu.CONSTRAINT_CATALOG 
										        AND rc.CONSTRAINT_NAME = rcu.CONSTRAINT_NAME
										INNER JOIN 
										    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE rcu1 
										        ON rc.UNIQUE_CONSTRAINT_CATALOG = rcu1.CONSTRAINT_CATALOG 
										        AND rc.UNIQUE_CONSTRAINT_NAME = rcu1.CONSTRAINT_NAME
										WHERE rcu.TABLE_NAME = '{tableName}'";

			using (var command = connection.CreateCommand(sqlForeignKeys))
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
					foreignKeyColumns.Add(new Tuple<string, string>(reader.GetString(2), reader.GetString(3)));
			}
		}

		//Get Columns 
		var behavior = isFromMutiTables ? (CommandBehavior.SchemaOnly | CommandBehavior.SingleRow) : (CommandBehavior.KeyInfo | CommandBehavior.SingleRow);

		using (var command = connection.CreateCommand(sql))
		using (var reader = command.ExecuteReader(behavior))
		{
			do
			{
				var schema = reader.GetSchemaTable();
				foreach (DataRow row in schema.Rows)
				{
					var type = (Type)row["DataType"];
					var name = TypeAliases.ContainsKey(type) ? TypeAliases[type] : type.FullName;
					var isNullable = (bool)row["AllowDBNull"] && NullableTypes.Contains(type);
					var collumnName = (string)row["ColumnName"];

					if (generatorBehavior.HasFlag(GeneratorBehavior.Comment) && !isFromMutiTables)
					{
						var comments = new[] { "DataTypeName", "IsUnique", "IsKey", "IsAutoIncrement", "IsReadOnly" }
							   .Select(s =>
							   {
								   if (row[s] is bool && ((bool)row[s]))
									   return s;
								   if (row[s] is string && !string.IsNullOrWhiteSpace((string)row[s]))
									   return string.Format(" {0} : {1} ", s, row[s]);
								   return null;
							   }).Where(w => w != null).ToArray();
						var sComment = string.Join(" , ", comments);

						builder.AppendFormat("		/// <summary>{0}</summary>{1}", sComment, Environment.NewLine);
					}

					if (generatorBehavior.HasFlag(GeneratorBehavior.DapperContrib) && !isFromMutiTables)
					{
						var isKey = (bool)row["IsKey"];
						var isAutoIncrement = (bool)row["IsAutoIncrement"];
						if (isKey && isAutoIncrement)
							builder.AppendLine("		[Dapper.Contrib.Extensions.Key]");
						if (isKey && !isAutoIncrement)
							builder.AppendLine("		[Dapper.Contrib.Extensions.ExplicitKey]");
						if (!isKey && isAutoIncrement)
							builder.AppendLine("		[Dapper.Contrib.Extensions.Computed]");
					}

					if (generatorBehavior.HasFlag(GeneratorBehavior.DapperContribExtended) && !isFromMutiTables)
					{
						if(uniqueColumns.Contains(collumnName))
							builder.AppendLine("		[UniqueConstraint]");
						
						var foreignKeys = foreignKeyColumns.Where(f => f.Item1 == collumnName);
						if(foreignKeys.Any())
							builder.AppendLine("		[ForeignKey(typeof(" + foreignKeys.First().Item2 + "))]");
					}

					builder.AppendLine(string.Format("		public {0}{1} {2} {{ get; set; }}", name, isNullable ? "?" : string.Empty, collumnName));
				}

				builder.AppendLine("	}");
				builder.AppendLine();
			} while (reader.NextResult());

			return builder.ToString();
		}
	}

	#region Private
	private static string[] Split(this string text, string splitText) => text.Split(new[] { splitText }, StringSplitOptions.None);
	private static IDbCommand CreateCommand(this IDbConnection connection, string sql)
	{
		var cmd = connection.CreateCommand();
		cmd.CommandText = sql;
		return cmd;
	}
	#endregion
}