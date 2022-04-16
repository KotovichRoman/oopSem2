namespace lab4.Abstract_Factory
{
    class RussianFactory : AbstractFactory
    {
        public override OneRoom CreateOneRoomFlat()
        {
            Addres addres = new Addres();
            return new RussianOneRoomFlat(addres);
        }

        public override TwoRooms CreateTwoRoomsFlat()
        {
            Addres addres = new Addres();
            return new RussianTwoRoomsFlat(addres);
        }
    }
}