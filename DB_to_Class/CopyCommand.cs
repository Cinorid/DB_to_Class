using System.Windows;

namespace DB_to_Class;

public class CopyCommand : CommandBase
{
	public override bool CanExecute(object parameter)
	{
		if (parameter is not ControllerMain controller)
			return false;

		return !string.IsNullOrEmpty(controller.ResultString);
	}

	public override void Execute(object parameter)
	{
		if (parameter is ControllerMain controller)
		{
			Clipboard.SetText(controller.ResultString);
		}
	}
}
