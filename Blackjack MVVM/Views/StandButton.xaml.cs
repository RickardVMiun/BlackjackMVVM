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
    /// Interaction logic for StandButton.xaml
    /// </summary>
    public partial class StandButton : UserControl
    {
        public StandButton()
        {
            InitializeComponent();
        }



        public string StandToggle
        {
            get { return (string)GetValue(StandToggleProperty); }
            set { SetValue(StandToggleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StandToggle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StandToggleProperty =
            DependencyProperty.Register("StandToggle", typeof(string), typeof(StandButton), new PropertyMetadata("True"));


    }
}
