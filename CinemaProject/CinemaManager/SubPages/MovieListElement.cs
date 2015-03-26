﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.SubPages
{
    public partial class MovieListElement : UserControl
    {


        public MovieListElement(CinemaModel.Movies movie)
        {
            InitializeComponent();

            Common.UISynchronizer.synchronizeWithUI(descriptionTextbox, x => descriptionTextbox.ScrollBars = x, ScrollBars.Vertical);

            setControls(movie);

        }

        private void setControls(CinemaModel.Movies movie)
        {
            Common.UISynchronizer.synchronizeWithUI(this.titleLabel, x => this.titleLabel.Text = x, movie.title);
            Common.UISynchronizer.synchronizeWithUI(this.DirectorLabel, x => this.DirectorLabel.Text += x, movie.director);
            Common.UISynchronizer.synchronizeWithUI(this.durationLabel, x => this.durationLabel.Text += string.Format("{0:0} min.", x), movie.duration);
            Common.UISynchronizer.synchronizeWithUI(this.descriptionTextbox, x => this.descriptionTextbox.Text = x, movie.description);
            Common.UISynchronizer.synchronizeWithUI(this.priceLabel, x => this.priceLabel.Text += string.Format("{0:0.00} zł", x), movie.price);
            Common.UISynchronizer.synchronizeWithUI(editButton, x => editButton.Tag = x, movie);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //int movieID = Convert.ToInt32(button.Tag);

            EditMovieForm form = new EditMovieForm((CinemaModel.Movies)button.Tag);
            form.ShowDialog();
        }
    }
}
