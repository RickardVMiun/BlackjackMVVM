using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class CloseRulesInPlayViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        PlayViewModel playViewModel;
        public CloseRulesInPlayViewCommand(PlayViewModel playViewModel)
        {
            this.playViewModel = playViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            playViewModel.rulesvisibilitypm = "Hidden";
            playViewModel.playRulespm.RulesVisible = playViewModel.rulesvisibilitypm;
        }
    }
}
