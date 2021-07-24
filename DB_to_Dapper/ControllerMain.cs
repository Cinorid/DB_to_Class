using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DB_to_Dapper
{
	public class ControllerMain : INotifyPropertyChanged
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

		private bool _AddDapperAttributes;
		public bool AddDapperAttributes
		{
			get { return _AddDapperAttributes; }
			set
			{
				_AddDapperAttributes = value;
				SendPropertyChanged(nameof(AddDapperAttributes));
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

		public CommadConvert CommadConvert { get; }

		public ControllerMain()
		{
			CommadConvert = new CommadConvert(this);
		}
	}
}
