﻿namespace CinemaManager.SubPages
{
    partial class EditTicket
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
            this.labelListProducts = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddNewcategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelListProducts
            // 
            this.labelListProducts.AutoSize = true;
            this.labelListProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelListProducts.ForeColor = System.Drawing.Color.White;
            this.labelListProducts.Location = new System.Drawing.Point(58, 9);
            this.labelListProducts.Name = "labelListProducts";
            this.labelListProducts.Size = new System.Drawing.Size(182, 24);
            this.labelListProducts.TabIndex = 5;
            this.labelListProducts.Text = "Dodaj nowy bilet";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(25, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 21);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Nazwa:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameTextbox.Location = new System.Drawing.Point(96, 71);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(168, 26);
            this.nameTextbox.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(29, 156);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 44);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonAddNewcategory
            // 
            this.buttonAddNewcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonAddNewcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddNewcategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddNewcategory.FlatAppearance.BorderSize = 0;
            this.buttonAddNewcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewcategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewcategory.Location = new System.Drawing.Point(160, 156);
            this.buttonAddNewcategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewcategory.Name = "buttonAddNewcategory";
            this.buttonAddNewcategory.Size = new System.Drawing.Size(104, 44);
            this.buttonAddNewcategory.TabIndex = 34;
            this.buttonAddNewcategory.Text = "Dodaj";
            this.buttonAddNewcategory.UseVisualStyleBackColor = false;
            this.buttonAddNewcategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cena:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(96, 107);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(139, 26);
            this.textBoxPrice.TabIndex = 36;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "zł";
            // 
            // AddNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(292, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNewcategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.labelListProducts);
            this.Name = "AddNewTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj nowy bilet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListProducts;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNewcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
    }
}