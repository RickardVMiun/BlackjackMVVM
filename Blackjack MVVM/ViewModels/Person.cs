using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    public class Person
    {
        public string Name { get; set; }
        public int HandScore { get; set; }
        public SavedMarkers Markers { get; set; }
        public int StartMarkers { get; set; }
        public int Bet { get; set; }
    }
}
