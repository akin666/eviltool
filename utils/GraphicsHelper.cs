using EvilTool.Model;
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
        public static void draw(Graphics graphics, Selector selector, Pen pen)
        {
            if (selector == null)
            {
                return;
            }

            List<Vec3> vertexes = selector.getList();
            if (vertexes == null || vertexes.Count < 2)
            {
                return;
            }

            List<Point> points = new List<Point>();
            for (int i = 0; i < vertexes.Count; ++i)
            {
                points.Add(new Point((int)vertexes[i].x, (int)vertexes[i].y));
            }

            graphics.DrawPolygon(pen, points.ToArray());
        }

        public static void circle( Graphics graphics , Vec3 center , int size , Pen pen )
        {
            Point tl = new Point((int)center.x - (size / 2), (int)center.y - (size / 2));
            Rectangle rect = new Rectangle(tl, new Size(size, size));
            graphics.DrawEllipse(pen, rect);
        }

        public static void polygon(Graphics graphics, List<Vec3> vertexes, Brush pen)
        {
            if( vertexes == null || vertexes.Count < 1 )
            {
                return;
            }

            List<Point> points = new List<Point>();
            for( int i = 0 ; i < vertexes.Count ; ++i )
            {
                points.Add( new Point( (int)vertexes[i].x , (int)vertexes[i].y ) );
            }

            graphics.FillPolygon(pen, points.ToArray());
        }

        public static void polygon(Graphics graphics, List<Vec3> vertexes, Pen pen)
        {
            if (vertexes == null || vertexes.Count < 1)
            {
                return;
            }

            List<Point> points = new List<Point>();
            for (int i = 0; i < vertexes.Count; ++i)
            {
                points.Add(new Point((int)vertexes[i].x, (int)vertexes[i].y));
            }

            graphics.DrawPolygon(pen, points.ToArray());
        }

        public static void dimensions(Graphics graphics, Vec3 center, float size)
        {
            Pen blue = new Pen(Color.Blue, 2.0f);
            Pen red = new Pen(Color.Red, 2.0f);
            Pen green = new Pen(Color.Green, 2.0f);
            Pen black = new Pen(Color.Black, 2.0f);

            float arrowsize = size / 10.0f;
            if (arrowsize > 20.0f)
            {
                arrowsize = 20.0f;
            }

            Vec3 a = center;
            Vec3 b = new Vec3( center.x , center.y + size , 0.0f );
            Vec3 c = new Vec3(center.x + size, center.y, 0.0f);

            Vec3 b1 = new Vec3(center.x + arrowsize, center.y + size - arrowsize, 0.0f);
            Vec3 b2 = new Vec3(center.x - arrowsize, center.y + size - arrowsize, 0.0f);

            Vec3 c1 = new Vec3(center.x + size - arrowsize, center.y + arrowsize, 0.0f);
            Vec3 c2 = new Vec3(center.x + size - arrowsize, center.y - arrowsize, 0.0f);

            // a->b
            graphics.DrawLine(red, a.x, a.y, b.x, b.y);
            graphics.DrawLine(red, b.x, b.y, b1.x, b1.y);
            graphics.DrawLine(red, b.x, b.y, b2.x, b2.y);

            // a->c
            graphics.DrawLine(blue, a.x, a.y, c.x, c.y);
            graphics.DrawLine(blue, c.x, c.y, c1.x, c1.y);
            graphics.DrawLine(blue, c.x, c.y, c2.x, c2.y);
        }
    }
}
