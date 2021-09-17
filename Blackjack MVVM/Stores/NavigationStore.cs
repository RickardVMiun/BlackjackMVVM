using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_MVVM.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        private BaseViewModel CurrentViewModel1;
        public BaseViewModel CurrentViewModel
        {
            get => CurrentViewModel1;
            set
            {
                CurrentViewModel1 = value;
                OnCurrentViewModelChanged();
            }


        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();

        }
    }
}
