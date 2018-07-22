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

namespace PicStudios.Widgets
{
    /// <summary>
    /// Interaktionslogik für TimeUpDown.xaml
    /// </summary>
    public partial class TimeUpDown : UserControl
    {
        private int hours, minutes, seconds;

        private SolidColorBrush selectedColor = new SolidColorBrush(Color.FromArgb(255, 51, 153, 255));

        private void reset_Background()
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
            lbl_hours.Background = solidColorBrush;
            lbl_minutes.Background = solidColorBrush;
            lbl_secconds.Background = solidColorBrush;
        }

        private void lbl_hours_MouseDown(object sender, MouseButtonEventArgs e)
        {
            reset_Background();
            lbl_hours.Background = selectedColor;
        }

        private void lbl_minutes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            reset_Background();
            lbl_minutes.Background = selectedColor;
        }

        private void lbl_secconds_MouseDown(object sender, MouseButtonEventArgs e)
        {
            reset_Background();
            lbl_secconds.Background = selectedColor;
        }

        private void lbl_hours_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.D)
                e.
        }

        private void timeUpDown_LostFocus(object sender, RoutedEventArgs e)
        {
            reset_Background();
        }

        public TimeUpDown()
        {
            InitializeComponent();
        }
    }
}
