using EvilTool.Editor;
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
    public class TextController : ControllerInterface
    {
        public Text text { get; set; }

        public TextController(Text text)
        {
            this.text = text;
        }

        public Control createControl()
        {
            return new TextEditor(this);
        }

        public string getName()
        {
            return "text";
        }
    }
}
