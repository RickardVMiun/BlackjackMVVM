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
    /// Interaction logic for Markers.xaml
    /// </summary>
    public partial class Markers : UserControl
    {
        public Markers()
        {
            InitializeComponent();
        }



        public int MarkerTotal
        {
            get { return (int)GetValue(MarkerTotalProperty); }
            set { SetValue(MarkerTotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MarkerTotal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarkerTotalProperty =
            DependencyProperty.Register("MarkerTotal", typeof(int), typeof(Markers), new PropertyMetadata(0));
        public int MarkerSessionScore
        {
            get { return (int)GetValue(MarkerSessionScoreProperty); }
            set { SetValue(MarkerSessionScoreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MarkerSessionScore.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarkerSessionScoreProperty =
            DependencyProperty.Register("MarkerSessionScore", typeof(int), typeof(Markers), new PropertyMetadata(0));


    }
}
