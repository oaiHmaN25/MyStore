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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyStore_G5
{
    /// <summary>
    /// Interaction logic for StaffOrder.xaml
    /// </summary>
    public partial class StaffOrder : Page
    {
        public StaffOrder()
        {
            InitializeComponent();
        }

      

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var addOrder = new StaffAddOrder();
            addOrder.Show();
        }
    }
}
