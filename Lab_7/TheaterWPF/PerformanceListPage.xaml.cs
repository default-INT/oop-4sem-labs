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
    /// Логика взаимодействия для PerformanceListPage.xaml
    /// </summary>
    public partial class PerformanceListPage : Page
    {
        Cashbox cashbox;

        public PerformanceListPage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void PerformanceList_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Performance performance in cashbox.GetPerformances()) // В xaml соеденить 3 столбца rowspan и сделать стэкпанель по горизонт.
            {
                TextBlock nameBlock = new TextBlock();
                TextBlock ticketBlock = new TextBlock();
                TextBlock dateBlock = new TextBlock();

                nameBlock.Text = performance.name;
                dateBlock.Text = performance.date.ToLongDateString();
                ticketBlock.Text = "Партерр: " + performance.GetTicketsInfo()[0] + "\n" +
                    "Балкон: " + performance.GetTicketsInfo()[1] + "\n" +
                    "Ложа: " + performance.GetTicketsInfo()[2];

                nameBlock.Width = column1.Width;
                nameBlock.Height = 60;
                ticketBlock.Width = column2.Width;
                ticketBlock.Height = 60;
                dateBlock.Width = column3.Width;
                dateBlock.Height = 60;

                column1.Children.Add(nameBlock);
                column2.Children.Add(ticketBlock);
                column3.Children.Add(dateBlock);
            }
        }
    }
}
