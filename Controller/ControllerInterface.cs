using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Controller
{
    public interface ControllerInterface
    {
        Control createControl();
        string getName();
    }
}
