﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales.Main
{
    public partial class BuyTicketsForm : Form
    {
        private List<modelTicket> AllTickets = new List<modelTicket>();
        private int activeTicketId = 0;

        public BuyTicketsForm()
        {
            InitializeComponent();
            DisplayShowsScreen();
        }

        private void BuyTicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayShowsScreen()
        {
            DisplayHalls();
            DisplayShowsInHalls();
            DisplayTickets();
        }
        
        private void DisplayHalls()
        {
            var Halls = getAllHalls();

            this.SuspendLayoutAll();

            int i = 0;
            foreach (var hall in Halls)
            {
                addButtonToColumnHalls(hall.hallID, hall.number, i);
                i++;
            }

            this.ResumeLayoutAll();
        }

        private void addButtonToColumnHalls(int hallID, int number, int i)
        {
            
            Button btn = new System.Windows.Forms.Button();
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(165)))), ((int)(((byte)(11)))));
            btn.Location = new System.Drawing.Point(0, (i*100));
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Name = "button" + hallID.ToString();
            btn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            btn.Size = new System.Drawing.Size(100, 80);
            btn.TabIndex = ( hallID + 1 );
            btn.Text = number.ToString();
            btn.UseVisualStyleBackColor = false;

            ColumnHallsButtons.Controls.Add(btn);

            FlowLayoutPanel LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();

            LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            LayoutPanel.AutoSize = true;
            LayoutPanel.Tag = hallID;
            LayoutPanel.Location = new System.Drawing.Point(0, (i*80));
            LayoutPanel.Name = "flowLayoutPanel" + hallID.ToString();
            LayoutPanel.Size = new System.Drawing.Size(395, 80);
            LayoutPanel.TabIndex = (hallID + 1);

            ColumnShowsLayout.Controls.Add(LayoutPanel);

        }

        private void DisplayShowsInHalls()
        {

            var Shows = getShows(DateTime.Now);

            this.SuspendLayoutAll();

            int i = 0;
            foreach (var show in Shows)
            {
                addButtonToShowsLayout(show.title, show.dateStart, show.showID, show.HallID, i);

                i++;
            }

            this.ResumeLayoutAll();

           
        }

        private void addButtonToShowsLayout(String name, DateTime time, int ShowID, int HallID, int i)
        {
            Button btn = new System.Windows.Forms.Button();
               
            
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            btn.AutoSize = true;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(184)))), ((int)(((byte)(162)))));
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Name = "buttonShows" + ShowID.ToString();
            btn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            btn.Size = new System.Drawing.Size(100, 80);
            btn.MaximumSize = new System.Drawing.Size(400, 80);
            btn.TabIndex = (ShowID + 1);
            btn.Text = name + "\n\n" + time.ToString("HH:mm");
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            //btn.Click += new System.EventHandler(this.ActiveButton);

            //flowLayoutPanel1.Controls.Add(btn, HallID);
            hookButtonToShows(btn, HallID);
        }

        private void hookButtonToShows(Button btn, int HallID)
        {
            foreach (FlowLayoutPanel column in ColumnShowsLayout.Controls)
            {
                if ((int)column.Tag == HallID) column.Controls.Add(btn);
            }
        }


        private void DisplayTickets()
        {
            var Tickets = getTickets();

            this.SuspendLayoutAll();

            foreach (var ticket in Tickets)
            {
                modelTicket new_ticket = new modelTicket(ticket.ticektID, ticket.name, ticket.price, ticket.description_ticket);
                addButtonToTicketColumn(new_ticket);
                AllTickets.Add(new_ticket);
            }

            this.ResumeLayoutAll();

        }

        private void addButtonToTicketColumn(modelTicket ticket)
        {
            Button btn = new System.Windows.Forms.Button();


            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(0, BarWithTickets.Controls.Count * 65);
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Name = "buttonTicket" + ticket.ticketID.ToString();
            btn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            btn.Size = new System.Drawing.Size(100, 60);
            btn.MaximumSize = new System.Drawing.Size(400, 80);
            btn.TabIndex = (ticket.ticketID + 1);
            btn.Text = ticket.name;
            btn.Tag = ticket.ticketID;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Click += new System.EventHandler(this.ActiveTicket);

            BarWithTickets.Controls.Add(btn);
        }

        private void hookButtonToTicketBar(Button btn)
        {

        }

        private void SuspendLayoutAll()
        {
            this.SuspendLayout();
            MainTicketsPanel.SuspendLayout();
            ColumnHallsButtons.SuspendLayout();
            ColumnShowsLayout.SuspendLayout();
        }

        private void ResumeLayoutAll()
        {
            this.ResumeLayout();
            ColumnShowsLayout.ResumeLayout();
            ColumnHallsButtons.ResumeLayout();
            MainTicketsPanel.ResumeLayout();
        }

        private void ActiveTicket(object sender, EventArgs e)
        {
            this.activeTicketId = (int)((Button)sender).Tag;

            foreach (var item in this.BarWithTickets.Controls)
            {
                ((Button)item).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            }

            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
        }

        // MODELS

        private List<modelShowsInSales> getShows(DateTime day)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                // testowo data 
                day = new DateTime(2015, 04, 23);

                var shows =
                    (from s in ctx.Shows
                     where DbFunctions.TruncateTime(s.dateStart) == DbFunctions.TruncateTime(day)
                     join m in ctx.Movies on s.movieID equals m.movieID
                     orderby s.dateStart ascending
                     select new modelShowsInSales()
                     {
                         title = m.title,
                         dateStart = s.dateStart,
                         showID = s.showID,
                         HallID = s.hallID
                     }).ToList();

                return shows;
            }
        }

        private CinemaModel.Halls[] getAllHalls()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Halls = (from t in ctx.Halls
                             select t).ToArray();
                return Halls;
            }
        }

        private CinemaModel.Tickets[] getTickets()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Tickets = (from t in ctx.Tickets
                             select t).ToArray();
                return Tickets;
            }
        }

    }


    public class modelShowsInSales
    {
        public string title { get; set; }
        public DateTime dateStart { get; set; }
        public int showID { get; set; }
        public int HallID { get; set; }
    }

    public class modelTicket
    {
        public int ticketID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string description_ticket { get; set; }

        public modelTicket(int t, string n, decimal p, string d_t)
        {
            this.ticketID = t;
            this.name = n;
            this.price = p;
            this.description_ticket = d_t;
        }
    }

}
