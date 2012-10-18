using EvilTool.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Controller
{
    public class ContainerController : ControllerInterface
    {
        public Container container { get; set; }

        public ContainerController(Container container)
        {
            this.container = container;
        }

        public Control createControl()
        {
            MessageBox.Show("No control specified for this type.");
            return null;
        }

        public string getName()
        {
            return "container";
        }

        public void add(LayerController layer)
        {
            if (container.layers == null)
            {
                container.layers = new List<Layer>();
            }
            container.layers.Add(layer.layer);
        }
    }
}
