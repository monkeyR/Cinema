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
        private float price;

        public Product(string n, int a, float p){
            this.name = n;
            this.amount = a;
            this.price = p;
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

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
