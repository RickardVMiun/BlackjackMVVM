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
    /// Interaction logic for PlaceBetButton.xaml
    /// </summary>
    public partial class PlaceBetButton : UserControl
    {
        public PlaceBetButton()
        {
            InitializeComponent();
        }



        public string ButtonDisabling2
        {
            get { return (string)GetValue(ButtonDisabling2Property); }
            set { SetValue(ButtonDisabling2Property, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonDisabling2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonDisabling2Property =
            DependencyProperty.Register("ButtonDisabling2", typeof(string), typeof(PlaceBetButton), new PropertyMetadata("False"));


    }
}
