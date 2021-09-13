using Blackjack_MVVM.Data;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Blackjack_MVVM.Views
{
    public class Cards : UserControl
    {
        // User control 00> dependency properties
        //public char CardSuit { get; set; }

        public string CardValue { get; set; }

        public string CardColor { get; set; }

        public CardSuit CardSuit { get; set; }

        private static readonly Random random = new Random();
        public ObservableCollection<Cards> deckofcards { get; set; }
        public Cards()
        {
            CardValue = GetValue();
            CardSuit = GetSuit();
        }


        public char GetSuit()
        {
            int i = random.Next(1,4);
            if (i == 1)
            {
                // CardSuit = '♥'; // hearts "&#9829;" '♥'
                CardSuit = CardSuit.Hjärter;
                
            }
            else if (i == 2)
            {
                CardSuit = '♠'; // spades &#9824;
            }
            else if (i == 3)
            {
                CardSuit = '♣'; // clubs "&#9827;"
            }
            else 
            {
                CardSuit = '♦'; // diamonds "&#9670;"
            }
            
            return CardSuit;
        }

        //public string GetColor()
        //{
        


        //}

        public string GetValue()
        {
            int x = random.Next(1, 14);
            if (x == 1 || x == 14)
            {
                CardValue = "A";
            }
            else if (x == 11)
            {
                CardValue = "J";
            }
            else if (x == 12)
            {
                CardValue = "Q";
            }
            else if (x == 13)
            {
                CardValue = "K";
            }
            else
            {
                CardValue = x.ToString();
            }
            return CardValue;
        }
  
    }
}
