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
            this.CreateHallONButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HallCreatorHallNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HallCreatorColumsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatorRowsNumberTextBox = new System.Windows.Forms.TextBox();
            this.HallCreatorNmeOfHallLabel = new System.Windows.Forms.Label();
            this.HallCteatorHowManyRowsLabel = new System.Windows.Forms.Label();
            this.HallCteatorHowManyCollumnsLabel = new System.Windows.Forms.Label();
            this.HallCreateTable = new System.Windows.Forms.TableLayoutPanel();
            this.HallCreatePanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.HallCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateHallONButton
            // 
            this.CreateHallONButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateHallONButton.Location = new System.Drawing.Point(146, 167);
            this.CreateHallONButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateHallONButton.Name = "CreateHallONButton";
            this.CreateHallONButton.Size = new System.Drawing.Size(100, 32);
            this.CreateHallONButton.TabIndex = 0;
            this.CreateHallONButton.Text = "Dalej";
            this.CreateHallONButton.UseVisualStyleBackColor = true;
            this.CreateHallONButton.Click += new System.EventHandler(this.CreateHallONButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość rzędów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość kolumn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HallCreatorHallNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HallCreatorColumsNumberTextBox);
            this.groupBox1.Controls.Add(this.HallCreatorRowsNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateHallONButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // HallCreatorHallNameTextBox
            // 
            this.HallCreatorHallNameTextBox.Location = new System.Drawing.Point(146, 127);
            this.HallCreatorHallNameTextBox.Name = "HallCreatorHallNameTextBox";
            this.HallCreatorHallNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorHallNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwa sali:";
            // 
            // HallCreatorColumsNumberTextBox
            // 
            this.HallCreatorColumsNumberTextBox.Location = new System.Drawing.Point(146, 87);
            this.HallCreatorColumsNumberTextBox.Name = "HallCreatorColumsNumberTextBox";
            this.HallCreatorColumsNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorColumsNumberTextBox.TabIndex = 4;
            // 
            // HallCreatorRowsNumberTextBox
            // 
            this.HallCreatorRowsNumberTextBox.Location = new System.Drawing.Point(146, 47);
            this.HallCreatorRowsNumberTextBox.Name = "HallCreatorRowsNumberTextBox";
            this.HallCreatorRowsNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.HallCreatorRowsNumberTextBox.TabIndex = 3;
            // 
            // HallCreatorNmeOfHallLabel
            // 
            this.HallCreatorNmeOfHallLabel.AutoSize = true;
            this.HallCreatorNmeOfHallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HallCreatorNmeOfHallLabel.Location = new System.Drawing.Point(359, 12);
            this.HallCreatorNmeOfHallLabel.Name = "HallCreatorNmeOfHallLabel";
            this.HallCreatorNmeOfHallLabel.Size = new System.Drawing.Size(0, 25);
            this.HallCreatorNmeOfHallLabel.TabIndex = 7;
            // 
            // HallCteatorHowManyRowsLabel
            // 
            this.HallCteatorHowManyRowsLabel.AutoSize = true;
            this.HallCteatorHowManyRowsLabel.Location = new System.Drawing.Point(362, 54);
            this.HallCteatorHowManyRowsLabel.Name = "HallCteatorHowManyRowsLabel";
            this.HallCteatorHowManyRowsLabel.Size = new System.Drawing.Size(0, 17);
            this.HallCteatorHowManyRowsLabel.TabIndex = 5;
            // 
            // HallCteatorHowManyCollumnsLabel
            // 
            this.HallCteatorHowManyCollumnsLabel.AutoSize = true;
            this.HallCteatorHowManyCollumnsLabel.Location = new System.Drawing.Point(362, 75);
            this.HallCteatorHowManyCollumnsLabel.Name = "HallCteatorHowManyCollumnsLabel";
            this.HallCteatorHowManyCollumnsLabel.Size = new System.Drawing.Size(0, 17);
            this.HallCteatorHowManyCollumnsLabel.TabIndex = 6;
            // 
            // HallCreateTable
            // 
            this.HallCreateTable.AutoScroll = true;
            this.HallCreateTable.ColumnCount = 1;
            this.HallCreateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.HallCreateTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.HallCreateTable.Location = new System.Drawing.Point(3, 3);
            this.HallCreateTable.Name = "HallCreateTable";
            this.HallCreateTable.RowCount = 1;
            this.HallCreateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HallCreateTable.Size = new System.Drawing.Size(843, 366);
            this.HallCreateTable.TabIndex = 0;
            this.HallCreateTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // HallCreatePanel
            // 
            this.HallCreatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HallCreatePanel.AutoScroll = true;
            this.HallCreatePanel.Controls.Add(this.HallCreateTable);
            this.HallCreatePanel.Location = new System.Drawing.Point(12, 234);
            this.HallCreatePanel.Name = "HallCreatePanel";
            this.HallCreatePanel.Size = new System.Drawing.Size(957, 436);
            this.HallCreatePanel.TabIndex = 8;
            // 
            // HallCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 682);
            this.Controls.Add(this.HallCreatePanel);
            this.Controls.Add(this.HallCreatorNmeOfHallLabel);
            this.Controls.Add(this.HallCteatorHowManyCollumnsLabel);
            this.Controls.Add(this.HallCteatorHowManyRowsLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HallCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HallCreatorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HallCreatePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label HallCreatorNmeOfHallLabel;
        private System.Windows.Forms.Label HallCteatorHowManyRowsLabel;
        private System.Windows.Forms.Label HallCteatorHowManyCollumnsLabel;
        private System.Windows.Forms.TableLayoutPanel HallCreateTable;
        private System.Windows.Forms.Panel HallCreatePanel;
    }
}