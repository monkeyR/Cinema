using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.SubPages
{
    public partial class EditMovieForm : Form
    {
        CinemaModel.Movies movie;

        public EditMovieForm(CinemaModel.Movies movie)
        {
            InitializeComponent();

            this.movie = movie;

            startFilling();
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
        }
        private void fillWithData(object sender, DoWorkEventArgs e)
        {
            insertMovieData();
        }

        private void insertMovieData()
        {
            Common.UISynchronizer.synchronizeWithUI(titleTextbox, x => titleTextbox.Text = x, movie.title);
            Common.UISynchronizer.synchronizeWithUI(directorTextbox, x => directorTextbox.Text = x, movie.director);
            Common.UISynchronizer.synchronizeWithUI(priceTextbox, x => priceTextbox.Text = x, string.Format("{0:0.00}",movie.price));
            Common.UISynchronizer.synchronizeWithUI(durationNumericUpDown, x => durationNumericUpDown.Value = x, movie.duration);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
