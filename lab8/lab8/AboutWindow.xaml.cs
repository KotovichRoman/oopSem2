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

namespace lab67
{
    /// <summary>
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab8/lab8/games.xml";

        public MainWindow mainWindow = new MainWindow();
        public List<Game> games = new List<Game>();
        public Game windowGame = new Game();
        public string languagePath;
        public AboutWindow()
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(MainWindow.mainWindow.languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public AboutWindow(Game game)
        {
            InitializeComponent();

            languagePath = "Russian.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            DataContext = new ApplicationsViewModel();
            if(game != null)
            {
                windowGame = game;
                NameBox.Text = game.Name;
                GenresBox.Text = game.Genre;
                PriceBox.Text = Convert.ToString(game.Price);
                QuantityBox.Text = Convert.ToString(game.Quantity);
                StatusBox.Text = game.Status;
                ImageField.Source = BitmapFrame.Create(new Uri(game.ImgSrc));
            }
            
        }

        public void Update(Game game)
        {
            windowGame = game;
            NameBox.Text = game.Name;
            PriceBox.Text = Convert.ToString(game.Price);
            QuantityBox.Text = Convert.ToString(game.Quantity);
            StatusBox.Text = game.Status;
            ImageField.Source = BitmapFrame.Create(new Uri(game.ImgSrc));
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

            State.undoStack.Push(Game.GetListFromXML());

            Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow(windowGame, this);
            editWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
        }
    }
}
