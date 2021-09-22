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

        public PlayAgainCommand(GameViewModel gameViewModel, NavigationStore navigationStore)
        {
            this.gameViewModel = gameViewModel;
            navigationStore = navigationStore;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {

            navigationStore.CurrentViewModel = new GameViewModel(navigationStore);
           
        }
    }
}
