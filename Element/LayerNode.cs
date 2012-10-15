using EvilTool.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Element
{
    public class LayerNode : NodeInterface
    {
        public LayerModel layer { get; set; }

        public LayerNode(LayerModel layer)
        {
            this.layer = layer;
        }

        public Control createControl()
        {
            MessageBox.Show("No control specified for this type.");
            return null;
        }

        public string getName()
        {
            return "layer";
        }
    }
}
