using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab6_7
{
    public class Game
    {
        public string Name { get; set; }
        public string Genres { get; set; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    Status = "Есть в наличии";
                    quantity = value;
                }
                else if (value == 0)
                {
                    Status = "Нет в наличии";
                    quantity = value;
                }
                else
                {
                    MessageBox.Show("Количество не может быть отрицательным!");
                }
            }
        }
        public string Status { get; set; }
        public int Price { get; set; }
        public string ImgSrc { get; set; }

        public Game() { }
    }
}
