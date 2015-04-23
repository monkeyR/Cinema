using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Utils;

namespace CinemaManager.SubPages
{
    public partial class RemoveShowForm : Form
    {
        private static String dateFormat = "HH:mm - MMMM dd";

        private ShowModel model;
        private Action<CinemaModel.Halls> onShowRemoved;
        public RemoveShowForm(ShowModel model, Action<CinemaModel.Halls> onShowRemoved)
        {
            this.model = model;
            this.onShowRemoved = onShowRemoved;
            InitializeComponent();
            setupData();
        }
        
        private void setupData()
        {
            this.titleLabel.Text = model.movieTitle;
            this.dateStartLabel.Text = model.show.dateStart.ToString(dateFormat);
            this.dateEndLabel.Text = model.show.dateEnd.ToString(dateFormat);
            this.hallNumberLabel.Text = model.hall.number.ToString();
            this.hallNameLabel.Text = model.hall.title;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                try
                {
                    CinemaModel.Shows show = 
                        (from s in ctx.Shows
                         where model.show.showID == s.showID
                         select s).FirstOrDefault();
                    ctx.Shows.Remove(show);
                    ctx.SaveChanges();
                    onShowRemoved(model.hall);
                }
                catch(Exception ex)
                {
                    showError(ex);
                }
            }
            this.Close();
        }

        private void showError(Exception ex)
        {
            String message = "Wystąpił błąd: " + ex.Message;
            MessageBox.Show(message);
        }     
    }
}
