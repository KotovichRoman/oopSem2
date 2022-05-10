using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;    

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab6-7/lab6-7/games.xml";

        public MainWindow mainWindow = new MainWindow();
        public List<Game> games = new List<Game>();
        public Game windowGame = new Game();

        public AboutWindow()
        {
            InitializeComponent();
        }

        public AboutWindow(Game game)
        {
            InitializeComponent();

            NameBox.Text = game.Name;
            GenresBox.Text = game.Genres;
            PriceBox.Text = Convert.ToString(game.Price);
            QuantityBox.Text = Convert.ToString(game.Quantity);
            StatusBox.Text = game.Status;
            ImageField.Source = BitmapFrame.Create(new Uri(game.ImgSrc));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            games = XmlSerializeWrapper.Deserialize<Game>(filePath);

            windowGame.Name = NameBox.Text;
            windowGame.Price = Convert.ToInt32(PriceBox.Text);

            foreach (var game in games)
            {
                if (windowGame.Name == game.Name && windowGame.Price == game.Price)
                {
                    windowGame = game;
                    break;
                }
            }

            games.Remove(windowGame);

            XmlSerializeWrapper.Serialize<Game>(games, filePath);

            Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            windowGame.Name = NameBox.Text;
            windowGame.Genres = GenresBox.Text;
            windowGame.Price = Convert.ToInt32(PriceBox.Text);
            windowGame.Quantity = Convert.ToInt32(QuantityBox.Text);
            windowGame.ImgSrc = Convert.ToString(ImageField.Source);

            EditWindow editWindow = new EditWindow(windowGame);

            editWindow.Show();
        }
    }
}
