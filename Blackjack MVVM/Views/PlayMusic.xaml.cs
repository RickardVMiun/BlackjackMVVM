using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack_MVVM.Views
{
    /// <summary>
    /// Interaction logic for PlayMusic.xaml
    /// </summary>
    public partial class PlayMusic : UserControl
    {
        public PlayMusic()
        {
            InitializeComponent();
        }

        public string PlayMusicVisible
        {
            get { return (string)GetValue(PlayMusicVisibleProperty); }
            set { SetValue(PlayMusicVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayMusicVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayMusicVisibleProperty =
            DependencyProperty.Register("PlayMusicVisible", typeof(string), typeof(PlayMusic), new PropertyMetadata("Hidden"));



        public string PlayMusicDisabling
        {
            get { return (string)GetValue(PlayMusicDisablingProperty); }
            set { SetValue(PlayMusicDisablingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayMusicDisabling.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayMusicDisablingProperty =
            DependencyProperty.Register("PlayMusicDisabling", typeof(string), typeof(PlayMusic), new PropertyMetadata("False"));




    }
}
