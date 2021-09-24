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
    /// Interaction logic for StopMusic.xaml
    /// </summary>
    public partial class StopMusic : UserControl
    {
        public StopMusic()
        {
            InitializeComponent();
        }

        public string StopMusicVisible
        {
            get { return (string)GetValue(StopMusicVisibleProperty); }
            set { SetValue(StopMusicVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StopMusicVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StopMusicVisibleProperty =
            DependencyProperty.Register("StopMusicVisible", typeof(string), typeof(StopMusic), new PropertyMetadata("Visible"));

        public string StopMusicDisabling
        {
            get { return (string)GetValue(StopMusicDisablingProperty); }
            set { SetValue(StopMusicDisablingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StopMusicDisabling.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StopMusicDisablingProperty =
            DependencyProperty.Register("StopMusicDisabling", typeof(string), typeof(StopMusic), new PropertyMetadata("True"));




    }
}
