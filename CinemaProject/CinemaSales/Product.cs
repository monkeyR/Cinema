using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    class Product
    {
        private string name;
        private int amount;
        private float cost;

        public Product(){

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
