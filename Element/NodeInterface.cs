using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Element
{
    public interface NodeInterface
    {
        Control createControl();
        string getName();

        void write(JsonWriter writer ,TreeNode self);
        TreeNode read(JsonReader reader);
    }
}
