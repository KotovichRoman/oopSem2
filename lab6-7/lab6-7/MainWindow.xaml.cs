using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab6-7/lab6-7/games.xml";

        public List<Game> games = new List<Game>();

        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void AddObjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();

            Close();
        }

        private void GameList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game game = (Game)GameList.SelectedItem;
            AboutWindow aboutWindow = new AboutWindow(game);

            aboutWindow.Show();

            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            games = XmlSerializeWrapper.Deserialize<Game>(filePath);
            GameList.ItemsSource = games;
        }
    }
}
