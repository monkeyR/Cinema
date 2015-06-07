namespace CinemaManager.SubPages
{
    partial class MovieListElement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieListElement));
            this.titleLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.expireMovieButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(100, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tytuł";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DirectorLabel.ForeColor = System.Drawing.Color.White;
            this.DirectorLabel.Location = new System.Drawing.Point(130, 45);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(68, 17);
            this.DirectorLabel.TabIndex = 2;
            this.DirectorLabel.Text = "Reżyser: ";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.durationLabel.ForeColor = System.Drawing.Color.White;
            this.durationLabel.Location = new System.Drawing.Point(102, 62);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(96, 17);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Czas trwania: ";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(5, 116);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.Size = new System.Drawing.Size(538, 126);
            this.descriptionTextbox.TabIndex = 4;
            this.descriptionTextbox.Text = resources.GetString("descriptionTextbox.Text");
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(149, 79);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 17);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Cena: ";
            // 
            // expireMovieButton
            // 
            this.expireMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.expireMovieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.expireMovieButton.ForeColor = System.Drawing.Color.White;
            this.expireMovieButton.Location = new System.Drawing.Point(6, 41);
            this.expireMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.expireMovieButton.Name = "expireMovieButton";
            this.expireMovieButton.Size = new System.Drawing.Size(89, 33);
            this.expireMovieButton.TabIndex = 35;
            this.expireMovieButton.Text = "Zdejmij";
            this.expireMovieButton.UseVisualStyleBackColor = false;
            this.expireMovieButton.Click += new System.EventHandler(this.expireMovieButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(6, 4);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(89, 33);
            this.editButton.TabIndex = 36;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(121, 96);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 37;
            this.categoryLabel.Text = "Kategoria: ";
            // 
            // MovieListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.expireMovieButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Name = "MovieListElement";
            this.Size = new System.Drawing.Size(546, 252);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button expireMovieButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label categoryLabel;
    }
}
