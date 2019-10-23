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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShoppingControl shopping = new ShoppingControl();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //viewFrame.Content = new PerformanceDatePage(ref cashbox);
            Template();
            viewFrame.Content = new MenuPage(ref viewFrame, ref shopping);
        }

        private new void Template()
        {
            shopping.AddProduct("Молоко", 1.80);
            shopping.AddProduct("Яблоко", 0.80);
            shopping.AddProduct("Яблоко", 0.80);
            shopping.AddProduct("Яблоко", 0.80);
            shopping.AddProduct("Яблоко", 0.80);
            shopping.AddProduct("Молоко", 1.80);
            shopping.AddProduct("Чипсы", 2.80);
            shopping.AddProduct("Кола", 1.85);
            shopping.AddProduct("Макароны", 1.80);
        }

        private void productListButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new ProductListPage(ref shopping);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new MenuPage(ref viewFrame, ref shopping);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new AddProductPage(ref shopping);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new DeleteProductPage(ref shopping);
        }
    }
}
