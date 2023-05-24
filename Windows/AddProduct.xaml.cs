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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        BookEntities Bd = new BookEntities();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void ToProduct(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            using (Bd)
            {
                Bd.SaveChanges();
                Console.WriteLine("Чек");
            }
        }
    }
}
