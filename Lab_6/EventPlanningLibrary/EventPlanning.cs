using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanningLibrary
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public Event(int id, string name, DateTime date)
        {
            this.id = id;
            this.date = date;
            this.name = name;
        }
    }

    public class EventPlanning
    {
        /// <summary>
        /// Метод возвращает количество мероприятий в заданную дату
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int CountEventsOnDay(EventPlanning eventList, DateTime date)
        {
            return eventList.CountEventsOnDay(date);
        }

        List<Event> eventList { get; set; }

        public EventPlanning()
        {
            this.eventList = new List<Event>();
        }

        public EventPlanning(params Event[] events)
        {
            this.eventList = new List<Event>();
            foreach (Event ev in events)
            {
                this.eventList.Add(ev);
            }
        }

        /// <summary>
        /// Индексатор доступа к элементам класса
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Event this[int index]
        {
            set
            {
                eventList[index] = value;
            }

            get
            {
                return eventList[index];
            }
        }

        /// <summary>
        /// Метод возвращает количество мероприятий
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return eventList.Count;
        }

        /// <summary>
        /// Метод создаёт новое мероприятие
        /// </summary>
        /// <param name="ev">Мероприятие</param>
        public void CreateEvent(Event ev)
        {
            eventList.Add(ev);
        }

        /// <summary>
        /// Метод возвращает количество мероприятий в заданную дату
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int CountEventsOnDay(DateTime date)
        {
            int k = 0;
            foreach (Event ev in eventList)
            {
                if (ev.date.Date == date.Date)
                {
                    k++;
                }
            }
            return k;
        }

        /// <summary>
        /// Метод возвращает количество мероприятий в указанный день недели
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public int CountEventsOnDay(DayOfWeek day)
        {
            int k = 0;
            foreach (Event ev in eventList)
            {
                if (ev.date.DayOfWeek == day)
                {
                    k++;
                }
            }
            return k;
        }

        /// <summary>
        /// Метод добавляет новое событие в список событий eventList
        /// </summary>
        /// <param name="name">Название мероприятия</param>
        /// <param name="date">Дата проведения</param>
        public void CreateEvent(string name, DateTime date)
        {
            int id;
            bool existsEvent = false;
            foreach (Event evnt in eventList)
            {
                if (String.Equals(evnt, name) && evnt.date == date)
                {
                    existsEvent = true;
                    break;
                }
            }
            if (!existsEvent)
            {
                id = eventList.Count > 0 ? eventList.Last().id + 1 : 1;
                eventList.Add(new Event(id, name, date));
            }
            else
            {
                throw new Exception("Мероприятие с таким же именем и датой уже существует.");
            }
        }

        /// <summary>
        /// Метод удаляет мероприятия
        /// </summary>
        /// <param name="name">Название мероприятия</param>
        /// <param name="date">Дата проведения</param>
        public void DeleteEvent(string name, DateTime date)
        {
            foreach (Event evnt in eventList)
            {
                if (String.Equals(evnt.name, name) && date.Date == evnt.date.Date && date.TimeOfDay == evnt.date.TimeOfDay)
                {
                    eventList.Remove(evnt);
                    break;
                }
            }
        }

        /// <summary>
        /// Находит мероприятия по заданой дате
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public EventPlanning FindEventsOnDate(DateTime date)
        {
            EventPlanning eventsOnDay = new EventPlanning();

            foreach (Event evnt in eventList)
            {
                if (evnt.date.DayOfYear == date.DayOfYear)
                {
                    eventsOnDay.CreateEvent(evnt);
                }
            }
            return eventsOnDay;
        }

        /// <summary>
        /// Метод возврщает список указанных событий после определённой даты
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public EventPlanning FindEventsAfterDate(string name, DateTime date)
        {
            EventPlanning eventsOnDate = new EventPlanning();

            foreach (Event evnt in eventList)
            {
                if (evnt.date.Ticks > date.Ticks && String.Equals(name, evnt.name))
                {
                    eventsOnDate.CreateEvent(evnt);
                }
            }
            return eventsOnDate;
        }
    }
}
