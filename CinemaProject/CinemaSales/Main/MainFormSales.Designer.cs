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
            this.BinPanel = new System.Windows.Forms.Panel();
            this.ClearBinButtton = new System.Windows.Forms.Button();
            this.BackLastOperationButton = new System.Windows.Forms.Button();
            this.AllCostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BinListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.BinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketTabButton
            // 
            this.TicketTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.TicketTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketTabButton.FlatAppearance.BorderSize = 0;
            this.TicketTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketTabButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.BarTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarTabButton.FlatAppearance.BorderSize = 0;
            this.BarTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarTabButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FinalButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BinPanel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(618, 9);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(157, 543);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // FinalButton
            // 
            this.FinalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.FinalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalButton.FlatAppearance.BorderSize = 0;
            this.FinalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FinalButton.Location = new System.Drawing.Point(0, 497);
            this.FinalButton.Margin = new System.Windows.Forms.Padding(0);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(157, 46);
            this.FinalButton.TabIndex = 1;
            this.FinalButton.Text = "SUMA";
            this.FinalButton.UseVisualStyleBackColor = false;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // BinPanel
            // 
            this.BinPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinPanel.Controls.Add(this.ClearBinButtton);
            this.BinPanel.Controls.Add(this.BackLastOperationButton);
            this.BinPanel.Controls.Add(this.AllCostLabel);
            this.BinPanel.Controls.Add(this.label3);
            this.BinPanel.Controls.Add(this.label2);
            this.BinPanel.Controls.Add(this.BinListBox);
            this.BinPanel.Location = new System.Drawing.Point(0, 120);
            this.BinPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BinPanel.Name = "BinPanel";
            this.BinPanel.Size = new System.Drawing.Size(157, 377);
            this.BinPanel.TabIndex = 5;
            // 
            // ClearBinButtton
            // 
            this.ClearBinButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.ClearBinButtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBinButtton.FlatAppearance.BorderSize = 0;
            this.ClearBinButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBinButtton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearBinButtton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClearBinButtton.Location = new System.Drawing.Point(0, 344);
            this.ClearBinButtton.Name = "ClearBinButtton";
            this.ClearBinButtton.Size = new System.Drawing.Size(157, 29);
            this.ClearBinButtton.TabIndex = 5;
            this.ClearBinButtton.Text = "Wyczyść wszystko";
            this.ClearBinButtton.UseVisualStyleBackColor = false;
            // 
            // BackLastOperationButton
            // 
            this.BackLastOperationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.BackLastOperationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLastOperationButton.FlatAppearance.BorderSize = 0;
            this.BackLastOperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackLastOperationButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackLastOperationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.BackLastOperationButton.Location = new System.Drawing.Point(0, 309);
            this.BackLastOperationButton.Name = "BackLastOperationButton";
            this.BackLastOperationButton.Size = new System.Drawing.Size(157, 29);
            this.BackLastOperationButton.TabIndex = 4;
            this.BackLastOperationButton.Text = "Cofnij ostatnią operacje";
            this.BackLastOperationButton.UseVisualStyleBackColor = false;
            // 
            // AllCostLabel
            // 
            this.AllCostLabel.AutoSize = true;
            this.AllCostLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCostLabel.ForeColor = System.Drawing.Color.White;
            this.AllCostLabel.Location = new System.Drawing.Point(79, 279);
            this.AllCostLabel.Margin = new System.Windows.Forms.Padding(5);
            this.AllCostLabel.Name = "AllCostLabel";
            this.AllCostLabel.Size = new System.Drawing.Size(31, 22);
            this.AllCostLabel.TabIndex = 3;
            this.AllCostLabel.Text = "0zł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybrane produkty:";
            // 
            // BinListBox
            // 
            this.BinListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.BinListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinListBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.BinListBox.ForeColor = System.Drawing.Color.White;
            this.BinListBox.FormattingEnabled = true;
            this.BinListBox.ItemHeight = 18;
            this.BinListBox.Location = new System.Drawing.Point(6, 35);
            this.BinListBox.Margin = new System.Windows.Forms.Padding(5);
            this.BinListBox.Name = "BinListBox";
            this.BinListBox.Size = new System.Drawing.Size(146, 234);
            this.BinListBox.TabIndex = 0;
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
            this.BinPanel.ResumeLayout(false);
            this.BinPanel.PerformLayout();
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
        private System.Windows.Forms.Panel BinPanel;
        private System.Windows.Forms.ListBox BinListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AllCostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackLastOperationButton;
        private System.Windows.Forms.Button ClearBinButtton;
    }
}