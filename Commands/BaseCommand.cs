using System;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    public class BaseCommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}