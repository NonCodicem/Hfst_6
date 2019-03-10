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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hoofdstuk_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int carCount = 0;
        public MainWindow()
        {
            InitializeComponent();
            lbl_count.Content = $"There is {carCount} car in the parkinglot.";
        }

        private void btn_out_Click(object sender, RoutedEventArgs e)
        {
            if (carCount > 0)
            {
                carCount -= 1;
                if (carCount == 1)
                {
                    lbl_count.Content = lbl_count.Content = $"There is {carCount} car in the parkinglot.";
                }
                else
                {
                    lbl_count.Content = lbl_count.Content = $"There are {carCount} cars are in the parkinglot.";
                }
                
            }
            else
            {
                lbl_count.Content = lbl_count.Content = $"There are {carCount} cars are in the parkinglot.";
                MessageBox.Show($"All cars left the parkinglot.");
                
            }
            

        }

        private void btn_in_Click(object sender, RoutedEventArgs e)
        {
           
            carCount += 1;
            if (carCount == 1)
            {
                lbl_count.Content = lbl_count.Content = $"There is {carCount} car in the parkinglot.";
            }
            else
            {
                lbl_count.Content = lbl_count.Content = $"There are {carCount} cars are in the parkinglot.";
            }
        }
    }
    
}
