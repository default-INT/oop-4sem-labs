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
    /// Логика взаимодействия для CountSaleProductPage.xaml
    /// </summary>
    public partial class CountSaleProductPage : Page
    {
        ShoppingControl shopping = null;

        public CountSaleProductPage(ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.shopping = shopping;
        }

        private void CountSaleProductPage_Loaded(object sender, RoutedEventArgs e)
        {
            column1.Children.Clear();
            column2.Children.Clear();

            string[] names = shopping.GetProductsName().ToArray();

            foreach (string name in names)
            {
                Label nameLabel = new Label();
                Label countLabel = new Label();

                nameLabel.Content = name;
                countLabel.Content = shopping.CountProduct(name);

                column1.Children.Add(nameLabel);
                column2.Children.Add(countLabel);
            }
        }

    }
}
