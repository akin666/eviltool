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
    public class LayerController : ControllerInterface
    {
        public Layer layer { get; set; }

        public LayerController(Layer layer)
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

        public bool alreadyInUse()
        {
            return layer.field != null || layer.polygon != null || layer.text != null;
        }

        public bool add( Object o )
        {
            if (alreadyInUse())
            {
                return false;
            }
            if (o is FieldController)
            {
                FieldController p = (FieldController)o;
                layer.field = p.field;
            }
            else if (o is PolygonController)
            {
                PolygonController p = (PolygonController)o;
                layer.polygon = p.polygon;
            }
            else if (o is TextController)
            {
                TextController p = (TextController)o;
                layer.text = p.text;
            }
            return true;
        }
    }
}
