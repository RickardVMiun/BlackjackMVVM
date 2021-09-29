using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class PlayViewModel : BaseViewModel
    {
        public ICommand StartPlayCommand { get; }
       
        public GameViewModel gameViewModel;
     
        public string personName { get; set; } = "Enter name";
   
        public PlayViewModel(NavigationStore navStore, MainWindow mainWindow)
        {
            StartPlayCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore, mainWindow, personName));               
        }
    }
}
