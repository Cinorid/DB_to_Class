using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Input;

namespace DB_to_Class
{
	public class CommandConvert : CommandBase
	{
		public override bool CanExecute(object parameter)
		{
			var controller = parameter as ControllerMain;
			if (controller != null)
			{
				if (!string.IsNullOrWhiteSpace(controller.ConnectionString))
				{
					return true;
				}
			}

			return false;
		}

		public override void Execute(object parameter)
		{
			var controller = parameter as ControllerMain;
			if (controller != null)
			{
				try
				{
					using (var connection = new SqlConnection(controller.ConnectionString))
					{
						if (!string.IsNullOrWhiteSpace(controller.SQLString))
						{
							if (controller.AddExtendedAttributes)
							{
								controller.ResultString = connection.GenerateClass(controller.SQLString, GeneratorBehavior.DapperContribExtended);
							}
							else if (controller.AddDapperAttributes)
							{
								controller.ResultString = connection.GenerateClass(controller.SQLString, GeneratorBehavior.DapperContrib);
							}
							else
							{
								controller.ResultString = connection.GenerateClass(controller.SQLString, GeneratorBehavior.Default);
							}
						}
						else
						{
							if (controller.AddExtendedAttributes)
							{
								controller.ResultString = connection.GenerateAllTables(GeneratorBehavior.DapperContribExtended);
							}
							else if (controller.AddDapperAttributes)
							{
								controller.ResultString = connection.GenerateAllTables(GeneratorBehavior.DapperContrib);
							}
							else
							{
								controller.ResultString = connection.GenerateAllTables(GeneratorBehavior.Default);
							}
						}

						controller.ErrorOccurred = false;
					}
				}
				catch (Exception ex)
				{
					controller.ResultString = ex.Message;
					controller.ErrorOccurred = true;
				}
			}
		}
	}
}
