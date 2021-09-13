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
        public string CardSuit { get; set; }

        public string CardValue { get; set; }

        private static readonly Random random = new Random();
        public ObservableCollection<Cards> deckofcards { get; set; }
        public Cards()
        {
            CardValue = GetValue();
        }

        //public Cards card1
        //{
        //    get { return (Cards)GetValue(card1Property); }
        //    set { SetValue(card1Property, gameViewModel.ShowCard()); }
        //}

        //// Using a DependencyProperty as the backing store for card1.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty card1Property =
        //    DependencyProperty.Register("card1", typeof(Cards), typeof(Cards), new PropertyMetadata(0));


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
