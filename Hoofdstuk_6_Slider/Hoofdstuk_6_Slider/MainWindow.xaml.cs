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

namespace Hoofdstuk_6_Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            sldBreedte.Minimum = 0;
            sldBreedte.Maximum = canvas.Width;

            sldHoogte.Minimum = 0;
            sldHoogte.Maximum = canvas.Height;

            lblBreedte.Content = Convert.ToString(sldBreedte.Value);
            lblHoogte.Content = Convert.ToString(sldHoogte.Value);

            createEllipse();

        }

        private void sldBreedte_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int breedte = Convert.ToInt32(sldBreedte.Value);
            lblBreedte.Content = Convert.ToString(breedte);

            updateEllipse();

        }

        private void sldHoogte_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hoogte = Convert.ToInt32(sldHoogte.Value);
            lblHoogte.Content = Convert.ToString(hoogte);

            updateEllipse();

        }

        private void createEllipse()
        {

            ellipse = new Ellipse();
            ellipse.Width = sldBreedte.Value;
            ellipse.Height = sldHoogte.Value;
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            canvas.Children.Add(ellipse);
        }

        private void updateEllipse()
        {
            ellipse.Width = sldBreedte.Value;
            ellipse.Height = sldHoogte.Value;
        }
    }
}
