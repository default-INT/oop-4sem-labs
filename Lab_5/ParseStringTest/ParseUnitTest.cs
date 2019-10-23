using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using ParseStringLib;

namespace ParseStringTest
{
    [TestClass]
    public class ParseUnitTest
    {
        [TestMethod]
        public void GetEmail_FindEmailInString()
        {
            StringBuilder actual = ParseStr.GetEmail(new StringBuilder("dsfsdf godDog2000@gmail.com"));
            StringBuilder expected = new StringBuilder("godDog2000@gmail.com");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void GetPhoneNumber_FindPhoneNumberInString()
        {
            StringBuilder actual = ParseStr.GetPhoneNumber(new StringBuilder("4564-544- 4 465-654-456-789-456 375-29-817-47-53"));
            StringBuilder expected = new StringBuilder("375-29-817-47-53");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void GetFullName_FindClientName()
        {
            StringBuilder actual = ParseStr.GetFullName(new StringBuilder(" sdsd ФИО: Трофимов Евгений Владимирович"));
            StringBuilder expected = new StringBuilder("Трофимов Евгений Владимирович");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void GetAdress_FindClientAdress()
        {
            StringBuilder actual = ParseStr.GetAdress(new StringBuilder(" sdsd ФИО: Трофимов Евгений Владимирович адрес: пер.Заслонова,12 "));
            StringBuilder expected = new StringBuilder("пер.Заслонова,12");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
