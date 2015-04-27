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
        private List<SubPages.MovieListElement> moviesElements = new List<SubPages.MovieListElement>();

        public MoviesManagementForm()
        {
            InitializeComponent();

            Common.UISynchronizer.synchronizeWithUI(MoviesListflowLayoutPanel, x => MoviesListflowLayoutPanel.AutoScroll = x, true);
            startFilling();
        }

        public void startFilling()
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
            Common.UISynchronizer.synchronizeWithUI(expiredMoviesListView, expiredMoviesListView.Items.Clear);
            foreach (SubPages.MovieListElement elem in moviesElements.ToList())
            {
                Common.UISynchronizer.synchronizeWithUI(MoviesListflowLayoutPanel, x => MoviesListflowLayoutPanel.Controls.Remove(x), elem);
                moviesElements.Remove(elem);
            }

            fillWithMovies();
        }

        private void fillWithMovies()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var movies = 
                    (from m in ctx.Movies
                     orderby m.movieID descending
                     select m
                    );

                foreach (var movie in movies)
                {
                    if ((bool)movie.isAvailable)
                    {
                        SubPages.MovieListElement movieElement = new SubPages.MovieListElement(movie, this);
                        moviesElements.Add(movieElement);
                        Common.UISynchronizer.synchronizeWithUI(MoviesListflowLayoutPanel, x => MoviesListflowLayoutPanel.Controls.Add(x), movieElement);
                    }
                    else
                    {
                        fillExpiredMovies(movie);
                    }
                }
            }
        }

        private void fillExpiredMovies(CinemaModel.Movies movie)
        {
            List<string> listItem = new List<string>(5);
            listItem.Add(movie.title);
            listItem.Add(movie.director);
            listItem.Add(string.Format("{0:0.00}zł", movie.price));
            listItem.Add(Convert.ToString(movie.duration));
            listItem.Add(movie.description);

            ListViewItem item = new ListViewItem(listItem.ToArray());
            Common.UISynchronizer.synchronizeWithUI(expiredMoviesListView, x => expiredMoviesListView.Items.Add(x), item);
            Common.UISynchronizer.synchronizeWithUI(expiredMoviesListView,
                x => expiredMoviesListView.Items[expiredMoviesListView.Items.Count - 1].Tag = x, movie.movieID);

        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            SubPages.AddNewMovieForm form = new SubPages.AddNewMovieForm();
            form.ShowDialog();

            startFilling();
        }

        private void expiredMoviesListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && expiredMoviesListView.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem returnMovieItem = new MenuItem("Przywróć do ramówki");
                returnMovieItem.Click += (objectSender, args) =>
                {
                    returnMovieItemClick(objectSender, args);
                };
                cm.MenuItems.Add(returnMovieItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void returnMovieItemClick(object objectSender, EventArgs args)
        {
            int movieID = (int)expiredMoviesListView.SelectedItems[0].Tag;

            Cursor.Current = Cursors.WaitCursor;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Movies movie = ctx.Movies.First(x => x.movieID.Equals(movieID));

                movie.isAvailable = true;

                ctx.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }

            Cursor.Current = Cursors.Default;

            startFilling();
        }
    }
}
