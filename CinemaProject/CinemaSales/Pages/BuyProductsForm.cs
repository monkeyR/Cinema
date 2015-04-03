using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CinemaSales.Main
{
    public partial class BuyProductsForm : Form
    {

        public IDictionary<string, string> MainCategories = new Dictionary<string, string>();
        public int CurrentCategory;
        private Bin MainBin;

        public BuyProductsForm(Bin B)
        {
            InitializeComponent();
            this.MainBin = B;
            this.DisplayCategories();
            this.DisplayProductsLayout();
            
            //this.TEST();
        }

        private void SuspendLayoutAll()
        {
            this.SuspendLayout();
            MainProductsPanel.SuspendLayout();
            MainProductsPanel.ResumeLayout();
        }

        private void ResumeLayoutAll()
        {
            this.ResumeLayout();
            MainProductsPanel.ResumeLayout();
        }

        private void TEST()
        {
            System.Windows.Forms.FlowLayoutPanel LayoutProductsPanel = new System.Windows.Forms.FlowLayoutPanel();

            LayoutProductsPanel.SuspendLayout();

            this.MainProductsPanel.Controls.Add(LayoutProductsPanel);

            LayoutProductsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.flowLayoutPanel1.Controls.Add(this.button4);
            LayoutProductsPanel.Location = new System.Drawing.Point(0, MainProductsPanel.Controls.Count * 111);
            LayoutProductsPanel.Margin = new System.Windows.Forms.Padding(0);
            LayoutProductsPanel.Name = "FlowLayoutPanel123";
            LayoutProductsPanel.Size = new System.Drawing.Size(499, 106);
            LayoutProductsPanel.TabIndex = MainProductsPanel.Controls.Count;
            //LayoutProductsPanel.Tag = 1;
            LayoutProductsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));

            LayoutProductsPanel.ResumeLayout(false);
        }
        private void DisplayCategories()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Categories = (from t in ctx.Categories
                             where t.mainCat.Equals(true)
                             select t);
                this.CurrentCategory = Categories.First().categoryID;

                foreach (var cat in Categories)
                {
                    MainCategories.Add(cat.slug, cat.name);
                    AddButtonToCategoriesPanel(CreateButtonCategory(cat.name, cat.slug, cat.categoryID));
                }
                
            }
        }

        private void AddButtonToCategoriesPanel(System.Windows.Forms.Button btn){

            int LocationY = (CategoriesPanel.Controls.Count * btn.Height) + CategoriesPanel.Controls.Count * 5;
            btn.Location = new System.Drawing.Point(0, LocationY);
            this.CategoriesPanel.Controls.Add(btn);

        }

        private void ActiveButton(object sender, EventArgs e)
        {

            foreach (var item in this.CategoriesPanel.Controls)
	        {
                ((Button)item).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
	        }

            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
        }

        private System.Windows.Forms.Button CreateButtonCategory(string name, string slug, int ID){

            System.Windows.Forms.Button ButtonCat = new System.Windows.Forms.Button();
            ButtonCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            ButtonCat.FlatAppearance.BorderSize = 0;
            ButtonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonCat.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ButtonCat.ForeColor = System.Drawing.Color.White;
            ButtonCat.Margin = new System.Windows.Forms.Padding(0);
            ButtonCat.Name = slug+"Button";
            ButtonCat.Size = new System.Drawing.Size(100, 60);
            ButtonCat.TabIndex = CategoriesPanel.Controls.Count;
            ButtonCat.Text = name;
            ButtonCat.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonCat.Tag = ID;
            ButtonCat.UseVisualStyleBackColor = false;
            ButtonCat.Click += new System.EventHandler(DisplayProducts);
            ButtonCat.Click += new System.EventHandler(ActiveButton);
            return ButtonCat;
        }



        private void DisplayProducts(object sender, EventArgs e)
        {
            MainProductsPanel.Controls.Clear();
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            CurrentCategory = (int)btn.Tag;
            DisplayProductsLayout((int)btn.Tag);
        }

        private void DisplayProductsLayout(int Cat = 0)
        {
            if (Cat == 0)
            {
                if (CurrentCategory != 0)
                {
                    using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                    {
                        var SubCategories = (from c in ctx.Categories where c.parentCat == CurrentCategory select c);

                        foreach (var item in SubCategories)
                        {
                            System.Windows.Forms.FlowLayoutPanel FLP = AddLayoutPanelToProductPanel(item);
                            AddProductsToLayoutPanel(FLP);
                        }

                    }
                }  
            }
            else
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    var SubCategories = (from c in ctx.Categories where c.parentCat == Cat select c);

                    foreach (var item in SubCategories)
                    {
                        System.Windows.Forms.FlowLayoutPanel FLP = AddLayoutPanelToProductPanel(item);
                        AddProductsToLayoutPanel(FLP);
                    }

                }
            }
        }

        private System.Windows.Forms.Button CreateProductButton(CinemaModel.Products product, int tabi)
        {
            System.Windows.Forms.Button ButtonProduct = new System.Windows.Forms.Button();
            ButtonProduct.BackgroundImage = Common.ResourcesApp.GetImg(product.slug);
            ButtonProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            //ButtonProduct.Text = product.name;
            ButtonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            ButtonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonProduct.Name = product.slug;
            ButtonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonProduct.Size = new System.Drawing.Size(100, 100);
            ButtonProduct.TabIndex = tabi;
            ButtonProduct.UseVisualStyleBackColor = true;
            ButtonProduct.Tag = product;
            ButtonProduct.Click += new System.EventHandler(MainBin.AddProduct);
            return ButtonProduct;
            
        }

        private void AddProductsToLayoutPanel(System.Windows.Forms.FlowLayoutPanel FLP)
        {
            var Products = GetProductsFromSubCategory((int)FLP.Tag);
            SuspendLayoutAll();
            FLP.SuspendLayout();

            foreach (var item in Products)
            {
                FLP.Controls.Add(CreateProductButton(item, FLP.Controls.Count));
            }

            FLP.ResumeLayout();
            ResumeLayoutAll();
        }

        private System.Windows.Forms.FlowLayoutPanel AddLayoutPanelToProductPanel(CinemaModel.Categories SubCat)
        {

            System.Windows.Forms.FlowLayoutPanel LayoutProductsPanel = new System.Windows.Forms.FlowLayoutPanel();
            LayoutProductsPanel.SuspendLayout();


            LayoutProductsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            LayoutProductsPanel.Location = new System.Drawing.Point(0, MainProductsPanel.Controls.Count * 111);
            LayoutProductsPanel.Margin = new System.Windows.Forms.Padding(0);
            LayoutProductsPanel.Name = SubCat.slug+"FlowLayoutPanel"+MainProductsPanel.Controls.Count.ToString();
            LayoutProductsPanel.Size = new System.Drawing.Size(499, 106);
            LayoutProductsPanel.TabIndex = MainProductsPanel.Controls.Count;
            LayoutProductsPanel.Tag = SubCat.categoryID;

            MainProductsPanel.Controls.Add(LayoutProductsPanel);

            LayoutProductsPanel.ResumeLayout(false);
            return LayoutProductsPanel;
            
        }

        private CinemaModel.Products[] GetProductsFromSubCategory(int ID)
        {
            //System.Linq.IQueryable<CinemaModel.Products> Products;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Products = (from t in ctx.Products where t.sub_category == ID select t).ToArray();
                return Products;
            }
            
        }


        private void AddToBin(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BuyProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
