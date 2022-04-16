namespace lab4.Abstract_Factory
{
    abstract class AbstractFactory
    {
        public abstract OneRoom CreateOneRoomFlat();
        public abstract TwoRooms CreateTwoRoomsFlat();
    }
}