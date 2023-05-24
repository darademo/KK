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
using System.Windows.Shapes;

namespace KK.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookEntities Bd = new BookEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aut(object sender, RoutedEventArgs e)
        {
            string login = tbx_login.Text;
            string password = tbx_password.Password;
            try
            {
                User user = Bd.User.Where((u) => u.UserLogin == login && u.UserPassword == password).Single();
                if (user.UserRole == 3)
                {
                    Client client = new Client();
                    client.Show();
                    this.Close();
                }
                else if (user.UserRole == 2)
                {
                    Manager manager = new Manager();
                    manager.Show();
                    this.Close();
                }
                else
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Нет значений");
            }
        }

        private void Guest(object sender, RoutedEventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
