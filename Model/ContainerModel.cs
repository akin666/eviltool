using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Model
{
    public class ContainerModel
    {
        public string name { get; set; }

        public List<LayerModel> layers = new List<LayerModel>();
    }
}
