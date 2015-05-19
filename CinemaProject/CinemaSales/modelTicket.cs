using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    public class modelTicket
    {
        public int ticketID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string description_ticket { get; set; }

        public modelTicket(int t, string n, decimal p, string d_t)
        {
            this.ticketID = t;
            this.name = n;
            this.price = p;
            this.description_ticket = d_t;
        }
    }
}
