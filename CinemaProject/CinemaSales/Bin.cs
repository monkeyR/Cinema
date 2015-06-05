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
        private List<TicketBin> BinTickets;
        private List<HistoryItem> HistoryOperation;
        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.Label AllCostLabel;
        private decimal CurrentCost = 0;
        private int currentShowId;
        public Bin()
        {
            Products = new List<Product>();
            HistoryOperation = new List<HistoryItem>();
            this.Tickets = new List<LocationObject>();
            this.BinTickets = new List<TicketBin>();
        }

        public void AddTickets(List<LocationObject> ticketsList, int ShowID)
        {
            this.currentShowId = ShowID;
            CleanTickets();
            foreach (var item in ticketsList)
            {
                this.CurrentCost += item.getTicket().price;
                if (!CheckAvailabilityTicket(item))
                {
                    this.BinTickets.Add(new TicketBin(item));
                }
            }
            RefreshBin();
        }

        private bool CheckAvailabilityTicket(LocationObject ticket)
        {
            foreach (var item in this.BinTickets)
            {
                if (item.getId() == ticket.getTicket().ticketID) {
                    item.IncrementAmount();
                    return true; 
                }
            }
            return false;
        }

        public void CleanTickets()
        {
            foreach (var ticket in this.BinTickets)
            {
                this.CurrentCost -= ticket.getPrice();
            }

            this.BinTickets.Clear();
        }

        public void ResetTickets(object sender, EventArgs e)
        {
            CleanTickets();
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

        public void ClearBinEvent(object sender, EventArgs e)
        {
            this.ClearBin();
        }

        private void ClearBin()
        {
            this.BinTickets.Clear();
            Products.Clear();
            HistoryOperation.Clear();
            CurrentCost = 0;
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

            foreach (var item in BinTickets)
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

        public bool FinalTransaction()
        {
            if (this.CurrentCost == 0) return false;
            else
            {
                InsertTransitions();
                this.ClearBin();
                return true;
            }
        }

        public void InsertTransitions()
        {
            try
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {

                    if (this.currentShowId != 0)
                    {
                        CinemaModel.Transations newTransition = new CinemaModel.Transations();
                        newTransition.showID = this.currentShowId;
                        newTransition.transationDate = DateTime.Now;
                        ctx.Transations.Add(newTransition);

                        ctx.SaveChanges();

                        CinemaModel.TicketSales newTicket;

                        foreach (var item in this.BinTickets)
                        {
                            newTicket = new CinemaModel.TicketSales();
                            newTicket.ticketID = item.IdTicket;
                            newTicket.transationID = newTransition.transationID;
                            newTicket.amount = item.getAmount();

                            ctx.TicketSales.Add(newTicket);
                            ctx.SaveChanges();
                        }
                    }
                    else
                    {
                        CinemaModel.Transations newTransition = new CinemaModel.Transations();
                        newTransition.showID = null;
                        ctx.Transations.Add(newTransition);

                        ctx.SaveChanges();
                    }

                    CinemaModel.ProductSales newProduct;

                    foreach (var item in this.Products)
                    {
                        newProduct = new CinemaModel.ProductSales();
                        newProduct.productID = item.ID;
                        newProduct.amount = item.Amount;
                        newProduct.salesDate = DateTime.Now;
                        ctx.ProductSales.Add(newProduct);
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd przy kupowaniu!");
            }

        }
    }
}
