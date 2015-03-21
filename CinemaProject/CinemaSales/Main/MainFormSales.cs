using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales.Main
{
    public partial class MainFormSales : Form
    {
        public MainFormSales()
        {
            InitializeComponent();
        }

        private void selectPage(Form page)
        {
            Cursor.Current = Cursors.WaitCursor;

            page.TopLevel = false;
            MainSalesPanel.Controls.Clear();
            MainSalesPanel.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();

            Cursor.Current = Cursors.Default;

        }

        private void ticketTabButton_Click(object sender, EventArgs e)
        {
            selectPage(new BuyTicketsForm());
        }

        private void BarTabButton_Click(object sender, EventArgs e)
        {
            selectPage(new BuyProductsForm());
        }

    }
}
