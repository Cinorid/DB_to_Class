﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DB_to_Class
{
	public class ControllerMain : ObservableObject
	{
		private string _ConnectionString;
		public string ConnectionString
		{
			get { return _ConnectionString; }
			set
			{
				_ConnectionString = value;
				SendPropertyChanged(nameof(ConnectionString));
			}
		}

		private string _SQLString;
		public string SQLString
		{
			get { return _SQLString; }
			set
			{
				_SQLString = value;
				SendPropertyChanged(nameof(SQLString));
			}
		}

		private string _ResultString;
		public string ResultString
		{
			get { return _ResultString; }
			set
			{
				_ResultString = value;
				SendPropertyChanged(nameof(ResultString));
			}
		}

		private bool _AddDapperAttributes = true;
		public bool AddDapperAttributes
		{
			get { return _AddDapperAttributes; }
			set
			{
				_AddDapperAttributes = value;
				SendPropertyChanged(nameof(AddDapperAttributes));
			}
		}
		

		private bool _AddExtendedAttributes;
		public bool AddExtendedAttributes
		{
			get { return _AddExtendedAttributes; }
			set
			{
				_AddExtendedAttributes = value;
				if(value)
				{
					AddDapperAttributes = true;
				}
				SendPropertyChanged(nameof(AddExtendedAttributes));
			}
		}

		private bool _ErrorOccurred;
		public bool ErrorOccurred
		{
			get { return _ErrorOccurred; }
			set
			{
				_ErrorOccurred = value;
				SendPropertyChanged(nameof(ErrorOccurred));
			}
		}

		public CommandConvert CommandConvert { get; } = new CommandConvert();
		public CopyCommand CopyCommand { get; } = new CopyCommand();

		public ControllerMain()
		{
			ConnectionString = "Data Source=.;Initial Catalog=AccAmj;Integrated Security=True;";
			SQLString = "SELECT * FROM tblSalesFactor";

			//for (int i = 0; i < 999999999; i++) ;

			//int a = 0;
			//int b = 0;
			//int c = a / b;

			//string test = null;
			//test.Trim();

			//try
			//{
			//	//int a = 0;
			//	//int b = 0;
			//	//int c = a / b;

			//	string test = null;
			//	test.Trim();
			//}
			//catch (DivideByZeroException)
			//{
			//	throw new DivideByZeroException("خطای تقسیم بر صفر در بخش محاسبه شسیشسیشسی");
			//}
			//catch (NullReferenceException)
			//{
			//	throw new NullReferenceException("خطای عدم مقدار دهی پارامتر طططططط");
			//}
			//catch (Exception ex)
			//{
			//	throw new DivideByZeroException($"خطای نامشخص: {ex.Message}");
			//}
		}
	}
}
