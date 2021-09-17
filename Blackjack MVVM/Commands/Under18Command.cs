using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class Under18Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private StartingViewModel startingViewModel;

        public Under18Command(StartingViewModel startingViewModel)
        {
            this.startingViewModel = startingViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
