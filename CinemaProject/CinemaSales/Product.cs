using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    class Product
    {
        private int id;
        private string name;
        private float price;
        private int count = 0;
        public Product(int i, string n, float p, bool inc = false){
            this.id = i;
            this.name = n;
            this.price = p;
            if (inc) this.Increment();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Amount
        {
            get { return count; }
            set { count = value; }
        }

        public string show()
        {
            return this.count.ToString() + " x " + this.name.ToString();
        }

        public void Decrement()
        {
            if (this.count > 0) this.count--;
        }
        public void Increment()
        {
            this.count++;
        }
    }
}
