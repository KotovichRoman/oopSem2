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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Game windowGame;
        AboutWindow parentWindow;
        string imgPath;
        public EditWindow()
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(MainWindow.mainWindow.languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public EditWindow(Game game, AboutWindow aboutWindow)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(MainWindow.mainWindow.languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            parentWindow = aboutWindow;
            windowGame = game;
            GameNameBox.Text = game.Name;
            GenresComboBox.Text = game.Genre;
            PriceBox.Text = Convert.ToString(game.Price);
            QuantityBox.Text = Convert.ToString(game.Quantity);
            imgPath = Convert.ToString(BitmapFrame.Create(new Uri(game.ImgSrc)));
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
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
                    windowGame.Name = GameNameBox.Text;
                    windowGame.Genre = GenresComboBox.Text;
                    windowGame.Quantity = Convert.ToInt32(QuantityBox.Text);
                    windowGame.Price = Convert.ToInt32(PriceBox.Text);
                    windowGame.ImgSrc = imgPath;
                    parentWindow.Update(windowGame);
                    Game.Export();
                    MainWindow.GameList.ItemsSource = null;
                    MainWindow.GameList.ItemsSource = Game.Collection;
                    MainWindow.mainWindow.InputFunc();
                    MessageBox.Show("Редактирование выполнено!", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
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
