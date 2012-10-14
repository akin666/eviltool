using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Element
{
    public class TextNode : NodeInterface
    {
        public TextNode()
        {
        }

        public Control createControl()
        {
            return null;
        }

        public string getName()
        {
            return "text";
        }

        public void write(JsonWriter writer, TreeNode self)
        {
        }

        public TreeNode read(JsonReader reader)
        {
            return null;
        }
    }
}
