using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    public class PlayerViewModel
    {
        public int HandScore { get; set; }
        public int Bet { get; set; }
    }
}
