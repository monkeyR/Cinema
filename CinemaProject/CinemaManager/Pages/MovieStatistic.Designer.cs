namespace CinemaManager.Pages
{
    partial class MovieStatistic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MovieStaisticDisplayPanel = new System.Windows.Forms.Panel();
            this.OneMovieStatistic_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MovieStatisticAllMovieTableLauotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayStatisticOfFilm = new System.Windows.Forms.Button();
            this.MovieStatisticPropertisPanel = new System.Windows.Forms.Panel();
            this.thisMothButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.LastMonthStatistic = new System.Windows.Forms.Button();
            this.MovieStaisticDisplayPanel.SuspendLayout();
            this.MovieStatisticPropertisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Location = new System.Drawing.Point(247, 26);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.From_dateTimePicker.TabIndex = 2;
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Location = new System.Drawing.Point(444, 26);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(170, 22);
            this.To_dateTimePicker.TabIndex = 3;
            // 
            // MovieStaisticDisplayPanel
            // 
            this.MovieStaisticDisplayPanel.Controls.Add(this.OneMovieStatistic_tableLayoutPanel);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MovieStatisticAllMovieTableLauotPanel);
            this.MovieStaisticDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieStaisticDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.MovieStaisticDisplayPanel.Name = "MovieStaisticDisplayPanel";
            this.MovieStaisticDisplayPanel.Size = new System.Drawing.Size(1129, 528);
            this.MovieStaisticDisplayPanel.TabIndex = 7;
            this.MovieStaisticDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovieStaisticDisplayPanel_Paint);
            // 
            // OneMovieStatistic_tableLayoutPanel
            // 
            this.OneMovieStatistic_tableLayoutPanel.ColumnCount = 1;
            this.OneMovieStatistic_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OneMovieStatistic_tableLayoutPanel.Location = new System.Drawing.Point(12, 209);
            this.OneMovieStatistic_tableLayoutPanel.Name = "OneMovieStatistic_tableLayoutPanel";
            this.OneMovieStatistic_tableLayoutPanel.RowCount = 1;
            this.OneMovieStatistic_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OneMovieStatistic_tableLayoutPanel.Size = new System.Drawing.Size(627, 238);
            this.OneMovieStatistic_tableLayoutPanel.TabIndex = 1;
            // 
            // MovieStatisticAllMovieTableLauotPanel
            // 
            this.MovieStatisticAllMovieTableLauotPanel.ColumnCount = 4;
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Location = new System.Drawing.Point(12, 120);
            this.MovieStatisticAllMovieTableLauotPanel.Name = "MovieStatisticAllMovieTableLauotPanel";
            this.MovieStatisticAllMovieTableLauotPanel.RowCount = 2;
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Size = new System.Drawing.Size(627, 83);
            this.MovieStatisticAllMovieTableLauotPanel.TabIndex = 0;
            this.MovieStatisticAllMovieTableLauotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovieStatisticAllMovieTableLauotPanel_Paint);
            // 
            // DisplayStatisticOfFilm
            // 
            this.DisplayStatisticOfFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.DisplayStatisticOfFilm.ForeColor = System.Drawing.Color.White;
            this.DisplayStatisticOfFilm.Location = new System.Drawing.Point(247, 54);
            this.DisplayStatisticOfFilm.Name = "DisplayStatisticOfFilm";
            this.DisplayStatisticOfFilm.Size = new System.Drawing.Size(367, 32);
            this.DisplayStatisticOfFilm.TabIndex = 1;
            this.DisplayStatisticOfFilm.Text = "Wyswietl statystyki z tego okresu";
            this.DisplayStatisticOfFilm.UseVisualStyleBackColor = false;
            // 
            // MovieStatisticPropertisPanel
            // 
            this.MovieStatisticPropertisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.MovieStatisticPropertisPanel.Controls.Add(this.thisMothButton);
            this.MovieStatisticPropertisPanel.Controls.Add(this.DisplayStatisticOfFilm);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label2);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label1);
            this.MovieStatisticPropertisPanel.Controls.Add(this.button2);
            this.MovieStatisticPropertisPanel.Controls.Add(this.LastMonthStatistic);
            this.MovieStatisticPropertisPanel.Controls.Add(this.To_dateTimePicker);
            this.MovieStatisticPropertisPanel.Controls.Add(this.From_dateTimePicker);
            this.MovieStatisticPropertisPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieStatisticPropertisPanel.Location = new System.Drawing.Point(0, 0);
            this.MovieStatisticPropertisPanel.Name = "MovieStatisticPropertisPanel";
            this.MovieStatisticPropertisPanel.Size = new System.Drawing.Size(1129, 89);
            this.MovieStatisticPropertisPanel.TabIndex = 8;
            // 
            // thisMothButton
            // 
            this.thisMothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.thisMothButton.ForeColor = System.Drawing.Color.White;
            this.thisMothButton.Location = new System.Drawing.Point(166, 9);
            this.thisMothButton.Name = "thisMothButton";
            this.thisMothButton.Size = new System.Drawing.Size(75, 77);
            this.thisMothButton.TabIndex = 6;
            this.thisMothButton.Text = "Aktualny miesiąc";
            this.thisMothButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz przedział czasowy:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(87, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ostatni tydzień";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LastMonthStatistic
            // 
            this.LastMonthStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.LastMonthStatistic.FlatAppearance.BorderSize = 0;
            this.LastMonthStatistic.ForeColor = System.Drawing.Color.White;
            this.LastMonthStatistic.Location = new System.Drawing.Point(9, 9);
            this.LastMonthStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.LastMonthStatistic.Name = "LastMonthStatistic";
            this.LastMonthStatistic.Size = new System.Drawing.Size(75, 77);
            this.LastMonthStatistic.TabIndex = 0;
            this.LastMonthStatistic.Text = "Ostatni miesiąc";
            this.LastMonthStatistic.UseVisualStyleBackColor = false;
            this.LastMonthStatistic.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1129, 528);
            this.Controls.Add(this.MovieStatisticPropertisPanel);
            this.Controls.Add(this.MovieStaisticDisplayPanel);
            this.Name = "MovieStatistic";
            this.Text = "Statystyki filmów";
            this.MovieStaisticDisplayPanel.ResumeLayout(false);
            this.MovieStatisticPropertisPanel.ResumeLayout(false);
            this.MovieStatisticPropertisPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.Panel MovieStaisticDisplayPanel;
        private System.Windows.Forms.Panel MovieStatisticPropertisPanel;
        private System.Windows.Forms.Button DisplayStatisticOfFilm;
        private System.Windows.Forms.TableLayoutPanel MovieStatisticAllMovieTableLauotPanel;
        private System.Windows.Forms.Button LastMonthStatistic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel OneMovieStatistic_tableLayoutPanel;
        private System.Windows.Forms.Button thisMothButton;
    }
}