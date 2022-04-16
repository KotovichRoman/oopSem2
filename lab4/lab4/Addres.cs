using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    [Serializable]
    public class Addres
    {
        public string Country;
        public string City;
        public string District;
        public string Street;
        public int House;
        public int FlatNumber;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
