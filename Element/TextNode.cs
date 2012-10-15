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
    public class TextNode : NodeInterface
    {
        public TextModel text { get; set; }

        public TextNode(TextModel text)
        {
            this.text = text;
        }

        public Control createControl()
        {
            return null;
        }

        public string getName()
        {
            return "text";
        }
    }
}
