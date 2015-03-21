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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FinalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.TicketTabButton.Location = new System.Drawing.Point(0, 0);
            this.TicketTabButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TicketTabButton.Name = "TicketTabButton";
            this.TicketTabButton.Size = new System.Drawing.Size(301, 46);
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
            this.BarTabButton.Location = new System.Drawing.Point(305, 0);
            this.BarTabButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.BarTabButton.Name = "BarTabButton";
            this.BarTabButton.Size = new System.Drawing.Size(299, 46);
            this.BarTabButton.TabIndex = 1;
            this.BarTabButton.Text = "Kasa barowa";
            this.BarTabButton.UseVisualStyleBackColor = false;
            this.BarTabButton.Click += new System.EventHandler(this.BarTabButton_Click);
            // 
            // MainSalesPanel
            // 
            this.MainSalesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSalesPanel.Location = new System.Drawing.Point(9, 60);
            this.MainSalesPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MainSalesPanel.Name = "MainSalesPanel";
            this.MainSalesPanel.Size = new System.Drawing.Size(604, 492);
            this.MainSalesPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82935F));
            this.tableLayoutPanel1.Controls.Add(this.BarTabButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TicketTabButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FinalButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(618, 9);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(157, 543);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // FinalButton
            // 
            this.FinalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(244)))), ((int)(((byte)(99)))));
            this.FinalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalButton.FlatAppearance.BorderSize = 0;
            this.FinalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalButton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.FinalButton.Location = new System.Drawing.Point(3, 500);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(151, 40);
            this.FinalButton.TabIndex = 1;
            this.FinalButton.Text = "SUMA";
            this.FinalButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(151, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dane\r\n     Sprzedawcy";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(151, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "KOSZYK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.MainSalesPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainFormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel sprzedawcy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TicketTabButton;
        private System.Windows.Forms.Button BarTabButton;
        private System.Windows.Forms.Panel MainSalesPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button FinalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}