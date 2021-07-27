using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Input;

namespace DB_to_Class
{
	public class CommandConvert : ICommand
	{
		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public bool CanExecute(object parameter)
		{
			var Controller = parameter as ControllerMain;
			if (Controller != null)
			{
				if (!string.IsNullOrWhiteSpace(Controller.ConnectionString))
				{
					return true;
				}
			}

			return false;
		}

		public void Execute(object parameter)
		{
			var Controller = parameter as ControllerMain;
			if (Controller != null)
			{
				try
				{
					using (var connection = new SqlConnection(Controller.ConnectionString))
					{
						if (!string.IsNullOrWhiteSpace(Controller.SQLString))
						{
							if (Controller.AddDapperAttributes)
							{
								Controller.ResultString = connection.GenerateClass(Controller.SQLString, GeneratorBehavior.DapperContrib);
							}
							else
							{
								Controller.ResultString = connection.GenerateClass(Controller.SQLString, GeneratorBehavior.Default);
							}
						}
						else
						{
							if (Controller.AddDapperAttributes)
							{
								Controller.ResultString = connection.GenerateAllTables(GeneratorBehavior.DapperContrib);
							}
							else
							{
								Controller.ResultString = connection.GenerateAllTables(GeneratorBehavior.Default);
							}
						}

						Controller.ErrorOccurred = false;
					}
				}
				catch (Exception ex)
				{
					Controller.ResultString = ex.Message;
					Controller.ErrorOccurred = true;
				}
			}
		}
	}
}
