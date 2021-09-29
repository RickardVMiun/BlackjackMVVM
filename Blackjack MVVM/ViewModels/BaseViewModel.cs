using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Blackjack_MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
