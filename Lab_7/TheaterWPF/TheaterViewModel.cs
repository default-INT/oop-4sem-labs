using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theater;

namespace TheaterWPF
{
    public class TheaterViewModel 
    {
        public Cashbox cashbox = new Cashbox();

        public TheaterViewModel()
        {
            Template();
        }

        private void Template()
        {
            cashbox.AddPerformance("Ромео и Джульета", new DateTime(2019, 6, 7, 19, 00, 00));
            cashbox.AddPerformance("Снежная королева", new DateTime(2019, 6, 17, 19, 00, 00));
            cashbox.AddPerformance("Щелкунчик", new DateTime(2019, 6, 17, 19, 00, 00));
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.balcony);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(0), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Липский Д.С."), cashbox.SelectPerformance(1), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Липский Д.С."), cashbox.SelectPerformance(1), typeTicket.lodge);
            cashbox.SaleTicket(new Client("Трофимов Е.В."), cashbox.SelectPerformance(1), typeTicket.balcony);
        }
    }
}
