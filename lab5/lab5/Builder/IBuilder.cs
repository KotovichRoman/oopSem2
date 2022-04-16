using System;

namespace lab4
{
    public interface IBuilder
    {
        void BuildSquare(int square);
        void BuildRoomsCount(int RoomsCount );
        void BuildDate(DateTime date);
        void BuildAddres(Addres adres);
    }
}