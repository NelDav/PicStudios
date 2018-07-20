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
using System.IO;

namespace PicStudios
{
    /// <summary>
    /// Interaktionslogik für Image_Entry.xaml
    /// </summary>
    public partial class Image_Entry : UserControl
    {
        public Image_Entry()
        {
            InitializeComponent();
        }
        public Image_Entry(String path)
        {
            InitializeComponent();
            setImage(path);
        }


        public bool setImage(String path)
        {
            if (!File.Exists(path))
                return false;

            image.Source = new BitmapImage(new Uri(path));
            textBlock.Text = path;

            return true;
        }
    }
}
