using EvilTool.Editor;
using EvilTool.Model;
using EvilTool.utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Element
{
    public class PolygonNode : NodeInterface
    {
        public PolygonModel polygon { get; set; }

        public PolygonNode(PolygonModel polygon)
        {
            this.polygon = polygon;
        }

        public Control createControl()
        {
            return new PolygonControl(this);
        }

        public string getName()
        {
            return "polygon";
        }
    }
}
