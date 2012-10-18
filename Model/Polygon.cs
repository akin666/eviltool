using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Model
{
    public class Polygon
    {
        public List<Point> points { get; set; }
        public Position position { get; set; }
        public Point pivot { get; set; }
    }
}
