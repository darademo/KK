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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        BookEntities Bd = new BookEntities();
        public Admin()
        {
            InitializeComponent();
            DGrid.ItemsSource = Bd.Product.ToList();
        }

        private void ToMain(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }

        private void btn_del(object sender, RoutedEventArgs e)
        {

        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            Bd.SaveChanges();
            DGrid.ItemsSource = Bd.Product.ToList();
            MessageBox.Show("Данные сохранены");
        }
    }
}
