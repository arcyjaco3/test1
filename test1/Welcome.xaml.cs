using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace test1
{
    /// <summary>
    /// Logika interakcji dla klasy Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }
        Search search = new Search();
        //Addpage addpage = new Addpage();
        //Logout logout = new Logout();
        


       /* private void AddPageClick(object sender, RoutedEventArgs e)
        {
            addpage.ShowDialog();
            //Close();
        }

    */
        private void SearchClick(object sender, RoutedEventArgs e)
        {
            search.ShowDialog();
            //Close();
        }

        private void LogOutClick(object sender, RoutedEventArgs e)
        {
            //Hide();
            // new Logout.ShowDialog();
            //ShowDialog();
            ShowDialog();
            
        }
    }
}
