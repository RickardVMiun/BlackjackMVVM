using System;
using Blackjack_MVVM.ViewModels;
using System.Collections.Generic;
using System.Text;
using Blackjack_MVVM.Stores;

namespace Blackjack_MVVM.Commands
{
    public class NavigationCommand<TViewModel> : BaseCommand
           where TViewModel : BaseViewModel
    {
        private readonly NavigationStore navStore1;
        private readonly Func<TViewModel> createViewModel1;

        public NavigationCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            navStore1 = navigationStore;
            createViewModel1 = createViewModel;
        }

        public override void Execute(object parameter)
        {
            navStore1.CurrentViewModel = createViewModel1();
        }
    }
}
