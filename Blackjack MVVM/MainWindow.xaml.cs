using Blackjack_MVVM.Data;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationStore navStore = new NavigationStore();
        MediaPlayer mediaPlayer;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(navStore);
            navStore.CurrentViewModel = new StartingViewModel(navStore);
            //BackgroundMusic();
        }

        //public void BackgroundMusic()
        //{
        //    mediaPlayer = new MediaPlayer();
        //    mediaPlayer.Open(new Uri(@"C:\Users\junof\Source\Repos\SUP21_Grupp4\Blackjack MVVM\Sound\test.wav"));
        //    mediaPlayer.Play();

        //}
    }
}
