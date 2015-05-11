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

namespace CinemaDisplay.Main
{
    public partial class MainFormDisplay : Form
    {
        private DateTime dateTime = DateTime.Now;

        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                askForLeaving();
        }

        private void askForLeaving()
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
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
    }
}
