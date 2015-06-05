using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    public class TicketBin
    {
        public int IdTicket;
        public LocationObject ticket; 
        private int amount = 1;

        public TicketBin(){ }

        public TicketBin(LocationObject ticket){
            this.IdTicket = ticket.getTicket().ticketID;
            this.ticket = ticket;
        }

        public void IncrementAmount()
        {
            this.amount++;
        }

        public int getAmount()
        {
            return this.amount;
        }

        public int getId()
        {
            return this.IdTicket;
        }

        public string show()
        {
            return this.amount.ToString() + " x " + this.ticket.show();
        }

        public decimal getPrice()
        {
            return (this.amount * this.ticket.getTicket().price);
        }
    }
}
