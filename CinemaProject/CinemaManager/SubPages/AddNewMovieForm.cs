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
        bool alreadyFocused;

        public AddNewMovieForm()
        {
            InitializeComponent();
            grTextbox.GotFocus += grTextbox_GotFocus;
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
                        decimal moviePrice = Convert.ToDecimal(string.Format("{0},{1}", zlTextbox.Text, grTextbox.Text));
                        bool allowTransaction = false;

                        if (moviePrice == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Czy chcesz wprowadzić darmowe bilety?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                allowTransaction = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Dodawanie filmu wycofano", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            allowTransaction = true;
                        }
                        if (allowTransaction)
                        {
                            CinemaModel.Movies newMovie = new CinemaModel.Movies();
                            newMovie.title = titleTextbox.Text;
                            newMovie.price = moviePrice;
                            newMovie.director = directorTextbox.Text;
                            newMovie.description = descriptionTextbox.Text;
                            newMovie.duration = Convert.ToInt32(durationNumericUpDown.Value);
                            newMovie.isAvailable = true;
                            newMovie.category = categoryTextbox.Text;

                            ctx.Movies.Add(newMovie);
                            ctx.SaveChanges();

                            this.Close();
                        }
                     
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Błędny format ceny", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Pozostawiono puste pole", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private bool isAnyEmpty()
        {
            if (titleTextbox.Text == string.Empty ||
                zlTextbox.Text == string.Empty ||
                directorTextbox.Text == string.Empty ||
                durationNumericUpDown.Value == 0 ||
                categoryTextbox.Text == string.Empty)
                return true;
            return false;
        }        

        private void grTextbox_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.grTextbox.SelectAll();
                alreadyFocused = true;
            }
        }

        private void grTextbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && this.grTextbox.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.grTextbox.SelectAll();
            }
        }

        private void grTextbox_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
        }

        private void durationNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }
    }
}
