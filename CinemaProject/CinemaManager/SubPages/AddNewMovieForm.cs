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
    public partial class AddNewMovieForm : Form
    {
        public AddNewMovieForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!isAnyEmpty())
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    try
                    {
                        CinemaModel.Movies newMovie = new CinemaModel.Movies();

                        newMovie.title = titleTextbox.Text;
                        newMovie.price = Convert.ToDecimal(priceTextbox.Text);
                        newMovie.director = directorTextbox.Text;
                        newMovie.description = descriptionTextbox.Text;
                        newMovie.duration = Convert.ToInt32(durationNumericUpDown.Value);

                        ctx.Movies.Add(newMovie);
                        ctx.SaveChanges();                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Błędny format ceny", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Pozostawiono puste pole", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private bool isAnyEmpty()
        {
            if (titleTextbox.Text == string.Empty ||
                priceTextbox.Text == string.Empty ||
                directorTextbox.Text == string.Empty ||
                durationNumericUpDown.Value == 0)
                return true;
            return false;
        }
    }
}
