using Blackjack_MVVM.Data;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        // presentera allt här i vyn

        // presentera ett enda kort

        public GenericCard Card { get; set; }

    }

}
