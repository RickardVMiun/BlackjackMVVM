using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Blackjack_MVVM.ViewModels
{
    public class CardViewModel : UserControl
    {
        public int[] Cards { get; set; } = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public CardViewModel()
        {

        }

        public int GetCard()
        {
            Random random = new Random();
            int returnCard = Cards[random.Next(1, 10)];

            return returnCard;
        }
    }
}
