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
    /// Логика взаимодействия для ClientsListPage.xaml
    /// </summary>
    public partial class ClientsListPage : Page
    {
        Cashbox cashbox;

        public ClientsListPage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void ClientList_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Client client in cashbox.GetClients())
            {
                TextBlock fullNameBlock = new TextBlock();
                TextBlock ticketBlock = new TextBlock();
                TextBlock statusBlock = new TextBlock();

                fullNameBlock.Text = client.fullName;
                ticketBlock.Text = "Билетов куплено: " + client.GetNumberOfTickets();
                statusBlock.Text = client.GetStatus();

                fullNameBlock.Width = column1.Width;
                fullNameBlock.Height = 30;
                ticketBlock.Width = column2.Width;
                ticketBlock.Height = 30;
                statusBlock.Width = column3.Width;
                statusBlock.Height = 30;

                column1.Children.Add(fullNameBlock);
                column2.Children.Add(ticketBlock);
                column3.Children.Add(statusBlock);
            }
        }
    }
}
