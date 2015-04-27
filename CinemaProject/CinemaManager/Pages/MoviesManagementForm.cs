using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Pages
{
    public partial class MoviesManagementForm : Form
    {
        public MoviesManagementForm()
        {
            InitializeComponent();

            Common.UISynchronizer.synchronizeWithUI(MoviesListflowLayoutPanel, x => MoviesListflowLayoutPanel.AutoScroll = x, true);
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
            fillPanelWithMovies();
            fillExpiredMovies();
        }

        private void fillExpiredMovies()
        {
            //TODO:
            // baza danych - stare filmy
        }

        private void fillPanelWithMovies()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var movies = ctx.Movies;

                foreach (var movie in movies)
                {
                    SubPages.MovieListElement movieElement = new SubPages.MovieListElement(movie);
                    Common.UISynchronizer.synchronizeWithUI(MoviesListflowLayoutPanel, x => MoviesListflowLayoutPanel.Controls.Add(x), movieElement);
                   // MoviesListflowLayoutPanel.Controls.Add(movieElement);
                }
            }
        }

        private void MoviesListflowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
