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
    public partial class EditSubCategory : Form
    {
        CinemaModel.Categories category;

        public EditSubCategory(int ID)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                category = ctx.Categories.FirstOrDefault(x => x.categoryID.Equals(ID));
            }

            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
            this.nameEditTextbox.Text = this.category.name;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var mainCategories = ctx.Categories.Where(x => x.mainCat == true);

                foreach (var item in mainCategories)
                {
                    ComboboxItem combo = new ComboboxItem();
                    combo.Text = item.name;
                    combo.Value = item.categoryID;
                    ComboboxMainCategories.Items.Add(combo);
                    if (category.parentCat == item.categoryID)
                    {
                        ComboboxMainCategories.SelectedIndex = (ComboboxMainCategories.Items.Count - 1);
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

                    this.category.name = nameEditTextbox.Text;
                    this.category.slug = CinemaManager.Pages.ProductsManagmentForm.ToSlug(nameEditTextbox.Text);
                    ComboboxItem itm = (ComboboxItem)ComboboxMainCategories.SelectedItem;
                    category.parentCat = itm.Value;

                    ctx.Entry(this.category).State = System.Data.Entity.EntityState.Modified;

                    ctx.SaveChanges();
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Edytowano kategorie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (this.nameEditTextbox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
