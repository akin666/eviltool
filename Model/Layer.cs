using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Model
{
    public class Layer
    {
        public string name { get; set; }
        public int id { get; set; }

        // potential things inside.. who needs inheritance anyways, its for.. 
        public Polygon polygon { get; set; }
        public Text text { get; set; }
        public Field field { get; set; }
    }
}
