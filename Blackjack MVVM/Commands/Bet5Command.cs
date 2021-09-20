using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class Bet5Command : ICommand
    {
        private GameViewModel gameViewModel;
        int bet5 = 5;
        public Bet5Command(GameViewModel gameViewModel)
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
            //while (gameViewModel.AddBet() < 5)
            //{
            //    gameViewModel.AddBet();
            //}

            gameViewModel.BettingTotal(bet5);

        }
    }
}
