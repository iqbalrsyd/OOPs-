using System;
using System.Windows.Input;

namespace BarangKu.Services
{
	public class RelayCommand : ICommand
	{
		private readonly Action _execute;
		private readonly Func<bool> _canExecute;

		public RelayCommand(Action execute, Func<bool> canExecute = null)
		{
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute();
		}

		public void Execute(object parameter)
		{
			_execute();
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		//private Action<object> execute;
		//private Func<object, bool> canExecute;

		//public RelayCommand(Action<object> execute)
		//{
		//	this.execute = execute;
		//	canExecute = null;
		//}

		//public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
		//{
		//	this.execute = execute;
		//	this.canExecute = canExecute;
		//}

		//public event EventHandler canExecuteChanged
		//{
		//	add { CommandManager.RequerySuggested += value; }
		//	remove { CommandManager.RequerySuggested -= value; }
		//}

		//public bool CanExecute(object parameter)
		//{
		//	return canExecute != null && canExecute(parameter);
		//}

		//public void Execute(object parameter)
		//{
		//	execute(parameter);
		//}

	}
}
