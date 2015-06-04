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
            this.MainTicketsPanel = new System.Windows.Forms.Panel();
            this.ColumnShowsLayout = new System.Windows.Forms.Panel();
            this.ColumnHallsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTicketsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTicketsPanel
            // 
            this.MainTicketsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTicketsPanel.AutoScroll = true;
            this.MainTicketsPanel.Controls.Add(this.ColumnShowsLayout);
            this.MainTicketsPanel.Controls.Add(this.ColumnHallsButtons);
            this.MainTicketsPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTicketsPanel.Name = "MainTicketsPanel";
            this.MainTicketsPanel.Size = new System.Drawing.Size(603, 492);
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
            this.ColumnShowsLayout.Size = new System.Drawing.Size(500, 492);
            this.ColumnShowsLayout.TabIndex = 1;
            // 
            // ColumnHallsButtons
            // 
            this.ColumnHallsButtons.AutoSize = true;
            this.ColumnHallsButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
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
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.MainTicketsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyTicketsForm";
            this.Text = "BuyTicketsForm";
            this.Load += new System.EventHandler(this.BuyTicketsForm_Load);
            this.MainTicketsPanel.ResumeLayout(false);
            this.MainTicketsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainTicketsPanel;
        private System.Windows.Forms.FlowLayoutPanel ColumnHallsButtons;
        private System.Windows.Forms.Panel ColumnShowsLayout;
    }
}