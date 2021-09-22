using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class PlayViewModel : BaseViewModel
    {
        public ICommand StartPlayCommand { get; }
        public ICommand ReadRulesInPlayViewCommand { get; }
        public ICommand CloseRulesInPlayViewCommand { get; }

        public GameViewModel gameViewModel;
        public string rulesvisibilitypm { get; set; }
        public PlayRules playRulespm { get; set; }

        public PlayViewModel(NavigationStore navStore)
        {
            playRulespm = new PlayRules();
            gameViewModel = new GameViewModel(navStore);
            StartPlayCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore));
            ReadRulesInPlayViewCommand = new ReadRulesInPlayViewCommand(this);
            CloseRulesInPlayViewCommand = new CloseRulesInPlayViewCommand(this);
        }
    }
}
