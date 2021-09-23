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
    /// Interaction logic for BettingButtons.xaml
    /// </summary>
    public partial class BettingButtons : UserControl
    {
        public BettingButtons()
        {
            InitializeComponent();
        }

        public string ButtonDisabling
        {
            get { return (string)GetValue(ButtonDisablingProperty); }
            set { SetValue(ButtonDisablingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonDisabling.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonDisablingProperty =
            DependencyProperty.Register("ButtonDisabling", typeof(string), typeof(BettingButtons), new PropertyMetadata("True"));
    }
}
