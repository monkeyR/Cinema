using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Main
{
    public partial class MainFormManager : Form
    {
        private Button currentSelectedPageButton = null;

        public MainFormManager()
        {
            InitializeComponent();
        }

        private void selectPage(Form page, Button pageButton)
        {
            Cursor.Current = Cursors.WaitCursor;

            page.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();

            switchButton(pageButton);
            currentSelectedPageButton = pageButton;

            Cursor.Current = Cursors.Default;
        }

        private void switchButton(Button newButton)
        {
            if (currentSelectedPageButton != null)
            {
                currentSelectedPageButton.Enabled = false;
                currentSelectedPageButton.BackColor = Color.White;
            }

            newButton.Enabled = true;
            newButton.BackColor = Color.Red;
        }

        private void SalesStatisticsButton_Click(object sender, EventArgs e)
        {
            switchButton((Button)sender);
            //selectPage
        }
    }
}
