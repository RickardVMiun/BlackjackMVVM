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
    /// Interaction logic for PlayerName.xaml
    /// </summary>
    public partial class PlayerName : UserControl
    {
        public PlayerName()
        {
            InitializeComponent();
        }

        public string SetPlayerName
        {
            get { return (string)GetValue(SetPlayerNameProperty); }
            set { SetValue(SetPlayerNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SetPlayerName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SetPlayerNameProperty =
            DependencyProperty.Register("SetPlayerName", typeof(string), typeof(PlayerName), new PropertyMetadata("No name"));


    }
}
