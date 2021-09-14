using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
   public class PlayerViewModel : BaseViewModel
   {
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        public static GameViewModel gameViewModel;

        public PlayerViewModel()
        {
            gameViewModel = new GameViewModel();

        }
    }
}
