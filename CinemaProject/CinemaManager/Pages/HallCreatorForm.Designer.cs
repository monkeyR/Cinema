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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HallInfo = new System.Windows.Forms.Panel();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.HallNameLabel = new System.Windows.Forms.Label();
            this.HallCreatorHallNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HallCreatorColumsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatorRowsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatePanel = new System.Windows.Forms.Panel();
            this.nameOfHallLabel = new System.Windows.Forms.Label();
            this.ScreenLabel = new System.Windows.Forms.Label();
            this.HallCreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hallNameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveHallButton = new System.Windows.Forms.Button();
            this.displayHallButton = new System.Windows.Forms.Button();
            this.AddHall = new System.Windows.Forms.Button();
            this.HallCreateAddHallButton = new System.Windows.Forms.Button();
            this.CreateHallONButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.HallInfo.SuspendLayout();
            this.HallCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość rzędów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość kolumn:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.HallInfo);
            this.groupBox1.Controls.Add(this.HallCreatorHallNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HallCreatorColumsNumberTextBox);
            this.groupBox1.Controls.Add(this.HallCreateAddHallButton);
            this.groupBox1.Controls.Add(this.HallCreatorRowsNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateHallONButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // HallInfo
            // 
            this.HallInfo.BackColor = System.Drawing.SystemColors.Control;
            this.HallInfo.Controls.Add(this.ColumnsLabel);
            this.HallInfo.Controls.Add(this.RowsLabel);
            this.HallInfo.Controls.Add(this.HallNameLabel);
            this.HallInfo.Location = new System.Drawing.Point(333, 21);
            this.HallInfo.Name = "HallInfo";
            this.HallInfo.Size = new System.Drawing.Size(248, 100);
            this.HallInfo.TabIndex = 7;
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(7, 46);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(66, 17);
            this.ColumnsLabel.TabIndex = 2;
            this.ColumnsLabel.Text = "Kolumny:";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(7, 25);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(56, 17);
            this.RowsLabel.TabIndex = 1;
            this.RowsLabel.Text = "Rzędy: ";
            // 
            // HallNameLabel
            // 
            this.HallNameLabel.AutoSize = true;
            this.HallNameLabel.Location = new System.Drawing.Point(7, 4);
            this.HallNameLabel.Name = "HallNameLabel";
            this.HallNameLabel.Size = new System.Drawing.Size(83, 17);
            this.HallNameLabel.TabIndex = 0;
            this.HallNameLabel.Text = "Nazwa sali: ";
            // 
            // HallCreatorHallNameTextBox
            // 
            this.HallCreatorHallNameTextBox.Location = new System.Drawing.Point(130, 99);
            this.HallCreatorHallNameTextBox.Name = "HallCreatorHallNameTextBox";
            this.HallCreatorHallNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorHallNameTextBox.TabIndex = 6;
            this.HallCreatorHallNameTextBox.Text = "Siema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwa sali:";
            // 
            // HallCreatorColumsNumberTextBox
            // 
            this.HallCreatorColumsNumberTextBox.Location = new System.Drawing.Point(130, 59);
            this.HallCreatorColumsNumberTextBox.Name = "HallCreatorColumsNumberTextBox";
            this.HallCreatorColumsNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorColumsNumberTextBox.TabIndex = 4;
            this.HallCreatorColumsNumberTextBox.Text = "16";
            // 
            // HallCreatorRowsNumberTextBox
            // 
            this.HallCreatorRowsNumberTextBox.Location = new System.Drawing.Point(130, 19);
            this.HallCreatorRowsNumberTextBox.Name = "HallCreatorRowsNumberTextBox";
            this.HallCreatorRowsNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorRowsNumberTextBox.TabIndex = 3;
            this.HallCreatorRowsNumberTextBox.Text = "12";
            // 
            // HallCreatePanel
            // 
            this.HallCreatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallCreatePanel.AutoScroll = true;
            this.HallCreatePanel.Controls.Add(this.nameOfHallLabel);
            this.HallCreatePanel.Controls.Add(this.ScreenLabel);
            this.HallCreatePanel.Location = new System.Drawing.Point(12, 256);
            this.HallCreatePanel.Name = "HallCreatePanel";
            this.HallCreatePanel.Size = new System.Drawing.Size(957, 341);
            this.HallCreatePanel.TabIndex = 8;
            // 
            // nameOfHallLabel
            // 
            this.nameOfHallLabel.AutoSize = true;
            this.nameOfHallLabel.Location = new System.Drawing.Point(3, 13);
            this.nameOfHallLabel.Name = "nameOfHallLabel";
            this.nameOfHallLabel.Size = new System.Drawing.Size(44, 17);
            this.nameOfHallLabel.TabIndex = 1;
            this.nameOfHallLabel.Text = "Sala: ";
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
            this.HallCreateTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallCreateTableLayoutPanel.AutoScroll = true;
            this.HallCreateTableLayoutPanel.AutoSize = true;
            this.HallCreateTableLayoutPanel.ColumnCount = 1;
            this.HallCreateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Location = new System.Drawing.Point(12, 289);
            this.HallCreateTableLayoutPanel.Name = "HallCreateTableLayoutPanel";
            this.HallCreateTableLayoutPanel.RowCount = 1;
            this.HallCreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Size = new System.Drawing.Size(954, 305);
            this.HallCreateTableLayoutPanel.TabIndex = 0;
            this.HallCreateTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HallCreateTableLayoutPanel_Paint);
            // 
            // hallNameComboBox
            // 
            this.hallNameComboBox.FormattingEnabled = true;
            this.hallNameComboBox.Location = new System.Drawing.Point(12, 102);
            this.hallNameComboBox.Name = "hallNameComboBox";
            this.hallNameComboBox.Size = new System.Drawing.Size(255, 24);
            this.hallNameComboBox.TabIndex = 10;
            this.hallNameComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = global::CinemaManager.Properties.Resources.Apps_system_software_update_icon;
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 100);
            this.button1.TabIndex = 13;
            this.button1.Text = "Edytuj";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RemoveHallButton
            // 
            this.RemoveHallButton.BackgroundImage = global::CinemaManager.Properties.Resources.Close_2_icon;
            this.RemoveHallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveHallButton.Location = new System.Drawing.Point(99, 132);
            this.RemoveHallButton.Name = "RemoveHallButton";
            this.RemoveHallButton.Size = new System.Drawing.Size(81, 100);
            this.RemoveHallButton.TabIndex = 12;
            this.RemoveHallButton.Text = "Usuń";
            this.RemoveHallButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveHallButton.UseVisualStyleBackColor = true;
            this.RemoveHallButton.Click += new System.EventHandler(this.RemoveHallButton_Click);
            // 
            // displayHallButton
            // 
            this.displayHallButton.Image = global::CinemaManager.Properties.Resources.Actions_edit_redo_icon3;
            this.displayHallButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.displayHallButton.Location = new System.Drawing.Point(186, 132);
            this.displayHallButton.Name = "displayHallButton";
            this.displayHallButton.Size = new System.Drawing.Size(81, 100);
            this.displayHallButton.TabIndex = 11;
            this.displayHallButton.Text = "Wyświetl";
            this.displayHallButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.displayHallButton.UseVisualStyleBackColor = true;
            this.displayHallButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddHall
            // 
            this.AddHall.Image = global::CinemaManager.Properties.Resources.add4;
            this.AddHall.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddHall.Location = new System.Drawing.Point(12, 12);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(255, 84);
            this.AddHall.TabIndex = 9;
            this.AddHall.Text = "Dodaj nową salę";
            this.AddHall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddHall.UseVisualStyleBackColor = true;
            this.AddHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // HallCreateAddHallButton
            // 
            this.HallCreateAddHallButton.AutoSize = true;
            this.HallCreateAddHallButton.Image = global::CinemaManager.Properties.Resources.symbol_check_icon;
            this.HallCreateAddHallButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HallCreateAddHallButton.Location = new System.Drawing.Point(587, 19);
            this.HallCreateAddHallButton.Name = "HallCreateAddHallButton";
            this.HallCreateAddHallButton.Size = new System.Drawing.Size(86, 102);
            this.HallCreateAddHallButton.TabIndex = 1;
            this.HallCreateAddHallButton.Text = "Zatwierdź";
            this.HallCreateAddHallButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HallCreateAddHallButton.UseVisualStyleBackColor = true;
            this.HallCreateAddHallButton.Click += new System.EventHandler(this.HallCreateAddHallButton_Click);
            // 
            // CreateHallONButton
            // 
            this.CreateHallONButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateHallONButton.Image = global::CinemaManager.Properties.Resources.arrow_right_icon1;
            this.CreateHallONButton.Location = new System.Drawing.Point(29, 133);
            this.CreateHallONButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateHallONButton.Name = "CreateHallONButton";
            this.CreateHallONButton.Size = new System.Drawing.Size(201, 44);
            this.CreateHallONButton.TabIndex = 0;
            this.CreateHallONButton.UseVisualStyleBackColor = true;
            this.CreateHallONButton.Click += new System.EventHandler(this.CreateHallONButton_Click);
            // 
            // HallCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveHallButton);
            this.Controls.Add(this.displayHallButton);
            this.Controls.Add(this.HallCreateTableLayoutPanel);
            this.Controls.Add(this.hallNameComboBox);
            this.Controls.Add(this.AddHall);
            this.Controls.Add(this.HallCreatePanel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HallCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HallCreatorForm";
            this.Load += new System.EventHandler(this.HallCreatorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HallInfo.ResumeLayout(false);
            this.HallInfo.PerformLayout();
            this.HallCreatePanel.ResumeLayout(false);
            this.HallCreatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateHallONButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HallCreatorHallNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HallCreatorColumsNumberTextBox;
        private System.Windows.Forms.TextBox HallCreatorRowsNumberTextBox;
        private System.Windows.Forms.Panel HallCreatePanel;
        private System.Windows.Forms.Button HallCreateAddHallButton;
        private System.Windows.Forms.TableLayoutPanel HallCreateTableLayoutPanel;
        private System.Windows.Forms.Button AddHall;
        private System.Windows.Forms.ComboBox hallNameComboBox;
        private System.Windows.Forms.Button displayHallButton;
        private System.Windows.Forms.Panel HallInfo;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label HallNameLabel;
        private System.Windows.Forms.Label ScreenLabel;
        private System.Windows.Forms.Label nameOfHallLabel;
        private System.Windows.Forms.Button RemoveHallButton;
        private System.Windows.Forms.Button button1;
    }
}