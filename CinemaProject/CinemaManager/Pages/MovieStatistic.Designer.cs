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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MovieStaisticDisplayPanel = new System.Windows.Forms.Panel();
            this.MonthStatisticTypeOfMovieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InfoAboutParametrOfStatisticLabel = new System.Windows.Forms.Label();
            this.MovieStatisticAllMovieTableLauotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayStatisticOfFilm = new System.Windows.Forms.Button();
            this.MovieStatisticPropertisPanel = new System.Windows.Forms.Panel();
            this.thisMothButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastMonthStatistic = new System.Windows.Forms.Button();
            this.MonthStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MovieStaisticDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticTypeOfMovieChart)).BeginInit();
            this.MovieStatisticPropertisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Location = new System.Drawing.Point(168, 24);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.From_dateTimePicker.TabIndex = 2;
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Location = new System.Drawing.Point(365, 24);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(170, 22);
            this.To_dateTimePicker.TabIndex = 3;
            // 
            // MovieStaisticDisplayPanel
            // 
            this.MovieStaisticDisplayPanel.Controls.Add(this.MonthStatisticTypeOfMovieChart);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MonthStatisticChart);
            this.MovieStaisticDisplayPanel.Controls.Add(this.InfoAboutParametrOfStatisticLabel);
            this.MovieStaisticDisplayPanel.Controls.Add(this.MovieStatisticAllMovieTableLauotPanel);
            this.MovieStaisticDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieStaisticDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.MovieStaisticDisplayPanel.Name = "MovieStaisticDisplayPanel";
            this.MovieStaisticDisplayPanel.Size = new System.Drawing.Size(1129, 669);
            this.MovieStaisticDisplayPanel.TabIndex = 7;
            this.MovieStaisticDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovieStaisticDisplayPanel_Paint);
            // 
            // MonthStatisticTypeOfMovieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MonthStatisticTypeOfMovieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MonthStatisticTypeOfMovieChart.Legends.Add(legend1);
            this.MonthStatisticTypeOfMovieChart.Location = new System.Drawing.Point(574, 315);
            this.MonthStatisticTypeOfMovieChart.Name = "MonthStatisticTypeOfMovieChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MonthStatisticTypeOfMovieChart.Series.Add(series1);
            this.MonthStatisticTypeOfMovieChart.Size = new System.Drawing.Size(550, 339);
            this.MonthStatisticTypeOfMovieChart.TabIndex = 3;
            this.MonthStatisticTypeOfMovieChart.Text = "chart1";
            // 
            // InfoAboutParametrOfStatisticLabel
            // 
            this.InfoAboutParametrOfStatisticLabel.AutoSize = true;
            this.InfoAboutParametrOfStatisticLabel.Location = new System.Drawing.Point(15, 96);
            this.InfoAboutParametrOfStatisticLabel.Name = "InfoAboutParametrOfStatisticLabel";
            this.InfoAboutParametrOfStatisticLabel.Size = new System.Drawing.Size(216, 17);
            this.InfoAboutParametrOfStatisticLabel.TabIndex = 2;
            this.InfoAboutParametrOfStatisticLabel.Text = "Statystyki z ostatniego miesiąca: ";
            this.InfoAboutParametrOfStatisticLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // MovieStatisticAllMovieTableLauotPanel
            // 
            this.MovieStatisticAllMovieTableLauotPanel.AutoScroll = true;
            this.MovieStatisticAllMovieTableLauotPanel.AutoSize = true;
            this.MovieStatisticAllMovieTableLauotPanel.ColumnCount = 4;
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MovieStatisticAllMovieTableLauotPanel.Location = new System.Drawing.Point(12, 119);
            this.MovieStatisticAllMovieTableLauotPanel.Name = "MovieStatisticAllMovieTableLauotPanel";
            this.MovieStatisticAllMovieTableLauotPanel.RowCount = 2;
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MovieStatisticAllMovieTableLauotPanel.Size = new System.Drawing.Size(0, 0);
            this.MovieStatisticAllMovieTableLauotPanel.TabIndex = 0;
            this.MovieStatisticAllMovieTableLauotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovieStatisticAllMovieTableLauotPanel_Paint);
            // 
            // DisplayStatisticOfFilm
            // 
            this.DisplayStatisticOfFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.DisplayStatisticOfFilm.ForeColor = System.Drawing.Color.White;
            this.DisplayStatisticOfFilm.Location = new System.Drawing.Point(168, 52);
            this.DisplayStatisticOfFilm.Name = "DisplayStatisticOfFilm";
            this.DisplayStatisticOfFilm.Size = new System.Drawing.Size(367, 32);
            this.DisplayStatisticOfFilm.TabIndex = 1;
            this.DisplayStatisticOfFilm.Text = "Wyswietl statystyki z tego okresu";
            this.DisplayStatisticOfFilm.UseVisualStyleBackColor = false;
            this.DisplayStatisticOfFilm.Click += new System.EventHandler(this.DisplayStatisticOfFilm_Click);
            // 
            // MovieStatisticPropertisPanel
            // 
            this.MovieStatisticPropertisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.MovieStatisticPropertisPanel.Controls.Add(this.thisMothButton);
            this.MovieStatisticPropertisPanel.Controls.Add(this.DisplayStatisticOfFilm);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label2);
            this.MovieStatisticPropertisPanel.Controls.Add(this.label1);
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
            this.thisMothButton.Location = new System.Drawing.Point(87, 9);
            this.thisMothButton.Name = "thisMothButton";
            this.thisMothButton.Size = new System.Drawing.Size(75, 77);
            this.thisMothButton.TabIndex = 6;
            this.thisMothButton.Text = "Aktualny miesiąc";
            this.thisMothButton.UseVisualStyleBackColor = false;
            this.thisMothButton.Click += new System.EventHandler(this.thisMothButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz przedział czasowy:";
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
            // MonthStatisticChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MonthStatisticChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MonthStatisticChart.Legends.Add(legend2);
            this.MonthStatisticChart.Location = new System.Drawing.Point(18, 315);
            this.MonthStatisticChart.Name = "MonthStatisticChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.MonthStatisticChart.Series.Add(series2);
            this.MonthStatisticChart.Size = new System.Drawing.Size(550, 339);
            this.MonthStatisticChart.TabIndex = 3;
            this.MonthStatisticChart.Text = "chart1";
            // 
            // MovieStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1129, 669);
            this.Controls.Add(this.MovieStatisticPropertisPanel);
            this.Controls.Add(this.MovieStaisticDisplayPanel);
            this.Name = "MovieStatistic";
            this.Text = "Statystyki filmów";
            this.MovieStaisticDisplayPanel.ResumeLayout(false);
            this.MovieStaisticDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticTypeOfMovieChart)).EndInit();
            this.MovieStatisticPropertisPanel.ResumeLayout(false);
            this.MovieStatisticPropertisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthStatisticChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.Panel MovieStaisticDisplayPanel;
        private System.Windows.Forms.Panel MovieStatisticPropertisPanel;
        private System.Windows.Forms.Button DisplayStatisticOfFilm;
        private System.Windows.Forms.Button LastMonthStatistic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thisMothButton;
        private System.Windows.Forms.Label InfoAboutParametrOfStatisticLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthStatisticTypeOfMovieChart;
        private System.Windows.Forms.TableLayoutPanel MovieStatisticAllMovieTableLauotPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthStatisticChart;
    }
}