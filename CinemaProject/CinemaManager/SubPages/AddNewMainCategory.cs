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
    public partial class AddNewMainCategory : Form
    {
        public AddNewMainCategory()
        {
            InitializeComponent();
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
                    category.mainCat = true;
                    category.parentCat = 0;

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
}
