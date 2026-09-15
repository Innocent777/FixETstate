using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FixETstate
{
    public partial class ResetRequestWindow : Window
    {
        public ResetRequestWindow()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Reset approved.\n\nThe next version will perform the approved safe reset and restart the computer.",
                "Reset Approved",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            DialogResult = true;
        }

        private void DeclineButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "The reset request was declined. No changes were made.",
                "Request Declined",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            DialogResult = false;
        }
    }
}
