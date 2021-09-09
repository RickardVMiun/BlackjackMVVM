using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        // tja testar detta

        //testing testing
        //public int Card { get; set; } = GetCard();
        public string Test { get; set; } = "Hej";

        public ObservableCollection<Card> Cards { get; set; }

        public GameViewModel()
        {
            FillDeckOfCards();
            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            //throw new NotImplementedException();
        }

        protected virtual void FillDeckOfCards()
        {
            // supercool metod
        }

        
    }
    
}
