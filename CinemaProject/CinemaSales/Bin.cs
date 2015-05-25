using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales
{
    enum TypeBin
    {
        Products = 1,
        Tickets
    }

    class HistoryItem
    {
        public int ID;
        public TypeBin Type;

        public HistoryItem(int ID, TypeBin Type)
        {
            this.ID = ID;
            this.Type = Type;
        }
    }
    public class Bin
    {
        private List<Product> Products;
        private List<LocationObject> Tickets;
        private List<HistoryItem> HistoryOperation;
        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.Label AllCostLabel;
        private decimal CurrentCost = 0;
        public Bin()
        {
            Products = new List<Product>();
            HistoryOperation = new List<HistoryItem>();
            this.Tickets = new List<LocationObject>();
        }

        public void AddTickets(List<LocationObject> ticketsList)
        {
            foreach (var item in ticketsList)
            {
                this.Tickets.Add(item);
            }
            RefreshBin();
        }



        public void SetListProducts(System.Windows.Forms.ListBox l)
        {
            this.ListProducts = l;
        }

        public void SetCostLabel(System.Windows.Forms.Label l)
        {
            this.AllCostLabel = l;

        }
        public void ClearLastOperation(object sender, EventArgs e)
        {
            try
            {
                if (HistoryOperation.Count > 0)
                {
                    if (HistoryOperation[HistoryOperation.Count - 1].Type == TypeBin.Products)
                    {
                        this.RemoveProduct(HistoryOperation[HistoryOperation.Count - 1].ID);
                        HistoryOperation.RemoveAt(HistoryOperation.Count - 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd przy usuwaniu ostatniej operacji.");

            }

            this.RefreshBin();

        }

        public void ClearBin(object sender, EventArgs e)
        {
            Products.Clear();
            HistoryOperation.Clear();
            CurrentCost = 0;
            HistoryOperation.Clear();
            RefreshBin();
        }

        public void AddProduct(object sender, EventArgs e)
        {
            CinemaModel.Products p = (CinemaModel.Products)((System.Windows.Forms.Button)sender).Tag;
            if (!CheckExist(p.productID))
            {
                Products.Add(new Product(p.productID, p.name, p.price, true));
                this.CurrentCost += p.price;
                HistoryOperation.Add(new HistoryItem(p.productID, TypeBin.Products));
            }
            RefreshBin();
        }

        public void Display()
        {
            ListProducts.Items.Clear();
            foreach (var item in Products)
            {
                ListProducts.Items.Add(item.show());
            }
            foreach (var item in Tickets)
            {
                ListProducts.Items.Add(item.show());
            }
        }

        private void RefreshBin()
        {
            Display();
            DisplayCost();
        }

        public void DisplayCost()
        {
            this.AllCostLabel.Text = Math.Round(this.CurrentCost, 2).ToString() + " zł";
        }

        private bool CheckExist(int ID)
        {
            foreach (var item in Products)
            {
                if (ID == item.ID)
                {
                    item.Increment();
                    this.CurrentCost += item.Price;
                    HistoryOperation.Add(new HistoryItem(item.ID, TypeBin.Products));
                    return true;
                }
            }

            return false;
        }


        public void RemoveLastProduct()
        {
            if (Products.Count > 0)
                Products.RemoveAt(Products.Count - 1);
        }

        private Product getProduct(int ID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ID == ID) return Products[i];
            }
            return null;
        }

        public void RemoveProduct(int i)
        {
            Product p = getProduct(i);
            if (p != null)
            {
                this.CurrentCost -= p.Price;
                if (p.Amount > 1)
                {
                    p.Decrement();
                }
                else
                {
                    Products.Remove(p);
                }
            }


        }

    }
}
