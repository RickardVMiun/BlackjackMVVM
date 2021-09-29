using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class CloseRulesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        GameViewModel gameViewModel;
        public CloseRulesCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.rulesVisibility = "Hidden";
            gameViewModel.playRules.RulesVisible = gameViewModel.rulesVisibility;
        }
    }
}