using Microsoft.Win32;
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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    /// 
    public partial class AddWindow : Window
    {
        public static bool isOpened = false;
        public string imgPath;
        public AddWindow()
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(MainWindow.mainWindow.languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        private void AddingCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            try
            {
                if (GameNameBox.Text.Length < 1 || GenresComboBox.SelectedValue == null ||
                    QuantityBox.Text.Length < 1 || PriceBox.Text.Length < 1)
                {
                    throw new Exception("Введите все поля!");
                }
                else if (!(int.TryParse(QuantityBox.Text, out int num) || int.TryParse(PriceBox.Text, out int number)))
                {
                    throw new Exception("Цена и количество могут быть только числами!");
                }
                else if (Convert.ToInt32(QuantityBox.Text) < 0 || (Convert.ToInt32(PriceBox.Text) < 0))
                {
                    throw new Exception("Цена и количество не могут быть отрицательными!");
                }
                else
                {
                    game.Name = GameNameBox.Text;
                    game.Genre = GenresComboBox.Text;
                    game.Quantity = Convert.ToInt32(QuantityBox.Text);
                    game.Price = Convert.ToInt32(PriceBox.Text);
                    game.ImgSrc = imgPath;
                    Game.Push(game);
                    MainWindow.mainWindow.SortBox_DropDownClosed(sender, e);
                    MainWindow.mainWindow.GenreBox_DropDownClosed(sender, e);
                    State.undoStack.Push(Game.GetListFromXML());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == false)
                return;
            string filename = opf.FileName;
            imgPath = filename;
        }
    }
}
