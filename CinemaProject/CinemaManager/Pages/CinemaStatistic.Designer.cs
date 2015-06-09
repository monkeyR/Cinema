﻿namespace CinemaManager.Pages
{
    partial class CinemaStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MovieStatisticPropertisPanel = new System.Windows.Forms.Panel();
            this.thisMothButton = new System.Windows.Forms.Button();
            this.DisplayStatisticOfFilm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastMonthStatistic = new System.Windows.Forms.Button();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MovieStaisticDisplayPanel = new System.Windows.Forms.Panel();
            this.TicketStatisticTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MonthStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthStatisticTypeOfMovieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InfoAboutParametrOfStatisticLabel = new System.Windows.Forms.Label();
            this.MovieStatisticAllMovieTableLauotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MovieStatisticPropertisPanel.SuspendLayout();
            this.MovieStaisticDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticTypeOfMovieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieStatisticPropertisPanel
            // 
            this.MovieStatisticPropertisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(165)))));
            this.MovieStatisticPropertisPanel.Controls.Add(this.thisMothButton);
            this.MovieStatisticPropertisPanel.Controls.Add(this.DisplayStatisticOfFilm);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label2);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label1);
            this.MovieStatisticPropertisPanel.Controls.Add(this.LastMonthStatistic);
            this.MovieStatisticPropertisPanel.Controls.Add(this.To_dateTimePicker);
            this.MovieStatisticPropertisPanel.Controls.Add(this.From_dateTimePicker);
            this.MovieStatisticPropertisPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieStatisticPropertisPanel.Location = new System.Drawing.Point(0, 0);
            this.MovieStatisticPropertisPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovieStatisticPropertisPanel.Name = "MovieStatisticPropertisPanel";
            this.MovieStatisticPropertisPanel.Size = new System.Drawing.Size(694, 72);
            this.MovieStatisticPropertisPanel.TabIndex = 9;
            // 
            // thisMothButton
            // 
            this.thisMothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.thisMothButton.FlatAppearance.BorderSize = 0;
            this.thisMothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisMothButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.thisMothButton.ForeColor = System.Drawing.Color.White;
            this.thisMothButton.Location = new System.Drawing.Point(88, 7);
            this.thisMothButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thisMothButton.Name = "thisMothButton";
            this.thisMothButton.Size = new System.Drawing.Size(80, 63);
            this.thisMothButton.TabIndex = 6;
            this.thisMothButton.Text = "Aktualny miesiąc";
            this.thisMothButton.UseVisualStyleBackColor = false;
            this.thisMothButton.Click += new System.EventHandler(this.thisMothButton_Click);
            // 
            // DisplayStatisticOfFilm
            // 
            this.DisplayStatisticOfFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.DisplayStatisticOfFilm.FlatAppearance.BorderSize = 0;
            this.DisplayStatisticOfFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayStatisticOfFilm.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.DisplayStatisticOfFilm.ForeColor = System.Drawing.Color.White;
            this.DisplayStatisticOfFilm.Location = new System.Drawing.Point(172, 44);
            this.DisplayStatisticOfFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayStatisticOfFilm.Name = "DisplayStatisticOfFilm";
            this.DisplayStatisticOfFilm.Size = new System.Drawing.Size(275, 26);
            this.DisplayStatisticOfFilm.TabIndex = 1;
            this.DisplayStatisticOfFilm.Text = "Wyswietl statystyki z tego okresu";
            this.DisplayStatisticOfFilm.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz przedział czasowy:";
            // 
            // LastMonthStatistic
            // 
            this.LastMonthStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.LastMonthStatistic.FlatAppearance.BorderSize = 0;
            this.LastMonthStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastMonthStatistic.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.LastMonthStatistic.ForeColor = System.Drawing.Color.White;
            this.LastMonthStatistic.Location = new System.Drawing.Point(7, 7);
            this.LastMonthStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.LastMonthStatistic.Name = "LastMonthStatistic";
            this.LastMonthStatistic.Size = new System.Drawing.Size(79, 63);
            this.LastMonthStatistic.TabIndex = 0;
            this.LastMonthStatistic.Text = "Ostatni miesiąc";
            this.LastMonthStatistic.UseVisualStyleBackColor = false;
            this.LastMonthStatistic.Click += new System.EventHandler(this.LastMonthStatistic_Click);
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Location = new System.Drawing.Point(320, 21);
            this.To_dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.To_dateTimePicker.TabIndex = 3;
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Location = new System.Drawing.Point(172, 21);
            this.From_dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.From_dateTimePicker.TabIndex = 2;
            // 
            // MovieStaisticDisplayPanel
            // 
            this.MovieStaisticDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(205)))));
            this.MovieStaisticDisplayPanel.Controls.Add(this.TicketStatisticTableLayoutPanel);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MonthStatisticChart);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MonthStatisticTypeOfMovieChart);
            this.MovieStaisticDisplayPanel.Controls.Add(this.InfoAboutParametrOfStatisticLabel);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MovieStatisticAllMovieTableLauotPanel);
            this.MovieStaisticDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieStaisticDisplayPanel.Location = new System.Drawing.Point(0, 72);
            this.MovieStaisticDisplayPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovieStaisticDisplayPanel.Name = "MovieStaisticDisplayPanel";
            this.MovieStaisticDisplayPanel.Size = new System.Drawing.Size(694, 335);
            this.MovieStaisticDisplayPanel.TabIndex = 10;
            // 
            // TicketStatisticTableLayoutPanel
            // 
            this.TicketStatisticTableLayoutPanel.ColumnCount = 1;
            this.TicketStatisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicketStatisticTableLayoutPanel.Location = new System.Drawing.Point(256, 30);
            this.TicketStatisticTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TicketStatisticTableLayoutPanel.Name = "TicketStatisticTableLayoutPanel";
            this.TicketStatisticTableLayoutPanel.RowCount = 1;
            this.TicketStatisticTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicketStatisticTableLayoutPanel.Size = new System.Drawing.Size(236, 67);
            this.TicketStatisticTableLayoutPanel.TabIndex = 4;
            // 
            // MonthStatisticChart
            // 
            chartArea9.Name = "ChartArea1";
            this.MonthStatisticChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.MonthStatisticChart.Legends.Add(legend9);
            this.MonthStatisticChart.Location = new System.Drawing.Point(6, 102);
            this.MonthStatisticChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthStatisticChart.Name = "MonthStatisticChart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.MonthStatisticChart.Series.Add(series9);
            this.MonthStatisticChart.Size = new System.Drawing.Size(238, 219);
            this.MonthStatisticChart.TabIndex = 2;
            this.MonthStatisticChart.Text = "chart1";
            // 
            // MonthStatisticTypeOfMovieChart
            // 
            chartArea10.Name = "ChartArea1";
            this.MonthStatisticTypeOfMovieChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.MonthStatisticTypeOfMovieChart.Legends.Add(legend10);
            this.MonthStatisticTypeOfMovieChart.Location = new System.Drawing.Point(256, 102);
            this.MonthStatisticTypeOfMovieChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthStatisticTypeOfMovieChart.Name = "MonthStatisticTypeOfMovieChart";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.MonthStatisticTypeOfMovieChart.Series.Add(series10);
            this.MonthStatisticTypeOfMovieChart.Size = new System.Drawing.Size(236, 216);
            this.MonthStatisticTypeOfMovieChart.TabIndex = 3;
            this.MonthStatisticTypeOfMovieChart.Text = "chart1";
            // 
            // InfoAboutParametrOfStatisticLabel
            // 
            this.InfoAboutParametrOfStatisticLabel.AutoSize = true;
            this.InfoAboutParametrOfStatisticLabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.InfoAboutParametrOfStatisticLabel.ForeColor = System.Drawing.Color.White;
            this.InfoAboutParametrOfStatisticLabel.Location = new System.Drawing.Point(4, 12);
            this.InfoAboutParametrOfStatisticLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoAboutParametrOfStatisticLabel.Name = "InfoAboutParametrOfStatisticLabel";
            this.InfoAboutParametrOfStatisticLabel.Size = new System.Drawing.Size(182, 16);
            this.InfoAboutParametrOfStatisticLabel.TabIndex = 2;
            this.InfoAboutParametrOfStatisticLabel.Text = "Statystyki z ostatniego miesiąca: ";
            // 
            // MovieStatisticAllMovieTableLauotPanel
            // 
            this.MovieStatisticAllMovieTableLauotPanel.ColumnCount = 4;
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Location = new System.Drawing.Point(7, 30);
            this.MovieStatisticAllMovieTableLauotPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MovieStatisticAllMovieTableLauotPanel.Name = "MovieStatisticAllMovieTableLauotPanel";
            this.MovieStatisticAllMovieTableLauotPanel.RowCount = 2;
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Size = new System.Drawing.Size(238, 67);
            this.MovieStatisticAllMovieTableLauotPanel.TabIndex = 0;
            // 
            // CinemaStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 407);
            this.Controls.Add(this.MovieStaisticDisplayPanel);
            this.Controls.Add(this.MovieStatisticPropertisPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CinemaStatistic";
            this.Text = "Statystyki sprzedaży";
            this.MovieStatisticPropertisPanel.ResumeLayout(false);
            this.MovieStatisticPropertisPanel.PerformLayout();
            this.MovieStaisticDisplayPanel.ResumeLayout(false);
            this.MovieStaisticDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticTypeOfMovieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MovieStatisticPropertisPanel;
        private System.Windows.Forms.Button thisMothButton;
        private System.Windows.Forms.Button DisplayStatisticOfFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LastMonthStatistic;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Panel MovieStaisticDisplayPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthStatisticTypeOfMovieChart;
        private System.Windows.Forms.Label InfoAboutParametrOfStatisticLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthStatisticChart;
        private System.Windows.Forms.TableLayoutPanel MovieStatisticAllMovieTableLauotPanel;
        private System.Windows.Forms.TableLayoutPanel TicketStatisticTableLayoutPanel;
    }
}