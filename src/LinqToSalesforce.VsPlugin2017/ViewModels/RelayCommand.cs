using System;
using System.Windows.Input;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action action;

        public RelayCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}