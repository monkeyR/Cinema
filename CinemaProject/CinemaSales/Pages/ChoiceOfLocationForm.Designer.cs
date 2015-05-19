namespace CinemaSales.Pages
{
    partial class ChoiceOfLocationForm
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
            this.HallPanel = new System.Windows.Forms.Panel();
            this.BarWithTickets = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HallPanel
            // 
            this.HallPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallPanel.Location = new System.Drawing.Point(1, 0);
            this.HallPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HallPanel.Name = "HallPanel";
            this.HallPanel.Size = new System.Drawing.Size(632, 459);
            this.HallPanel.TabIndex = 0;
            // 
            // BarWithTickets
            // 
            this.BarWithTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarWithTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.BarWithTickets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BarWithTickets.Location = new System.Drawing.Point(633, 0);
            this.BarWithTickets.Margin = new System.Windows.Forms.Padding(0);
            this.BarWithTickets.Name = "BarWithTickets";
            this.BarWithTickets.Size = new System.Drawing.Size(100, 459);
            this.BarWithTickets.TabIndex = 2;
            // 
            // ChoiceOfLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.BarWithTickets);
            this.Controls.Add(this.HallPanel);
            this.Name = "ChoiceOfLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoiceOfLocationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HallPanel;
        private System.Windows.Forms.Panel BarWithTickets;
    }
}