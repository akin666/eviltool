using EvilTool.Model;
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
        public static double distance(this Vec3 point1, Vec3 point2)
        {
            var a = (double)(point2.x - point1.x);
            var b = (double)(point2.y - point1.y);

            return Math.Sqrt(a * a + b * b);
        }

        public static Vec3 midPoint(Vec3 point1, Vec3 point2)
        {
            return new Vec3((point1.x + point2.x) / 2.0f, (point1.y + point2.y) / 2.0f, (point1.z + point2.z) / 2.0f);
        }

        // http://social.msdn.microsoft.com/forums/en-US/winforms/thread/95055cdc-60f8-4c22-8270-ab5f9870270a/
        public static bool pointInPolygon(Vec3 p, List<Vec3> poly)
        {
            Vec3 p1, p2;
            bool inside = false;

            if (poly.Count < 3)
            {
                return inside;
            }

            Vec3 oldPoint = new Vec3(poly[poly.Count - 1].x, poly[poly.Count - 1].y , 0.0f);

            for (int i = 0; i < poly.Count; ++i)
            {
                Vec3 newPoint = new Vec3(poly[i]);

                if (newPoint.x > oldPoint.x)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.x < p.x) == (p.x <= oldPoint.x) && 
                    ((long)p.y - (long)p1.y) * (long)(p2.x - p1.x) < ((long)p2.y - (long)p1.y) * (long)(p.x - p1.x))
                {
                    inside = !inside;
                }
                oldPoint = newPoint;
            }

            return inside;
        }
    }
}
