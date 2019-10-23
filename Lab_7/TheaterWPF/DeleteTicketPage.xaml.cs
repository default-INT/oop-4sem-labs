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
    /// Логика взаимодействия для DeleteTicketPage.xaml
    /// </summary>
    public partial class DeleteTicketPage : Page
    {
        private static DateTime ConvertStringToDateTime(string date)
        {
            return new DateTime(Convert.ToInt16(date.Split('.')[2]),
                                Convert.ToInt16(date.Split('.')[1]),
                                Convert.ToInt16(date.Split('.')[0]));
        }

        Cashbox cashbox;

        public DeleteTicketPage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Client client in cashbox.GetClients())
            {
                clientsComboBox.Items.Add(client.fullName);
            }

            foreach (string namePerformnce in cashbox.GetPerformancesName())
            {
                performancesComboBox.Items.Add(namePerformnce);
            }
        }

        private void PerformancesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = e.AddedItems[0].ToString();
            dateComboBox.Items.Clear();

            foreach (DateTime date in cashbox.GetDateTimes(name))
            {
                dateComboBox.Items.Add(date.ToShortDateString());
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string performanceName = performancesComboBox.SelectedValue.ToString();
            string clientName = clientsComboBox.SelectedValue.ToString();
            DateTime date = ConvertStringToDateTime(dateComboBox.SelectedValue.ToString());
            typeTicket type = Cashbox.FindTicket(typeComboBox.SelectedValue.ToString());

            if (cashbox.ReturnTicket(performanceName, date, clientName, type))
            {
                msgTextBlock.Text = "Билет успешно сдан в кассу.";
            }
            else
            {
                msgTextBlock.Text = "Не найден данный билет, на указанный спектакль.";
            }
        }
    }
}
