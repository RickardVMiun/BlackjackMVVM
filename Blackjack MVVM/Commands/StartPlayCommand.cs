using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_MVVM.Commands
{
    class StartPlayCommand : BaseCommand
    {
        private MainViewModel mainViewModel;
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;
        private MainWindow mainWindow;
        string playerName;

        public StartPlayCommand(GameViewModel gameViewModel, NavigationStore navigationStore, MainWindow mainWindow, string playerName)
        {
            this.gameViewModel = gameViewModel;
            this.mainWindow = mainWindow;
            this.navigationStore = navigationStore;
            this.playerName = playerName;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {
            //gameViewModel.CreatePlayer();
            navigationStore.CurrentViewModel = new GameViewModel(navigationStore, mainWindow, playerName);

            
        }
    }
}
