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
    /// Логика взаимодействия для AddPerformacePage.xaml
    /// </summary>
    public partial class AddPerformacePage : Page
    {
        private Cashbox cashbox;

        public AddPerformacePage(ref Cashbox cashbox)
        {
            this.cashbox = cashbox;
            InitializeComponent();
        }

        private void AddPerformanceButton_Click(object sender, RoutedEventArgs e)
        {
            cashbox.AddPerformance(nameInputBox.Text, inputDatePicker.SelectedDate.Value);
            msgBox.Text = "Спектакль \"" + nameInputBox.Text + "\" успешно добавлен\nДата проведения : " + inputDatePicker.SelectedDate.Value.ToLongDateString();
        }
    }
}
