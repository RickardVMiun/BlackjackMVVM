using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class PlayAgainCommand : BaseCommand
    {
        private MainViewModel mainViewModel;
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;
        private MainWindow mainWindow;
        public string personName;

        public PlayAgainCommand(GameViewModel gameViewModel, NavigationStore navigationStore, MainWindow mainWindow, string personName)
        {
            this.gameViewModel = gameViewModel;
            this.mainWindow = mainWindow;
            this.navigationStore = navigationStore;
            this.personName = personName;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new GameViewModel(navigationStore, mainWindow, personName);
        }
    }
}
