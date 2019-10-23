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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Frame viewFrame = null;
        ShoppingControl shopping = null;

        public MenuPage(ref Frame viewFrame, ref ShoppingControl shopping)
        {
            InitializeComponent();
            this.viewFrame = viewFrame;
            this.shopping = shopping;
        }

        private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
        {
            msgLabel.Content = shopping.SummAllProduct();
        }

        private void CountProductDiscountButton_Click(object sender, RoutedEventArgs e)
        {
            msgLabel.Content = shopping.CountProductDiscaunt();
        }

        private void AvgCostProdButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new AvgCostProductsPage(ref shopping);
        }

        private void CountSaleProdButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new CountSaleProductPage(ref shopping);
        }
    }
}
