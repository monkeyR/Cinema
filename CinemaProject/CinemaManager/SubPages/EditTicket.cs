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
    public partial class EditTicket : Form
    {
        CinemaModel.Tickets ticket;
        public EditTicket(int ID)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                ticket = ctx.Tickets.FirstOrDefault(x => x.ticketID.Equals(ID));
            }

            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
            this.nameTextbox.Text = this.ticket.name;
            this.textBoxPrice.Text = this.ticket.price.ToString();
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

                        this.ticket.name = nameTextbox.Text;
                        this.ticket.price = Convert.ToDecimal(textBoxPrice.Text);
                        ctx.Entry(this.ticket).State = System.Data.Entity.EntityState.Modified;

                        ctx.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        this.showError(ex);
                    }
                    
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Edytowano bilet", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (this.nameTextbox.Text == string.Empty || this.textBoxPrice.Text == string.Empty)
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
