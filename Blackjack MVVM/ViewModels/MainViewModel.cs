using Blackjack_MVVM.Data;
using Blackjack_MVVM.Stores;
using System;
using System.Collections.Generic;
using System.Text;


namespace Blackjack_MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore navStore1;
        public BaseViewModel CurrentViewModel => navStore1.CurrentViewModel;

        public MainViewModel(NavigationStore navStore)
        {
            navStore1 = navStore;

            navStore1.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
