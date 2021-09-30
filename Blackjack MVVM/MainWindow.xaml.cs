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
using System.Windows.Media.Animation;
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
            BackgroundMusic();
            DataContext = new MainViewModel(navStore);
            navStore.CurrentViewModel = new StartingViewModel(navStore, this);
            
        }
        public void BackgroundMusic()
        {
            var timeline = new MediaTimeline(new Uri("Sound/backgroundmusic.wav", UriKind.Relative));
            timeline.RepeatBehavior = RepeatBehavior.Forever;
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Volume = 0.3f;
            mediaPlayer.Clock = timeline.CreateClock();
            mediaPlayer.Clock.Controller.Begin();
        }

        public void PauseMusic()
        {
            mediaPlayer.Volume = 0f;
        }

        public void PlayMusic()
        {
            mediaPlayer.Volume = 0.3f;
        }
    }
}
