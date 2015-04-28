namespace CinemaManager.Pages
{
    partial class HallCreatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HallMenageButton = new System.Windows.Forms.Button();
            this.AddHall = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.HallMenagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberOfHallLabel = new System.Windows.Forms.Label();
            this.NumberOfColumnsLabel = new System.Windows.Forms.Label();
            this.NumberOfRowsLabel = new System.Windows.Forms.Label();
            this.HallNameLabel = new System.Windows.Forms.Label();
            this.HallEditButton = new System.Windows.Forms.Button();
            this.RemoveHallButton = new System.Windows.Forms.Button();
            this.displayHallButton = new System.Windows.Forms.Button();
            this.hallNameComboBox = new System.Windows.Forms.ComboBox();
            this.HallCreatePanel = new System.Windows.Forms.Panel();
            this.ScreenLabel = new System.Windows.Forms.Label();
            this.HallCreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.HallMenagePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HallCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HallMenageButton);
            this.panel1.Controls.Add(this.AddHall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(833, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 609);
            this.panel1.TabIndex = 14;
            // 
            // HallMenageButton
            // 
            this.HallMenageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.HallMenageButton.ForeColor = System.Drawing.Color.White;
            this.HallMenageButton.Location = new System.Drawing.Point(3, 86);
            this.HallMenageButton.Name = "HallMenageButton";
            this.HallMenageButton.Size = new System.Drawing.Size(142, 77);
            this.HallMenageButton.TabIndex = 10;
            this.HallMenageButton.Text = "Zarządzaj salami";
            this.HallMenageButton.UseVisualStyleBackColor = false;
            this.HallMenageButton.Click += new System.EventHandler(this.HallMenageButton_Click);
            // 
            // AddHall
            // 
            this.AddHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.AddHall.ForeColor = System.Drawing.Color.White;
            this.AddHall.Location = new System.Drawing.Point(3, 10);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(142, 77);
            this.AddHall.TabIndex = 9;
            this.AddHall.Text = "Dodaj nową salę";
            this.AddHall.UseVisualStyleBackColor = false;
            this.AddHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.HallMenagePanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(833, 609);
            this.panelMain.TabIndex = 15;
            // 
            // HallMenagePanel
            // 
            this.HallMenagePanel.Controls.Add(this.panel2);
            this.HallMenagePanel.Controls.Add(this.HallEditButton);
            this.HallMenagePanel.Controls.Add(this.RemoveHallButton);
            this.HallMenagePanel.Controls.Add(this.displayHallButton);
            this.HallMenagePanel.Controls.Add(this.hallNameComboBox);
            this.HallMenagePanel.Controls.Add(this.HallCreatePanel);
            this.HallMenagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HallMenagePanel.Location = new System.Drawing.Point(0, 0);
            this.HallMenagePanel.Name = "HallMenagePanel";
            this.HallMenagePanel.Size = new System.Drawing.Size(833, 609);
            this.HallMenagePanel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.NumberOfHallLabel);
            this.panel2.Controls.Add(this.NumberOfColumnsLabel);
            this.panel2.Controls.Add(this.NumberOfRowsLabel);
            this.panel2.Controls.Add(this.HallNameLabel);
            this.panel2.Location = new System.Drawing.Point(339, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 95);
            this.panel2.TabIndex = 16;
            // 
            // NumberOfHallLabel
            // 
            this.NumberOfHallLabel.AutoSize = true;
            this.NumberOfHallLabel.Location = new System.Drawing.Point(7, 67);
            this.NumberOfHallLabel.Name = "NumberOfHallLabel";
            this.NumberOfHallLabel.Size = new System.Drawing.Size(79, 17);
            this.NumberOfHallLabel.TabIndex = 3;
            this.NumberOfHallLabel.Text = "Numer sali:";
            // 
            // NumberOfColumnsLabel
            // 
            this.NumberOfColumnsLabel.AutoSize = true;
            this.NumberOfColumnsLabel.Location = new System.Drawing.Point(7, 46);
            this.NumberOfColumnsLabel.Name = "NumberOfColumnsLabel";
            this.NumberOfColumnsLabel.Size = new System.Drawing.Size(66, 17);
            this.NumberOfColumnsLabel.TabIndex = 2;
            this.NumberOfColumnsLabel.Text = "Kolumny:";
            // 
            // NumberOfRowsLabel
            // 
            this.NumberOfRowsLabel.AutoSize = true;
            this.NumberOfRowsLabel.Location = new System.Drawing.Point(7, 25);
            this.NumberOfRowsLabel.Name = "NumberOfRowsLabel";
            this.NumberOfRowsLabel.Size = new System.Drawing.Size(56, 17);
            this.NumberOfRowsLabel.TabIndex = 1;
            this.NumberOfRowsLabel.Text = "Rzędy: ";
            this.NumberOfRowsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // HallNameLabel
            // 
            this.HallNameLabel.AutoSize = true;
            this.HallNameLabel.Location = new System.Drawing.Point(7, 4);
            this.HallNameLabel.Name = "HallNameLabel";
            this.HallNameLabel.Size = new System.Drawing.Size(83, 17);
            this.HallNameLabel.TabIndex = 0;
            this.HallNameLabel.Text = "Nazwa sali: ";
            this.HallNameLabel.Click += new System.EventHandler(this.HallNameLabel_Click);
            // 
            // HallEditButton
            // 
            this.HallEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.HallEditButton.ForeColor = System.Drawing.Color.White;
            this.HallEditButton.Location = new System.Drawing.Point(128, 45);
            this.HallEditButton.Name = "HallEditButton";
            this.HallEditButton.Size = new System.Drawing.Size(118, 54);
            this.HallEditButton.TabIndex = 21;
            this.HallEditButton.Text = "Edytuj";
            this.HallEditButton.UseVisualStyleBackColor = false;
            this.HallEditButton.Click += new System.EventHandler(this.HallEditButton_Click);
            // 
            // RemoveHallButton
            // 
            this.RemoveHallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.RemoveHallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveHallButton.ForeColor = System.Drawing.Color.White;
            this.RemoveHallButton.Location = new System.Drawing.Point(12, 45);
            this.RemoveHallButton.Name = "RemoveHallButton";
            this.RemoveHallButton.Size = new System.Drawing.Size(117, 54);
            this.RemoveHallButton.TabIndex = 20;
            this.RemoveHallButton.Text = "Usuń";
            this.RemoveHallButton.UseVisualStyleBackColor = false;
            this.RemoveHallButton.Click += new System.EventHandler(this.RemoveHallButton_Click_1);
            // 
            // displayHallButton
            // 
            this.displayHallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.displayHallButton.ForeColor = System.Drawing.Color.White;
            this.displayHallButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.displayHallButton.Location = new System.Drawing.Point(244, 15);
            this.displayHallButton.Name = "displayHallButton";
            this.displayHallButton.Size = new System.Drawing.Size(96, 84);
            this.displayHallButton.TabIndex = 19;
            this.displayHallButton.Text = "Wyświetl";
            this.displayHallButton.UseVisualStyleBackColor = false;
            this.displayHallButton.Click += new System.EventHandler(this.displayHallButton_Click);
            // 
            // hallNameComboBox
            // 
            this.hallNameComboBox.FormattingEnabled = true;
            this.hallNameComboBox.Location = new System.Drawing.Point(12, 15);
            this.hallNameComboBox.Name = "hallNameComboBox";
            this.hallNameComboBox.Size = new System.Drawing.Size(234, 24);
            this.hallNameComboBox.TabIndex = 18;
            // 
            // HallCreatePanel
            // 
            this.HallCreatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallCreatePanel.AutoScroll = true;
            this.HallCreatePanel.Controls.Add(this.ScreenLabel);
            this.HallCreatePanel.Controls.Add(this.HallCreateTableLayoutPanel);
            this.HallCreatePanel.Location = new System.Drawing.Point(6, 110);
            this.HallCreatePanel.Name = "HallCreatePanel";
            this.HallCreatePanel.Size = new System.Drawing.Size(824, 475);
            this.HallCreatePanel.TabIndex = 17;
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenLabel.Location = new System.Drawing.Point(0, 0);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(81, 23);
            this.ScreenLabel.TabIndex = 0;
            this.ScreenLabel.Text = "EKRAN";
            this.ScreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HallCreateTableLayoutPanel
            // 
            this.HallCreateTableLayoutPanel.AutoScroll = true;
            this.HallCreateTableLayoutPanel.AutoSize = true;
            this.HallCreateTableLayoutPanel.ColumnCount = 1;
            this.HallCreateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.HallCreateTableLayoutPanel.Name = "HallCreateTableLayoutPanel";
            this.HallCreateTableLayoutPanel.RowCount = 1;
            this.HallCreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Size = new System.Drawing.Size(821, 439);
            this.HallCreateTableLayoutPanel.TabIndex = 14;
            // 
            // HallCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(981, 609);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HallCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HallCreatorForm";
            this.Load += new System.EventHandler(this.HallCreatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.HallMenagePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HallCreatePanel.ResumeLayout(false);
            this.HallCreatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddHall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HallMenageButton;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel HallMenagePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NumberOfColumnsLabel;
        private System.Windows.Forms.Label NumberOfRowsLabel;
        private System.Windows.Forms.Label HallNameLabel;
        private System.Windows.Forms.Button HallEditButton;
        private System.Windows.Forms.Button RemoveHallButton;
        private System.Windows.Forms.Button displayHallButton;
        private System.Windows.Forms.TableLayoutPanel HallCreateTableLayoutPanel;
        private System.Windows.Forms.ComboBox hallNameComboBox;
        private System.Windows.Forms.Panel HallCreatePanel;
        private System.Windows.Forms.Label ScreenLabel;
        private System.Windows.Forms.Label NumberOfHallLabel;
    }
}