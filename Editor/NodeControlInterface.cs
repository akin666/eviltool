using EvilTool.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.Editor
{
    public interface NodeControlInterface
    {
        void kill();
        NodeInterface getNode();
    }
}
