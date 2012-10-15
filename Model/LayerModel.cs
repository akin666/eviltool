using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Model
{
    public class LayerModel
    {
        public string name { get; set; }
        public int level { get; set; }
        public Object child { get; set; }
    }
}
