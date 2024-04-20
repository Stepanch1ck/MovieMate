using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMate
{

    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int cornerRadius = 20; // Adjust the corner radius as needed

            using (GraphicsPath path = GetRoundedRectanglePath(bounds, cornerRadius))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillPath(Brushes.Black, path); // Set the background color to black
                graphics.DrawPath(Pens.Black, path); // Set the border color to black

                // Set the text color to white
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(this.Text, this.Font, Brushes.White, bounds, format);
                }
            }

        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(bounds.Right - cornerRadius * 2, bounds.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}