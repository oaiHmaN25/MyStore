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
    /// Interaction logic for StaffReport.xaml
    /// </summary>
    public partial class StaffReport : Page
    {
        private MyStoreContext _context;

        public StaffReport()
        {
            InitializeComponent();
            _context = new MyStoreContext();
            LoadOrders();
        }

        private void LoadOrders()
        {
            int staffId = Session.LoggedInStaffId;

            var orders = _context.Orders
                                 .Where(o => o.StaffId == staffId)
                                 .Select(o => new OrderViewModel
                                 {
                                     OrderId = o.OrderId,
                                     OrderDate = o.OrderDate,
                                     StaffId = o.StaffId,
                                     StaffName = o.Staff.Name
                                 })
                                 .ToList();

            lvOrders.ItemsSource = orders;
        }

    }


    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }
    }
}

