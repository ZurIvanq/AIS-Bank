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

namespace AIS_Bank.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        MainWindow mainWindow { get => Application.Current.MainWindow as MainWindow; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScreenLoad SL = new ScreenLoad();
            SL.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
