using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theater;

namespace TheaterUnitTest
{
    [TestClass]
    public class CashboxUnitTest
    {
        Cashbox cashboxActual = new Cashbox();

        [TestMethod]
        public void AddPerformanceTestMethod()
        {
            Cashbox cashboxExpected = new Cashbox();
            cashboxActual.AddPerformance("Ромео и Джульета", new DateTime(2019, 6, 7, 19, 00, 00));
        }

        private void Template()
        {
            cashboxActual.AddPerformance("Ромео и Джульета", new DateTime(2019, 6, 7, 19, 00, 00));
            cashboxActual.AddPerformance("Снежная королева", new DateTime(2019, 6, 17, 19, 00, 00));
            cashboxActual.AddPerformance("Щелкунчик", new DateTime(2019, 6, 17, 19, 00, 00));
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(0), typeTicket.balcony);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(0), typeTicket.parterre);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(0), typeTicket.lodge);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(0), typeTicket.lodge);
            cashboxActual.SaleTicket(new Client("Липский Д.С."), cashboxActual.SelectPerformance(1), typeTicket.lodge);
            cashboxActual.SaleTicket(new Client("Липский Д.С."), cashboxActual.SelectPerformance(1), typeTicket.lodge);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(1), typeTicket.balcony);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(1), typeTicket.balcony);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(1), typeTicket.parterre);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(1), typeTicket.parterre);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(2), typeTicket.parterre);
            cashboxActual.SaleTicket(new Client("Трофимов Е.В."), cashboxActual.SelectPerformance(2), typeTicket.parterre);
        }
    }
}
