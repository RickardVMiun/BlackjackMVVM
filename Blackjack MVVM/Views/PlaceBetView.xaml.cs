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
    /// Interaction logic for PlaceBetView.xaml
    /// </summary>
    public partial class PlaceBetView : UserControl
    {
        public PlaceBetView()
        {
            InitializeComponent();
        }



        public string BettingViewVisibility
        {
            get { return (string)GetValue(BettingViewVisibilityProperty); }
            set { SetValue(BettingViewVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BettingViewVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BettingViewVisibilityProperty =
            DependencyProperty.Register("BettingViewVisibility", typeof(string), typeof(PlaceBetView), new PropertyMetadata("Visible"));


    }
}
