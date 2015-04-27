using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.SubPages;
using CinemaManager.Utils;
using Common;

namespace CinemaManager.Pages
{
    public partial class ShowManagementForm : Form
    {

        private List<CinemaModel.Halls> halls;
        private int flowLayoutHeight = 50;
        private int flowLayoutMaxWidth = 0;

        public ShowManagementForm()
        {
            InitializeComponent();
            startLoadingHalls();
        }

        private void startLoadingHalls()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += setupHalls;
            worker.RunWorkerCompleted += onHallsInitialized;
            worker.RunWorkerAsync();
        }

        private void setupHalls(object sender, DoWorkEventArgs e)
        {
            this.halls = getHalls();
            for (int i = 0; i < halls.Count; i++)
            {
                var hall = halls[i];
                FlowLayoutPanel panel = getLayoutPanel();
                panel.Location = new System.Drawing.Point(0, i * flowLayoutHeight);

                Button numberButton = getStaticButton();
                numberButton.Text = hall.number.ToString();
                numberButton.Enabled = false;
                Button addButton = getStaticButton();
                addButton.Click += onShowAddButtonClick;
                addButton.Text = "+";
                addButton.Tag = hall;

                panel.Controls.Add(numberButton);
                panel.Controls.Add(addButton);
                panel.Tag = hall;

                UISynchronizer.synchronizeWithUI(mainPanel, () => mainPanel.Controls.Add(panel));
            }
        }

        private void onHallsInitialized(object sender, RunWorkerCompletedEventArgs e)
        {
            startLoadingShows();
        }

        private void startLoadingShows()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += setupShows;
            worker.RunWorkerCompleted += onShowInitialized;
            worker.RunWorkerAsync();
        }

        private void setupShows(object sender, DoWorkEventArgs e)
        {
            flowLayoutMaxWidth = mainPanel.Size.Width;
            foreach(FlowLayoutPanel hallPanel in mainPanel.Controls)
            {
                CinemaModel.Halls hall = (CinemaModel.Halls)hallPanel.Tag;
                addShowsToHall(hall, hallPanel);
            }
        }

        private void addShowsToHall(CinemaModel.Halls hall, FlowLayoutPanel hallPanel)
        {
            List<ShowModel> shows = getShows(hall, datePicker.Value);
            List<Button> showButtons = new List<Button>(shows.Count);
            foreach (var show in shows)
            {
                Button showButton = getShowButton();
                showButton.Text = show.ToString();
                showButton.Tag = show;
                showButton.Click += onShowButtonClick;
                showButtons.Add(showButton);
            }
            UISynchronizer.synchronizeWithUI(hallPanel, () =>
                {
                    clearShows(hallPanel);
                    hallPanel.Size = new System.Drawing.Size(mainPanel.Size.Width, flowLayoutHeight);
                    hallPanel.Controls.AddRange(showButtons.ToArray());
                    if (hallPanel.Size.Width > flowLayoutMaxWidth)
                        flowLayoutMaxWidth = hallPanel.Size.Width;
                });
        }

        private void onShowButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ShowModel model = (ShowModel)button.Tag;
            RemoveShowForm form = new RemoveShowForm(model, (hall) => startUpdatingHallPanel(hall));
            form.ShowDialog();
        }


        private void clearShows(FlowLayoutPanel hallPanel)
        {
            while(hallPanel.Controls.Count > 2)
            {
                hallPanel.Controls.RemoveAt(2);
            }
        }

        private void onShowInitialized(object sender, RunWorkerCompletedEventArgs e)
        {
            updateHallPanelsWidth();
        }

        private void onShowAddButtonClick(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value;
            Button button = (Button)sender;
            CinemaModel.Halls hall = (CinemaModel.Halls)button.Tag;
            AddShowForm form = new AddShowForm(date, hall, (h) => startUpdatingHallPanel(h));
            form.ShowDialog();
        }

        private void startUpdatingHallPanel(CinemaModel.Halls hall)
        {
            FlowLayoutPanel panel = getPanelWithHallId(hall.hallID);
            if (panel != null)
            {
                Task.Factory.StartNew(() => addShowsToHall(hall, panel))
                    .ContinueWith((t1) => updateHallPanelsWidth());
            }
        }

        private FlowLayoutPanel getPanelWithHallId(int hallId)
        {
            foreach(FlowLayoutPanel panel in mainPanel.Controls)
            {
                CinemaModel.Halls hall = (CinemaModel.Halls)panel.Tag;
                if (hall.hallID == hallId)
                    return panel;
            }
            return null;
        }

        private List<CinemaModel.Halls> getHalls()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var halls =
                    (from h in ctx.Halls
                     select h);
                return halls.ToList();
            }      
        }

        private List<ShowModel> getShows(CinemaModel.Halls h, DateTime day)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var shows =
                    (from s in ctx.Shows
                        where s.hallID.Equals(h.hallID)
                        && DbFunctions.TruncateTime(s.dateStart) == DbFunctions.TruncateTime(day)
                        join m in ctx.Movies on s.movieID equals m.movieID
                        join hh in ctx.Halls on h.hallID equals hh.hallID
                        select new ShowModel() { show = s, movieTitle = m.title, hall = hh });
                return shows.ToList();
            } 
        }

        private FlowLayoutPanel getLayoutPanel()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoSize = true;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Margin = new System.Windows.Forms.Padding(2);
            panel.Size = new System.Drawing.Size(mainPanel.Size.Width, flowLayoutHeight);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            return panel;
        }

        private Button getStaticButton()
        {
            Button button = getBaseButton();
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            return button;
        }

        private Button getShowButton()
        {
            Button button = getBaseButton();
            button.AutoSize = true;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            return button;
        }

        private Button getBaseButton()
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.Margin = new System.Windows.Forms.Padding(2);
            button.Size = new System.Drawing.Size(45, 45);
            button.UseVisualStyleBackColor = false;
            return button;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            startLoadingShows();
        }

        private void updateHallPanelsWidth()
        {
            foreach(FlowLayoutPanel hallPanel in mainPanel.Controls)
            {
                if(hallPanel.Size.Width < flowLayoutMaxWidth)
                    hallPanel.Size = new System.Drawing.Size(flowLayoutMaxWidth, flowLayoutHeight);
            }
        }

    }
}
