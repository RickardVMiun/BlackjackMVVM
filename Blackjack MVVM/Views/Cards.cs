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
        //private static readonly Random random = new Random();
        public int cardId { get; set; }

        public string CardSuit { get; set; }

        public ObservableCollection<Cards> deckofcards { get; set; }
        public Cards()
        {
            CardValue = GetValue();
        }

        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Size.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(int), typeof(Cards), new PropertyMetadata(1, new PropertyChangedCallback(OnSizeSet)));

        private static void OnSizeSet(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var Card = d as Cards;
            Card.CardValue = Convert.ToString(5);

        }

        private static readonly Random random2= new Random();

        public string CardValue { get; set; }


        public string GetValue()
        {
            int x = random2.Next(1, 14);
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
