using System;

namespace lab4
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set
            {
                builder = value;
            }
        }

        Random ranNum = new Random();

        public void BuildRandomStudent()
        {
            int square = getRanSquare();
            int RoomsCount = getRanRoomsCount();
            DateTime Date = getBuildDate();

            Addres addres = new Addres();

            string Country = getRanCountry();
            string City = getRanCity();
            string District = getRanDistrict();
            string Street = getRanStreet();
            int Home = getRanHouse();
            int FlatNumber = getRanFlatNumber();

            addres.Country = Country;
            addres.City = City;
            addres.District = District;
            addres.Street = Street;
            addres.House = Home;
            addres.FlatNumber = FlatNumber;

            builder.BuildSquare(square);
            builder.BuildRoomsCount(RoomsCount);
            builder.BuildDate(Date);
            builder.BuildAddres(addres);
        }

        public int getRanSquare()
        {
            Random random = new Random();
            int square = random.Next();
            return square;
        }

        public int getRanRoomsCount()
        {
            int[] count = { 1, 2, 3 };
            return count[ranNum.Next(0, count.Length)];
        }

        public string getRanCountry()
        {
            string[] countryes = { "Беларусь", "Россия", "Украина" };
            return countryes[ranNum.Next(0, countryes.Length)];
        }

        public string getRanCity()
        {
            string[] cityes = { "Несвиж", "Столбцы", "Минск", "Городея" };
            return cityes[ranNum.Next(0, cityes.Length)];
        }

        public string getRanDistrict()
        {
            string[] streets = { "Ленинский", "Победный" };
            return streets[ranNum.Next(0, streets.Length)];
        }

        public string getRanStreet()
        {
            string[] streets = { "Победа", "Мая", "Ленина", "Сталина" };
            return streets[ranNum.Next(0, streets.Length)];
        }

        public int getRanHouse()
        {
            return ranNum.Next(1, 200);
        }

        public int getRanFlatNumber()
        {
            return ranNum.Next(100000, 999999);
        }

        public DateTime getBuildDate()
        {
            int year = ranNum.Next(1990, 2005);
            int month = ranNum.Next(1, 13);
            int day = ranNum.Next(1, 29);

            DateTime date = new DateTime(year, month, day);
            return date;
        }
    }
}