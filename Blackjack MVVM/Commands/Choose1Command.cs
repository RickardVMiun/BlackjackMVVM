using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class Choose1Command : ICommand
    {
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        public int chose1 = 1;
        public Choose1Command(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.SetAceValueTo1();
            gameViewModel.acedecisionvisibility = "Hidden";
        }
    }
}
