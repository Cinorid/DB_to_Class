﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DB_to_Dapper
{
	public class Model : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void SendPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

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

		public ConvertCommad ConvertCommad { get; }

		public Model()
		{
			 ConvertCommad = new ConvertCommad(this);
		}
	}
}
