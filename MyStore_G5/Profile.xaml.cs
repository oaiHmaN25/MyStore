using Microsoft.Extensions.Configuration;
using MyStore_G5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.IO;
using System.Text.Json.Nodes;
using System.Security.Principal;
using System.Text.Json;

namespace MyStore_G5
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        private MyStoreContext con;
        PasswordBox[] passwordBoxes = new PasswordBox[3];
        public Profile()
        {
            InitializeComponent();
            con = new MyStoreContext();
            UsernameLable.Content = Session.Username;
        }

        private void ChangePass_Click(object sender, RoutedEventArgs e)
        {
            PasswordStackPanel.Children.Clear();

            string[] labels = { "Old Password:", "New Password:", "Confirm Password:" };
            

            // Tạo và thêm ba PasswordBox mới
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Content = labels[i];
                label.Margin = new Thickness(0, 5, 0, 0);
                label.HorizontalAlignment = HorizontalAlignment.Center;

                // Tạo ô nhập liệu
                PasswordBox passwordBox = new PasswordBox();
                passwordBox.Margin = new Thickness(0, 5, 0, 0);
                passwordBox.Width = 130;
                passwordBox.HorizontalAlignment = HorizontalAlignment.Center;
                passwordBoxes[i] = passwordBox;


                // Thêm Label và ô nhập liệu vào StackPanel
                PasswordStackPanel.Children.Add(label);
                PasswordStackPanel.Children.Add(passwordBox);

                if (i == 2)
                {
                    Button button = new Button();
                    button.Content = "Change";
                    button.Width = 50;
                    button.Margin = new Thickness(0, 5, 0, 0);
                    button.Click += new RoutedEventHandler(ChangePassClickEvent);
                    PasswordStackPanel.Children.Add(button);
                }
            }
        }

        private void ChangePassClickEvent(object sender, RoutedEventArgs e)
        {
            string[] passwords = new string[3];
            for (int i = 0; i < 3; i++)
            {
                passwords[i] = ConvertToUnsecureString(passwordBoxes[i].SecurePassword);
            }
            string oldPassword = passwords[0];
            string newPassword = passwords[1];
            string confPassWord = passwords[2];
           
            if (!Session.Username.Equals("admin"))
            {
                MyStoreContext con = new MyStoreContext();
                var user = con.Staffs.FirstOrDefault(u => u.Name == Session.Username);
                if (oldPassword == user.Password)
                {
                    if (newPassword == oldPassword)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!");
                    }
                    else if (newPassword != confPassWord)
                    {
                        MessageBox.Show("Mật khẩu mới không khớp nhau!");
                    }
                    else
                    {
                        user.Password = newPassword;
                        con.SaveChanges();
                        MessageBox.Show("Thành công!");
                        PasswordStackPanel.Children.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác!");
                }
            }
            else
            {
                var account = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("account");
                if (oldPassword == account["password"])
                {
                    if (newPassword == oldPassword)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!");
                    }
                    else if (newPassword != confPassWord)
                    {
                        MessageBox.Show("Mật khẩu mới không khớp nhau!");
                    }
                    else
                    {
                        MessageBox.Show("Thành công!");
                        PasswordStackPanel.Children.Clear();
                    }

                }
            }
            
        }

        private string ConvertToUnsecureString(SecureString securePassword)
        {
            if (securePassword == null)
            {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
