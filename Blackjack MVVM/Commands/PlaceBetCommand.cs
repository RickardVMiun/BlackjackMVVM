using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
   public class PlaceBetCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private GameViewModel gameViewModel;

        public PlaceBetCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.AddStartingCardsHuman();
            gameViewModel.AddStartingCardsCpu();
            gameViewModel.DisableBettingButtons();
            gameViewModel.betviewvisibility = "Hidden";
        }
    }
}
