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
            this.SuspendLayout();
            // 
            // TicketTabButton
            // 
            this.TicketTabButton.Location = new System.Drawing.Point(12, 12);
            this.TicketTabButton.Name = "TicketTabButton";
            this.TicketTabButton.Size = new System.Drawing.Size(174, 47);
            this.TicketTabButton.TabIndex = 0;
            this.TicketTabButton.Text = "Kasa biletowa";
            this.TicketTabButton.UseVisualStyleBackColor = true;
            this.TicketTabButton.Click += new System.EventHandler(this.ticketTabButton_Click);
            // 
            // BarTabButton
            // 
            this.BarTabButton.Location = new System.Drawing.Point(198, 12);
            this.BarTabButton.Name = "BarTabButton";
            this.BarTabButton.Size = new System.Drawing.Size(174, 47);
            this.BarTabButton.TabIndex = 1;
            this.BarTabButton.Text = "Kasa barowa";
            this.BarTabButton.UseVisualStyleBackColor = true;
            this.BarTabButton.Click += new System.EventHandler(this.barTabButton_Click);
            // 
            // MainSalesPanel
            // 
            this.MainSalesPanel.Location = new System.Drawing.Point(12, 65);
            this.MainSalesPanel.Name = "MainSalesPanel";
            this.MainSalesPanel.Size = new System.Drawing.Size(360, 233);
            this.MainSalesPanel.TabIndex = 2;
            // 
            // MainFormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.MainSalesPanel);
            this.Controls.Add(this.BarTabButton);
            this.Controls.Add(this.TicketTabButton);
            this.Name = "MainFormSales";
            this.Text = "Panel sprzedawcy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TicketTabButton;
        private System.Windows.Forms.Button BarTabButton;
        private System.Windows.Forms.Panel MainSalesPanel;
    }
}