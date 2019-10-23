using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public class Balcony : Ticket
    {
        public static int GetCost()
        {
            return new Balcony().cost;
        }

        private Balcony()
        {
            this.cost = 3;
            this.type = typeTicket.balcony;
        }

        public Balcony(string namePerformance, DateTime date) : base(namePerformance, date)
        {
            this.cost = 3;
            this.numberOfTickets = 150;
            this.type = typeTicket.balcony;
        }
    }
}
