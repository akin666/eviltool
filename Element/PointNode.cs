using EvilTool.Editor;
using EvilTool.utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool.Element
{
    public class PointNode : NodeInterface
    {
        public List<Point> points = new List<Point>();

        public PointNode()
        {
        }

        public Control createControl()
        {
            return new PointControl(this);
        }

        public string getName()
        {
            return "point";
        }

        public void write(JsonWriter writer, TreeNode self)
        {
            writer.WritePropertyName(getName());
            writer.WriteStartObject();
            // write data here..
            // vertex point data.
            JsonHelper.write(writer, points);

            writer.WriteEndObject();
        }

        public TreeNode read(JsonReader reader)
        {
            if (!JsonHelper.readPropertyName(reader, getName()))
            {
                return null;
            }

            // now we have the class thing.. startobject?
            if (!JsonHelper.readStartObject(reader))
            {
                return null;
            }

            // now we have the vertexes?
            if (!reader.Read())
            {
                return null;
            }
            JsonHelper.read(reader, points);

            // now we have the class thing.. endobject?
            if (!JsonHelper.readEndObject(reader) )
            {
                return null;
            }

            return null;
        }
    }
}
