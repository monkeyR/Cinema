using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    

    public class LocationObject
    {
        private string location;
        private int X;
        private int Y;
        private modelTicket ticket;

        LocationObject()
        {

        }
        public LocationObject(string l, int x, int y, modelTicket t)
        {
            this.location = l;
            this.X = x;
            this.Y = y;
            this.ticket = t;
        }

        public bool checkLocation(string l)
        {
            if (l == this.location) return true;
            else return false;
        }
    }
}
