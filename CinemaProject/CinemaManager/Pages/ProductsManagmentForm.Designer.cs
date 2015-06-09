namespace CinemaManager.Pages
{
    partial class ProductsManagmentForm
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
            this.panelOfProducts = new System.Windows.Forms.Panel();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.productsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelListProducts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listTickets = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddSubCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listSubCategories = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.listMainCategories = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panelOfProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOfProducts
            // 
            this.panelOfProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOfProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.panelOfProducts.Controls.Add(this.addNewProductButton);
            this.panelOfProducts.Controls.Add(this.productsListView);
            this.panelOfProducts.Controls.Add(this.labelListProducts);
            this.panelOfProducts.Location = new System.Drawing.Point(0, 1);
            this.panelOfProducts.Margin = new System.Windows.Forms.Padding(0);
            this.panelOfProducts.Name = "panelOfProducts";
            this.panelOfProducts.Size = new System.Drawing.Size(922, 278);
            this.panelOfProducts.TabIndex = 18;
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.addNewProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewProductButton.FlatAppearance.BorderSize = 0;
            this.addNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProductButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewProductButton.ForeColor = System.Drawing.Color.White;
            this.addNewProductButton.Location = new System.Drawing.Point(674, 12);
            this.addNewProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(245, 44);
            this.addNewProductButton.TabIndex = 21;
            this.addNewProductButton.Text = "Dodaj nowy produkt";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // productsListView
            // 
            this.productsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.productsListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productsListView.FullRowSelect = true;
            this.productsListView.GridLines = true;
            this.productsListView.Location = new System.Drawing.Point(3, 69);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(916, 205);
            this.productsListView.TabIndex = 6;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.productsListView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ilość";
            this.columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena";
            this.columnHeader3.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Główna kategoria";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Podkategoria";
            this.columnHeader5.Width = 2;
            // 
            // labelListProducts
            // 
            this.labelListProducts.AutoSize = true;
            this.labelListProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelListProducts.ForeColor = System.Drawing.Color.White;
            this.labelListProducts.Location = new System.Drawing.Point(3, 22);
            this.labelListProducts.Name = "labelListProducts";
            this.labelListProducts.Size = new System.Drawing.Size(169, 24);
            this.labelListProducts.TabIndex = 4;
            this.labelListProducts.Text = "Lista produktów";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.listTickets);
            this.panel1.Controls.Add(this.buttonAddTicket);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonAddSubCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listSubCategories);
            this.panel1.Controls.Add(this.buttonAddCategory);
            this.panel1.Controls.Add(this.listMainCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 316);
            this.panel1.TabIndex = 22;
            // 
            // listTickets
            // 
            this.listTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listTickets.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listTickets.FullRowSelect = true;
            this.listTickets.GridLines = true;
            this.listTickets.Location = new System.Drawing.Point(591, 103);
            this.listTickets.MultiSelect = false;
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(328, 210);
            this.listTickets.TabIndex = 27;
            this.listTickets.UseCompatibleStateImageBehavior = false;
            this.listTickets.View = System.Windows.Forms.View.Details;
            this.listTickets.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listTickets_MouseUp);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nazwa";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cena";
            this.columnHeader8.Width = 150;
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonAddTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddTicket.FlatAppearance.BorderSize = 0;
            this.buttonAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTicket.ForeColor = System.Drawing.Color.White;
            this.buttonAddTicket.Location = new System.Drawing.Point(591, 56);
            this.buttonAddTicket.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(328, 44);
            this.buttonAddTicket.TabIndex = 26;
            this.buttonAddTicket.Text = "Dodaj nowy bilet";
            this.buttonAddTicket.UseVisualStyleBackColor = false;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(587, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bilety";
            // 
            // buttonAddSubCategory
            // 
            this.buttonAddSubCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonAddSubCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddSubCategory.FlatAppearance.BorderSize = 0;
            this.buttonAddSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddSubCategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddSubCategory.Location = new System.Drawing.Point(219, 56);
            this.buttonAddSubCategory.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonAddSubCategory.Name = "buttonAddSubCategory";
            this.buttonAddSubCategory.Size = new System.Drawing.Size(300, 44);
            this.buttonAddSubCategory.TabIndex = 24;
            this.buttonAddSubCategory.Text = "Dodaj nową podkategorie";
            this.buttonAddSubCategory.UseVisualStyleBackColor = false;
            this.buttonAddSubCategory.Click += new System.EventHandler(this.buttonAddSubCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lista podkategorii";
            // 
            // listSubCategories
            // 
            this.listSubCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSubCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listSubCategories.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listSubCategories.FullRowSelect = true;
            this.listSubCategories.GridLines = true;
            this.listSubCategories.Location = new System.Drawing.Point(219, 103);
            this.listSubCategories.MultiSelect = false;
            this.listSubCategories.Name = "listSubCategories";
            this.listSubCategories.Size = new System.Drawing.Size(300, 210);
            this.listSubCategories.TabIndex = 22;
            this.listSubCategories.UseCompatibleStateImageBehavior = false;
            this.listSubCategories.View = System.Windows.Forms.View.Details;
            this.listSubCategories.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listSubCategories_MouseUp);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Nazwa";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Kategoria główna";
            this.columnHeader12.Width = 150;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.buttonAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddCategory.FlatAppearance.BorderSize = 0;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddCategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddCategory.Location = new System.Drawing.Point(3, 56);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(200, 44);
            this.buttonAddCategory.TabIndex = 21;
            this.buttonAddCategory.Text = "Dodaj nową kategorie";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // listMainCategories
            // 
            this.listMainCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMainCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listMainCategories.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listMainCategories.FullRowSelect = true;
            this.listMainCategories.GridLines = true;
            this.listMainCategories.Location = new System.Drawing.Point(3, 103);
            this.listMainCategories.MultiSelect = false;
            this.listMainCategories.Name = "listMainCategories";
            this.listMainCategories.Size = new System.Drawing.Size(200, 210);
            this.listMainCategories.TabIndex = 6;
            this.listMainCategories.UseCompatibleStateImageBehavior = false;
            this.listMainCategories.View = System.Windows.Forms.View.Details;
            this.listMainCategories.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listMainCategories_MouseUp);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nazwa";
            this.columnHeader6.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista kategorii";
            // 
            // ProductsManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(923, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOfProducts);
            this.Name = "ProductsManagmentForm";
            this.Text = "ProductsManagmentForm";
            this.Resize += new System.EventHandler(this.ProductsManagmentForm_Resize);
            this.panelOfProducts.ResumeLayout(false);
            this.panelOfProducts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfProducts;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelListProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddSubCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listSubCategories;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ListView listMainCategories;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listTickets;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Label label3;
    }
}