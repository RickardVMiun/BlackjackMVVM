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

        public int PlayerScore { get; set; }
        public int CpuScore { get; set; }
        public GenericCard Card { get; set; }
        private static readonly Random random = new Random();
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        public ObservableCollection<GenericCard> CardsInGame { get; set; }
        public ObservableCollection<GenericCard> PersonCardsInGame { get; set; } = new ObservableCollection<GenericCard>();
        public ObservableCollection<GenericCard> CpuCardsInGame { get; set; } = new ObservableCollection<GenericCard>();



        // cpucardsingame/playercardsingame
        public EnumToSymbolConverter converter = new EnumToSymbolConverter();
        public ICommand HitCommand { get; }
        public GenericCard newCard { get; set; }
        public Person p1 = new Person();
        public Cpu p2 = new Cpu();
     //   public PlayerViewModel P2 { get; set; } = new Cpu();

        public GameViewModel()
        {
            
            HitCommand = new HitCommand(this);
            DeckOfCards = new ObservableCollection<GenericCard>();
            FillDeckOfCards();
            AddStartingCardsHuman();
            AddStartingCardsCpu();
        }

        private void AddStartingCardsHuman()
        {
            AddCard();
        }

        private void AddStartingCardsCpu()
        {
            AddCardCpu();
            AddCardCpu();
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


        public void AddCard()
        {
           
            newCard = new GenericCard();
            int x = GetRandomCard();
            if (true)
            {
                newCard = DeckOfCards[x];
            }
            PersonCardsInGame.Add(newCard);
            AddPlayerPoints(newCard);
        }

        public void AddCardCpu()
        {
            newCard = new GenericCard();
            int x = GetRandomCard();
            if (true)
            {
                newCard = DeckOfCards[x];
            }
            CpuCardsInGame.Add(newCard);
            AddPlayerPoints(newCard);
        }
        public void AddPlayerPoints(GenericCard card)
        {
            // gör om till en int så att vi kan räkna ut värdet.
            int value = 0;

            if(card.CardValue == "A" || card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K" )
            {
                value = 10;
            }
            else
            {
               value = int.Parse(card.CardValue);
            }
            p1.HandScore += value;
        }

        public void AddCpuPoints(GenericCard card)
        {
            // gör om till en int så att vi kan räkna ut värdet.
            int value = 0;

            if (card.CardValue == "A" || card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K")
            {
                value = 10;
            }
            else
            {
                value = int.Parse(card.CardValue);
            }
            p2.HandScore += value;
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
