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
    public partial class PersonName : UserControl
    {
        public PersonName()
        {
            InitializeComponent();
        }

        public string SetPersonName
        {
            get { return (string)GetValue(SetPersonNameProperty); }
            set { SetValue(SetPersonNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SetPersonName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SetPersonNameProperty =
            DependencyProperty.Register("SetPersonName", typeof(string), typeof(PersonName), new PropertyMetadata("No name"));


    }
}
