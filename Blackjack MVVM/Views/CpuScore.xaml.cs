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
    /// Interaction logic for CpuScore.xaml
    /// </summary>
    public partial class CpuScore : UserControl
    {
        public CpuScore()
        {
            InitializeComponent();
        }



        public int cpuScore
        {
            get { return (int)GetValue(cpuScoreProperty); }
            set { SetValue(cpuScoreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for cpuScore.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty cpuScoreProperty =
            DependencyProperty.Register("cpuScore", typeof(int), typeof(CpuScore), new PropertyMetadata(0));


    }
}
