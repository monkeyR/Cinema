namespace CinemaSales.Main
{
    partial class BuyTicketsForm
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
            this.BarWithTickets = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainTicketsPanel = new System.Windows.Forms.Panel();
            this.ColumnShowsLayout = new System.Windows.Forms.Panel();
            this.ColumnHallsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BarWithTickets.SuspendLayout();
            this.MainTicketsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarWithTickets
            // 
            this.BarWithTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarWithTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.BarWithTickets.Controls.Add(this.button3);
            this.BarWithTickets.Controls.Add(this.button2);
            this.BarWithTickets.Controls.Add(this.button1);
            this.BarWithTickets.Location = new System.Drawing.Point(504, 0);
            this.BarWithTickets.Margin = new System.Windows.Forms.Padding(0);
            this.BarWithTickets.Name = "BarWithTickets";
            this.BarWithTickets.Size = new System.Drawing.Size(100, 492);
            this.BarWithTickets.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Bilet VIP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ActiveButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bilet normalny";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bilet ulgowy";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainTicketsPanel
            // 
            this.MainTicketsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTicketsPanel.Controls.Add(this.ColumnShowsLayout);
            this.MainTicketsPanel.Controls.Add(this.ColumnHallsButtons);
            this.MainTicketsPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTicketsPanel.Name = "MainTicketsPanel";
            this.MainTicketsPanel.Size = new System.Drawing.Size(501, 492);
            this.MainTicketsPanel.TabIndex = 2;
            // 
            // ColumnShowsLayout
            // 
            this.ColumnShowsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnShowsLayout.AutoScroll = true;
            this.ColumnShowsLayout.Location = new System.Drawing.Point(103, 0);
            this.ColumnShowsLayout.Name = "ColumnShowsLayout";
            this.ColumnShowsLayout.Size = new System.Drawing.Size(395, 492);
            this.ColumnShowsLayout.TabIndex = 1;
            // 
            // ColumnHallsButtons
            // 
            this.ColumnHallsButtons.Location = new System.Drawing.Point(0, 0);
            this.ColumnHallsButtons.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHallsButtons.Name = "ColumnHallsButtons";
            this.ColumnHallsButtons.Size = new System.Drawing.Size(100, 492);
            this.ColumnHallsButtons.TabIndex = 0;
            // 
            // BuyTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.MainTicketsPanel);
            this.Controls.Add(this.BarWithTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyTicketsForm";
            this.Text = "BuyTicketsForm";
            this.Load += new System.EventHandler(this.BuyTicketsForm_Load);
            this.BarWithTickets.ResumeLayout(false);
            this.MainTicketsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarWithTickets;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MainTicketsPanel;
        private System.Windows.Forms.FlowLayoutPanel ColumnHallsButtons;
        private System.Windows.Forms.Panel ColumnShowsLayout;
    }
}