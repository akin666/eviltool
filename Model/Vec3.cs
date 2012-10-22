using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Model
{
    public class Vec3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Vec3()
        {
        }

        public Vec3(Vec3 other)
        {
            this.x = other.x;
            this.y = other.y;
            this.z = other.z;
        }

        public Vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
