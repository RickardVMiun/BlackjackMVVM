using Blackjack_MVVM.Data;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using Blackjack_MVVM.Views;
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
            this.navigationStore = navigationStore;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {     
            navigationStore.CurrentViewModel = new GameViewModel(navigationStore);

            //gameViewModel.GetSavedMarkers();
            //gameViewModel.markers.MarkerTotal = gameViewModel.savedMarkers.MarkersSaved;

            //gameViewModel.savedMarkers = FileHandler.Open<SavedMarkers>(gameViewModel.filename);
            //gameViewModel.markers.MarkerTotal = gameViewModel.savedMarkers.MarkersSaved;

        }
    }
}
