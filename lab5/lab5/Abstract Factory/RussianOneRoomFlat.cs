using System.Windows.Forms;

namespace lab4.Abstract_Factory
{
    class RussianOneRoomFlat : OneRoom
    {
        public int Square;
        public int RoomsCount = 1;
        public Addres Addres;

        public RussianOneRoomFlat(Addres addres)
        {
            Addres = addres;
        }

        public override void OneRoomInfo()
        {
            Flats flats = new Flats();

            Square = 200;
            Addres.Country = "Россия";
            Addres.City = "Москва";
            Addres.District = "Ленинский";
            Addres.Street = "Российская";
            Addres.House = 11;
            Addres.FlatNumber = 22;

            flats.infoTableForFactoty.Rows.Add(Addres.Country, Addres.City,
                                               Addres.District, Addres.Street,
                                               Addres.House, Addres.FlatNumber,
                                               Square, RoomsCount);
        }
    }
}