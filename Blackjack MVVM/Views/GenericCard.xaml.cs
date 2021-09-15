using Blackjack_MVVM.ViewModels;
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
    /// Interaction logic for GenericCard.xaml
    /// </summary>
    public partial class GenericCard : UserControl
    {
        public GenericCard()
        {
            InitializeComponent();
        }


        public string CardValue
        {
            get { return (string)GetValue(CardValueProperty); }
            set { SetValue(CardValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardValueProperty =
            DependencyProperty.Register("CardValue", typeof(string), typeof(GenericCard), new PropertyMetadata(null));


        //public string CardColor
        //{
        //    get { return (string)GetValue(CardColorProperty); }
        //    set { SetValue(CardColorProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for CardColor.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty CardColorProperty =
        //    DependencyProperty.Register("CardColor", typeof(string), typeof(GenericCard), new PropertyMetadata(null));

        public char CardSuit
        {
            get { return (char)GetValue(CardSuitProperty); }
            set { SetValue(CardSuitProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardSuit.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardSuitProperty =
            DependencyProperty.Register("CardSuit", typeof(char), typeof(GenericCard), new PropertyMetadata(null));

    }
}
