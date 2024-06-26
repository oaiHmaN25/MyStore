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

namespace MyStore_G5
{
    /// <summary>
    /// Interaction logic for Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();
        }

       
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            lableWelcome.Visibility = Visibility.Hidden;
            Profile pro = new Profile();
            frameMain.Content = pro;
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            Session.Logout();
            this.Close();
        }

        private void ManageOrder(object sender, RoutedEventArgs e)
        {
            StaffOrder order = new StaffOrder();
            frameMain.Content = order;
        }

        private void Report(object sender, RoutedEventArgs e)
        {
            StaffReport report = new StaffReport();
            frameMain.Content = report;
        }
    }
}
