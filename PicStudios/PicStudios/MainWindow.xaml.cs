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
using Microsoft.Win32;

namespace PicStudios
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        #region Resize Toolbar
        bool toolResize = false;
        private void grd_Tool_Size_MouseDown(object sender, MouseEventArgs e)
        {
            toolResize = true;
        }

        private void grd_Tool_Size_MouseUp(object sender, MouseEventArgs e)
        {
            toolResize = false;
        }

        private void grd_Tool_Size_MouseMove(object sender, MouseEventArgs e)
        {
            if (toolResize)
                MainGrid.RowDefinitions.ElementAt(0).Height = new GridLength(e.GetPosition(MainGrid).Y + 2);
        }
        #endregion

        #region Resize property
        bool propertyResize = false;
        private void grd_Property_Size_MouseDown(object sender, MouseEventArgs e)
        {
            propertyResize = true;
        }

        private void grd_Property_Size_MouseUp(object sender, MouseEventArgs e)
        {
            propertyResize = false;
        }

        private void grd_Property_Size_MouseMove(object sender, MouseEventArgs e)
        {
            if (propertyResize)
                InletGrid.ColumnDefinitions.ElementAt(1).Width = new GridLength(InletGrid.ActualWidth - e.GetPosition(InletGrid).X + 2);
        }
        #endregion

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, Filter = "Image File|*.jpg", Title = "Load Images"};
            
            if(ofd.ShowDialog().Value)
            {
                foreach (string file in ofd.FileNames)
                {
                    Image_Entry entry = new Image_Entry();

                    if(entry.setImage(file))
                        lst_Images.Items.Add(entry);
                }
            }
        }
    }
}
