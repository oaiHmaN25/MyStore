using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ManageProduct_Click(object sender, RoutedEventArgs e)
        {
            var ManageProduct = new ManageProduct();
            ManageProduct.Show();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
