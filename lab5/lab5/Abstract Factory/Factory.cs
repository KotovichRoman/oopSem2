namespace lab4.Abstract_Factory
{
    class Factory
    {
        public OneRoom oneRoom;
        public TwoRooms twoRooms;

        public Factory(AbstractFactory factory)
        {
            oneRoom = factory.CreateOneRoomFlat();
            twoRooms = factory.CreateTwoRoomsFlat();
        }

        public void InfoAboutFactory()
        {
            oneRoom.OneRoomInfo();
            twoRooms.TwoRoomsInfo();
        }
    }
}