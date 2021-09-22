using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class ReadRulesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        GameViewModel gameViewModel;
        public ReadRulesCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.rulesvisibility = "Visible";
            gameViewModel.playRules.RulesVisible = gameViewModel.rulesvisibility;
        }
    }
}
