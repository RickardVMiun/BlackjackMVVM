using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class Bet1Command : ICommand
    {
        private GameViewModel gameViewModel;
        int bet1 = 1;
        public Bet1Command(GameViewModel gameViewModel)
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
            gameViewModel.BettingTotal(bet1);
        }
    }
}
