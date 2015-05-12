using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Utils;
using Common;

namespace CinemaManager.SubPages
{
    public partial class AddShowForm : Form
    {

        private Action<CinemaModel.Halls> onShowAdded;

        private const int minutesInHour = 60;

        private RadioListBox radioListBox;
        private DateTime date;
        private CinemaModel.Halls hall;

        public AddShowForm(DateTime date, CinemaModel.Halls hall, Action<CinemaModel.Halls> onShowAdded)
        {
            this.date = date;
            this.hall = hall;
            this.onShowAdded = onShowAdded;
            InitializeComponent();
            setupTimer();
            addRadioListBox();
            startFilling();
        }

        private void setupTimer()
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            timePicker.Value = date;
        }

        private void addRadioListBox()
        {
            radioListBox = new RadioListBox();
            radioListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            radioListBox.FormattingEnabled = true;
            radioListBox.Location = new System.Drawing.Point(28, 69);
            radioListBox.Size = new System.Drawing.Size(276, 280);
            radioListBox.HorizontalScrollbar = true;
            radioListBox.IntegralHeight = true;
            this.Controls.Add(radioListBox);
        }

        private void startFilling()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += fillWithData;
            worker.RunWorkerCompleted += onWorkerCompleted;
            Cursor.Current = Cursors.WaitCursor;
            worker.RunWorkerAsync();
        }

        private void onWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            updateHorizontalScrollSize();
        }

        private void fillWithData(object sender, DoWorkEventArgs e)
        {
            AvaibleMoviesLoader loader = new AvaibleMoviesLoader();
            List<CinemaModel.Movies> movies = loader.load();
            foreach (var movie in movies)
            {
                Common.UISynchronizer.synchronizeWithUI(radioListBox, () => radioListBox.Items.Add(new MovieModel(movie)));
            }        
        }

        private void updateHorizontalScrollSize()
        {
            Graphics g = radioListBox.CreateGraphics();
            String test = radioListBox.Items[radioListBox.Items.Count - 1].ToString();
            int hzSize = (int)g.MeasureString(radioListBox.Items[radioListBox.Items.Count - 1].ToString(), radioListBox.Font).Width;
            radioListBox.HorizontalExtent = hzSize;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Object selected = radioListBox.SelectedItem;
            if (preValidate(selected))
                startValidating((MovieModel)selected);
        }

        private bool preValidate(Object selected)
        {
            if (selected == null)
            {
                MessageBox.Show("Wybierz film");
                return false;
            }
            return true;
        }

        private void startValidating(MovieModel model)
        {
            disableUI();
            Task.Factory.StartNew(() =>validate(model)).
                ContinueWith((t1) => addShow(t1.Result, model), TaskScheduler.FromCurrentSynchronizationContext());
        }

        private bool validate(MovieModel model)
        {
            DateTime startTime = timePicker.Value;
            DateTime endTime = startTime.AddMinutes(model.Duration);
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var shows =
                    (from s in ctx.Shows
                     where s.hallID.Equals(hall.hallID)
                     && (
                     (s.dateEnd >= startTime && s.dateEnd <= endTime)
                     || (s.dateStart >= startTime && s.dateStart <= endTime))
                     select s);

                if(shows.Count() > 0)
                {
                    MessageBox.Show("Wystąpiła kolizja. Zmień czas rozpoczęcia seansu.");
                    return false;
                }
            }
            return true;
        }

        private void addShow(bool validated, MovieModel model)
        {
            if(validated)
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    try
                    {
                        DateTime startTime = timePicker.Value;
                        DateTime endTime = startTime.AddMinutes(model.Duration);

                        CinemaModel.Shows show = new CinemaModel.Shows();
                        show.movieID = model.Id;
                        show.hallID = hall.hallID;
                        show.dateStart = startTime;
                        show.dateEnd = endTime;
                        ctx.Shows.Add(show);
                        ctx.SaveChanges();

                        onShowAdded(hall);
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        showError(ex);
                        enableUI();
                    }
                }      
            }
            else
            {
                enableUI();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void disableUI()
        {
            radioListBox.Enabled = false;
            cancelButton.Enabled = false;
            addButton.Enabled = false;
            timePicker.Enabled = false;
        }

        private void enableUI()
        {
            radioListBox.Enabled = true;
            cancelButton.Enabled = true;
            addButton.Enabled = true;
            timePicker.Enabled = true;
        }

        private void showError(Exception ex)
        {
            String message = "Wystąpił błąd: " + ex.Message;
            MessageBox.Show(message);
        }

    }

    public partial class MovieModel
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private int duration;
        public int Duration
        {
            get { return duration; }
        }

        private String title;
        public String Title
        {
            get { return title; }
        }

        public MovieModel(CinemaModel.Movies movie)
        {
            this.id = movie.movieID;
            this.duration = movie.duration;
            this.title = movie.title;
        }

        public override string ToString()
        {
            String toBeReturned = title;
            toBeReturned = StringUtils.getTrunctedTextWithEllipsis(toBeReturned, 32);
            toBeReturned += " (" + duration + ")";
            return toBeReturned;
        }
    }
}
