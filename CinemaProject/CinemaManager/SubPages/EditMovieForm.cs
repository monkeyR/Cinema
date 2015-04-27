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
    public partial class EditMovieForm : Form
    {
        CinemaModel.Movies movie;

        bool alreadyFocused;

        public EditMovieForm(CinemaModel.Movies movie)
        {
            InitializeComponent();

            this.movie = movie;

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
            insertMovieData();
        }

        private void insertMovieData()
        {
            Common.UISynchronizer.synchronizeWithUI(titleTextbox, x => titleTextbox.Text = x, movie.title);
            Common.UISynchronizer.synchronizeWithUI(directorTextbox, x => directorTextbox.Text = x, movie.director);
            Common.UISynchronizer.synchronizeWithUI(zlTextbox, x => zlTextbox.Text = x, getPrice(movie.price, true).ToString());
            Common.UISynchronizer.synchronizeWithUI(grTextbox, x => grTextbox.Text = x, getPrice(movie.price, false).ToString());
            Common.UISynchronizer.synchronizeWithUI(durationNumericUpDown, x => durationNumericUpDown.Value = x, movie.duration);
            Common.UISynchronizer.synchronizeWithUI(descriptionTextbox, x => descriptionTextbox.Text = x, movie.description);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isAnyChanged())
                {
                    MessageBox.Show("Brak zmian do zapisania", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (isAnyEmpty())
                    {
                        MessageBox.Show("Pozostało puste pole", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        Int16 zl = Convert.ToInt16(zlTextbox.Text);
                        Byte gr = Convert.ToByte(grTextbox.Text);
                        decimal price = Convert.ToDecimal(string.Format("{0},{1}", zl, gr));

                        movie.title = titleTextbox.Text;
                        movie.director = directorTextbox.Text;
                        movie.price = price;
                        movie.duration = Convert.ToInt32(durationNumericUpDown.Value);
                        movie.description = descriptionTextbox.Text;

                        using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                        {
                            ctx.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                            ctx.SaveChanges();
                        }

                        Cursor.Current = Cursors.Default;

                        this.Close();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadziłeś złą liczbę", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isAnyEmpty()
        {
            if (titleTextbox.Text == string.Empty ||
                zlTextbox.Text == string.Empty ||
                directorTextbox.Text == string.Empty ||
                durationNumericUpDown.Value == 0)
                return true;
            return false;
        }

        private bool isAnyChanged()
        {
            if (movie.title == titleTextbox.Text &&
                    movie.director == directorTextbox.Text &&
                    getPrice(movie.price, true) == Convert.ToDecimal(zlTextbox.Text) &&
                    getPrice(movie.price, false) == Convert.ToDecimal(grTextbox.Text) &&
                    movie.duration == Convert.ToInt32(durationNumericUpDown.Value) &&
                    movie.description == descriptionTextbox.Text)
                return false;
            return true;
        }

        private decimal getPrice(decimal price, bool zl)
        {
            if (zl)
            {
                string zloty = string.Format("{0:0}", price);
                return Convert.ToDecimal(zloty);
            }
            else
            {
                string grosz = price.ToString();
                grosz = grosz.Substring(grosz.Length - 4, 2);
                return Convert.ToDecimal(grosz);
            }
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
