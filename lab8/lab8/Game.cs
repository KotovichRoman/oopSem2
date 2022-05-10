using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace lab67
{
    public class Game
    {
        static string source = @"C:/Users/User/Desktop/GitHub/oop (sem 2)/lab8/lab8/games.xml";
        static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Game>));
        public string? Name { get; set; }
        public string? Genre { get; set; }

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

        public static List<Game> Collection = new List<Game>();
        public static List<Game> currentCollection = new List<Game>();
        public static void Import()
        {
            using(FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                try
                {
                    Collection = xmlSerializer.Deserialize(fs) as List<Game>;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Файл пуст, добавьте книги!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

        public static void Export()
        {
            File.Delete(source);
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, Collection);
            }
        }

        public static void Push(Game game)
        {
            Collection.Add(game);
            Export();
            MainWindow.GameList.ItemsSource = null;
            MainWindow.GameList.ItemsSource = Collection;
        }

        public static List<Game> GetListFromXML()
        {
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                List<Game> temp = new List<Game>();
                temp = xmlSerializer.Deserialize(fs) as List<Game>;
                return temp;
            }
        }
    }
}
