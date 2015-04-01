using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales
{
    public class Bin
    {
        private List<Product> Products;
        private System.Windows.Forms.ListBox ListProducts;
        public Bin()
        {
            Products = new List<Product>();
        }

        public void SetListProducts(System.Windows.Forms.ListBox l)
        {
            this.ListProducts = l;
        }

        public void AddProduct(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            CinemaModel.Products p = (CinemaModel.Products)btn.Tag;
            if (!CheckExist(p.productID))
            {
                Products.Add(new Product(p.productID, p.name, (float)p.price, true)); 
            }
            Display();
        }

        public void Display()
        {
            ListProducts.Items.Clear();
            foreach (var item in Products)
            {
                ListProducts.Items.Add(item.show());
            }
        }

        private bool CheckExist(int ID)
        {
            foreach (var item in Products)
            {
                if (ID == item.ID)
                {
                    item.Increment();
                    return true;
                }
            }
            
            return false;
        }
        //public void AddProduct(Product P)
        //{
        //    Products.Add(P);
        //}

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
