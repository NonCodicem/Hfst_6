using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hoofdstuk_6_DispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int count = 1;

        public MainWindow()
        {
            InitializeComponent();

            //lblCount.Content = count;
            //timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += timerTick;
            timer.Tick += timerTick2;
        }

        private void timerTick(object sender, EventArgs e)
        {
            lblCount.Content = count++;
        }

        private void timerTick2(object sender, EventArgs e)
        {

            Random random = new Random();

            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);

            Brush brush = new SolidColorBrush(Color.FromRgb(r, g, b));

            lblCount.Background = brush;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            btnStart.IsEnabled = false;
            btnReset.IsEnabled = false;
            btnStop.IsEnabled = true;

        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            btnReset.IsEnabled = true;
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lblCount.Content = count = 0;
        }
    }
}
