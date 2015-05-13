namespace CinemaManager.Pages
{
    partial class ShiftsForm
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
            this.weeksComboBox = new System.Windows.Forms.ComboBox();
            this.shiftsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.shiftsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weeksComboBox
            // 
            this.weeksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weeksComboBox.FormattingEnabled = true;
            this.weeksComboBox.Location = new System.Drawing.Point(12, 25);
            this.weeksComboBox.Name = "weeksComboBox";
            this.weeksComboBox.Size = new System.Drawing.Size(121, 21);
            this.weeksComboBox.TabIndex = 5;
            this.weeksComboBox.SelectedIndexChanged += new System.EventHandler(this.weeksComboBox_SelectedIndexChanged);
            // 
            // shiftsFlowLayoutPanel
            // 
            this.shiftsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftsFlowLayoutPanel.AutoScroll = true;
            this.shiftsFlowLayoutPanel.Controls.Add(this.label1);
            this.shiftsFlowLayoutPanel.Location = new System.Drawing.Point(12, 75);
            this.shiftsFlowLayoutPanel.Name = "shiftsFlowLayoutPanel";
            this.shiftsFlowLayoutPanel.Size = new System.Drawing.Size(698, 311);
            this.shiftsFlowLayoutPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "  Brak zmian w tym tygodniu";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.addEmployeeButton.Location = new System.Drawing.Point(140, 12);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(106, 44);
            this.addEmployeeButton.TabIndex = 31;
            this.addEmployeeButton.Text = "Dodaj pracownika";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // ShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(720, 457);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.shiftsFlowLayoutPanel);
            this.Controls.Add(this.weeksComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftsForm";
            this.shiftsFlowLayoutPanel.ResumeLayout(false);
            this.shiftsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weeksComboBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel shiftsFlowLayoutPanel;
        private System.Windows.Forms.Button addEmployeeButton;

    }
}