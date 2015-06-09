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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {

            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
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
                    }
                    else
                    {
                        this.comboSubCategory.Items.Add(combo);
                    }
                }

                this.ComboboxMainCategories.SelectedIndex = 0;
                this.comboSubCategory.SelectedIndex = 0;
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
                        CinemaModel.Products product = new CinemaModel.Products();

                        product.name = nameTextbox.Text;
                        product.slug = CinemaManager.Pages.ProductsManagmentForm.ToSlug(nameTextbox.Text);
                        product.amount = Convert.ToInt32(this.textBoxAmount.Text);
                        product.price = Convert.ToDecimal(this.textBoxPrice.Text);

                        ComboboxItem itm = (ComboboxItem)ComboboxMainCategories.SelectedItem;
                        product.main_category = itm.Value;
                        itm = (ComboboxItem)comboSubCategory.SelectedItem;
                        product.sub_category = itm.Value;

                        ctx.Products.Add(product);
                        ctx.Entry(product).State = System.Data.Entity.EntityState.Added;

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
                MessageBox.Show("Dodano nowy produkt", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
