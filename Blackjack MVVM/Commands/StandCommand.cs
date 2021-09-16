﻿using Blackjack_MVVM.ViewModels;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    class StandCommand : ICommand
    {
        private GameViewModel gameViewModel;

        public StandCommand(GameViewModel gameViewModel)
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
           // gameViewModel.AddCardCpu();
           // gameViewModel.ShowNewCard();
         //   gameViewModel.PersonIsBust(gameViewModel.p1);

            while (gameViewModel.p2.HandScore < 17)
            {
                //Thread.Sleep(1000);
                
                gameViewModel.AddCardCpu();
                gameViewModel.CpuWon(gameViewModel.p2, gameViewModel.p1);
                //   gameViewModel.ShowNewCard();
            }
        }
    }
}
