using System;

namespace lab4
{

    class FlatBuilder : IBuilder
    {
        private Flat flat = new Flat();

        public FlatBuilder()
        {
            Reset();
        }

        public Flat GetFlat ()
        {
            Flat result = flat;

            Reset();

            return result;
        }

        public void Reset()
        {
            flat = new Flat ();
        }

        public void BuildAddres(Addres adres)
        {
            flat.Addres = adres;
        }

        public void BuildSquare(int square)
        {
            flat.SquareFootage = square;
        }

        public void BuildRoomsCount (int roomsCount)
        {
            flat.RoomsCount = roomsCount;

        }

        public void BuildDate(DateTime date)
        {
            flat.BuildDate = date;
        }
    }
}