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
using System.Windows.Shapes;

namespace Library
{
    public partial class AdminNavigation : Window
    {
        public AdminNavigation()
        {
            InitializeComponent();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
            Close();

        }

        private void Button_DataBase(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            userPageWindow.Show();
            Close();
        }

        private void Button_Click_BooksAdmin(object sender, RoutedEventArgs e)
        {
            BookSearchAdmin bookSearchAdmin = new BookSearchAdmin();
            bookSearchAdmin.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            bookSearchAdmin.Show();
            Close();

        }

        private void Button_AdminView(object sender, RoutedEventArgs e)
        {
            AdminViewBorrowed adminViewBorrowed = new AdminViewBorrowed();
            adminViewBorrowed.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            adminViewBorrowed.Show();
        }
    }
}
