using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventPlanningLibrary;

namespace EventPlanningTest
{
    [TestClass]
    public class EventsTest
    {

        [TestMethod]
        public void FindEventsAfterDate_TestMethod()
        {
            EventPlanning events = new EventPlanning();
            TemplateEvents(events);
            EventPlanning expected = events.FindEventsAfterDate("Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));
            EventPlanning actual = new EventPlanning();

            actual.CreateEvent("Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));
            actual.CreateEvent("Поездка в Минск", new DateTime(2019, 5, 3, 8, 20, 0));

            Assert.AreEqual(new Event(0, "Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0)), actual[0]);
        }

        [TestMethod]
        public void CreateEvent_TestMethod()
        {
            EventPlanning expected = new EventPlanning(
                new Event(0, "Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0))
            );
            Event e = new Event(0, "Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));
            Event actual = new Event(0, "Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));

            Assert.AreEqual(e, actual);
        }

        private void TemplateEvents(EventPlanning events)
        {
            events.CreateEvent("Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));
            events.CreateEvent("Поход в музей", new DateTime(2019, 4, 3, 15, 0, 0));
            events.CreateEvent("Поход в кино", new DateTime(2019, 4, 3, 16, 10, 0));
            events.CreateEvent("Поездка в Минск", new DateTime(2019, 5, 3, 8, 20, 0));
            events.CreateEvent("Поход в музей", new DateTime(2019, 4, 5, 14, 0, 0));
        }
    }
}
