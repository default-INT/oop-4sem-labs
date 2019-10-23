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
    /// Логика взаимодействия для AvgCostProductsPage.xaml
    /// </summary>
    public partial class AvgCostProductsPage : Page
    {
        ShoppingControl shopping = null;

        public AvgCostProductsPage(ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.shopping = shopping;
        }

        private void AvgCostProductsPage_Loaded(object sender, RoutedEventArgs e)
        {
            column1.Children.Clear();
            column2.Children.Clear();

            string[] products = shopping.GetProductsName().ToArray();

            foreach (string name in products)
            {
                Label nameLable = new Label();
                Label avgCostLable = new Label();

                nameLable.Content = name;
                avgCostLable.Content = shopping.AverageCostProduct(name);

                column1.Children.Add(nameLable);
                column2.Children.Add(avgCostLable);
            }
        }
    }
}
