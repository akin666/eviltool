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
    public class FieldController : ControllerInterface
    {
        public Field field { get; set; }

        public FieldController(Field field)
        {
            this.field = field;
        }

        public Control createControl()
        {
            return new FieldEditor(this);
        }

        public string getName()
        {
            return "point field";
        }
    }
}
