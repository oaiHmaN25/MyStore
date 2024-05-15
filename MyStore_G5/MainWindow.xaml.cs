using MyStore_G5.Models;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyStoreContext())
            {
                // Truy vấn các category từ cơ sở dữ liệu
                var categories = context.Categories.ToList();

                // Tạo nội dung cho message box
                string message = "Categories:\n";
                foreach (var category in categories)
                {
                    message += $"{category.CategoryName}\n";
                }

                // Hiển thị message box
                MessageBox.Show(message, "Categories", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
