namespace CinemaManager.SubPages
{
    partial class EditMovieForm
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
            this.categoryTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.durationLabel = new System.Windows.Forms.Label();
            this.zlTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.directorTextbox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTextbox
            // 
            this.categoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryTextbox.Location = new System.Drawing.Point(103, 185);
            this.categoryTextbox.Name = "categoryTextbox";
            this.categoryTextbox.Size = new System.Drawing.Size(121, 26);
            this.categoryTextbox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kategoria";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(283, 435);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 44);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Edytuj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "gr";
            // 
            // grTextbox
            // 
            this.grTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grTextbox.Location = new System.Drawing.Point(171, 116);
            this.grTextbox.MaxLength = 2;
            this.grTextbox.Name = "grTextbox";
            this.grTextbox.Size = new System.Drawing.Size(25, 26);
            this.grTextbox.TabIndex = 4;
            this.grTextbox.Text = "00";
            this.grTextbox.Leave += new System.EventHandler(this.grTextbox_Leave);
            this.grTextbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grTextbox_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "zł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Opis";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptionTextbox.Location = new System.Drawing.Point(13, 258);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTextbox.Size = new System.Drawing.Size(345, 172);
            this.descriptionTextbox.TabIndex = 6;
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durationNumericUpDown.Location = new System.Drawing.Point(103, 148);
            this.durationNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(71, 26);
            this.durationNumericUpDown.TabIndex = 5;
            this.durationNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationNumericUpDown_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.categoryTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.grTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descriptionTextbox);
            this.panel1.Controls.Add(this.durationNumericUpDown);
            this.panel1.Controls.Add(this.durationLabel);
            this.panel1.Controls.Add(this.zlTextbox);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.directorLabel);
            this.panel1.Controls.Add(this.directorTextbox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.titleTextbox);
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 481);
            this.panel1.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(2, 435);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 44);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.durationLabel.ForeColor = System.Drawing.Color.White;
            this.durationLabel.Location = new System.Drawing.Point(26, 149);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(70, 21);
            this.durationLabel.TabIndex = 26;
            this.durationLabel.Text = "Długość";
            // 
            // zlTextbox
            // 
            this.zlTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zlTextbox.Location = new System.Drawing.Point(103, 116);
            this.zlTextbox.MaxLength = 3;
            this.zlTextbox.Name = "zlTextbox";
            this.zlTextbox.Size = new System.Drawing.Size(38, 26);
            this.zlTextbox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(50, 118);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(46, 21);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edytuj film";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.directorLabel.ForeColor = System.Drawing.Color.White;
            this.directorLabel.Location = new System.Drawing.Point(30, 86);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(66, 21);
            this.directorLabel.TabIndex = 4;
            this.directorLabel.Text = "Reżyser";
            // 
            // directorTextbox
            // 
            this.directorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.directorTextbox.Location = new System.Drawing.Point(103, 84);
            this.directorTextbox.Name = "directorTextbox";
            this.directorTextbox.Size = new System.Drawing.Size(121, 26);
            this.directorTextbox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(49, 54);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(47, 21);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Tytuł";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleTextbox.Location = new System.Drawing.Point(103, 52);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(121, 26);
            this.titleTextbox.TabIndex = 1;
            // 
            // EditMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(400, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edycja filmu";
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox categoryTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox zlTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox directorTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextbox;


    }
}