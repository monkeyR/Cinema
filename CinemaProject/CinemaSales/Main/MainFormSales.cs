﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales.Main
{
    public partial class MainFormSales : Form
    {
        public Bin MBin;
        private BuyTicketsForm TicketsForm = null;
        private BuyProductsForm ProductsForm = null;
        //private CinemaModel.Employees LoginUser = null;
        public static CinemaModel.Employees LoginUser = null;

        public static string LastChooseLocations = null;
        public static int LastChooseShow = 0;

        public MainFormSales(CinemaModel.Employees user)
        {
            InitializeComponent();

            this.MBin = new Bin();
            this.MBin.SetListProducts(this.BinListBox);
            this.MBin.SetCostLabel(this.AllCostLabel);
            MainFormSales.LoginUser = user;

            this.LoginUserLabel.Text = "Zalogowany jako:\n" + user.name;


            this.ClearBinButtton.Click += new System.EventHandler(MBin.ClearBinEvent);
            this.BackLastOperationButton.Click += new System.EventHandler(MBin.ClearLastOperation);
            this.ResetTicketsButton.Click += new System.EventHandler(MBin.ResetTickets);

            this.TicketsForm = new BuyTicketsForm(this.MBin);
            this.ProductsForm = new BuyProductsForm(this.MBin);

            this.BarTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            selectPage(this.ProductsForm);
        }

        private void selectPage(Form page)
        {
            Cursor.Current = Cursors.WaitCursor;

            page.TopLevel = false;
            MainSalesPanel.Controls.Clear();
            MainSalesPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
            page.Show();
            Cursor.Current = Cursors.Default;

        }

        private void ticketTabButton_Click(object sender, EventArgs e)
        {
            //selectPage(new BuyTicketsForm());
            SelecButton(((Button)sender));
            selectPage(this.TicketsForm);
        }

        private void BarTabButton_Click(object sender, EventArgs e)
        {
            //selectPage(new BuyProductsForm(this.MBin));
            SelecButton(((Button)sender));
            selectPage(this.ProductsForm);
        }

        private void SelecButton(Button btn)
        {
            this.TicketTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.BarTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            if (this.MBin.FinalTransaction())
            {
                MessageBox.Show("Kupione! Bilety wydrukowane!");
            }
            else
            {
                MessageBox.Show("Koszyk jest pusty!");
            }
        }







    }
}
