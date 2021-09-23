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
    /// Interaction logic for HitButton.xaml
    /// </summary>
    public partial class HitButton : UserControl
    {
        public HitButton()
        {
            InitializeComponent();
        }



        public string HitToggle
        {
            get { return (string)GetValue(HitToggleProperty); }
            set { SetValue(HitToggleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HitToggle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HitToggleProperty =
            DependencyProperty.Register("HitToggle", typeof(string), typeof(HitButton), new PropertyMetadata("True"));


    }
}
