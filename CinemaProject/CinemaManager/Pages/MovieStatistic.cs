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

                foreach (var movie in movies)
                {
                    howManyRows++;
                }

                MovieStatisticAllMovieTableLauotPanel.RowCount = howManyRows + 1;
                MovieStatisticAllMovieTableLauotPanel.ColumnCount = 3;
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() {Text = "Tytuł filmu", AutoSize = true},
                    0, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() {Text = "Łącznie sprzedanych biletów", AutoSize = true}, 1, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() {Text = "Łącznie zrealizowanych seansów", AutoSize = true}, 2, 0);
                MovieStatisticAllMovieTableLauotPanel.BackColor = Color.Lavender;
                //MovieStatisticAllMovieTableLauotPanel.Text

                foreach (var movie2 in movies)
                {

                   var movies_display_count = (from t in ctx.MovieSales
                                              where t.movieID == movie2.movieID
                                               select t).Count();

                   var movies_seance_count = (from k in ctx.Shows
                                               where k.movieID == movie2.movieID
                                               select k).Count();
                    
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() {Text = movie2.title,}, 0, whichRow);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = movies_display_count.ToString(), }, 1, whichRow);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = movies_seance_count.ToString(), }, 2, whichRow);
                    
                    whichRow++;
                }
                whichRow = 1;
               
            }
        }
        private void DisplayStatisticOfMovie_Click(object sender, EventArgs e)
        {

        }

        private void MovieStaisticDisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
