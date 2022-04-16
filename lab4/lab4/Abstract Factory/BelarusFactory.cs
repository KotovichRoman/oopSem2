namespace lab4.Abstract_Factory
{

    class BelarusFactory : AbstractFactory
    {
        public override OneRoom CreateOneRoomFlat()
        {
            Addres addres = new Addres();
            return new BelarusOneRoomFlat(addres);
        }

        public override TwoRooms CreateTwoRoomsFlat()
        {
            Addres addres = new Addres();
            return new BelarusTwoRoomsFlat(addres);
        }
    }
}