using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilTool.utils
{
    class JsonHelper
    {
        // Vertexes
        static string vertexes = "vertexes";
        public static void write(JsonWriter writer, List<Point> points)
        {
            writer.WritePropertyName(vertexes);
            writer.WriteStartArray();
            foreach (Point point in points)
            {
                write(writer, point);
            }
            writer.WriteEndArray();
        }

        public static void read(JsonReader reader, List<Point> points)
        {
            if( !readPropertyName(reader , vertexes ) )
            {
                return;
            }

            // array start
            if (!readStartArray(reader))
            {
                return;
            }

            // while we are not in the end of the array
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                Point point = new Point();
                points.Add(point);
            }

            // array end
            if (!reader.Read())
            {
                return;
            }
        }

        // POINT
        public static void write(JsonWriter writer, Point point)
        {
            writer.WriteStartArray();
            writer.WriteValue(point.X);
            writer.WriteValue(point.Y);
            writer.WriteEndArray();
        }

        public static bool read(JsonReader reader, Point point)
        {
            // array start
            if (!readStartArray(reader))
            {
                return false;
            }

            // read X
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType == JsonToken.Integer)
            {
                Nullable<int> tt = reader.ReadAsInt32();
                if (tt != null) point.X = tt.Value;
                else return false;
            }
            else
            {
                return false;
            }

            // read Y
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType == JsonToken.Integer)
            {
                Nullable<int> tt = reader.ReadAsInt32();
                if (tt != null) point.Y = tt.Value;
                else return false;
            }
            else
            {
                return false;
            }

            // array end
            if (!readEndArray(reader))
            {
                return false;
            }

            return true;
        }

        // general
        public static bool readStartObject(JsonReader reader)
        {
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType != JsonToken.StartObject)
            {
                return false;
            }
            return true;
        }

        public static bool readEndObject(JsonReader reader)
        {
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType != JsonToken.EndObject)
            {
                return false;
            }
            return true;
        }

        public static bool readPropertyName(JsonReader reader , string name )
        {
            if (reader.TokenType != JsonToken.PropertyName || !name.Equals(reader.Value))
            {
                return false;
            }
            return true;
        }

        public static bool readStartArray(JsonReader reader)
        {
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType != JsonToken.StartArray)
            {
                return false;
            }
            return true;
        }

        public static bool readEndArray(JsonReader reader)
        {
            if (!reader.Read())
            {
                return false;
            }
            if (reader.TokenType != JsonToken.StartArray)
            {
                return false;
            }
            return true;
        }
    }
}
