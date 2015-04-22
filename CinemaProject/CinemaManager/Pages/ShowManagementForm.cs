using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.SubPages;

namespace CinemaManager.Pages
{
    public partial class ShowManagementForm : Form
    {

        public ShowManagementForm()
        {
            InitializeComponent();
        }

        private void ShowManagementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value;
            AddShowForm form = new AddShowForm(datePicker.Value, 2);
            form.Show();
        }
    }
}
