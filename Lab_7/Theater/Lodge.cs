using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public class Lodge : Ticket
    {
        public static int GetCost()
        {
            return new Lodge().cost;
        }

        private Lodge()
        {
            this.cost = 10;
            this.type = typeTicket.lodge;
        }

        public Lodge(string namePerformance, DateTime date) : base(namePerformance, date)
        {
            this.cost = 10;
            this.numberOfTickets = 30;
            this.type = typeTicket.lodge;
        }
    }
}
