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
    public partial class MovieStatistic : Form
    {
        public MovieStatistic()
        {
            InitializeComponent();
            FIllComboBox();
            FIllTable();
        }
        private void FIllComboBox()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var movies = (from t in ctx.Movies
                    where t.isAvailable == true
                    select t);
                foreach (var movie in movies)
                {
                    Common.UISynchronizer.synchronizeWithUI(MovieComboBox, x => MovieComboBox.Items.Add(x),
                        movie.title);
                }
                MovieComboBox.Sorted = true;
               if(MovieComboBox.Items.Count!=0) MovieComboBox.SelectedIndex = 0;
            }
        }

        private void FIllTable()
        {
            int whichRow = 1;
            int whichColumn = 0;
            int howManyRows = 0;
            int howManyDisplay = 0;
            int howManyTicket = 0;

            MovieStatisticAllMovieTableLauotPanel.AutoSize = true;
           
           using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var movies = (from t in ctx.Movies
                              where t.isAvailable == true
                              select t);
                var movies_display_count = (from t in ctx.MovieSales 
                                            join p in ctx.Movies 
                                            on t.movieID equals p.movieID
                                            select t);
                foreach (var movie in movies)
                {
                    howManyRows++;
                }
                
               MovieStatisticAllMovieTableLauotPanel.RowCount = howManyRows+1;
                MovieStatisticAllMovieTableLauotPanel.ColumnCount = 3;
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = "Tytuł filmu", AutoSize = true }, 0, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = "Łącznie sprzedanych biletów", AutoSize = true },1,0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = "Łącznie zrealizowanych seansów", AutoSize = true }, 2, 0);

                foreach (var movie in movies)
                {
                   MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = movie.title, }, 0, whichRow);
                   whichRow++;
                }
              whichRow = 1;
                foreach (var movie_count in movies_display_count)
                {
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() {Text = movie_count.Movies.title.Count().ToString(),}, 1, whichRow);
                    whichRow++;
                }

            }
        }
        private void DisplayStatisticOfMovie_Click(object sender, EventArgs e)
        {

        }

        private void MovieStaisticDisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
