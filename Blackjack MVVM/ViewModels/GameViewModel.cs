using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Converters;
using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        // presentera allt här i vyn
        // presentera ett enda kort

        public GenericCard Card { get; set; }
        private static readonly Random random = new Random();
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        public ObservableCollection<GenericCard> CardsInGame { get; set; }
        public EnumToSymbolConverter converter = new EnumToSymbolConverter();
        public ICommand HitCommand { get; }

        //public GenericCard Card1 { get; set; }
        //public GenericCard Card2 { get; set; }
        //public GenericCard Card3 { get; set; }

        public GenericCard newCard { get; set; }

        //public PlayerViewModel P1 { get; set; } = new Person();
        //public PlayerViewModel P2 { get; set; } = new Cpu();

        public GameViewModel()
        {
            HitCommand = new HitCommand(this);
            DeckOfCards = new ObservableCollection<GenericCard>();
            CardsInGame = new ObservableCollection<GenericCard>();
            //Card1 = new GenericCard();
            //Card2 = new GenericCard();
            //Card3 = new GenericCard();
            
        }

        public char GetSuit()
        {
            int i = random.Next(1, 4);
            if (i == 1)
            {
                Card.CardSuit = '♥'; 
            }
            else if (i == 2)
            {
                Card.CardSuit = '♠'; 
            }
            else if (i == 3)
            {
                Card.CardSuit = '♣'; 
            }
            else
            {
                Card.CardSuit = '♦'; 
            }

            return Card.CardSuit;
        }

        public string GetValue()
        {
            int x = random.Next(1, 14);
            if (x == 1 || x == 14)
            {
                Card.CardValue = "A";
            }
            else if (x == 11)
            {
                Card.CardValue = "J";
            }
            else if (x == 12)
            {
                Card.CardValue = "Q";
            }
            else if (x == 13)
            {
                Card.CardValue = "K";
            }
            else
            {
                Card.CardValue = x.ToString();
            }
            return Card.CardValue;
        }

        public GenericCard GenerateCards()
        {
            Card = new GenericCard();
            DeckOfCards.Add(new GenericCard
            {
                CardValue = GetValue(),
                CardSuit = GetSuit()
            });

            return Card;
        }


        public void ShowCard()
        {
            FillDeckOfCards();
            newCard = new GenericCard();
            int x = GetRandomCard();
            if (true)
            {
                newCard = DeckOfCards[x];
            }

            CardsInGame.Add(newCard);
        }

        public void FillDeckOfCards()
        {
            int count = 0;

            while (count < 52)
            {
                GenerateCards();
                count++;
            }
        }

        public int GetRandomCard()
        {
            int idRandomCard;

            Random randomCard = new Random();
            idRandomCard = randomCard.Next(1, 52);

            return idRandomCard;
        }
    }
}
