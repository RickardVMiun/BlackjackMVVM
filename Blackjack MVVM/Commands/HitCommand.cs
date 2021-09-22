using Blackjack_MVVM.ViewModels;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class HitCommand : ICommand
    {
        private GameViewModel gameViewModel;
        public GenericCard genericCard;

        public HitCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;  
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.AddCard();
            gameViewModel.PersonIsBust(gameViewModel.p1);
            
            //gameViewModel.ShowNewCard();
            gameViewModel.SaveMarkers();
        }
    }
}
