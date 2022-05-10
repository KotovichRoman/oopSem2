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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public string imgPath;
        public EditWindow()
        {
            InitializeComponent();
        }

        public EditWindow(Game game)
        {
            InitializeComponent();

            GameNameBox.Text = game.Name;
            GenresComboBox.Text = game.Genres;
            PriceBox.Text = Convert.ToString(game.Price);
            QuantityBox.Text = Convert.ToString(game.Quantity);
            imgPath = game.ImgSrc;
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
    }
}
