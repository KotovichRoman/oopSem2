using System.Windows.Forms;

namespace lab4.Abstract_Factory
{
    class RussianTwoRoomsFlat : TwoRooms
    {
        public int Square;
        public int RoomsCount = 1;
        public Addres Addres;

        public RussianTwoRoomsFlat(Addres addres)
        {
            Addres = addres;
        }

        public override void TwoRoomsInfo()
        {
            Flats flats = new Flats();

            Square = 200;
            Addres.Country = "Беларусь";
            Addres.City = "Минск";
            Addres.District = "Ленинский";
            Addres.Street = "Белорусская";
            Addres.House = 10;
            Addres.FlatNumber = 20;

            flats.infoTableForFactoty.Rows.Add(Addres.Country, Addres.City,
                                               Addres.District, Addres.Street,
                                               Addres.House, Addres.FlatNumber,
                                               Square, RoomsCount);
        }
    }
}