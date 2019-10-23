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
    /// Логика взаимодействия для DeleteProductPage.xaml
    /// </summary>
    public partial class DeleteProductPage : Page
    {
        ShoppingControl shopping = null;

        public DeleteProductPage(ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.shopping = shopping;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string name = productsComboBox.Text;

            msgLabel.Content = shopping.DeleteProduct(name);
            RefreshStatus();
        }

        private void DeleteProductPage_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            string[] names = shopping.GetProductsName().ToArray();
            productsComboBox.Items.Clear();

            foreach (string name in names)
            {
                productsComboBox.Items.Add(name);
            }
        }
    }
}
