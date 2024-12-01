using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace интернет___магазин_с_исп.конструкторов_и_деконструкторов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            string name = ProductsName.Text;
            if (double.TryParse(ProductsPrice.Text, out double price) && int.TryParse(ProductsQuantity.Text, out int quantity))
            {
                var product = new Product(name, price, quantity);
                ProductsListBox.Items.Add(product);
                ProductsName.Clear();
                ProductsPrice.Clear();
                ProductsQuantity.Clear();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
