using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.Data.Entity;
using System.Threading;
using System.Configuration;

namespace CinemaDisplay.Main
{
    public partial class MainFormDisplay : Form
    {
        private static String UISettingsIntervalTag = "UIRefresh";
        private static String DataRefreshTag = "DataRefresh";
        private static String movieDateFormat = "HH:mm";
        private DateTime dateTime = DateTime.Now;
        int margin = 5;
        private int flowLayoutHeight = 63;
        private int maxMoviesAtOnce = 0;
        private int UITimerInterval = 10000;
        private int modelsTimerInterval = 30000;
        private int position = 0;

        private Dictionary<MovieModel, List<ShowModel>> updatedGroupedShows;
        private Dictionary<MovieModel, List<ShowModel>> groupedShows;
        private System.Windows.Forms.Timer updateUITimer;
        private System.Windows.Forms.Timer updateModelsTimer;
        private ManualResetEvent initializeEvent = new ManualResetEvent(false);
        private object updateSynchronizationObject = new object();

        public MainFormDisplay()
        {
            InitializeComponent();
            initializeSettings();
            startLoadingShows();
        }

        private void initializeSettings()
        {
            try
            {
                UITimerInterval = Int32.Parse(ConfigurationManager.AppSettings[UISettingsIntervalTag]);
                modelsTimerInterval = Int32.Parse(ConfigurationManager.AppSettings[DataRefreshTag]);
            }
            catch(Exception ex)
            {}
        }

        private void initializeMaxMoviesAtOnce()
        {
            maxMoviesAtOnce = mainPanel.Size.Height / ((flowLayoutHeight * 2) + margin);
        }

        private void startLoadingShows()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += setupShows;
            worker.RunWorkerCompleted += startTimers;
            worker.RunWorkerAsync();
        }

        private void startTimers(object sender, RunWorkerCompletedEventArgs e)
        {
            startUITimer(sender, e);
            startModelsTimer();
        }

        private void startUITimer(object sender, RunWorkerCompletedEventArgs e)
        {
            updateUITimer = new System.Windows.Forms.Timer();
            updateUITimer.Interval = UITimerInterval;
            updateUITimer.Tick += new EventHandler(onUITimerTick);
            updateUITimer.Start();
            onUITimerTick(sender, e);
        }

        private void startModelsTimer()
        {
            updateModelsTimer = new System.Windows.Forms.Timer();
            updateModelsTimer.Interval = modelsTimerInterval;
            updateModelsTimer.Tick += new EventHandler(onModelsTimerTick);
            updateModelsTimer.Start();
        }

        private void onModelsTimerTick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            var shows = getShows(dateTime);
            var groupedShows = getGroupedShows(shows);
            lock (updateSynchronizationObject)
            {
                updatedGroupedShows = groupedShows;
            }
        }

        private void setupShows(object sender, DoWorkEventArgs e)
        {
            var shows = getShows(dateTime);
            groupedShows = getGroupedShows(shows);
            initializeEvent.WaitOne();
        }

        private void onUITimerTick(object sender, EventArgs e)
        {
            if (position == 0) //starting position in cycle
                checkoutUpdatedShows();
            int startingPosition = position * maxMoviesAtOnce;
            List<Control> controlsToAdd = new List<Control>();
            
            for (int i = startingPosition; i < groupedShows.Count && i < maxMoviesAtOnce * (position + 1); i++)
            {
                var item = groupedShows.ElementAt(i);
                FlowLayoutPanel panel = getLayoutPanel();

                int temp = i - position * maxMoviesAtOnce;
                panel.Location = new Point(0, temp * 2 * flowLayoutHeight + temp * margin);
                Button movieButton = getMovieButton();
                movieButton.Text = item.Key.Title;
                panel.Controls.Add(movieButton);
                fillWithShows(panel, item.Value);
                controlsToAdd.Add(panel);
            }
            UISynchronizer.synchronizeWithUI(mainPanel, (controls) =>
                {
                    mainPanel.SuspendLayout();
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.AddRange(controls);
                }, controlsToAdd.ToArray());
            UISynchronizer.synchronizeWithUI(mainPanel, () => mainPanel.ResumeLayout());

            position++;
            if (position > groupedShows.Count / (maxMoviesAtOnce + 1))
                position = 0;
        }

        private void checkoutUpdatedShows()
        {
            lock (updateSynchronizationObject)
            {
                if (updatedGroupedShows != null)
                {
                    groupedShows = updatedGroupedShows;
                    updatedGroupedShows = null;
                }
            }
        }

        private void fillWithShows(FlowLayoutPanel panel, List<ShowModel> shows)
        {
            foreach (var show in shows)
            {
                //Button button = getShowButton();
                //button.Text = getDateString(show);
                Control showControl = getShowPanel(getDateString(show), show.hall.title);
                panel.Controls.Add(showControl);
            }
        }

        private String getDateString(ShowModel model)
        {
            String toBeReturned = "";
            toBeReturned += model.show.dateStart.ToString(movieDateFormat);
            toBeReturned += " - ";
            toBeReturned += model.show.dateEnd.ToString(movieDateFormat);
            return toBeReturned;
        }

        private Panel getShowPanel(String time, String hallTitle)
        {
            Label hallLabel = new Label();
            hallLabel.AutoEllipsis = true;
            hallLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            hallLabel.TextAlign = this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            hallLabel.Location = new System.Drawing.Point(30, 36);
            hallLabel.Size = new System.Drawing.Size(160, 17);
            hallLabel.Text = hallTitle;

            Label showLabel = new Label();
            showLabel.AutoSize = true;
            showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            showLabel.ForeColor = System.Drawing.Color.White;
            showLabel.Location = new System.Drawing.Point(0, 5);
            showLabel.Size = new System.Drawing.Size(127, 25);
            showLabel.Text = time;

            Panel showPanel = new Panel();
            showPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            showPanel.Controls.Add(hallLabel);
            showPanel.Controls.Add(showLabel);
            showPanel.ForeColor = System.Drawing.Color.White;
            int margin = 3;
            showPanel.Margin = new System.Windows.Forms.Padding(margin, margin, margin, margin);
            showPanel.Size = new System.Drawing.Size(200, flowLayoutHeight - margin * 2);
            
            return showPanel;
        }

        private Button getMovieButton()
        {
            Button button = getBaseButton();
            button.AutoSize = true;
            button.Size = new Size(400, flowLayoutHeight);
            button.MaximumSize = new Size(400, flowLayoutHeight);
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            return button;
        }

        private Button getBaseButton()
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.Margin = new System.Windows.Forms.Padding(1);
            button.Size = new System.Drawing.Size(45, 45);
            button.UseVisualStyleBackColor = false;
            return button;
        }

        private FlowLayoutPanel getLayoutPanel()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Margin = new System.Windows.Forms.Padding(2);
            panel.Size = new System.Drawing.Size(mainPanel.Size.Width, flowLayoutHeight * 2);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            return panel;
        }

        private Dictionary<MovieModel, List<ShowModel>> getGroupedShows(List<ShowModel> shows)
        {
            Dictionary<MovieModel, List<ShowModel>> dictionary = new Dictionary<MovieModel, List<ShowModel>>();
            foreach (ShowModel model in shows)
            {
                MovieModel movieModel = new MovieModel(model.movieTitle, model.show.movieID);
                List<ShowModel> showList;
                if (dictionary.TryGetValue(movieModel, out showList))
                {
                    showList.Add(model);
                }
                else
                {
                    showList = new List<ShowModel>();
                    showList.Add(model);
                    dictionary.Add(movieModel, showList);
                }
            }
            return dictionary;
        }

        private List<ShowModel> getShows(DateTime day)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var shows =
                    (from s in ctx.Shows
                     where DbFunctions.TruncateTime(s.dateStart) == DbFunctions.TruncateTime(day)
                     join m in ctx.Movies on s.movieID equals m.movieID
                     join hh in ctx.Halls on s.hallID equals hh.hallID
                     orderby s.dateStart ascending
                     select new ShowModel() { show = s, movieTitle = m.title, hall = hh });
                return shows.ToList();
            }
        }

        private void MainFormDisplay_Activated(object sender, EventArgs e)
        {
            if (maxMoviesAtOnce == 0)
            {
                initializeMaxMoviesAtOnce();
                initializeEvent.Set();
            }
        }

        private void MainFormDisplay_KeyUp(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Escape)
            {
                stopTimers();
                this.Close();
            }
        }

        private void stopTimers()
        {
            updateModelsTimer.Stop();
            updateUITimer.Stop();
        }
    }
}
