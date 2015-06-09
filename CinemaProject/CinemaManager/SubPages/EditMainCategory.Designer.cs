namespace CinemaManager.SubPages
{
    partial class EditMainCategory
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
            this.nameEditTextbox = new System.Windows.Forms.TextBox();
            this.buttonEditCancel = new System.Windows.Forms.Button();
            this.buttonEditNewcategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListProducts
            // 
            this.labelListProducts.AutoSize = true;
            this.labelListProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelListProducts.ForeColor = System.Drawing.Color.White;
            this.labelListProducts.Location = new System.Drawing.Point(58, 9);
            this.labelListProducts.Name = "labelListProducts";
            this.labelListProducts.Size = new System.Drawing.Size(178, 24);
            this.labelListProducts.TabIndex = 5;
            this.labelListProducts.Text = "Edytuj  kategorie";
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
            // nameEditTextbox
            // 
            this.nameEditTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameEditTextbox.Location = new System.Drawing.Point(96, 71);
            this.nameEditTextbox.Name = "nameEditTextbox";
            this.nameEditTextbox.Size = new System.Drawing.Size(168, 26);
            this.nameEditTextbox.TabIndex = 7;
            // 
            // buttonEditCancel
            // 
            this.buttonEditCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonEditCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditCancel.FlatAppearance.BorderSize = 0;
            this.buttonEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCancel.ForeColor = System.Drawing.Color.White;
            this.buttonEditCancel.Location = new System.Drawing.Point(29, 128);
            this.buttonEditCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditCancel.Name = "buttonEditCancel";
            this.buttonEditCancel.Size = new System.Drawing.Size(104, 44);
            this.buttonEditCancel.TabIndex = 33;
            this.buttonEditCancel.Text = "Anuluj";
            this.buttonEditCancel.UseVisualStyleBackColor = false;
            this.buttonEditCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonEditNewcategory
            // 
            this.buttonEditNewcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonEditNewcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditNewcategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditNewcategory.FlatAppearance.BorderSize = 0;
            this.buttonEditNewcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditNewcategory.ForeColor = System.Drawing.Color.White;
            this.buttonEditNewcategory.Location = new System.Drawing.Point(160, 128);
            this.buttonEditNewcategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditNewcategory.Name = "buttonEditNewcategory";
            this.buttonEditNewcategory.Size = new System.Drawing.Size(104, 44);
            this.buttonEditNewcategory.TabIndex = 34;
            this.buttonEditNewcategory.Text = "Edytuj";
            this.buttonEditNewcategory.UseVisualStyleBackColor = false;
            this.buttonEditNewcategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewMainCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(292, 189);
            this.Controls.Add(this.buttonEditNewcategory);
            this.Controls.Add(this.buttonEditCancel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameEditTextbox);
            this.Controls.Add(this.labelListProducts);
            this.Name = "AddNewMainCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj nową kategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListProducts;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameEditTextbox;
        private System.Windows.Forms.Button buttonEditCancel;
        private System.Windows.Forms.Button buttonEditNewcategory;
    }
}