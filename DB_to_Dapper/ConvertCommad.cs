using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Input;

namespace DB_to_Dapper
{
	public class ConvertCommad : ICommand
	{
		public Model ModelMain { get; set; }

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public ConvertCommad(Model model)
		{
			ModelMain = model;
		}

		public bool CanExecute(object parameter)
		{
			if (ModelMain != null)
			{
				if (!string.IsNullOrWhiteSpace(ModelMain.ConnectionString))
				{
					return true;
				}
			}

			return false;
		}

		public void Execute(object parameter)
		{
			if (ModelMain != null)
			{
				using (var connection = new SqlConnection(ModelMain.ConnectionString))
				{
					if (!string.IsNullOrWhiteSpace(ModelMain.SQLString))
					{
						var classCode = connection.GenerateClass(ModelMain.SQLString, GeneratorBehavior.DapperContrib);
						ModelMain.ResultString = classCode;
					}
					else
					{
						ModelMain.ResultString = connection.GenerateAllTables(GeneratorBehavior.DapperContrib);
					}
				}
			}
		}
	}
}
