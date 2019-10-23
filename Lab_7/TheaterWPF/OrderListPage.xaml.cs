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
    /// Логика взаимодействия для OrderListPage.xaml
    /// </summary>
    public partial class OrderListPage : Page
    {
        Cashbox cashbox;

        public OrderListPage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Client client in cashbox.GetClients())
            {
                clientListBox.Items.Add(client.fullName);
            }
        }

        private void ClientListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //headlineLabel.Content = cashbox.GetClient(e.AddedItems[0].ToString()).fullName;
            statusTextBlock.Text = cashbox.GetClient(e.AddedItems[0].ToString()).GetStatus();
            column1.Children.Clear();
            column2.Children.Clear();
            column3.Children.Clear();

            foreach (Ticket ticket in cashbox.GetClient(e.AddedItems[0].ToString()).tickets)
            {
                TextBlock namePerformance = new TextBlock();
                TextBlock typeTicketBlock = new TextBlock();
                TextBlock dateText = new TextBlock();

                namePerformance.Text = ticket.namePerformance;
                typeTicketBlock.Text = Cashbox.FindTicket(ticket.type);
                dateText.Text = ticket.date.ToLongDateString();

                namePerformance.Width = column1.Width;
                namePerformance.Height = 30;
                typeTicketBlock.Width = column2.Width;
                typeTicketBlock.Height = 30;
                dateText.Width = column3.Width;
                dateText.Height = 30;

                column1.Children.Add(namePerformance);
                column2.Children.Add(typeTicketBlock);
                column3.Children.Add(dateText);
            }
            
            /*
            TextBlock namePerformance = new TextBlock();
            TextBlock countOfTicket = new TextBlock();
            TextBlock dateText = new TextBlock();

            nameBlock.Width = column1.Width;
            nameBlock.Height = 60;
            ticketBlock.Width = column2.Width;
            ticketBlock.Height = 60;
            dateBlock.Width = column3.Width;
            dateBlock.Height = 60;
            */
        }
    }
}
