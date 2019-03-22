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
        private void txt_hours_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int number;
            if (int.TryParse(txt_hours.Text + e.Text, out number))
            {
                if(number > 24)
                {
                    e.Handled = true;
                }
            }
        }

        private SolidColorBrush selectedColor = new SolidColorBrush(Color.FromArgb(255, 51, 153, 255));

        public TimeUpDown()
        {
            InitializeComponent();
        }

        private void txt_minutes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int number;
            if (int.TryParse(txt_minutes.Text + e.Text, out number))
            {
                if (number > 60)
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_secconds_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int number;
            if (int.TryParse(txt_secconds.Text + e.Text, out number))
            {
                if (number > 60)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
