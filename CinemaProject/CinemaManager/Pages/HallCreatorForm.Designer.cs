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
            this.panel3 = new System.Windows.Forms.Panel();
            this.HallEditPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubColumnButton = new System.Windows.Forms.Button();
            this.SubtractRowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hallNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlaceCount = new System.Windows.Forms.Label();
            this.NumberOfHallLabel = new System.Windows.Forms.Label();
            this.NumberOfColumnsLabel = new System.Windows.Forms.Label();
            this.NumberOfRowsLabel = new System.Windows.Forms.Label();
            this.displayHallButton = new System.Windows.Forms.Button();
            this.HallEditButton = new System.Windows.Forms.Button();
            this.RemoveHallButton = new System.Windows.Forms.Button();
            this.HallCreatePanel = new System.Windows.Forms.Panel();
            this.ScreenLabel = new System.Windows.Forms.Label();
            this.HallCreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.HallMenagePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.HallEditPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HallCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.HallMenageButton);
            this.panel1.Controls.Add(this.AddHall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(590, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 495);
            this.panel1.TabIndex = 14;
            // 
            // HallMenageButton
            // 
            this.HallMenageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.HallMenageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HallMenageButton.FlatAppearance.BorderSize = 0;
            this.HallMenageButton.ForeColor = System.Drawing.Color.White;
            this.HallMenageButton.Location = new System.Drawing.Point(0, 77);
            this.HallMenageButton.Margin = new System.Windows.Forms.Padding(0);
            this.HallMenageButton.Name = "HallMenageButton";
            this.HallMenageButton.Size = new System.Drawing.Size(146, 72);
            this.HallMenageButton.TabIndex = 10;
            this.HallMenageButton.Text = "Zarządzaj salami";
            this.HallMenageButton.UseVisualStyleBackColor = false;
            this.HallMenageButton.Click += new System.EventHandler(this.HallMenageButton_Click);
            // 
            // AddHall
            // 
            this.AddHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.AddHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddHall.FlatAppearance.BorderSize = 0;
            this.AddHall.ForeColor = System.Drawing.Color.White;
            this.AddHall.Location = new System.Drawing.Point(0, 0);
            this.AddHall.Margin = new System.Windows.Forms.Padding(0);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(146, 77);
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
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(590, 495);
            this.panelMain.TabIndex = 15;
            // 
            // HallMenagePanel
            // 
            this.HallMenagePanel.Controls.Add(this.panel3);
            this.HallMenagePanel.Controls.Add(this.HallCreatePanel);
            this.HallMenagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HallMenagePanel.Location = new System.Drawing.Point(0, 0);
            this.HallMenagePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HallMenagePanel.Name = "HallMenagePanel";
            this.HallMenagePanel.Size = new System.Drawing.Size(590, 495);
            this.HallMenagePanel.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.HallEditPanel);
            this.panel3.Controls.Add(this.hallNameComboBox);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.displayHallButton);
            this.panel3.Controls.Add(this.HallEditButton);
            this.panel3.Controls.Add(this.RemoveHallButton);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 139);
            this.panel3.TabIndex = 22;
            // 
            // HallEditPanel
            // 
            this.HallEditPanel.Controls.Add(this.tableLayoutPanel1);
            this.HallEditPanel.Location = new System.Drawing.Point(199, 56);
            this.HallEditPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HallEditPanel.Name = "HallEditPanel";
            this.HallEditPanel.Size = new System.Drawing.Size(130, 57);
            this.HallEditPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AddColumnButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddRowButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubColumnButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SubtractRowButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 56);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColumnButton.BackgroundImage = global::CinemaManager.Properties.Resources.add8;
            this.AddColumnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColumnButton.Location = new System.Drawing.Point(97, 28);
            this.AddColumnButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(33, 28);
            this.AddColumnButton.TabIndex = 2;
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowButton.AutoSize = true;
            this.AddRowButton.BackgroundImage = global::CinemaManager.Properties.Resources.add7;
            this.AddRowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRowButton.Location = new System.Drawing.Point(97, 0);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(33, 28);
            this.AddRowButton.TabIndex = 0;
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wiersze";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubColumnButton
            // 
            this.SubColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubColumnButton.BackgroundImage = global::CinemaManager.Properties.Resources.sub3;
            this.SubColumnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubColumnButton.Location = new System.Drawing.Point(0, 28);
            this.SubColumnButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubColumnButton.Name = "SubColumnButton";
            this.SubColumnButton.Size = new System.Drawing.Size(32, 28);
            this.SubColumnButton.TabIndex = 3;
            this.SubColumnButton.UseVisualStyleBackColor = true;
            this.SubColumnButton.Click += new System.EventHandler(this.SubColumnButton_Click);
            // 
            // SubtractRowButton
            // 
            this.SubtractRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractRowButton.BackgroundImage = global::CinemaManager.Properties.Resources.sub3;
            this.SubtractRowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubtractRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubtractRowButton.Location = new System.Drawing.Point(0, 0);
            this.SubtractRowButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubtractRowButton.Name = "SubtractRowButton";
            this.SubtractRowButton.Size = new System.Drawing.Size(32, 28);
            this.SubtractRowButton.TabIndex = 1;
            this.SubtractRowButton.UseVisualStyleBackColor = true;
            this.SubtractRowButton.Click += new System.EventHandler(this.SubtractRowButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kolumny";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hallNameComboBox
            // 
            this.hallNameComboBox.FormattingEnabled = true;
            this.hallNameComboBox.Location = new System.Drawing.Point(9, 2);
            this.hallNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hallNameComboBox.Name = "hallNameComboBox";
            this.hallNameComboBox.Size = new System.Drawing.Size(186, 21);
            this.hallNameComboBox.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.PlaceCount);
            this.panel2.Controls.Add(this.NumberOfHallLabel);
            this.panel2.Controls.Add(this.NumberOfColumnsLabel);
            this.panel2.Controls.Add(this.NumberOfRowsLabel);
            this.panel2.Location = new System.Drawing.Point(199, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 45);
            this.panel2.TabIndex = 16;
            // 
            // PlaceCount
            // 
            this.PlaceCount.AutoSize = true;
            this.PlaceCount.Location = new System.Drawing.Point(171, 20);
            this.PlaceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlaceCount.Name = "PlaceCount";
            this.PlaceCount.Size = new System.Drawing.Size(78, 13);
            this.PlaceCount.TabIndex = 4;
            this.PlaceCount.Text = "Razem miejsc: ";
            // 
            // NumberOfHallLabel
            // 
            this.NumberOfHallLabel.AutoSize = true;
            this.NumberOfHallLabel.Location = new System.Drawing.Point(5, 2);
            this.NumberOfHallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfHallLabel.Name = "NumberOfHallLabel";
            this.NumberOfHallLabel.Size = new System.Drawing.Size(34, 13);
            this.NumberOfHallLabel.TabIndex = 3;
            this.NumberOfHallLabel.Text = "Sala: ";
            // 
            // NumberOfColumnsLabel
            // 
            this.NumberOfColumnsLabel.AutoSize = true;
            this.NumberOfColumnsLabel.Location = new System.Drawing.Point(77, 20);
            this.NumberOfColumnsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfColumnsLabel.Name = "NumberOfColumnsLabel";
            this.NumberOfColumnsLabel.Size = new System.Drawing.Size(50, 13);
            this.NumberOfColumnsLabel.TabIndex = 2;
            this.NumberOfColumnsLabel.Text = "Kolumny:";
            // 
            // NumberOfRowsLabel
            // 
            this.NumberOfRowsLabel.AutoSize = true;
            this.NumberOfRowsLabel.Location = new System.Drawing.Point(5, 20);
            this.NumberOfRowsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfRowsLabel.Name = "NumberOfRowsLabel";
            this.NumberOfRowsLabel.Size = new System.Drawing.Size(43, 13);
            this.NumberOfRowsLabel.TabIndex = 1;
            this.NumberOfRowsLabel.Text = "Rzędy: ";
            // 
            // displayHallButton
            // 
            this.displayHallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.displayHallButton.ForeColor = System.Drawing.Color.White;
            this.displayHallButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.displayHallButton.Location = new System.Drawing.Point(100, 27);
            this.displayHallButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayHallButton.Name = "displayHallButton";
            this.displayHallButton.Size = new System.Drawing.Size(94, 44);
            this.displayHallButton.TabIndex = 19;
            this.displayHallButton.Text = "Wyświetl";
            this.displayHallButton.UseVisualStyleBackColor = false;
            this.displayHallButton.Click += new System.EventHandler(this.displayHallButton_Click);
            // 
            // HallEditButton
            // 
            this.HallEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.HallEditButton.ForeColor = System.Drawing.Color.White;
            this.HallEditButton.Location = new System.Drawing.Point(9, 69);
            this.HallEditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HallEditButton.Name = "HallEditButton";
            this.HallEditButton.Size = new System.Drawing.Size(185, 44);
            this.HallEditButton.TabIndex = 21;
            this.HallEditButton.Text = "Zatwierdź zmiany";
            this.HallEditButton.UseVisualStyleBackColor = false;
            this.HallEditButton.Click += new System.EventHandler(this.HallEditButton_Click);
            // 
            // RemoveHallButton
            // 
            this.RemoveHallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.RemoveHallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveHallButton.ForeColor = System.Drawing.Color.White;
            this.RemoveHallButton.Location = new System.Drawing.Point(9, 27);
            this.RemoveHallButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveHallButton.Name = "RemoveHallButton";
            this.RemoveHallButton.Size = new System.Drawing.Size(94, 44);
            this.RemoveHallButton.TabIndex = 20;
            this.RemoveHallButton.Text = "Usuń";
            this.RemoveHallButton.UseVisualStyleBackColor = false;
            this.RemoveHallButton.Click += new System.EventHandler(this.RemoveHallButton_Click_1);
            // 
            // HallCreatePanel
            // 
            this.HallCreatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallCreatePanel.AutoScroll = true;
            this.HallCreatePanel.Controls.Add(this.ScreenLabel);
            this.HallCreatePanel.Controls.Add(this.HallCreateTableLayoutPanel);
            this.HallCreatePanel.Location = new System.Drawing.Point(4, 144);
            this.HallCreatePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HallCreatePanel.Name = "HallCreatePanel";
            this.HallCreatePanel.Size = new System.Drawing.Size(584, 341);
            this.HallCreatePanel.TabIndex = 17;
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenLabel.Location = new System.Drawing.Point(4, 0);
            this.ScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(67, 18);
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
            this.HallCreateTableLayoutPanel.Location = new System.Drawing.Point(4, 41);
            this.HallCreateTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HallCreateTableLayoutPanel.Name = "HallCreateTableLayoutPanel";
            this.HallCreateTableLayoutPanel.RowCount = 1;
            this.HallCreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Size = new System.Drawing.Size(579, 297);
            this.HallCreateTableLayoutPanel.TabIndex = 14;
            // 
            // HallCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(736, 495);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HallCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HallCreatorForm";
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.HallMenagePanel.ResumeLayout(false);
            this.HallMenagePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.HallEditPanel.ResumeLayout(false);
            this.HallEditPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button HallEditButton;
        private System.Windows.Forms.Button RemoveHallButton;
        private System.Windows.Forms.Button displayHallButton;
        private System.Windows.Forms.TableLayoutPanel HallCreateTableLayoutPanel;
        private System.Windows.Forms.ComboBox hallNameComboBox;
        private System.Windows.Forms.Panel HallCreatePanel;
        private System.Windows.Forms.Label ScreenLabel;
        private System.Windows.Forms.Label NumberOfHallLabel;
        private System.Windows.Forms.Panel HallEditPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button SubColumnButton;
        private System.Windows.Forms.Button SubtractRowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PlaceCount;
    }
}