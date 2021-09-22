using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class ReadRulesInPlayViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        PlayViewModel playViewModel;
        public ReadRulesInPlayViewCommand(PlayViewModel playViewModel)
        {
            this.playViewModel = playViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            playViewModel.rulesvisibilitypm = "Visible";
            playViewModel.playRulespm.RulesVisible = playViewModel.rulesvisibilitypm;
        }
    }
}
