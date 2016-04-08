using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KIK
{
    public enum ButtonState
    {
        None = 0,
        O = 1,
        X = 2
    }

    public class ImageButton
    {

        public ButtonState State { get; set; }

        public Image Image { get; set; }

        public ImageButton(Image image, ButtonState state)
        {
            this.Image = image;
            this.State = state;
        } 
    }
}
