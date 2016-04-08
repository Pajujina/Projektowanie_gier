using MahApps.Metro.Controls;
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

namespace KIK
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (Image)sender;

            string source = image.Source.ToString();
            source = source.Substring(0, source.Length - 4) + "_inw.png";
            Uri uri = new Uri(source, UriKind.Absolute);

            image.Source = new BitmapImage(uri);
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            Image image = (Image)sender;

            string source = image.Source.ToString();
            source = source.Substring(0, source.Length - 8) + ".png";
            Uri uri = new Uri(source, UriKind.Absolute);

            image.Source = new BitmapImage(uri);
        }
    }
}
