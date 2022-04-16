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

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для Form.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab6-7/lab6-7/games.xml";
        public string imgPath;

        public MainWindow mainWindow = new MainWindow();

        public AddWindow()
        {
            InitializeComponent();
        }
        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == false)
            {
                return;
            }
            string filename = opf.FileName;
            imgPath = filename;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            List<Game> games = new List<Game>();
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
                    game.Genres = GenresComboBox.Text;
                    game.Quantity = Convert.ToInt32(QuantityBox.Text);
                    game.Price = Convert.ToInt32(PriceBox.Text);
                    game.ImgSrc = imgPath;

                    games = XmlSerializeWrapper.Deserialize<Game>(filePath);
                    games.Add(game);
                    XmlSerializeWrapper.Serialize<Game>(games, filePath);

                    mainWindow.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
