using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace lab4
{
    [Serializable]
    [XmlRoot(Namespace = "lab2")]
    public class Flat : IPrototype
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

        public Flat(Addres addres)
        {
            Addres = addres;
        }

        public Flat() { }

        public Flat(Flat flat)
        {
            SquareFootage = flat.SquareFootage;
            RoomsCount = flat.RoomsCount;
            BuildDate = flat.BuildDate;
            Addres = flat.Addres;
        }

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

        public IPrototype Clone()
        {
            return new Flat(this);
        }

        public void GetInfo()
        {
            MessageBox.Show($"Скопированная квартира\n\n" +
                            $"Метраж: {SquareFootage}\n" +
                            $"Количество комнта: {RoomsCount}\n" +
                            $"Дата постройки: {BuildDate}\n" +
                            $"Адрес: {Addres.Country} {Addres.City} {Addres.District} {Addres.Street} {Addres.House}");
        }

        public void DeacreaseSquare()
        {
            if (SquareFootage > 1)
            {
                SquareFootage--;
                MessageBox.Show($"Метраж уменьшен: {SquareFootage}");
            }
            else
            {
                MessageBox.Show("Ниже некуда");
            }
        }

        public Memento SaveState()
        {
            MessageBox.Show($"Объект полностью сохранен");
            return new Memento(SquareFootage, RoomsCount, BuildDate, Addres.Country, 
                Addres.City, Addres.District, Addres.Street, Addres.House, Addres.FlatNumber);
        }

        public void RestoreState(Memento flatMemento)
        {
            this.SquareFootage = flatMemento.SquareFootage;
            this.RoomsCount = flatMemento.RoomsCount;
            this.BuildDate = flatMemento.BuildDate;
            this.Addres.Country = flatMemento.Country;
            this.Addres.City = flatMemento.City;
            this.Addres.District = flatMemento.District;
            this.Addres.Street = flatMemento.Street;
            this.Addres.House = flatMemento.House;
            this.Addres.FlatNumber = flatMemento.FlatNumber;
            MessageBox.Show($"Параметры восстановлены!\n\n" + this.ToString());
        }
    }
}
