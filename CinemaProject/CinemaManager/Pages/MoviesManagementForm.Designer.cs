namespace CinemaManager.Pages
{
    partial class MoviesManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.expiredMoviesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.expireMovieButton = new System.Windows.Forms.Button();
=======
            this.addMovieButton = new System.Windows.Forms.Button();
>>>>>>> origin/master
            this.label2 = new System.Windows.Forms.Label();
            this.MoviesListflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.expiredMoviesListView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 452);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 225);
            this.panel1.TabIndex = 20;
            // 
            // expiredMoviesListView
            // 
            this.expiredMoviesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expiredMoviesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.expiredMoviesListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expiredMoviesListView.FullRowSelect = true;
            this.expiredMoviesListView.GridLines = true;
            this.expiredMoviesListView.Location = new System.Drawing.Point(9, 61);
            this.expiredMoviesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expiredMoviesListView.MultiSelect = false;
            this.expiredMoviesListView.Name = "expiredMoviesListView";
            this.expiredMoviesListView.Size = new System.Drawing.Size(940, 160);
            this.expiredMoviesListView.TabIndex = 19;
            this.expiredMoviesListView.UseCompatibleStateImageBehavior = false;
            this.expiredMoviesListView.View = System.Windows.Forms.View.Details;
            this.expiredMoviesListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.expiredMoviesListView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tytuł";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reżyser";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Długość";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Opis";
            this.columnHeader10.Width = 349;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista nieaktualnych filmów";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.addMovieButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MoviesListflowLayoutPanel);
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 430);
            this.panel2.TabIndex = 21;
            // 
<<<<<<< HEAD
            // expireMovieButton
            // 
            this.expireMovieButton.Location = new System.Drawing.Point(836, 11);
            this.expireMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.expireMovieButton.Name = "expireMovieButton";
            this.expireMovieButton.Size = new System.Drawing.Size(112, 39);
            this.expireMovieButton.TabIndex = 29;
            this.expireMovieButton.Text = "Dodaj nowy";
            this.expireMovieButton.UseVisualStyleBackColor = true;
=======
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(669, 9);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(90, 31);
            this.addMovieButton.TabIndex = 29;
            this.addMovieButton.Text = "Dodaj nowy";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
>>>>>>> origin/master
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aktualna ramówka";
            // 
            // MoviesListflowLayoutPanel
            // 
            this.MoviesListflowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
<<<<<<< HEAD
            this.MoviesListflowLayoutPanel.Location = new System.Drawing.Point(64, 56);
            this.MoviesListflowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviesListflowLayoutPanel.Name = "MoviesListflowLayoutPanel";
            this.MoviesListflowLayoutPanel.Size = new System.Drawing.Size(839, 370);
            this.MoviesListflowLayoutPanel.TabIndex = 1;
            this.MoviesListflowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MoviesListflowLayoutPanel_Paint);
=======
            this.MoviesListflowLayoutPanel.Location = new System.Drawing.Point(100, 45);
            this.MoviesListflowLayoutPanel.Name = "MoviesListflowLayoutPanel";
            this.MoviesListflowLayoutPanel.Size = new System.Drawing.Size(570, 296);
            this.MoviesListflowLayoutPanel.TabIndex = 1;
>>>>>>> origin/master
            // 
            // MoviesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(982, 681);
=======
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(786, 545);
>>>>>>> origin/master
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoviesManagementForm";
            this.Text = "MoviesManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView expiredMoviesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel MoviesListflowLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addMovieButton;

    }
}