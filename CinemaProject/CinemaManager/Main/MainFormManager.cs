using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Pages;

namespace CinemaManager.Main
{
    public partial class MainFormManager : Form
    {
        public MainFormManager()
        {
            InitializeComponent();
        }

        private void selectPage(Form page)
        {
            Cursor.Current = Cursors.WaitCursor;

            page.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();

            Cursor.Current = Cursors.Default;
        }

        private void HallCreatorButton_Click(object sender, EventArgs e)
        {
            selectPage(new HallCreatorForm());
        }
    }
}
