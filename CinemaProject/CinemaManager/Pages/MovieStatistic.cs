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
       public int thisMonth = DateTime.Today.Month;
       public int lastMonts = DateTime.Today.Month - 1;
       public int thisYear = DateTime.Today.Year;
       public int lastYear = DateTime.Today.Year - 1;
       public int month = 0;

       List<QuantityOfSalesTicket> qstList = new List<QuantityOfSalesTicket>();
       List<ShowMovie> showMov = new List<ShowMovie>();
       List<QuantityOfSalesTicketOneMovie> qstMoviesList = new List<QuantityOfSalesTicketOneMovie>();
       List<string> nameOfCateg = new List<string>();
       List<QuantityOfSalesTicketTypeOfMovie> qstCategoryList = new List<QuantityOfSalesTicketTypeOfMovie>();
               
       int year = 0;
       public DateTime today = DateTime.Today;
       
        
       public List<int> nameOfMoviesList = new List<int>();
       public List<string> nameOfMoviesListString = new List<string>();
       public List<int> quantityOfSalesTicketsList;

       private bool monthClicked = false;
       private bool dateClicked = false;

        public MovieStatistic()
        {
            InitializeComponent();
            FillTable();
            MonthStatisticTypeOfMovieChart.Hide();
            MonthStatisticChart.Hide();
            if (thisMonth == 1) { year = lastYear; }
            else year = thisYear;
        }
        
        private void FillTable()
        {
            int whichRow = 1;
            int howManyRows = 0;
            int howManyDisplay = 0;
            int howManyTicket = 0;

            int howManyDisplayNow = 0;

           // MovieStatisticAllMovieTableLauotPanel.AutoSize = true;
            
            MovieStatisticAllMovieTableLauotPanel.Size = new Size(900,150 );
            MovieStatisticAllMovieTableLauotPanel.VerticalScroll.Maximum = 200;
            MovieStatisticAllMovieTableLauotPanel.HorizontalScroll.Maximum = 200;
            MovieStatisticAllMovieTableLauotPanel.AutoSize = false;
            MovieStatisticAllMovieTableLauotPanel.AutoScroll = true;

         
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
                
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = "Tytuł filmu", AutoSize = true, Margin=new Padding(5,5,5,5)},
                    0, 0);

                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() { Text = "Łącznie sprzedanych biletów", AutoSize = true, Margin = new Padding(5, 5, 5, 5) }, 1, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                    new Label() { Text = "Łącznie zrealizowanych seansów", AutoSize = true, Margin = new Padding(5, 5, 5, 5) }, 2, 0);
              
               
                MovieStatisticAllMovieTableLauotPanel.BackColor = Color.Lavender;
            

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

                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Margin=new Padding(5,0,0,0),Text = movie2.title, }, 0, whichRow);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = movies_display_count.ToString(), }, 1, whichRow);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = movies_seance_count.ToString(), }, 2, whichRow);
                    //             MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplayNow.ToString(), }, 2, whichRow);
                    howManyTicket += movies_display_count;
                    howManyDisplay += movies_seance_count;

                    whichRow++;
                }
                MovieStatisticAllMovieTableLauotPanel.Size=new Size(950,(movies.Count()*35));
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

        /*
        private void DisplayChartStatistic(List<QuantityOfSalesTicketOneMovie> lista)
        {
            Chart char1 = new Chart();
           // MonthStatisticChart.Show();
            var s = new Series();
            s.Name = "Ilość sprzedanych biletów na dany film";
            s.ChartType = SeriesChartType.Column;

            foreach (var d in lista)
            {
                s.Points.AddXY(d.MovieNameQ, d.SalesTicketQ);
            }

            char1.Series.Clear();
            char1.Series.Add(s);

        }
        */


        private void DisplayChartStatistic2(List<QuantityOfSalesTicketOneMovie> lista)
        {
            
            MonthStatisticChart.Show();
            var s = new Series();
            s.Name = "Ilość sprzedanych biletów na dany film";
            s.ChartType = SeriesChartType.Column;

            foreach (var d in lista)
            {
                s.Points.AddXY(d.MovieNameQ, d.SalesTicketQ);
            }

            MonthStatisticChart.Series.Clear();
            MonthStatisticChart.Series.Add(s);
           
        }
        private void DisplayChartStatistic_typefMovie(List<QuantityOfSalesTicketTypeOfMovie> lista)
        {
           
            
            MonthStatisticTypeOfMovieChart.Show();
            var series = new Series();
            series.Name = "Ilość sprzedanych biletów na dany typ filmu";
            series.ChartType = SeriesChartType.Column;

            foreach (var d2 in lista)
            {
                series.Points.AddXY(d2.typeOfMovie, d2.quantityTicket);
            }
          //  MonthStatisticTypeOfMovieChart.Series.First().XValueMember = "X";
          //  MonthStatisticTypeOfMovieChart.Series.First().YValueMembers = "Y";

            MonthStatisticTypeOfMovieChart.Series.Clear();
            MonthStatisticTypeOfMovieChart.Series.Add(series);
            MonthStatisticTypeOfMovieChart.Update();
            

        }


        private void Statistic()
        {
            CleanAllLIst();

            MovieStatisticAllMovieTableLauotPanel.Controls.Clear();
            MovieStatisticAllMovieTableLauotPanel.RowStyles.Clear();
            MovieStatisticAllMovieTableLauotPanel.AutoSize = true;
            MovieStatisticAllMovieTableLauotPanel.Controls.Clear();
            MovieStatisticAllMovieTableLauotPanel.Size = new Size(950, 140);
              
            MovieStatisticAllMovieTableLauotPanel.RowCount = 5;
            MovieStatisticAllMovieTableLauotPanel.ColumnCount = 2;
       
            MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                 new Label() { Text = "Sprzedanych biletów", AutoSize = true }, 0, 0);
            MovieStatisticAllMovieTableLauotPanel.Controls.Add(
                new Label() { Text = "Zrealizowanych seansów", AutoSize = true }, 0, 1);
            MovieStatisticAllMovieTableLauotPanel.Controls.Add(
              new Label() { Text = "Granych filmów", AutoSize = true }, 0, 2);
            MovieStatisticAllMovieTableLauotPanel.Controls.Add(
             new Label() { Text = "Najbardziej lubiany typ filmu:", AutoSize = true }, 0, 3);
            MovieStatisticAllMovieTableLauotPanel.BackColor = Color.LemonChiffon;

            MonthStatisticChart.Controls.Clear();
            MonthStatisticTypeOfMovieChart.Controls.Clear();
           
            
            if (monthClicked) {
                InfoAboutParametrOfStatisticLabel.Text = "Statystyki z ostatniego miesiąca: " + lastMonts.ToString() + "-" + thisYear.ToString();
                MonthStatistic();
            }
            else if (dateClicked) {
                InfoAboutParametrOfStatisticLabel.Text = "Statystyki z danego okresu: " + thisMonth.ToString() + "-" + thisYear.ToString();
                DateStatistic();
            }
            else MessageBox.Show("Wystąpił niespodziewany błąd. Niepoprawne wejście do funkcji.");
          
        }

        private void CleanAllLIst()
        {
            qstList.Clear();
            showMov.Clear();
            qstMoviesList.Clear();
            nameOfCateg.Clear();
            qstCategoryList.Clear();
                    

        }

        private void MonthStatistic()
        {
            int howManySalesTicket = 0;
            int howManyDifferentMoviesInMonth = 0;
            int howManyDisplay = 0;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                // wszystkie bilety sprzedane w tym miesiącu
                var allSalesTicket_Transaction = (from t in ctx.Transations
                                                  where t.transationDate.Year == year
                                                  && t.transationDate.Month == month
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
                                           && k.dateStart.Month == month
                                           select k).Count();

                howManyDisplay += allShowsInThisMonth;


                // ile rónych filmów było granych w tym miesiacu
                var allTicket = (from t in ctx.Shows
                                 where t.dateStart.Year == year
                                 && t.dateStart.Month == month
                                 group t by t.movieID into g
                                 select g).Count();

                howManyDifferentMoviesInMonth = allTicket;


               
                //lista filmów realizowanych w tym miesiacu
                var listOfMovies = (from t in ctx.Shows
                                    where t.dateStart.Year == year
                                    && t.dateStart.Month == month
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
                    else
                    { }

                }
            
                // lista ilości sprzedanych biletów na konkretny film
                var cos = (from t in ctx.Transations
                           join ts in ctx.TicketSales
                           on t.transationID equals ts.transationID
                           where t.transationDate.Month == month
                           && t.transationDate.Year == year
                           select new { n1 = t.showID, n2 = ts.amount });


              
                
                foreach (var ticketSalesInTransactions in cos)
                {
                    if (qstList.Count() == 0)
                    {
                        qstList.Add(new QuantityOfSalesTicket() { ShowIDQ = (int)ticketSalesInTransactions.n1, SalesTicket = (int)ticketSalesInTransactions.n2 });
                    }
                    else
                    {
                        // sprawdzam, czy na liście istnieje już element z showID
                        // if(qstList.Find(x => x.ShowIDQ.Contains(ticketSalesInTransactions.n1)))
                        if (qstList.Exists(x => x.ShowIDQ == ticketSalesInTransactions.n1))
                        {
                            var firstObject = qstList.FirstOrDefault(x => x.ShowIDQ == (int)ticketSalesInTransactions.n1);
                            firstObject.SalesTicket += (int)ticketSalesInTransactions.n2;
                        }
                        else qstList.Add(new QuantityOfSalesTicket() { ShowIDQ = (int)ticketSalesInTransactions.n1, SalesTicket = (int)ticketSalesInTransactions.n2 });

                    }
                }
                foreach (var listOfMov in uniqueMovieID)
                {

                    qstMoviesList.Add(new QuantityOfSalesTicketOneMovie() { MovieIDQ = (int)listOfMov, MovieNameQ = "", SalesTicketQ = 0, Category="" });
                }




                foreach (var u1 in uniqueMovieID)
                {
                    var MovieTitle = (from m in ctx.Movies
                                      select new { m.movieID, m.title ,m.category});
                    foreach (var u2 in MovieTitle)
                    {
                        if (qstMoviesList.Exists(x => x.MovieIDQ == u2.movieID))
                        {

                            var findObject2 = qstMoviesList.FirstOrDefault(y => y.MovieIDQ == (int)u2.movieID);
                            findObject2.MovieNameQ = (string)u2.title;
                            findObject2.Category = (string)u2.category;
                        }


                    }

                }

                 var show = (from s in ctx.Shows
                            select new { s.showID, s.movieID });

                foreach (var u2 in show)
                {
                    if (qstMoviesList.Exists(x => x.MovieIDQ == u2.movieID))
                    {
                        showMov.Add(new ShowMovie() { MovieID = u2.movieID, ShowID = u2.showID });
                    }

                }

                foreach (var u3 in showMov)
                {
                    var firstObject = qstMoviesList.FirstOrDefault(x => x.MovieIDQ == (int)u3.MovieID);
                    var show_account = qstList.FirstOrDefault(y => y.ShowIDQ == (int)u3.ShowID);
                    if (show_account != null)
                        firstObject.SalesTicketQ += (int)show_account.SalesTicket;
                }


              // najczęściej kupowany typ filmu
                   int mv = qstMoviesList.Max(r => (int)r.SalesTicketQ);
                var findObj = qstMoviesList.FirstOrDefault(f => f.SalesTicketQ == (int)mv);
                
                   var theBetCategory = (from m in ctx.Movies
                               where m.movieID==findObj.MovieIDQ
                               select new { m }).Single();

                   var categ = (from c in ctx.Movies
                                select c.category);
                   nameOfCateg = categ.Distinct().ToList();

                   foreach (var u4 in nameOfCateg)
                   {
                       qstCategoryList.Add(new QuantityOfSalesTicketTypeOfMovie() { typeOfMovie = u4, quantityTicket = 0 });
                   }
               
                foreach(var u5 in qstMoviesList)
                {
                    if(qstCategoryList.Exists(x => x.typeOfMovie==u5.Category))
                    {
                        var findObject3 = qstCategoryList.FirstOrDefault(t => t.typeOfMovie==(string)u5.Category);
                            findObject3.quantityTicket+=(int)u5.SalesTicketQ;
                    }
                    else MessageBox.Show("Wysląpił nieoczekiwany błąd w działaniu programu.");

                }


                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManySalesTicket.ToString(), }, 1, 0);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplay.ToString(), }, 1, 1);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDifferentMoviesInMonth.ToString(), }, 1, 2);
                MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = theBetCategory.m.category.ToString(), }, 1, 3);

                DisplayChartStatistic2(qstMoviesList);
                DisplayChartStatistic_typefMovie(qstCategoryList);
            }
        }

        private void DateStatistic()
        {
            DateTime dtStart = this.From_dateTimePicker.Value.Date;
            DateTime dtStop = this.To_dateTimePicker.Value.Date;
            int howManySalesTicket = 0;
            int howManyDifferentMoviesInMonth = 0;
            int howManyDisplay = 0;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                // wszystkie bilety sprzedane w tym miesiącu
                var allSalesTicket_Transaction = (from t in ctx.Transations
                                                  where t.transationDate > dtStart
                                                  && t.transationDate < dtStop
                                                  select t);
                if (allSalesTicket_Transaction.Count() == 0)
                {
                    MessageBox.Show("W tym czasie nie emitowano żadnych filmów");
                    MonthStatisticChart.Hide();
                    MonthStatisticTypeOfMovieChart.Hide();
                    MovieStatisticAllMovieTableLauotPanel.Refresh();
                }
                else
                {

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
                                               where k.dateStart > dtStart
                                               && k.dateStart < dtStop
                                               select k).Count();
                    howManyDisplay += allShowsInThisMonth;

                    // ile rónych filmów było granych w tym miesiacu
                    var allTicket = (from t in ctx.Shows
                                     where t.dateStart > dtStart
                                              && t.dateStart < dtStop
                                     group t by t.movieID into g
                                     select g).Count();

                    howManyDifferentMoviesInMonth = allTicket;

                    //lista filmów realizowanych w tym miesiacu
                    var listOfMovies = (from t in ctx.Shows
                                        where t.dateStart > dtStart
                                              && t.dateStart < dtStop
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

                    // lista ilości sprzedanych biletów na konkretny film
                    var cos = (from t in ctx.Transations
                               join ts in ctx.TicketSales
                               on t.transationID equals ts.transationID
                               where t.transationDate > dtStart
                               && t.transationDate < dtStop
                               select new { n1 = t.showID, n2 = ts.amount });

                    /*List<QuantityOfSalesTicket> qstList = new List<QuantityOfSalesTicket>();
                    List<ShowMovie> showMov = new List<ShowMovie>();
                    List<QuantityOfSalesTicketOneMovie> qstMoviesList = new List<QuantityOfSalesTicketOneMovie>();
                    List<string> nameOfCateg = new List<string>();
                    List<QuantityOfSalesTicketTypeOfMovie> qstCategoryList = new List<QuantityOfSalesTicketTypeOfMovie>();
                    */
                    foreach (var ticketSalesInTransactions in cos)
                    {
                        if (qstList.Count() == 0)
                        {
                            qstList.Add(new QuantityOfSalesTicket() { ShowIDQ = (int)ticketSalesInTransactions.n1, SalesTicket = (int)ticketSalesInTransactions.n2 });
                        }
                        else
                        {
                            // sprawdzam, czy na liście istnieje już element z showID
                            // if(qstList.Find(x => x.ShowIDQ.Contains(ticketSalesInTransactions.n1)))
                            if (qstList.Exists(x => x.ShowIDQ == ticketSalesInTransactions.n1))
                            {
                                var firstObject = qstList.FirstOrDefault(x => x.ShowIDQ == (int)ticketSalesInTransactions.n1);
                                firstObject.SalesTicket += (int)ticketSalesInTransactions.n2;
                            }
                            else qstList.Add(new QuantityOfSalesTicket() { ShowIDQ = (int)ticketSalesInTransactions.n1, SalesTicket = (int)ticketSalesInTransactions.n2 });
                        }
                    }
                    foreach (var listOfMov in uniqueMovieID)
                    {
                        qstMoviesList.Add(new QuantityOfSalesTicketOneMovie() { MovieIDQ = (int)listOfMov, MovieNameQ = "", SalesTicketQ = 0, Category = "" });
                    }

                    foreach (var u1 in uniqueMovieID)
                    {
                        var MovieTitle = (from m in ctx.Movies
                                          select new { m.movieID, m.title, m.category });
                        foreach (var u2 in MovieTitle)
                        {
                            if (qstMoviesList.Exists(x => x.MovieIDQ == u2.movieID))
                            {
                                var findObject2 = qstMoviesList.FirstOrDefault(y => y.MovieIDQ == (int)u2.movieID);
                                findObject2.MovieNameQ = (string)u2.title;
                                findObject2.Category = (string)u2.category;
                            }
                        }
                    }

                    var show = (from s in ctx.Shows
                                select new { s.showID, s.movieID });

                    foreach (var u2 in show)
                    {
                        if (qstMoviesList.Exists(x => x.MovieIDQ == u2.movieID))
                        {
                            showMov.Add(new ShowMovie() { MovieID = u2.movieID, ShowID = u2.showID });
                        }

                    }

                    foreach (var u3 in showMov)
                    {
                        var firstObject = qstMoviesList.FirstOrDefault(x => x.MovieIDQ == (int)u3.MovieID);
                        var show_account = qstList.FirstOrDefault(y => y.ShowIDQ == (int)u3.ShowID);
                        if (show_account != null)
                            firstObject.SalesTicketQ += (int)show_account.SalesTicket;
                    }


                    // najczęściej kupowany typ filmu
                    int mv = qstMoviesList.Max(r => (int)r.SalesTicketQ);
                    var findObj = qstMoviesList.FirstOrDefault(f => f.SalesTicketQ == (int)mv);

                    var theBetCategory = (from m in ctx.Movies
                                          where m.movieID == findObj.MovieIDQ
                                          select new { m }).Single();

                    var categ = (from c in ctx.Movies
                                 select c.category);
                    nameOfCateg = categ.Distinct().ToList();

                    foreach (var u4 in nameOfCateg)
                    {
                        qstCategoryList.Add(new QuantityOfSalesTicketTypeOfMovie() { typeOfMovie = u4, quantityTicket = 0 });
                    }

                    foreach (var u5 in qstMoviesList)
                    {
                        if (qstCategoryList.Exists(x => x.typeOfMovie == u5.Category))
                        {
                            var findObject3 = qstCategoryList.FirstOrDefault(t => t.typeOfMovie == (string)u5.Category);
                            findObject3.quantityTicket += (int)u5.SalesTicketQ;
                        }
                        else MessageBox.Show("Wystąpił nieoczekiwany błąd w działaniu programu.");

                    }


                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManySalesTicket.ToString(), }, 1, 0);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDisplay.ToString(), }, 1, 1);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = howManyDifferentMoviesInMonth.ToString(), }, 1, 2);
                    MovieStatisticAllMovieTableLauotPanel.Controls.Add(new Label() { Text = theBetCategory.m.category.ToString(), }, 1, 3);

                    DisplayChartStatistic2(qstMoviesList);
                    DisplayChartStatistic_typefMovie(qstCategoryList);
            
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //statystyki miesięczne 
            month = lastMonts;
            monthClicked = true;
            dateClicked = false;
            Statistic();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MovieStatisticAllMovieTableLauotPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // statystyki tygodniowe
            dateClicked = true;
            monthClicked = false;
            Statistic();
        }

        private void DisplayStatisticOfFilm_Click(object sender, EventArgs e)
        {
           
            dateClicked = true;
            monthClicked = false;
            Statistic();
        }

        private void thisMothButton_Click(object sender, EventArgs e)
        {
            month = thisMonth;
            dateClicked = false;
            monthClicked = true;
            Statistic();
        }

    }
}