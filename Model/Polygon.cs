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
        public List<Vec3> points { get; set; }
        public Vec3 pivot { get; set; }
        public string texture { get; set; }
    }
}
