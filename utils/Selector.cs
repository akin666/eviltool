using EvilTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.utils
{
    public class Selector
    {
        private List<Vec3> current = new List<Vec3>();

        public void addToPoly(Vec3 point)
        {
            current.Add(point);
        }

        public void reset()
        {
            current.Clear();
        }

        public List<int> collide(List<Vec3> points)
        {
            List<int> retlist = new List<int>();
            if (points == null)
            {
                return retlist;
            }
            for (int i = 0; i < points.Count; ++i)
            {
                if (MathHelper.pointInPolygon(points[i], current))
                {
                    retlist.Add(i);
                }
            }
            return retlist;
        }

        public List<Vec3> getList()
        {
            return current;
        }
    }
}
