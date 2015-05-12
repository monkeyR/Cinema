namespace CinemaDisplay.Main
{
    partial class MainFormDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new CinemaDisplay.NonFilckeringPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dzisiejszy repertuar";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Location = new System.Drawing.Point(10, 69);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1030, 509);
            this.mainPanel.TabIndex = 2;
            // 
            // MainFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1049, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainFormDisplay_Activated);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormDisplay_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NonFilckeringPanel mainPanel;
    }
}