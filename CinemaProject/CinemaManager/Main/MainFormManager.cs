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

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            selectPage(new EmployeesManagementForm());
        }

        private void MovieButton_Click(object sender, EventArgs e)
        {
            selectPage(new MoviesManagementForm());
        }

        private void MovieHallsButton_Click(object sender, EventArgs e)
        {
            selectPage(new ShowManagementForm());
        }

        private void ShiftsAndPositionsButton_Click(object sender, EventArgs e)
        {
            selectPage(new ShiftsForm());
        }

        private void SalesStatisticsButton_Click(object sender, EventArgs e)
        {
            selectPage(new CinemaStatistic());
        }

        private void MovieStatisticsButton_Click(object sender, EventArgs e)
        {
            selectPage(new MovieStatistic());
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            selectPage(new ProductsManagmentForm());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
