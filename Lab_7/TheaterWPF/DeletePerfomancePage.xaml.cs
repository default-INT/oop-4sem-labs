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
    /// Логика взаимодействия для DeletePerfomancePage.xaml
    /// </summary>
    public partial class DeletePerfomancePage : Page
    {
        Cashbox cashbox = new Cashbox();

        public DeletePerfomancePage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Performance performance in cashbox.GetPerformances())
            {
                performanceComboBox.Items.Add(performance.name);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)dateSelectPicker.SelectedDate;

            if (cashbox.DeletePerformance(performanceComboBox.Text, date))
            {
                msgDelete.Text = "Спектакль \"" + performanceComboBox.Text + "\" успешно удалён.";
            }
            else
            {
                msgDelete.Text = "Спектакль \"" + performanceComboBox.Text + "\" в указанную дату не найден.";
            }
        }
    }
}
