using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Blackjack_MVVM.Commands
{
    public class StartMusicCommand : ICommand
    {
        private GameViewModel gameViewModel;
        public event EventHandler CanExecuteChanged;
        MainWindow mainWindow;

        public StartMusicCommand(GameViewModel gameViewModel, MainWindow mainWindow)
        {
            this.gameViewModel = gameViewModel;
            this.mainWindow = mainWindow;
           
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
            mainWindow.PlayMusic();
        }
    }
}
