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
using Theater;

namespace TheaterWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationService nav;
        public Cashbox cashbox = new Cashbox();

        public MainWindow()
        {
            InitializeComponent();
            nav = viewFrame.NavigationService;
            Template();

        }

        private void StartApp(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new PerformanceDatePage(ref cashbox);
        }

        private void PerformanceListButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new PerformanceListPage(ref cashbox);
        }

        private void AddPerformance_Click(object sender, RoutedEventArgs e)
        {

            viewFrame.Content = new AddPerformacePage(ref cashbox);
            
            //viewFrame.Navigate(new System.Uri("AddPerformancePage.xaml", UriKind.RelativeOrAbsolute), cashbox);
        }

        private void Template()
        {
            cashbox.AddPerformance("Ромео и Джульета", new DateTime(2019, 6, 7, 19, 00, 00));
            cashbox.AddPerformance("Снежная королева", new DateTime(2019, 6, 17, 19, 00, 00));
            cashbox.AddPerformance("Щелкунчик", new DateTime(2019, 6, 17, 19, 00, 00));
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.balcony);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.parterre);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Липский Д.С."), cashbox.SelectPerformance(1), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Липский Д.С."), cashbox.SelectPerformance(1), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(1), typeTicket.balcony);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(1), typeTicket.balcony);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(1), typeTicket.parterre);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(1), typeTicket.parterre);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(2), typeTicket.parterre);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(2), typeTicket.parterre);
        }

        private void ClientListButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new ClientsListPage(ref cashbox);
        }

        private void BuyTicketButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new BuyTicketPage(ref cashbox);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new PerformanceDatePage(ref cashbox);
        }

        private void OrderListButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new OrderListPage(ref cashbox);
        }

        private void DeletePerformanceButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new DeletePerfomancePage(ref cashbox);
        }

        private void DeleteTicketButton_Click(object sender, RoutedEventArgs e)
        {
            viewFrame.Content = new DeleteTicketPage(ref cashbox);
        }
    }
}
