using System.Windows.Forms;
using lab4;

namespace lab4.Abstract_Factory
{
    class BelarusOneRoomFlat : OneRoom
    {
        public int Square;
        public int RoomsCount = 1;
        public Addres Addres;

        public BelarusOneRoomFlat(Addres addres)
        {
            Addres = addres;
        }

        public override void OneRoomInfo()
        {
            Flats flats = new Flats();

            Square = 200;
            Addres.Country = "Беларусь";
            Addres.City = "Минск";
            Addres.District = "Ленинский";
            Addres.Street = "Белорусская";
            Addres.House = 10;
            Addres.FlatNumber = 20;

            flats.infoTableForFactoty.Rows.Add($"{Addres.Country}, {Addres.City}");
        }
    }
}