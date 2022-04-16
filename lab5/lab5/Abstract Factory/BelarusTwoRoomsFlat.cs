using System.Windows.Forms;

namespace lab4.Abstract_Factory
{
    class BelarusTwoRoomsFlat : TwoRooms
    {
        public int Square;
        public int RoomsCount = 2;
        public Addres Addres;

        public BelarusTwoRoomsFlat(Addres addres)
        {
            Addres = addres;
        }

        public override void TwoRoomsInfo()
        {
            Flats flats = new Flats();

            Square = 200;
            Addres.Country = "Беларусь";
            Addres.City = "Слоним";
            Addres.District = "Ленинский";
            Addres.Street = "Красноармейская";
            Addres.House = 10;
            Addres.FlatNumber = 20;

            flats.infoTableForFactoty.Rows.Add(Addres.Country, Addres.City,
                                               Addres.District, Addres.Street,
                                               Addres.House, Addres.FlatNumber,
                                               Square, RoomsCount);
        }
    }
}