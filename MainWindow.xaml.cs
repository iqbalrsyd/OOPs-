﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarangKu
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
            User user = new User();
            user.LoginName = tbUsername.Text;
            user.Password = tbPassword.Password;
            if (user.Login(user.LoginName, user.Password))
            {
                MessageBox.Show("Login Berhasil, ID anda adalah " + user.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}