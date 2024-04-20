using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMate
{
    public class RoundedRichTextBox : RichTextBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 15;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius * 2, borderRadius * 2), 180, 90);
            path.AddLine(borderRadius, 0, Width - borderRadius, 0);
            path.AddArc(new Rectangle(Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2), 270, 90);
            path.AddLine(Width, borderRadius, Width, Height - borderRadius);
            path.AddArc(new Rectangle(Width - borderRadius * 2, Height - borderRadius * 2, borderRadius * 2, borderRadius * 2), 0, 90);
            path.AddLine(Width - borderRadius, Height, borderRadius, Height);
            path.AddArc(new Rectangle(0, Height - borderRadius * 2, borderRadius * 2, borderRadius * 2), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
