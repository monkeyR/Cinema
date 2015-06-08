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
            this.panelOfProducts.SuspendLayout();
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
            this.panelOfProducts.Size = new System.Drawing.Size(796, 328);
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
            this.addNewProductButton.Location = new System.Drawing.Point(635, 12);
            this.addNewProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(158, 44);
            this.addNewProductButton.TabIndex = 21;
            this.addNewProductButton.Text = "Dodaj nowy";
            this.addNewProductButton.UseVisualStyleBackColor = false;
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
            this.productsListView.Size = new System.Drawing.Size(790, 256);
            this.productsListView.TabIndex = 6;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
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
            // ProductsManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(797, 358);
            this.Controls.Add(this.panelOfProducts);
            this.Name = "ProductsManagmentForm";
            this.Text = "ProductsManagmentForm";
            this.Resize += new System.EventHandler(this.ProductsManagmentForm_Resize);
            this.panelOfProducts.ResumeLayout(false);
            this.panelOfProducts.PerformLayout();
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
    }
}