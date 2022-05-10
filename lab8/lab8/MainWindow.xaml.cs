using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace lab67
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public static ListBox GameList;
        public static MainWindow mainWindow;
        public string languagePath;
        public string WindowLanguage = "Russian";

        string purpleStyle = "Purple";
        string limeStyle = "Lime";
        string currentStyle = "Lime";

        public MainWindow()
        {
            InitializeComponent();
            GameList = gameList;
            mainWindow = this;
            DataContext = new ApplicationsViewModel();

            ResourceDictionary language = new ResourceDictionary();
            languagePath = "Russian.xaml";
            language.Source = new Uri(languagePath, UriKind.Relative);

            State.undoStack.Push(Game.GetListFromXML());
        }

        public void SwitchLanguageRussian()
        {
            languagePath = "Russian.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void SwitchLanguageEng()
        {
            languagePath = "English.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {      
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Game.Import();
            gameList.ItemsSource = Game.Collection;
            foreach(var b in Game.Collection)
            {
                Game.currentCollection.Add(b);
            }
        }

        public void GenreBox_DropDownClosed(object sender, EventArgs e)
        {
            InputFunc();
        }

        public void SortBox_DropDownClosed(object sender, EventArgs e)
        {
            InputFunc();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputFunc();
        }

        public void InputFunc()
        {
            gameList.ItemsSource = null;
            List<Game> tempo = new List<Game>();
            if (GenreBox.Text == "Все")
            {
                Game.currentCollection = Game.Collection;
                gameList.ItemsSource = Game.currentCollection;
                tempo = Game.currentCollection;
            }
            else if(GenreBox.Text == "All")
            {
                Game.currentCollection = Game.Collection;
                gameList.ItemsSource = Game.currentCollection;
                tempo = Game.currentCollection;
            }
            else
            {
                Game.currentCollection = Game.Collection.Where(b => b.Genre == GenreBox.Text).ToList();
                gameList.ItemsSource = Game.currentCollection;
                tempo = Game.currentCollection;
            }

            if (SortBox.Text == "Не сортировать")
            {
                gameList.ItemsSource = Game.currentCollection;
                tempo = Game.currentCollection;
            }
            else if (SortBox.Text == "По названию ▲")
            {
                gameList.ItemsSource = Game.currentCollection.OrderBy(b => b.Name).ToList();
                tempo = Game.currentCollection.OrderBy(b => b.Name).ToList();
            }
            else if (SortBox.Text == "По названию ▼")
            {
                gameList.ItemsSource = Game.currentCollection.OrderByDescending(b => b.Name).ToList();
                tempo = Game.currentCollection.OrderByDescending(b => b.Name).ToList();
            }

            if (SortBox.Text == "Without sort")
            {
                gameList.ItemsSource = Game.currentCollection;
                tempo = Game.currentCollection;
            }
            else if (SortBox.Text == "By Title ▲")
            {
                gameList.ItemsSource = Game.currentCollection.OrderBy(b => b.Name).ToList();
                tempo = Game.currentCollection.OrderBy(b => b.Name).ToList();
            }
            else if (SortBox.Text == "By Title ▼")
            {
                gameList.ItemsSource = Game.currentCollection.OrderByDescending(b => b.Name).ToList();
                tempo = Game.currentCollection.OrderByDescending(b => b.Name).ToList();
            }

            List<Game> temp = new List<Game>();
            Regex regex = new Regex(SearchBox.Text);
            foreach (var b in tempo)
            {
                MatchCollection matches = regex.Matches(b.Name);
                if (matches.Count > 0)
                {
                    temp.Add(b);
                }
            }
            gameList.ItemsSource = temp;
        }

        private void gameList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(gameList.SelectedIndex != -1)
            {
                Game game= (Game)gameList.SelectedItem;
                AboutWindow aboutWindow = new AboutWindow(game);
                aboutWindow.Show();

                Close();
            }
        }

        private void StyleButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentStyle == "Purple")
            {
                var uri = new Uri(limeStyle + ".xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                currentStyle = "Lime";
            }
            else
            {
                var uri = new Uri(purpleStyle + ".xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                currentStyle = "Purple";
            }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            if (State.undoStack.Count <= 1)
            {
                Game.Collection = State.undoStack.Peek();
                MessageBox.Show("Не удалось отменить действие", "UndoStack пуст", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (State.undoStack.Count > 1)
            {
                State.redoStack.Push(State.undoStack.Peek());
                State.undoStack.Pop();
                Game.Collection = State.undoStack.Peek();
                Game.Export();
                MainWindow.GameList.ItemsSource = null;
                MainWindow.GameList.ItemsSource = Game.Collection;
            }
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            if (State.redoStack.Count >= 1)
            {
                var tempState = State.redoStack.Pop();
                State.undoStack.Push(tempState);
                Game.Collection = tempState;
                Game.Export();
                MainWindow.GameList.ItemsSource = null;
                MainWindow.GameList.ItemsSource = Game.Collection;
            }
            else
            {
                MessageBox.Show("Не удалось повторить действие", "RedoStack пуст", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
