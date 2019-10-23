using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public class Client
    {
        public static bool operator ==(Client client1, Client client2)
        {
            return String.Equals(client1.fullName, client2.fullName);
        }

        public static bool operator !=(Client client1, Client client2)
        {
            return !(client1 == client2);
        }

        public string fullName { get; set; }
        public double discount { get; set; }
        public List<Ticket> tickets = new List<Ticket>();

        public string GetStatus()
        {
            return discount == 1 ? "Обычный клиент" : "Постоянный клиент";
        }

        public Client(string fullName, List<Ticket> tickets)
        {
            this.fullName = fullName;
            this.tickets = tickets;
            SetStatus();
        }

        public Client(string fullName)
        {
            this.fullName = fullName;
            this.discount = 1;
        }

        /// <summary>
        /// Метод добавляет новый билет в историю покупок клиента
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
            SetStatus();
        }

        /// <summary>
        /// Метод удаляет билет из истории покупок клиента
        /// </summary>
        /// <param name="ticket"></param>
        public void DeleteTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }

        public bool DeleteTicket(string namePerformace, DateTime date, typeTicket type)
        {
            for (int i = 0; i < tickets.Count(); i++)
            {
                if (String.Equals(namePerformace, tickets[i].namePerformance) && type == tickets[i].type &&
                    tickets[i].date.Year == date.Year && tickets[i].date.Month == date.Month && tickets[i].date.Day == date.Day)
                {
                    tickets.RemoveAt(i);
                    SetStatus();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод обновляет статус постоянного покупателя 
        /// </summary>
        private void SetStatus()
        {
            DateTime today = DateTime.Now;
            int k = 0;
            foreach (Ticket ticket in tickets)
            {
                if ((today.Year - ticket.date.Year == 0)||
                    (today.Year - ticket.date.Year == 1 && today.Month - ticket.date.Month <= 0))
                {
                    k++;
                }
            }
            if (k >= 10 && k <= 30)
            {
                discount = 0.9;
            }
            else if (k > 30)
            {
                discount = 0.85;
            }
            else
            {
                discount = 1;
            }
        }

        /// <summary>
        /// Метод возвращает количество купленых билетов
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfTickets()
        {
            return tickets.Count();
        }

        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   fullName == client.fullName &&
                   discount == client.discount &&
                   EqualityComparer<List<Ticket>>.Default.Equals(tickets, client.tickets);
        }

        public override int GetHashCode()
        {
            var hashCode = 133725751;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fullName);
            hashCode = hashCode * -1521134295 + discount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Ticket>>.Default.GetHashCode(tickets);
            return hashCode;
        }

        public int[] GetTicketsInfo()
        {
            int[] countTickets = new int[3] { 0, 0, 0 };
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
