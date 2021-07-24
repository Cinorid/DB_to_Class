using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DB_to_Dapper
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public ControllerMain Controller { get; set; }

		protected override void OnStartup(StartupEventArgs e)
		{
			//base.OnStartup(e);

			Controller = new ControllerMain();

			MainWindow = new MainWindow()
			{
				DataContext = Controller
			};

			MainWindow.ShowDialog();
		}
	}
}
