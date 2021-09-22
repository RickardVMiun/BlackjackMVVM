﻿using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_MVVM.Commands
{
    class StartPlayCommand : BaseCommand
    {
        private MainViewModel mainViewModel;
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        private readonly NavigationStore navigationStore;

        public StartPlayCommand(GameViewModel gameViewModel, NavigationStore navigationStore)
        {
            this.gameViewModel = gameViewModel;
            navigationStore = navigationStore;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        public override void Execute(object parameter)
        {

            navigationStore.CurrentViewModel = new GameViewModel(navigationStore);
        }
    }
}