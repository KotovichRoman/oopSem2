using System;

namespace lab4
{

    public class Memento
    {
        public double SquareFootage { get; set; }

        public int RoomsCount { get; set; }

        public DateTime BuildDate { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public int House { get; set; }
        
        public int FlatNumber { get; set; }

        public Memento(double squareFootage, int roomsCount, DateTime buildDate, string country, string city, string district, string street, int house, int flatNumber)
        {
            this.SquareFootage = squareFootage;
            this.RoomsCount = roomsCount;
            this.BuildDate = buildDate;
            this.Country = country;
            this.City = city;
            this.District = district;
            this.Street = street;
            this.House = house;
            this.FlatNumber = flatNumber;
        }
    }
}