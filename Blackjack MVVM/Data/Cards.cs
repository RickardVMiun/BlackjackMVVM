using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack_MVVM.Data
{
    public class Cards : BaseViewModel
    {
        private static readonly Random random = new Random();

        public int CardValue { get; set; }
        public string CardSuit { get; set; }

        public ObservableCollection<Cards> deckofcards { get; set; }

        private void FillDeck() // Fyller lista med kort
        {
            deckofcards = new ObservableCollection<Cards>();
            {

               


            };

        }

        //public int SetCardValue()
        //{ 

        //}
        //public int GetCard()
        //{
        //    int returnCard = Cards[random.Next(1, 10)];

        //    return returnCard;
        //}

    }
}
