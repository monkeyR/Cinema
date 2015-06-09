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
    public partial class AddNewTicket : Form
    {
        public AddNewTicket()
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
                    try
                    {
                        CinemaModel.Tickets ticket = new CinemaModel.Tickets();

                        ticket.name = nameTextbox.Text;
                        this.textBoxPrice.Text = this.textBoxPrice.Text.Replace(".", ",");

                        ticket.price = Convert.ToDecimal(textBoxPrice.Text);

                        ctx.Tickets.Add(ticket);
                        ctx.Entry(ticket).State = System.Data.Entity.EntityState.Added;

                        ctx.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        this.showError(ex);
                    }
                    
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Dodano nowy bilet", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
