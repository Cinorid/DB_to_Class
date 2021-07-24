using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Input;

namespace DB_to_Dapper
{
	public class CommadConvert : ICommand
	{
		public ControllerMain ModelMain { get; set; }

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public CommadConvert(ControllerMain model)
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
				try
				{
					using (var connection = new SqlConnection(ModelMain.ConnectionString))
					{
						if (!string.IsNullOrWhiteSpace(ModelMain.SQLString))
						{
							if (ModelMain.AddDapperAttributes)
							{
								ModelMain.ResultString = connection.GenerateClass(ModelMain.SQLString, GeneratorBehavior.DapperContrib);
							}
							else
							{
								ModelMain.ResultString = connection.GenerateClass(ModelMain.SQLString, GeneratorBehavior.Default);
							}
						}
						else
						{
							if (ModelMain.AddDapperAttributes)
							{
								ModelMain.ResultString = connection.GenerateAllTables(GeneratorBehavior.DapperContrib);
							}
							else
							{
								ModelMain.ResultString = connection.GenerateAllTables(GeneratorBehavior.Default);
							}
						}

						ModelMain.ErrorOccurred = false;
					}
				}
				catch (Exception ex)
				{
					ModelMain.ResultString = ex.Message;
					ModelMain.ErrorOccurred = true;
				}
			}
		}
	}
}
