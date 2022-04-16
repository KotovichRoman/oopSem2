using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace lab2
{
    public static class XmlSerializeWrapper
    {

        public static void Serialize<Flat>(List<Flat> obj, string filename)
        {
            using(FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Flat>));
                formatter.Serialize(fs, obj);
            }
        }

        public static Flat[] Deserialize<Flat>(string filename)
        {
            Flat[] flats;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Flat[]));
                flats = (Flat[])formatter.Deserialize(fs);
            }
            return flats;
        }
    }
}
