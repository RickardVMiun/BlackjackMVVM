using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class PlayViewModel : BaseViewModel
    {

        public ICommand StartPlayCommand { get; }
        StartPlayCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore));
        }
    }
}
