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
    /// Interaction logic for PlayView.xaml
    /// </summary>
    public partial class PlayView : UserControl
    {
        string personName;
        public PlayView()
        {
            InitializeComponent();

            personName = txtPersonName.Text;
        }

        private void txtPersonName_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPersonName.Clear();
        }
    }
}
