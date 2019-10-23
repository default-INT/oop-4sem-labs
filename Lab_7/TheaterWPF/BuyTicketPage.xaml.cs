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
    /// Логика взаимодействия для BuyTicketPage.xaml
    /// </summary>
    public partial class BuyTicketPage : Page
    {
        private static DateTime ConvertStringToDateTime(string date)
        {
            return new DateTime(Convert.ToInt16(date.Split('.')[2]),
                                Convert.ToInt16(date.Split('.')[1]),
                                Convert.ToInt16(date.Split('.')[0]));
        }

        Cashbox cashbox;

        public BuyTicketPage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void BuyTicketPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string namePerformance in cashbox.GetPerformancesName())
            {
                comboPerformanceBox.Items.Add(namePerformance);
            }
            
        }

        private void PerformanceBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            comboDateBox.Items.Clear();
            comboTypeBox.Items.Clear();
            foreach (Performance performance in cashbox.GetPerformances())
            {
                if (String.Equals(performance.name.ToLower(), comboPerformanceBox.SelectedItem.ToString().ToLower()))
                {
                    comboDateBox.Items.Add(performance.date.ToShortDateString());
                    
                }
                
            }
            comboDateBox.SelectedItem = comboDateBox.Items[0];
        }

        private void BuyTicketButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameInputBox.Text.Length > 0 && comboPerformanceBox.Text.Length > 0 
                && comboDateBox.Text.Length > 0 && comboTypeBox.Text.Length > 0)
            {
                string fullname = nameInputBox.Text;
                string performanceName = comboPerformanceBox.Text;
                typeTicket type = Cashbox.FindTicket(comboTypeBox.Text.Split()[0].ToLower());
                DateTime date = ConvertStringToDateTime(comboDateBox.Text);

                cashbox.SaleTicket(new Client(fullname), new Performance(performanceName, date), type);

                sumTicketBox.Text = "Билет успешно куплен на спектакль \"" + performanceName + "\", который пройдёт: " + comboDateBox.Text;
            }
            else
            {
                sumTicketBox.Text = "Не все поля заполнены";
            }
            
        }

        private void ComboTypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SumCalculate();
        }

        private void SumCalculate()
        {
            string select = comboTypeBox.SelectedItem.ToString().ToLower().Split()[0];
            string fullname = nameInputBox.Text.ToString().ToLower();
            double discount = 1;
            double cost = 0;

            foreach (Client client in cashbox.GetClients())
            {
                if (String.Equals(client.fullName.ToLower(), fullname))
                {
                    discount = client.discount;
                }
            }

            if (String.Equals(select, "партерр"))
            {
                cost = discount * Parterre.GetCost();
            }
            else if (String.Equals(select, "балкон"))
            {
                cost = discount * Balcony.GetCost();
            }
            else if (String.Equals(select, "ложа"))
            {
                cost = discount * Lodge.GetCost();
            }
            sumTicketBox.Text = "Стоимость билета: " + cost + " руб.";
        }

        private void nameInputBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (comboTypeBox.SelectedItem != null)
            {
                SumCalculate();
            }
        }

        private void SetTypeComboBox(Performance performance)
        {
            comboTypeBox.Items.Add("Партерр | осталось: " + performance.GetTicketsInfo()[0]);
            comboTypeBox.Items.Add("Балкон | осталось: " + performance.GetTicketsInfo()[1]);
            comboTypeBox.Items.Add("Ложа | осталось: " + performance.GetTicketsInfo()[2]);
        }

        private void ComboDateBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboTypeBox.Items.Clear();
            DateTime date = ConvertStringToDateTime(e.AddedItems[0].ToString());
            SetTypeComboBox(cashbox.SelectPerformance(comboPerformanceBox.SelectedValue.ToString(), date));
        }
    }
}
