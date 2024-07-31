using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Fitness.Utilities
{
    public class LayoutHelper
    {
        public static void set_FormBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Panel panel = sender as Panel;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, panel.Width, panel.Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(238, 130, 238), Color.FromArgb(0, 209, 255), 270f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
