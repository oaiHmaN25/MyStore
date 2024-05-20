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
    public partial class StaffManagement : Page
    {
        private MyStoreContext con = new MyStoreContext();
        public StaffManagement()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                if (con == null || con.Staffs == null)
                {
                    MessageBox.Show("Error: Database connection not properly configured.");
                    return;
                }

                // Xóa danh sách nhân viên hiện có
                staffListView.Items.Clear();

                // Truy vấn danh sách nhân viên từ cơ sở dữ liệu
                var staffList = con.Staffs.ToList();

                // Hiển thị danh sách nhân viên trong ListView
                foreach (var staff in staffList)
                {
                    staffListView.Items.Add(staff);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading staff: {ex.Message}");
            }
        }


        private void staffListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
