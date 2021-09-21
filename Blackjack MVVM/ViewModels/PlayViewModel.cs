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

        public List<Person> Players { get; set; }

        public ICommand CreatePlayerCommand { get; }

        public PlayViewModel(NavigationStore navStore)
        {
            Players = new List<Person>();
            CreatePlayerCommand = new CreatePlayerCommand();
            StartPlayCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore));
        }
    }
}
