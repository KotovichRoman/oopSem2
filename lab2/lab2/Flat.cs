using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace lab2
{
    [Serializable]
    [XmlRoot(Namespace = "lab2")]
    public class Flat
    {
        [XmlElement(ElementName = "SquareFootage")]
        public double SquareFootage;

        [XmlElement(ElementName = "RoomsCount")]
        public int RoomsCount;

        [XmlElement(ElementName = "BuildDate")]
        public DateTime BuildDate;

        [XmlElement(ElementName = "Kitchen")]
        public string Kitchen = "-";

        [XmlElement(ElementName = "BathRoom")]
        public string BathRoom = "-";

        [XmlElement(ElementName = "Toilet")]
        public string Toilet = "-";
        
        [XmlElement(ElementName = "Basement")]
        public string Basement = "-";
        
        [XmlElement(ElementName = "Balcony")]
        public string Balcony = "-";

        [XmlElement(ElementName = "Price")]
        public double Price;

        [XmlElement(ElementName = "Rooms")]
        public List<Room> Rooms;

        [XmlElement(ElementName = "Addres")]
        public Addres Addres;

        public Flat(Addres addres, List<Room> rooms)
        {
            Addres = addres;
            Rooms = rooms;
        }

        public Flat() { }

        public override string ToString()
        {
            return base.ToString();
        }

        public void PriceCounter()
        {
            Price += SquareFootage * 20;
            Price += RoomsCount * 1000;

            if (Kitchen == "+")
            {
                Price += 400;
            }
            if (BathRoom == "+")
            {
                Price += 400;
            }
            if (Toilet == "+")
            {
                Price += 400;
            }
            if (Basement == "+")
            {
                Price += 200;
            }
            if (Balcony == "+")
            {
                Price += 200;
            }
        }
        
    }
}
