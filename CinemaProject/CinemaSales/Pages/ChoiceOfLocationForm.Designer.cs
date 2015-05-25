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
            this.choiceLocationsButton = new System.Windows.Forms.Button();
            this.cancelWindowButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel.SuspendLayout();
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
            this.BarWithTickets.Size = new System.Drawing.Size(100, 356);
            this.BarWithTickets.TabIndex = 2;
            // 
            // choiceLocationsButton
            // 
            this.choiceLocationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.choiceLocationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choiceLocationsButton.FlatAppearance.BorderSize = 0;
            this.choiceLocationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceLocationsButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.choiceLocationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.choiceLocationsButton.Location = new System.Drawing.Point(0, 0);
            this.choiceLocationsButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.choiceLocationsButton.Name = "choiceLocationsButton";
            this.choiceLocationsButton.Size = new System.Drawing.Size(100, 50);
            this.choiceLocationsButton.TabIndex = 2;
            this.choiceLocationsButton.Text = "Wybierz";
            this.choiceLocationsButton.UseVisualStyleBackColor = false;
            this.choiceLocationsButton.Click += new System.EventHandler(this.choiceLocationsButton_Click);
            // 
            // cancelWindowButton
            // 
            this.cancelWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cancelWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelWindowButton.FlatAppearance.BorderSize = 0;
            this.cancelWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelWindowButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelWindowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.cancelWindowButton.Location = new System.Drawing.Point(0, 53);
            this.cancelWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelWindowButton.Name = "cancelWindowButton";
            this.cancelWindowButton.Size = new System.Drawing.Size(100, 50);
            this.cancelWindowButton.TabIndex = 3;
            this.cancelWindowButton.Text = "Anuluj";
            this.cancelWindowButton.UseVisualStyleBackColor = false;
            this.cancelWindowButton.Click += new System.EventHandler(this.cancelWindowButton_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.buttonsPanel.Controls.Add(this.cancelWindowButton);
            this.buttonsPanel.Controls.Add(this.choiceLocationsButton);
            this.buttonsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonsPanel.Location = new System.Drawing.Point(633, 356);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(100, 103);
            this.buttonsPanel.TabIndex = 3;
            // 
            // ChoiceOfLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.BarWithTickets);
            this.Controls.Add(this.HallPanel);
            this.Name = "ChoiceOfLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoiceOfLocationForm";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HallPanel;
        private System.Windows.Forms.Panel BarWithTickets;
        private System.Windows.Forms.Button cancelWindowButton;
        private System.Windows.Forms.Button choiceLocationsButton;
        private System.Windows.Forms.Panel buttonsPanel;
    }
}