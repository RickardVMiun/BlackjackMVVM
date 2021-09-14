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

        public GenericCard Card { get; set; } = new GenericCard();

        private static readonly Random random = new Random();
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        public EnumToSymbolConverter converter = new EnumToSymbolConverter();
        public ICommand HitCommand { get; }
        public GameViewModel()
        {
            //Card.CardValue = GetValue();
            //Card.CardSuit = GetSuit();
            HitCommand = new HitCommand(this);
            DeckOfCards = new ObservableCollection<GenericCard>();
        }

        public char GetSuit()
        {
            int i = random.Next(1, 4);
            if (i == 1)
            {
                Card.CardSuit = '♥'; // hearts " &#9829;" '♥'
                                     //Card.CardSuit = converter.ConvertEnum();

            }
            else if (i == 2)
            {
                Card.CardSuit = '♠'; // spades &#9824;
            }
            else if (i == 3)
            {
                Card.CardSuit = '♣'; // clubs "&#9827;"
            }
            else
            {
                Card.CardSuit = '♦'; // diamonds "&#9670;"
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

        public void GenerateCards()
        {
            DeckOfCards.Add(new GenericCard
            {
                CardValue = GetValue(),
                CardSuit = GetSuit()

            });  

        }


    }
}
