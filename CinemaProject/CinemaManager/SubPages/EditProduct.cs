using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.SubPages
{
    public partial class EditProduct : Form
    {
        CinemaModel.Products product;
        public EditProduct(int ID)
        {

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                product = ctx.Products.FirstOrDefault(x => x.productID.Equals(ID));
            }

            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
            this.nameTextbox.Text = this.product.name;
            this.textBoxAmount.Text = this.product.amount.ToString();
            this.textBoxPrice.Text = this.product.price.ToString();

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var Categories = ctx.Categories;

                foreach (var item in Categories)
                {
                    ComboboxItem combo = new ComboboxItem();
                    combo.Text = item.name;
                    combo.Value = item.categoryID;
                    if (item.mainCat == true)
                    {
                        this.ComboboxMainCategories.Items.Add(combo);
                        if (product.main_category == item.categoryID)
                        {
                            this.ComboboxMainCategories.SelectedIndex = (this.ComboboxMainCategories.Items.Count - 1);
                        }
                    }
                    else
                    {
                        this.comboSubCategory.Items.Add(combo);
                        if (product.sub_category == item.categoryID)
                        {
                            this.comboSubCategory.SelectedIndex = (this.comboSubCategory.Items.Count - 1);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkIfEmpty())
            {
                Cursor.Current = Cursors.WaitCursor;
                
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    try
                    {
                        this.product.name = nameTextbox.Text;
                        this.product.slug = CinemaManager.Pages.ProductsManagmentForm.ToSlug(nameTextbox.Text);
                        this.product.amount = Convert.ToInt32(this.textBoxAmount.Text);
                        this.product.price = Convert.ToDecimal(this.textBoxPrice.Text);

                        ComboboxItem itm = (ComboboxItem)ComboboxMainCategories.SelectedItem;
                        this.product.main_category = itm.Value;
                        itm = (ComboboxItem)comboSubCategory.SelectedItem;
                        this.product.sub_category = itm.Value;

                        ctx.Entry(this.product).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        this.showError(ex);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Edytowano produkt", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij wszystkie pola", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private bool checkIfEmpty()
        {
            if (this.nameTextbox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void showError(Exception ex)
        {
            String message = "Wystąpił błąd: " + ex.Message;
            MessageBox.Show(message);
        }

    }

}
