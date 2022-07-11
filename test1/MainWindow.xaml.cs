using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace test1
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

        Welcome welcome = new Welcome();

        private void SingIn(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                errormessage.Text = "Enter an username";
                Username.Focus();
            }
            else if (!Regex.IsMatch(Username.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid name";
                Username.Select(0, Username.Text.Length);
                Username.Focus();
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;


                if (username != "admin@admin.pl" || password != "admin")
                {
                    errormessage.Text = "Wrong username or password";
                     
                }

                else if (username == "admin@admin.pl" && password == "admin")
                {
                    welcome.Show();
                    Close();
                    
                }
               
            }
        }
    }
}
