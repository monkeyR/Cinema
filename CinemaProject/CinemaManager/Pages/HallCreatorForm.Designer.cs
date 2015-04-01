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
            this.HallCreatorHallNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HallCreatorColumsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatorRowsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatePanel = new System.Windows.Forms.Panel();
            this.HallCreateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddHall = new System.Windows.Forms.Button();
            this.HallCreateAddHallButton = new System.Windows.Forms.Button();
            this.CreateHallONButton = new System.Windows.Forms.Button();
            this.HallInfo = new System.Windows.Forms.Panel();
            this.HallNameLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.HallCreatePanel.SuspendLayout();
            this.HallInfo.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.HallInfo);
            this.groupBox1.Controls.Add(this.HallCreatorHallNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HallCreatorColumsNumberTextBox);
            this.groupBox1.Controls.Add(this.HallCreateAddHallButton);
            this.groupBox1.Controls.Add(this.HallCreatorRowsNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateHallONButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(341, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // HallCreatorHallNameTextBox
            // 
            this.HallCreatorHallNameTextBox.Location = new System.Drawing.Point(145, 99);
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
            this.HallCreatorColumsNumberTextBox.Location = new System.Drawing.Point(145, 59);
            this.HallCreatorColumsNumberTextBox.Name = "HallCreatorColumsNumberTextBox";
            this.HallCreatorColumsNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorColumsNumberTextBox.TabIndex = 4;
            this.HallCreatorColumsNumberTextBox.Text = "16";
            // 
            // HallCreatorRowsNumberTextBox
            // 
            this.HallCreatorRowsNumberTextBox.Location = new System.Drawing.Point(145, 19);
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
            this.HallCreatePanel.Controls.Add(this.HallCreateTableLayoutPanel);
            this.HallCreatePanel.Location = new System.Drawing.Point(12, 234);
            this.HallCreatePanel.Name = "HallCreatePanel";
            this.HallCreatePanel.Size = new System.Drawing.Size(957, 436);
            this.HallCreatePanel.TabIndex = 8;
            // 
            // HallCreateTableLayoutPanel
            // 
            this.HallCreateTableLayoutPanel.AutoScroll = true;
            this.HallCreateTableLayoutPanel.AutoSize = true;
            this.HallCreateTableLayoutPanel.ColumnCount = 1;
            this.HallCreateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HallCreateTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HallCreateTableLayoutPanel.Name = "HallCreateTableLayoutPanel";
            this.HallCreateTableLayoutPanel.RowCount = 1;
            this.HallCreateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTableLayoutPanel.Size = new System.Drawing.Size(957, 436);
            this.HallCreateTableLayoutPanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Image = global::CinemaManager.Properties.Resources.Actions_edit_redo_icon1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(105, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 95);
            this.button1.TabIndex = 11;
            this.button1.Text = "Wyświetl salę";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddHall
            // 
            this.AddHall.Image = global::CinemaManager.Properties.Resources.add;
            this.AddHall.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddHall.Location = new System.Drawing.Point(12, 12);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(87, 125);
            this.AddHall.TabIndex = 9;
            this.AddHall.Text = "Dodaj salę";
            this.AddHall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddHall.UseVisualStyleBackColor = true;
            this.AddHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // HallCreateAddHallButton
            // 
            this.HallCreateAddHallButton.AutoSize = true;
            this.HallCreateAddHallButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HallCreateAddHallButton.Image = global::CinemaManager.Properties.Resources.symbol_check_icon;
            this.HallCreateAddHallButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HallCreateAddHallButton.Location = new System.Drawing.Point(537, 18);
            this.HallCreateAddHallButton.Name = "HallCreateAddHallButton";
            this.HallCreateAddHallButton.Size = new System.Drawing.Size(88, 121);
            this.HallCreateAddHallButton.TabIndex = 1;
            this.HallCreateAddHallButton.Text = "Zatwierdź";
            this.HallCreateAddHallButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HallCreateAddHallButton.UseVisualStyleBackColor = true;
            // 
            // CreateHallONButton
            // 
            this.CreateHallONButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateHallONButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateHallONButton.Image = global::CinemaManager.Properties.Resources.arrow_right_icon;
            this.CreateHallONButton.Location = new System.Drawing.Point(3, 139);
            this.CreateHallONButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateHallONButton.Name = "CreateHallONButton";
            this.CreateHallONButton.Size = new System.Drawing.Size(622, 81);
            this.CreateHallONButton.TabIndex = 0;
            this.CreateHallONButton.UseVisualStyleBackColor = true;
            this.CreateHallONButton.Click += new System.EventHandler(this.CreateHallONButton_Click);
            // 
            // HallInfo
            // 
            this.HallInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HallInfo.Controls.Add(this.ColumnsLabel);
            this.HallInfo.Controls.Add(this.RowsLabel);
            this.HallInfo.Controls.Add(this.HallNameLabel);
            this.HallInfo.Location = new System.Drawing.Point(252, 18);
            this.HallInfo.Name = "HallInfo";
            this.HallInfo.Size = new System.Drawing.Size(279, 121);
            this.HallInfo.TabIndex = 7;
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
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(7, 25);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(56, 17);
            this.RowsLabel.TabIndex = 1;
            this.RowsLabel.Text = "Rzędy: ";
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(7, 46);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(62, 17);
            this.ColumnsLabel.TabIndex = 2;
            this.ColumnsLabel.Text = "Kolumny";
            // 
            // HallCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddHall);
            this.Controls.Add(this.HallCreatePanel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HallCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HallCreatorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HallCreatePanel.ResumeLayout(false);
            this.HallCreatePanel.PerformLayout();
            this.HallInfo.ResumeLayout(false);
            this.HallInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel HallInfo;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label HallNameLabel;
    }
}