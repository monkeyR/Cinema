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
            this.addMovieButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MoviesListflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.expiredMoviesListView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 180);
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
            this.expiredMoviesListView.Location = new System.Drawing.Point(7, 49);
            this.expiredMoviesListView.MultiSelect = false;
            this.expiredMoviesListView.Name = "expiredMoviesListView";
            this.expiredMoviesListView.Size = new System.Drawing.Size(752, 128);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista nieaktualnych filmów";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.addMovieButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MoviesListflowLayoutPanel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 344);
            this.panel2.TabIndex = 21;
            // 
            // addMovieButton
            // 
            this.addMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.addMovieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addMovieButton.ForeColor = System.Drawing.Color.White;
            this.addMovieButton.Location = new System.Drawing.Point(484, 2);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(94, 44);
            this.addMovieButton.TabIndex = 30;
            this.addMovieButton.Text = "Dodaj nowy";
            this.addMovieButton.UseVisualStyleBackColor = false;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aktualna ramówka";
            // 
            // MoviesListflowLayoutPanel
            // 
            this.MoviesListflowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoviesListflowLayoutPanel.Location = new System.Drawing.Point(8, 51);
            this.MoviesListflowLayoutPanel.Name = "MoviesListflowLayoutPanel";
            this.MoviesListflowLayoutPanel.Size = new System.Drawing.Size(570, 290);
            this.MoviesListflowLayoutPanel.TabIndex = 1;
            // 
            // MoviesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(786, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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