﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class GenerateTextUserControl : UserControl
    {
        public GenerateTextUserControl()
        {
            InitializeComponent();
        }

        private void GenerateTextButton_Click(object sender, RoutedEventArgs e)
        {
            GenerateTextBox.Text = "Тот самый текст";
        }
    }
}
