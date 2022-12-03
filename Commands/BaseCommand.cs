using System;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    /// <summary>
    /// Base class for all commands
    /// </summary>
    public class BaseCommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}