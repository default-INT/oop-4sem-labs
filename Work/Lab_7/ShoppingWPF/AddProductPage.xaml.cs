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
using Shopping;

namespace ShoppingWPF
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        ShoppingControl shopping = null;

        public AddProductPage(ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.shopping = shopping;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                double price = Convert.ToDouble(priceTextBox.Text);

                msgLabe.Content = shopping.AddProduct(name, price);
            }
            catch
            {
                msgLabe.Content = "Товар не добавлен.";
            }
        }
    }
}
