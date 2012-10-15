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
    public class ContainerNode : NodeInterface
    {
        public ContainerModel container { get; set; }

        public ContainerNode( ContainerModel container )
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
    }
}
