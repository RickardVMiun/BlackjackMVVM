using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_MVVM.Commands
{
    class CreatePlayerCommand : BaseCommand
    {
        private MainViewModel mainViewModel;
        //  private GameViewModel gameViewModel;
        private PlayViewModel playViewModel;
        Person person;
        PlayView playView = new PlayView();

        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;

        public CreatePlayerCommand()
        {
         //   playViewModel = new PlayViewModel(NavigationStore navStore);
            navigationStore = navigationStore;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {
            person = new Person
            {
                Name = playView.txtPlayerName.Text,
                StartMarkers = 500
            };
            playViewModel.Players.Add(person);
            playView.lstPlayers.ItemsSource = null;
            playView.lstPlayers.ItemsSource = playViewModel.Players;
        }
    }
    }

