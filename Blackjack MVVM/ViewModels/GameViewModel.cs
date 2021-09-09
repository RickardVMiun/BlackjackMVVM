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

        //private static readonly Random random = new Random();

        //public string CardValue { get; set; }


        //public string GetValue()
        //{
        //    int x = random.Next(1, 14);
        //    if (x == 1 || x == 14)
        //    {
        //        CardValue = "A";
        //    }
        //    else if (x == 11)
        //    {
        //        CardValue = "J";
        //    }
        //    else if (x == 12)
        //    {
        //        CardValue = "Q";
        //    }
        //    else if (x == 13)
        //    {
        //        CardValue = "K";
        //    }
        //    else
        //    {
        //        CardValue = x.ToString();
        //    }
        //    return CardValue;
        //}


        public ObservableCollection<Cards> deckOfCards { get; set; } = new ObservableCollection<Cards>();

        public GameViewModel()
        {
           FillDeckOfCards();
            // ShuffleDeck();
            //GetValue();
            GetRandomCard(deckOfCards);
            
        }

        private void GetRandomCard(ObservableCollection<Cards> deckOfCards)
        {
            Random randomCard = new Random();
            randomCard.Next(1,52);
        }

        public void GenerateCards()
        {
            deckOfCards.Add(new Hearts());
            deckOfCards.Add(new Spades());
            deckOfCards.Add(new Clubs());
            deckOfCards.Add(new Diamonds());

        }

        //private void ShuffleDeck()
        //{
        //    //throw new NotImplementedException();
        //}

        public void FillDeckOfCards()
        {
            int count = 0;

            while (count<14)
            {
                GenerateCards();
                count++;
            }
        }

      


    }

}
