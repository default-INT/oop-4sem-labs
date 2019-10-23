using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public class Performance
    {
        /// <summary>
        /// Оператор сравнения
        /// </summary>
        /// <param name="performance1"></param>
        /// <param name="performance2"></param>
        /// <returns></returns>
        public static bool operator ==(Performance performance1, Performance performance2)
        {
            return String.Equals(performance1.name, performance2.name)&&(performance1.date == performance2.date);
        }

        /// <summary>
        /// Оператор сравнения
        /// </summary>
        /// <param name="performance1"></param>
        /// <param name="performance2"></param>
        /// <returns></returns>
        public static bool operator !=(Performance performance1, Performance performance2)
        {
            return !(performance1 == performance2);
        }

        public string name { get; set; }
        private List<Ticket> tickets = new List<Ticket>(280);
        public DateTime date { get; set; }

        /// <summary>
        /// Конструктор класса Performance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        public Performance(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
            for (int i = 0; i < 280; i++)
            {
                if (i < 150)
                {
                    this.tickets.Add(new Balcony(name, date));
                }
                else if (i < 250)
                {
                    this.tickets.Add(new Parterre(name, date));
                }
                else
                {
                    this.tickets.Add(new Lodge(name, date));
                }
            }
        }

        public void AddTicket(typeTicket type)
        {
            switch (type)
            {
                case (typeTicket.balcony):
                    tickets.Add(new Balcony(name, date));
                    break;
                case (typeTicket.lodge):
                    tickets.Add(new Lodge(name, date));
                    break;
                default:
                    tickets.Add(new Parterre(name, date));
                    break;
            }
        }

        /// <summary>
        /// Метод удаляет один билет данного спектакля
        /// </summary>
        /// <param name="ticket"></param>
        public void DeleteTicket(typeTicket type)
        {
            for (int i = 0; i < tickets.Count(); i++)
            {
                if (tickets[i].type == type)
                {
                    tickets.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// Метод возвращает количество оставшихся билетов
        /// </summary>
        /// <returns></returns>
        public int CountOfTickets()
        {
            return tickets.Count();
        }

        /// <summary>
        /// Метод возваршает целочисленный массив из 3-х элементов,
        /// где 1-ый элемент - количество оставшихся билетов в партерре
        /// 2-ой элемент - количество оставшихся билетов на балконе
        /// 3-ий элемент - количество оставшихся билетов в ложе
        /// </summary>
        /// <returns></returns>
        public int[] GetTicketsInfo()
        {
            int[] countTickets = new int[3] { 0, 0, 0};
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].type == typeTicket.parterre)
                {
                    countTickets[0] += 1;
                }
                else if (tickets[i].type == typeTicket.balcony)
                {
                    countTickets[1] += 1;
                }
                else if (tickets[i].type == typeTicket.lodge)
                {
                    countTickets[2] += 1;
                }
            }
            return countTickets;
        }
    }
}
