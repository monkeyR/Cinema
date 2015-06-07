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
using CinemaModel;
using System.Data.SqlClient;

namespace CinemaManager.Pages
{
    public partial class MovieStatistic : Form
    {
        public MovieStatistic()
        {
            InitializeComponent();
            FIllComboBox();
            FIllTable();
            MonthStatisticChart.Hide();
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

            int howManyDisplayNow = 0;

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

                MovieStatisticAllMovieTableLauotPanel.RowCount = howManyRows + 2;
                MovieStatisticAllMovieTableLauotPanel.ColumnCount = 3;
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() {Text = "Tytuł filmu", AutoSize = true},
                    0, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() {Text = "Łącznie sprzedanych biletów", AutoSize = true}, 1, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() {Text = "Łącznie zrealizowanych seansów", AutoSize = true}, 2, 0);
               // MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                //    new Label() { Text = "Teraz gramy [] filmów", AutoSize = true }, 3, 0);
                MovieStatisticAllMovieTableLauotPanel.BackColor = Color.Lavender;
                //MovieStatisticAllMovieTableLauotPanel.Text

                var howMAnyMoviesIsAvailable = (from t in ctx.Movies
                                                where t.isAvailable == true
                                                select t).Count();
                howManyDisplayNow = howMAnyMoviesIsAvailable;

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
       //             MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplayNow.ToString(), }, 2, whichRow);
                    howManyTicket += movies_display_count;
                    howManyDisplay += movies_seance_count;

                    whichRow++;
                }
                whichRow = 1;

                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = "SUMA", }, 0, howManyRows + 1);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyTicket.ToString(), }, 1, howManyRows + 1);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplay.ToString(), }, 2, howManyRows + 1);
                   
            }
        }
        private void DisplayStatisticOfMovie_Click(object sender, EventArgs e)
        {

        }

        private void MovieStaisticDisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void DisplayChart_MonthStatistic(List<QuantityOfSalesTicketOneMovie> lista )
        {
            MonthStatisticChart.Show();
            


            var s = new Series();
            s.Name = "Ilość sprzedanych biletów na dany film";
            s.ChartType = SeriesChartType.Column;
            
            //var d = new DateTime(2013, 04, 01);

            foreach (var d in lista)
            {
                s.Points.AddXY(d.MovieNameQ, d.SalesTicketQ);
            }

            /*s.Points.AddXY(d, 3);
            s.Points.AddXY(d.AddMonths(-1), 2);
            s.Points.AddXY(d.AddMonths(-2), 1);
            s.Points.AddXY(d.AddMonths(-3), 4);
            */
            MonthStatisticChart.Series.Clear();
            MonthStatisticChart.Series.Add(s);


            //MonthStatisticChart.Series[0].XValueType = ChartValueType.DateTime;
            //MonthStatisticChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            //MonthStatisticChart.ChartAreas[0].AxisX.Interval = 1;
            //MonthStatisticChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            //MonthStatisticChart.ChartAreas[0].AxisX.IntervalOffset = 1;

            //MonthStatisticChart.Series[0].XValueType = ChartValueType.DateTime;
            //DateTime minDate = new DateTime(2013, 01, 01).AddSeconds(-1);
            //DateTime maxDate = new DateTime(2013, 05, 01); // or DateTime.Now;
            //MonthStatisticChart.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            //MonthStatisticChart.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int whichRow = 1;
            int whichColumn = 0;
            int howManyRows = 0;
            int howManyDisplay = 0;
            int howManyTicket = 0;

            List<int> nameOfMoviesList = new List<int>();
            List<string> nameOfMoviesListString = new List<string>();
            List<int> quantityOfSalesTicketsList;


            int thisMonth = DateTime.Today.Month;
            int lastMonts=DateTime.Today.Month-1;
            int thisYear = DateTime.Today.Year;
            int lastYear = DateTime.Today.Year-1;
            MovieStatisticAllMovieTableLauotPanel.Controls.Clear();
            MovieStatisticAllMovieTableLauotPanel.RowStyles.Clear();
            int year;
            int howManySalesTicket = 0;

            if (thisMonth == 1) { year = lastYear; }
            else year = thisYear;

            InfoAboutParametrOfStatisticLabel.Text = "Statystyki z ostatniego miesiąca: " + lastMonts.ToString() + "-" + thisYear.ToString(); 
            MovieStatisticAllMovieTableLauotPanel.AutoSize = true;
            int howManyDifferentMoviesInMonth=0;
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                        

                MovieStatisticAllMovieTableLauotPanel.RowCount = 4;
                MovieStatisticAllMovieTableLauotPanel.ColumnCount = 2;
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() { Text = "Sprzedanych biletów", AutoSize = true }, 0, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() { Text = "Zrealizowanych seansów", AutoSize = true }, 0, 1);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                  new Label() { Text = "Granych filmów", AutoSize = true }, 0, 2);
                MovieStatisticAllMovieTableLauotPanel.BackColor = Color.Lavender;


                // wszystkie bilety sprzedane w tym miesiącu
                var allSalesTicket_Transaction = (from t in ctx.Transations
                                                  where t.transationDate.Year == year
                                                  && t.transationDate.Month == thisMonth
                                                  select t);
                   foreach (var salesTicketTransaction in allSalesTicket_Transaction)
                   {
                       var salesTicket = (from k in ctx.TicketSales
                                                  where k.transationID == salesTicketTransaction.transationID
                                                 select k);
                       foreach (var salesTicketInMonth2 in salesTicket)
                       {
                           howManySalesTicket += salesTicketInMonth2.amount;
                       }
                   }

                // wszystkie seanse zrealizowane w tym miesiacu
                   var allShowsInThisMonth = (from k in ctx.Shows
                                              where k.dateStart.Year == year
                                              && k.dateStart.Month == thisMonth
                                              select k).Count();
            
                   howManyDisplay += allShowsInThisMonth;


                // ile rónych filmów było granych w tym miesiacu
                var allTicket = (from t in ctx.Shows
                                 where t.dateStart.Year == year
                                 && t.dateStart.Month == thisMonth
                                 group t by t.movieID into g
                                 select g).Count();

                howManyDifferentMoviesInMonth = allTicket;
               


                //lista filmów realizowanych w tym miesiacu
                var listOfMovies = (from t in ctx.Shows
                                    where t.dateStart.Year == year
                                    && t.dateStart.Month == thisMonth
                                    select t);

                foreach (var nameOfMovie in listOfMovies)
                {
                    nameOfMoviesList.Add(nameOfMovie.movieID);
                }
                List<int> uniqueMovieID = nameOfMoviesList.Distinct().ToList();



                var mov = (from m in ctx.Movies
                           select m);
                
                foreach (var IDmovie in mov)
                {
                    if (nameOfMoviesList.Count() != 0)
                    {
                        if (nameOfMoviesListString.Count() != 0)
                        {
                            if (nameOfMoviesList.Contains(IDmovie.movieID))
                            {
                                if (nameOfMoviesListString.Contains(IDmovie.title.ToString()))
                                { }
                                else nameOfMoviesListString.Add(IDmovie.title.ToString());
                            }
                        }
                        else nameOfMoviesListString.Add(IDmovie.title);

                    }
                    else MessageBox.Show("Lista ID filmów jest pusta");
                
                }
                MessageBox.Show("Liczba filmów wyświetlanych w zeszłym miesiący"+nameOfMoviesListString.Count().ToString());


        
                // lista ilości sprzedanych biletów na konkretny film
                var cos = (from t in ctx.Transations
                           join ts in ctx.TicketSales
                           on t.transationID equals ts.transationID
                           where t.transationDate.Month == thisMonth
                           && t.transationDate.Year == year
                           select new { n1 = t.showID, n2 = ts.amount});


                int ile = 0;
                int ile2 = 0;
                
                 //parts.Find(x => x.PartName.Contains("seat")));



                List<QuantityOfSalesTicket> qstList = new List<QuantityOfSalesTicket>();
                List<ShowMovie> showMov = new List<ShowMovie>();

                List<QuantityOfSalesTicketOneMovie> qstMoviesList = new List<QuantityOfSalesTicketOneMovie>();
             
                foreach(var ticketSalesInTransactions in cos)
                {
                    if (qstList.Count() == 0)
                    {
                        qstList.Add(new QuantityOfSalesTicket(){ ShowIDQ=(int)ticketSalesInTransactions.n1,SalesTicket= (int)ticketSalesInTransactions.n2});
                    }
                    else 
                    { 
                        // sprawdzam, czy na liście istnieje już element z showID
                       // if(qstList.Find(x => x.ShowIDQ.Contains(ticketSalesInTransactions.n1)))
                        if (qstList.Exists(x => x.ShowIDQ == ticketSalesInTransactions.n1))
                        {
                            var firstObject = qstList.FirstOrDefault(x => x.ShowIDQ == (int)ticketSalesInTransactions.n1);
                                firstObject.SalesTicket+=(int)ticketSalesInTransactions.n2;
                        }
                        else qstList.Add(new QuantityOfSalesTicket(){ ShowIDQ=(int)ticketSalesInTransactions.n1,SalesTicket= (int)ticketSalesInTransactions.n2});
                    
                    }
                }
                foreach (var listOfMov in uniqueMovieID)
                {
                      
                        qstMoviesList.Add(new QuantityOfSalesTicketOneMovie(){MovieIDQ=(int)listOfMov, MovieNameQ="",SalesTicketQ=0});
                }
                                
 
            
                
                foreach(var u1 in uniqueMovieID)
                {
                    var MovieTitle = (from m in ctx.Movies
                                      select new {m.movieID, m.title});
                    foreach (var u2 in MovieTitle)
                    {
                        if (qstMoviesList.Exists(x => x.MovieIDQ == u2.movieID))
                        {

                            var findObject2 = qstMoviesList.FirstOrDefault(y => y.MovieIDQ == (int)u2.movieID);
                            findObject2.MovieNameQ = (string)u2.title;
                        }
                        
                        
                    }
                   
                }
                
/*
                foreach(var u in listOfMoviesUnique)
                {
                     var firstObject = qstMoviesList.FirstOrDefault(x => x.MovieIDQ == (int)u.movieID);
                     firstObject.MovieNameQ=(string)u.title;
                }
                */

                MessageBox.Show(qstMoviesList[1].MovieIDQ.ToString() + " " + qstMoviesList[1].MovieNameQ.ToString() + " " + qstMoviesList[1].SalesTicketQ.ToString());

                //List<ShowMovie> ShowMovieList = new List<ShowMovie>();
                var show = (from s in ctx.Shows
                             select new {s.showID, s.movieID });
               
                foreach (var u2 in show)
                {
                    if(qstMoviesList.Exists(x=> x.MovieIDQ==u2.movieID))
                    {
                        showMov.Add(new ShowMovie() { MovieID = u2.movieID, ShowID = u2.showID });
                    }

                }
                                                
                foreach(var u3 in showMov)
                {
                    var firstObject = qstMoviesList.FirstOrDefault(x => x.MovieIDQ == (int)u3.MovieID);
                    var show_account = qstList.FirstOrDefault(y => y.ShowIDQ == (int)u3.ShowID);
                    if(show_account!=null)
                        firstObject.SalesTicketQ += (int)show_account.SalesTicket;
                }


                foreach(var f in qstMoviesList)
                {
                    MessageBox.Show(f.MovieNameQ.ToString() + "  " + f.SalesTicketQ.ToString());

                }
               
                
                
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManySalesTicket.ToString(), }, 1,0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplay.ToString(),}, 1, 1);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDifferentMoviesInMonth.ToString(), }, 1, 2);

                DisplayChart_MonthStatistic(qstMoviesList); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void MovieStatisticAllMovieTableLauotPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
