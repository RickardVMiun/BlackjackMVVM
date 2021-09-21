using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class StartingViewModel : BaseViewModel
    {
        public ICommand Over18Command { get; }
        public ICommand Under18Command { get; }

        public StartingViewModel(NavigationStore navStore)
        {
            Over18Command = new NavigationCommand<PlayViewModel>(navStore, () => new PlayViewModel(navStore));
            Under18Command = new Under18Command(this);
        }
    }
}
