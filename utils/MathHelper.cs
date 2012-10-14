using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.utils
{
    public static class MathHelper
    {
        public static double distance(this Point point1, Point point2)
        {
            var a = (double)(point2.X - point1.X);
            var b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }

        public static Point midPoint(Point point1, Point point2)
        {
            return new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
        }
    }
}
