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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KIK
{
    public partial class MainWindow : MetroWindow
    {

        private Uri O = new Uri("res/img/green2.png", UriKind.Relative);
        private Uri X = new Uri("res/img/x-400.png", UriKind.Relative);
        private Uri NONE = new Uri("res/img/1x1.png", UriKind.Relative);

        private static ImageButton A1_Object;
        private static ImageButton A2_Object;
        private static ImageButton A3_Object;

        private static ImageButton B1_Object;
        private static ImageButton B2_Object;
        private static ImageButton B3_Object;

        private static ImageButton C1_Object;
        private static ImageButton C2_Object;
        private static ImageButton C3_Object;

        public MainWindow()
        {
            InitializeComponent();

            Menu main = new Menu();
            main.Show();

            List<Image> buttons = new List<Image>();
            buttons.Add(this.A1);
            buttons.Add(this.A2);
            buttons.Add(this.A3);
            buttons.Add(this.B1);
            buttons.Add(this.B2);
            buttons.Add(this.B3);
            buttons.Add(this.C1);
            buttons.Add(this.C2);
            buttons.Add(this.C3);

            A1_Object = new ImageButton(this.A1, ButtonState.None);
            A2_Object = new ImageButton(this.A2, ButtonState.None);
            A3_Object = new ImageButton(this.A3, ButtonState.None);

            B1_Object = new ImageButton(this.B1, ButtonState.None);
            B2_Object = new ImageButton(this.B2, ButtonState.None);
            B3_Object = new ImageButton(this.B3, ButtonState.None);

            C1_Object = new ImageButton(this.C1, ButtonState.None);
            C2_Object = new ImageButton(this.C2, ButtonState.None);
            C3_Object = new ImageButton(this.C3, ButtonState.None);

            foreach(var button in buttons)
            {
                button.Source = new BitmapImage(NONE);
            }
        }

        private ImageButton ImageButtonCast(Image image)
        {
            switch (image.Name)
            {
                case "A1":
                    return A1_Object;
                case "A2":
                    return A2_Object;
                case "A3":
                    return A3_Object;

                case "B1":
                    return B1_Object;
                case "B2":
                    return B2_Object;
                case "B3":
                    return B3_Object;

                case "C1":
                    return C1_Object;
                case "C2":
                    return C2_Object;
                case "C3":
                    return C3_Object;

                default:
                    return null;
            }
        }

        private void ImageChange_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;          
            ImageButton imgButton = ImageButtonCast(image);

            switch (imgButton.State)
            {
                case ButtonState.None:
                    imgButton.Image.Source = new BitmapImage(X);
                    imgButton.State = ButtonState.X;
                    break;
                case ButtonState.X:
                    imgButton.Image.Source = new BitmapImage(O);
                    imgButton.State = ButtonState.O;
                    break;
                case ButtonState.O:
                    imgButton.Image.Source = new BitmapImage(X);
                    imgButton.State = ButtonState.X;
                    break;
                default:
                    imgButton.Image.Source = new BitmapImage(NONE);
                    imgButton.State = ButtonState.None;
                    break;
            }   
        }
    }
}
