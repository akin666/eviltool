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

namespace EvilTool.Controller
{
    public class PolygonController : ControllerInterface
    {
        public Polygon polygon { get; set; }

        public PolygonController(Polygon polygon)
        {
            this.polygon = polygon;
        }

        public Control createControl()
        {
            return new PolygonEditor(this);
        }

        public string getName()
        {
            return "polygon";
        }
    }
}
