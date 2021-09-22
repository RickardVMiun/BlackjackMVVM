using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class Choose11Command : ICommand
    {
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        public int chose11 = 11;
        public Choose11Command(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //gameViewModel.SetAceValue(chose11);

            gameViewModel.playerScore.playerScore += 11;

            gameViewModel.acedecisionvisibility = "Hidden";
        }
    }
}
