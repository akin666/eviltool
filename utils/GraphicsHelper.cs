using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.utils
{
    public static class GraphicsHelper
    {
        public static void circle( Graphics graphics , Point center , int size , Pen pen )
        {
            Point tl = new Point(center.X - (size / 2), center.Y - (size / 2));
            Rectangle rect = new Rectangle(tl, new Size(size, size));
            graphics.DrawEllipse(pen, rect);
        }
    }
}
