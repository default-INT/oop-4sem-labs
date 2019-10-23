using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public abstract class Ticket
    {
        public string namePerformance { get; set; }
        public int cost { get; set; }
        public int numberOfTickets { get; set; }
        public DateTime date { get; set; }
        public typeTicket type { get; set; }

        public Ticket(string namePerformance, DateTime date)
        {
            this.date = date;
            this.namePerformance = namePerformance;
        }

        public Ticket()
        {

        }
    }
}
