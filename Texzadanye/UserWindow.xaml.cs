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
using Texzadanye.Items;

namespace Texzadanye
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public Product Product { get; set; }
        public UserWindow(Product product)
        {
            Product = product;
            DataContext = Product;
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            Method.Method.AddProduct(Product.Id, Product.Name, Product.Price, Product.Description);
            MainWindow mainwindow = new MainWindow();
            Close();
            mainwindow.ShowDialog();
        }
    }
}
