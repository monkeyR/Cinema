using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSales
{
    class Bin
    {
        private List<Product> Products;
        public Bin()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product P)
        {
            Products.Add(P);
        }

        public void RemoveLastProduct()
        {
            if(Products.Count > 0)
                Products.RemoveAt(Products.Count - 1);
        }

        public void RemoveProduct(int i)
        {
            Products.RemoveAt(i);
        }
    }
}
