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
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        ShoppingControl shopping = null;

        public ProductListPage(ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.shopping = shopping;
            LoadTable();
        }

        private void LoadTable()
        {
            column1.Children.Clear();
            column2.Children.Clear();

            string[,] products = shopping.GetProductList();
            int n = products.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Label nameLabel = new Label();
                Label priceLabel = new Label();

                nameLabel.Content = products[i, 0];
                priceLabel.Content = products[i, 1];

                column1.Children.Add(nameLabel);
                column2.Children.Add(priceLabel);
            }
        }
    }
}
