using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class Bet100Command : ICommand
    {
        private GameViewModel gameViewModel;
        int bet100 = 100;
        public Bet100Command(GameViewModel gameViewModel)
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
          
            gameViewModel.BettingTotal(bet100);

        }
    }
}
