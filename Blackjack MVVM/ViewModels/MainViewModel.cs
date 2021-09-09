using Blackjack_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Blackjack_MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; set; } = new GameViewModel();

       // public string lala { get; set; } = CardSuit.Hearts.ToString();
       


    }
}
