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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.weeksComboBox = new System.Windows.Forms.ComboBox();
            this.shiftsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(184, 14);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(161, 57);
            this.addEmployeeButton.TabIndex = 4;
            this.addEmployeeButton.Text = "Dodaj pracownika";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // weeksComboBox
            // 
            this.weeksComboBox.FormattingEnabled = true;
            this.weeksComboBox.Location = new System.Drawing.Point(16, 31);
            this.weeksComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weeksComboBox.Name = "weeksComboBox";
            this.weeksComboBox.Size = new System.Drawing.Size(160, 24);
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
            this.shiftsFlowLayoutPanel.Location = new System.Drawing.Point(16, 92);
            this.shiftsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shiftsFlowLayoutPanel.Name = "shiftsFlowLayoutPanel";
            this.shiftsFlowLayoutPanel.Size = new System.Drawing.Size(931, 383);
            this.shiftsFlowLayoutPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "  Brak zmian w tym tygodniu";
            // 
            // ShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 562);
            this.Controls.Add(this.shiftsFlowLayoutPanel);
            this.Controls.Add(this.weeksComboBox);
            this.Controls.Add(this.addEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShiftsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftsForm";
            this.shiftsFlowLayoutPanel.ResumeLayout(false);
            this.shiftsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.ComboBox weeksComboBox;
        private System.Windows.Forms.FlowLayoutPanel shiftsFlowLayoutPanel;
        private System.Windows.Forms.Label label1;

    }
}