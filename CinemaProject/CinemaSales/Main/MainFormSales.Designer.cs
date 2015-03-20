namespace CinemaSales.Main
{
    partial class MainFormSales
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
            this.TicketTabButton = new System.Windows.Forms.Button();
            this.BarTabButton = new System.Windows.Forms.Button();
            this.MainSalesPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketTabButton
            // 
            this.TicketTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.TicketTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketTabButton.FlatAppearance.BorderSize = 0;
            this.TicketTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketTabButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketTabButton.ForeColor = System.Drawing.Color.White;
            this.TicketTabButton.Location = new System.Drawing.Point(3, 3);
            this.TicketTabButton.Name = "TicketTabButton";
            this.TicketTabButton.Size = new System.Drawing.Size(294, 41);
            this.TicketTabButton.TabIndex = 0;
            this.TicketTabButton.Text = "Kasa biletowa";
            this.TicketTabButton.UseVisualStyleBackColor = false;
            this.TicketTabButton.Click += new System.EventHandler(this.ticketTabButton_Click);
            // 
            // BarTabButton
            // 
            this.BarTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.BarTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarTabButton.FlatAppearance.BorderSize = 0;
            this.BarTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarTabButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarTabButton.ForeColor = System.Drawing.Color.White;
            this.BarTabButton.Location = new System.Drawing.Point(303, 3);
            this.BarTabButton.Name = "BarTabButton";
            this.BarTabButton.Size = new System.Drawing.Size(294, 41);
            this.BarTabButton.TabIndex = 1;
            this.BarTabButton.Text = "Kasa barowa";
            this.BarTabButton.UseVisualStyleBackColor = false;
            this.BarTabButton.Click += new System.EventHandler(this.barTabButton_Click);
            // 
            // MainSalesPanel
            // 
            this.MainSalesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSalesPanel.Location = new System.Drawing.Point(12, 65);
            this.MainSalesPanel.Name = "MainSalesPanel";
            this.MainSalesPanel.Size = new System.Drawing.Size(600, 364);
            this.MainSalesPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BarTabButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TicketTabButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 47);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainFormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainSalesPanel);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainFormSales";
            this.Text = "Panel sprzedawcy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TicketTabButton;
        private System.Windows.Forms.Button BarTabButton;
        private System.Windows.Forms.Panel MainSalesPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}