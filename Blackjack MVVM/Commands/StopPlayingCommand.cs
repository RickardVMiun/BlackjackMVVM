using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class StopPlayingCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;
        private readonly MainWindow mainWindow;
        private GameViewModel gameViewModel;

        public StopPlayingCommand(GameViewModel gameViewModel, MainWindow mainWindow, NavigationStore navigationStore)
        {
            this.gameViewModel = gameViewModel;
            this.mainWindow = mainWindow;
            this.navigationStore = navigationStore;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new PlayViewModel(navigationStore, mainWindow);
        }
    }
}
