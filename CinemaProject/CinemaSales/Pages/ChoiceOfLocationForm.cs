using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales.Pages
{
    public partial class ChoiceOfLocationForm : Form
    {
        private List<modelTicket> AllTickets;
        private int activeTicketId = 0;
        private List<LocationObject> ChoiceLocations;
        public int ThisShowID;
        private int ThisHallID;
        private Button InstanceButton;

        private int rows = 0;
        private int columns = 0;
        private int[,] places;
        public String returnLocations = "";

        public EventHandler<List<LocationObject>> onLocationChange;

        public ChoiceOfLocationForm()
        {
            InitializeComponent();
            DisplayTickets();
        }

        public ChoiceOfLocationForm(String title, int[] IDs)
        {
            InitializeComponent();
            this.Text = title;
            this.ChoiceLocations = new List<LocationObject>();
            this.ThisShowID = IDs[0];
            this.ThisHallID = IDs[1];

            this.AllTickets = new List<modelTicket>();
            this.InstanceButton = InstanceButtonLocation();

            DisplayTickets();
            CreateHall();
        }

        private void DisplayTickets()
        {
            var Tickets = getTickets();

            //this.SuspendLayoutAll();

            foreach (var ticket in Tickets)
            {
                modelTicket new_ticket = new modelTicket(ticket.ticketID, ticket.name, ticket.price, ticket.description_ticket);
                addButtonToTicketColumn(new_ticket);
                AllTickets.Add(new_ticket);
                if (activeTicketId == 0)
                {
                    activeTicketId = ticket.ticketID;
                    BarWithTickets.Controls[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
                }
            }

            //this.ResumeLayoutAll();

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

        private void ActiveTicket(object sender, EventArgs e)
        {
            this.activeTicketId = (int)((Button)sender).Tag;

            foreach (var item in this.BarWithTickets.Controls)
            {
                ((Button)item).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            }

            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
        }

        private void CreateHall()
        {
            // START OPTIONS

            int margin = 3;
            string[] alpha = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "Y", "Z" };
            int widthOfBtn = 40;
            int heightOfBtn = 40;
            int startX = 50;
            int startY = 50;
            int[] currentPosition = new int[]{startX, startY};
            //int[,] places;

            // END OPTIONS
    
            //CinemaModel.Halls Hall = getHall(this.ThisHallID);

            CinemaModel.Shows Show = getShow(this.ThisShowID);

            try
            {
                string matrix = Show.matrix;

                string[] split = Show.matrix.Split(new Char[] { ',' });

                this.rows = (Convert.ToInt32(split[0]) - 1);
                this.columns = (Convert.ToInt32(split[1]) - 2);

                this.places = new int[this.rows, this.columns];

                int iterator = 2;

                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {
                        this.places[i, j] = Convert.ToInt32(split[iterator]);
                        iterator++;
                    }
                }

                int rowOffset = 0;
                int columnOffset = 0;
                bool wasRow = false;
                bool wasColumn = false;

                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {
                        if (this.places[i, j] == 1)
                        {
                            Button btn = CreatePlace(currentPosition, new OnePlace(j, i, alpha[i - rowOffset], (j - columnOffset)), new int[] { widthOfBtn, heightOfBtn });
                            this.HallPanel.Controls.Add(btn);
                        }
                        else if (this.places[i, j] == 2)
                        {
                            Button btn = CreatePlace(currentPosition, new OnePlace(j, i, alpha[i - rowOffset], (j - columnOffset)), new int[] { widthOfBtn, heightOfBtn }, false);
                            this.HallPanel.Controls.Add(btn);
                        }
                        if (this.places[i, j] != 0) { wasColumn = true; wasRow = true; }

                        if (!wasColumn)
                        {
                            columnOffset += 1;
                        }


                        currentPosition[0] += (widthOfBtn + margin);
                        wasColumn = false;
                    }
                    if (!wasRow)
                    {
                        rowOffset++;
                    }
                    wasRow = false;
                    columnOffset = 0;
                    currentPosition[0] = startX;
                    currentPosition[1] += (heightOfBtn + margin);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem z wyświetleniem sali.");
            }
            

        }

        private Button InstanceButtonLocation()
        {
            Button btn = new System.Windows.Forms.Button();
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Palatino Linotype", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.TabIndex = 1;
            btn.UseVisualStyleBackColor = false;

            return btn;
        }

        private Button CreatePlace(int[] position, OnePlace cord, int[] size, bool enable = true)
        {
            //Button btn = new System.Windows.Forms.Button();
            Button btn = this.InstanceButtonLocation();

            if (enable)
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            else
            {
                btn.BackColor = System.Drawing.Color.Red;
                btn.Enabled = false;
            }


            btn.Location = new System.Drawing.Point(position[0], position[1]);
            btn.Name = "button," + cord.name;
            btn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            btn.Size = new System.Drawing.Size(size[0], size[1]);
            btn.Text = cord.name;
            btn.Tag = cord;

            btn.Click += new System.EventHandler(this.SelectPlace);
            return btn;
        }

        private void SelectPlace(object sender, EventArgs e)
        {
            Button ClickedBtn = (Button)sender;

            //MessageBox.Show("Click");

            if (((OnePlace)ClickedBtn.Tag).active == false)
            {
                ((OnePlace)ClickedBtn.Tag).active = true;
                ClickedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(244)))), ((int)(((byte)(99)))));
                ClickedBtn.ForeColor = System.Drawing.Color.Green;

                ChoiceLocations.Add(new LocationObject(ClickedBtn.Text, ((OnePlace)ClickedBtn.Tag).X, ((OnePlace)ClickedBtn.Tag).Y, getTicket()));
            }
            else
            {
                ((OnePlace)ClickedBtn.Tag).active = false;
                ClickedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
                ClickedBtn.ForeColor = System.Drawing.Color.White;

                removePlace(ClickedBtn.Text);
            }

        }

        private void removePlace(string place)
        {
            foreach (LocationObject item in ChoiceLocations)
            {
                if (item.checkLocation(place))
                {
                    ChoiceLocations.Remove(item);
                    break;
                }
                
            }
        }

        private modelTicket getTicket()
        {
            foreach (var item in AllTickets)
            {
                if (item.ticketID == activeTicketId) return item;
            }

            return null;
        }
        // MODELS
        private CinemaModel.Tickets[] getTickets()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Tickets = (from t in ctx.Tickets
                               select t).ToArray();
                return Tickets;
            }
        }

        private CinemaModel.Halls getHall(int HallID)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Hall = (from t in ctx.Halls
                            where t.hallID == HallID
                            select t).FirstOrDefault();

                return (CinemaModel.Halls)Hall;
            }
        }

        private CinemaModel.Shows getShow(int ShowID)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Show = (from t in ctx.Shows
                            where t.showID == ShowID
                            select t).FirstOrDefault();

                return (CinemaModel.Shows)Show;
            }
        }

        private void choiceLocationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            this.returnLocations += (this.rows + 1).ToString() + "," + (this.columns + 2).ToString();

            foreach (var item in this.ChoiceLocations)
            {
                this.places[item.getY(), item.getX()] = 2;

            }

            foreach (var item in this.places)
            {
                this.returnLocations += "," + item.ToString();
            }

            onLocationChange(this, this.ChoiceLocations);
            this.Close();
        }

        private void cancelWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }

    public class OnePlace
    {
        public bool active = false;
        public int X = 0;
        public int Y = 0;
        public string name;
        public OnePlace()
        {

        }
        public OnePlace(int x, int y, string row, int column)
        {
            this.X = x;
            this.Y = y;
            this.name = row + (column+1).ToString();
        }
    }
}
