using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_MVVM.Commands
{
    class Over18Command : BaseCommand
    {
        private MainViewModel mainViewModel;
      //  private GameViewModel gameViewModel;
        private PlayViewModel playViewModel;
        private MainWindow mainWindow;

        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;

        public Over18Command(PlayViewModel playViewModel, NavigationStore navigationStore, MainWindow mainWindow)
        {
            this.playViewModel = playViewModel;
            this.mainWindow = mainWindow;
            navigationStore = navigationStore;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new PlayViewModel(navigationStore, mainWindow);
        }
    }
}
