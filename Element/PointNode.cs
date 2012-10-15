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
    public class PointNode : NodeInterface
    {
        public PointModel point { get; set; }

        public PointNode(PointModel point)
        {
            this.point = point;
        }

        public Control createControl()
        {
            return new PointControl(this);
        }

        public string getName()
        {
            return "point";
        }
    }
}
