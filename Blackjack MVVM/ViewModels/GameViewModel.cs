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

        public ObservableCollection<Cards> DeckOfCards { get; set; } = new ObservableCollection<Cards>();
        public List<Cards> ListOfCards { get; set; }

        public GameViewModel()
        {
           FillDeckOfCards();
            // ShuffleDeck();
            //GetValue();
            GetRandomCard();
        }

        public int SetCardId(ObservableCollection<Cards> deckOfCards, int idRandomCard, List<Cards> listOfCards)
        { 
            if(deckOfCards.Count == 0)
            {  
                deckOfCards[0] = listOfCards[idRandomCard];
            }
            

            return deckOfCards[0];
        }

        public int GetRandomCard()
        {
            int idRandomCard;
            int cardId = DeckOfCards.IndexOf();
            Random randomCard = new Random();
            idRandomCard = randomCard.Next(1, 52);

            return idRandomCard;
        }
       
        //public List<> listOfCards()
        //{

        //}

        public Cards ShowCard(int idRandomCard, ObservableCollection<Cards> deckOfCards)
        {
            Cards card = new Cards();
            int x = GetRandomCard();
           
            foreach (var card1 in deckOfCards)
            {
                while (x != DeckOfCards.IndexOf;)
                {

                }
                idRandomCard = deckOfCards[];
            }

            return card;
        }

        public void GenerateCards()
        {
            DeckOfCards.Add(new Hearts());
            DeckOfCards.Add(new Spades());
            DeckOfCards.Add(new Clubs());
            DeckOfCards.Add(new Diamonds());
        }

        //private void ShuffleDeck()
        //{
        //    //throw new NotImplementedException();
        //}

        public void FillDeckOfCards()
        {
            int count = 0;

            while (count<13)
            {
                GenerateCards();
                count++;
            }
        }
    }

}
