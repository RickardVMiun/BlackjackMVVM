using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {

        public ObservableCollection<Cards> DeckOfCards { get; set; } = new ObservableCollection<Cards>();
        public List<Cards> ListOfCards { get; set; }
        public Cards card1;
        public Cards card2;

        public GameViewModel()
        {
           FillDeckOfCards();
           GetRandomCard();

           // card1 = new Cards();
           // card2 = new Cards();
        }

        public int GetRandomCard()
        {
            int idRandomCard;
            
            Random randomCard = new Random();
            idRandomCard = randomCard.Next(1, 52);

            return idRandomCard;
        }

        //public Cards ShowCard()
        //{
        //    int x = GetRandomCard();
        //   // int y = GetRandomCard();
        //   // card1 = DeckOfCards[x];
        //    // card2 = DeckOfCards[y];
        //   // return card1;
        //}

        public void GenerateCards()
        {
            DeckOfCards.Add(new Hearts());
            DeckOfCards.Add(new Spades());
            DeckOfCards.Add(new Clubs());
            DeckOfCards.Add(new Diamonds());
           
        }


        public void FillDeckOfCards()
        {
            int count = 0;

            while (count<13)
            {
                GenerateCards();
                count++;
            }
            //ShowCard();
        }
    }

}
