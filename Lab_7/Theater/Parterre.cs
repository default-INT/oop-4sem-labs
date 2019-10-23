using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public class Parterre : Ticket
    {
        public static int GetCost()
        {
            return new Parterre().cost;
        }

        private Parterre()
        {
            this.cost = 5;
            this.type = typeTicket.parterre;
        }

        public Parterre(string namePerformance, DateTime date) : base(namePerformance, date)
        {
            this.cost = 5;
            this.numberOfTickets = 100;
            this.type = typeTicket.parterre;
        }
    }
}
