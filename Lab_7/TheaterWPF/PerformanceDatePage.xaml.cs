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
    /// Логика взаимодействия для PerformanceDatePage.xaml
    /// </summary>
    public partial class PerformanceDatePage : Page
    {
        Cashbox cashbox;

        public PerformanceDatePage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime)calendar.SelectedDate;
            performanceInDateBlock.Text = "";

            foreach (Performance performance in cashbox.GetPerformances(date))
            {
                performanceInDateBlock.Text += "\"" + performance.name + "\", осталось билетов: " + performance.CountOfTickets() + "\n";
            }
        }
    }
}
