namespace lab4.Proxy
{

    public class Proxy : ISubject
    {
        private Flat flat;

        public Proxy(Flat flat)
        {
            this.flat = flat;
        }

        public void GetInfo()
        {
            if (flat == null)
                flat = new Flat();

            flat.GetInfo();
        }

        public void DeacreaseSquare()
        {
            if (flat == null)
                flat = new Flat();

            flat.DeacreaseSquare();
        }
    }
}