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
        // tja testar detta

        //testing testing
        //public int Card { get; set; } = GetCard();
        public string Test { get; set; } = "Hej";

        private static readonly Random random = new Random();

        public string CardValue { get; set; }


        //public int GetValue()
        //{
        //    int x = random.Next(1, 14);
        //    if (x == 1 || x == 14)
        //    {
        //        CardValue = 'A';
        //    }
        //    else if (x == 11)
        //    {
        //        CardValue = 'J';
        //    }
        //    else if (x == 12)
        //    {
        //        CardValue = 'Q';
        //    }
        //    else if (x == 13)
        //    {
        //        CardValue = 'K';
        //    }
        //    else
        //    {
        //        CardValue = Convert.ToChar(x);

        //    }
        //    return CardValue;

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


        public ObservableCollection<Cards> Cards { get; set; }

        public GameViewModel()
        {
           // FillDeckOfCards();
           // ShuffleDeck();
            GetValue();
        }

        private void ShuffleDeck()
        {
            //throw new NotImplementedException();
        }

        protected virtual void FillDeckOfCards()
        {
            // supercool metod
        }

        
    }
    
}
