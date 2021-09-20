using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class Bet25Command : ICommand
    {
        private GameViewModel gameViewModel;
        int bet25 = 25;
        public Bet25Command(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.BettingTotal(bet25);

        }
    }
}
