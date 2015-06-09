using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CinemaManager.Pages
{
    public partial class CinemaStatistic : Form
    {
        List<QuantitySalesProduct> qspList = new List<QuantitySalesProduct>();
        List<QuantitySalesProduct> qspTicketList = new List<QuantitySalesProduct>();
        int month;
        int year;

        public CinemaStatistic()
        {
            InitializeComponent();

            ProductStatistic();
            FillTable();
            
            
            MonthStatisticChart.Hide();
            MonthStatisticTypeOfMovieChart.Hide();
            InfoAboutParametrOfStatisticLabel.Hide();

            TicketStatistic();
            FillTicketTable();
            
        }

       
        

        private void LastMonthStatistic_Click(object sender, EventArgs e)
        {
            month = DateTime.Today.Month - 1;
            //ProductStatistic(month);
        }

        private void FillTable()
        {
            int whichRow = 1;
            MovieStatisticAllMovieTableLauotPanel.Size = new Size(950, (qspList.Count() * 35));

            MovieStatisticAllMovieTableLauotPanel.VerticalScroll.Maximum = 200;
            MovieStatisticAllMovieTableLauotPanel.HorizontalScroll.Maximum = 200;
            MovieStatisticAllMovieTableLauotPanel.AutoSize = false;
            MovieStatisticAllMovieTableLauotPanel.AutoScroll = true;

            MovieStatisticAllMovieTableLauotPanel.RowCount = qspList.Count + 2;
            MovieStatisticAllMovieTableLauotPanel.ColumnCount = 2;

            MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Margin = new Padding(5, 5, 5, 5), Text = "Nazwa produktu" }, 0, 0);
            MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Margin = new Padding(5, 5, 5, 5), Text = "Ilość sprzedanych" }, 1, 0);

            foreach (var prodSales in qspList)
            {
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Margin = new Padding(5, 0, 0, 0), Text = prodSales.productName }, 0,whichRow);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Margin = new Padding(5, 0, 0, 0), Text = prodSales.quantitySalesProduct.ToString() }, 1, whichRow);
                whichRow++;
            }


        }

        private void FillTicketTable()
        {
            int whichRow = 1;
            TicketStatisticTableLayoutPanel.Size = new Size(220, (qspTicketList.Count() * 35));

           TicketStatisticTableLayoutPanel.AutoSize = false;
            TicketStatisticTableLayoutPanel.AutoScroll = true;

            TicketStatisticTableLayoutPanel.RowCount = qspTicketList.Count + 2;
            TicketStatisticTableLayoutPanel.ColumnCount = 2;

            TicketStatisticTableLayoutPanel.Controls.Add(new Label() { Margin = new Padding(5, 5, 5, 5), Text = "Rodzaj biletu" }, 0, 0);
            TicketStatisticTableLayoutPanel.Controls.Add(new Label() { Margin = new Padding(5, 5, 5, 5), Text = "Ilość sprzedanych biletów" }, 1, 0);

            foreach (var ticSales in qspTicketList)
            {
                TicketStatisticTableLayoutPanel.Controls.Add(new Label() { Margin = new Padding(5, 0, 0, 0), Text = ticSales.productName }, 0, whichRow);
                TicketStatisticTableLayoutPanel.Controls.Add(new Label() { Margin = new Padding(5, 0, 0, 0), Text = ticSales.quantitySalesProduct.ToString() }, 1, whichRow);
                whichRow++;
            }


        }

        private void TicketStatistic()
        {
            int ticketCount = 0;
            qspTicketList.Clear();


            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                // rodzaje biletów 
                var tickets = (from t in ctx.Tickets
                                select t);
                foreach (var tic in tickets)
                {
                    var salesTicket = (from k in ctx.TicketSales
                                       where k.ticketID == tic.ticketID
                                       select k);
                    foreach (var ps in salesTicket)
                    {
                        ticketCount += ps.amount;
                    }
                    qspTicketList.Add(new QuantitySalesProduct() { productName = tic.name, quantitySalesProduct = ticketCount });
                    ticketCount = 0;
                }
            }

        }
        private void ProductStatistic()
        {
            int howManySales=0;
            qspList.Clear();
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                // wszystkie produkty sprzedane w tym miesiącu
                var products = (from t in ctx.Products
                                     select t);
                foreach (var prod in products)
                {
                    var salesTicket = (from k in ctx.ProductSales
                                       where k.productID==prod.productID
                                       select k);
                    foreach (var ps in salesTicket)
                    {
                        howManySales += ps.amount;
                    }
                    qspList.Add(new QuantitySalesProduct() { productName = prod.name, quantitySalesProduct = howManySales });
                    howManySales=0;
                }
            }
    }

        private void thisMothButton_Click(object sender, EventArgs e)
        {
            month = DateTime.Today.Month;
            //ProductStatistic();
        }
    }
}