using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab67
{
    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(List<T> obj, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Truncate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
                formatter.Serialize(fs, obj);
            }
        }

        public static List<T> Deserialize<T>(string filename)
        {
            List<T> objects = new List<T>();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
                objects = (List<T>)formatter.Deserialize(fs);
            }
            return objects;
        }
    }
}
