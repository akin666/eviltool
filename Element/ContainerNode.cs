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
        public string name { get; set; }

        public ContainerNode()
        {
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

        public void write(JsonWriter writer, TreeNode self)
        {
            writer.WritePropertyName(getName());
            writer.WriteStartObject();

            // write data here..
            if (name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteValue(name);
            }

            foreach (TreeNode node in self.Nodes)
            {
                if (node.Tag is NodeInterface)
                {
                    ((NodeInterface)node.Tag).write(writer, node);
                }
            }

            writer.WriteEndObject();
        }

        public TreeNode read(JsonReader reader)
        {
            return null;
        }
    }
}
