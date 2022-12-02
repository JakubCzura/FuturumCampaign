using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace FuturumCampaign.Commands
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Predicate<T> canExecute;
        private readonly Action<T> execute;

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<T> action) : this(action, canExecute => true)
        {
            execute = action;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            try
            {
                //return true;
                return canExecute.Invoke((T)parameter);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Method error");
                return false;
            }
        }

        public void Execute(object parameter)
        {
            try
            {
                execute?.Invoke((T)parameter);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Method error");
            }
        }
    }
}
