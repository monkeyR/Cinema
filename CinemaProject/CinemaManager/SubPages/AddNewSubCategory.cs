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
    public partial class AddNewSubCategory : Form
    {
        public AddNewSubCategory()
        {

            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var mainCategories = ctx.Categories.Where(x => x.mainCat == true);

                foreach (var item in mainCategories)
                {
                    ComboboxItem combo = new ComboboxItem();
                    combo.Text = item.name;
                    combo.Value = item.categoryID;
                    ComboboxMainCategories.Items.Add(combo);
                }

                ComboboxMainCategories.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkIfEmpty())
            {
                Cursor.Current = Cursors.WaitCursor;

                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    CinemaModel.Categories category = new CinemaModel.Categories();

                    category.name = nameTextbox.Text;
                    category.slug = CinemaManager.Pages.ProductsManagmentForm.ToSlug(nameTextbox.Text);
                    category.mainCat = false;
                    ComboboxItem itm = (ComboboxItem)ComboboxMainCategories.SelectedItem;
                    category.parentCat = itm.Value;

                    ctx.Categories.Add(category);
                    ctx.Entry(category).State = System.Data.Entity.EntityState.Added;

                    ctx.SaveChanges();
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Dodano nową kategorie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
