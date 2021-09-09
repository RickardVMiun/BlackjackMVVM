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
        private static readonly Random random = new Random();

        public int CardValue { get; set; }
        public string CardSuit { get; set; }

        public ObservableCollection<Cards> deckofcards { get; set; }

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
            Card.CardValue = 5;

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
