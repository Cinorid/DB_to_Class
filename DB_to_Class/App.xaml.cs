using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DB_to_Class
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static ControllerMain Controller { get; set; }
		public static WindowSplash Splash = new WindowSplash();

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			try
			{
				Splash.Show();

				Controller = new ControllerMain();

				MainWindow = new MainWindow()
				{
					DataContext = Controller
				};

				Splash.Close();

				MainWindow.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error in starting application:\n{ex.Message}", ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
				Application.Current.Shutdown();
			}
		}
	}
}
