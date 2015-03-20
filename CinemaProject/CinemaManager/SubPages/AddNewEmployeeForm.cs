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
    public partial class AddNewEmployeeForm : Form
    {
        public AddNewEmployeeForm()
        {
            InitializeComponent();

            startFilling();
        }

        private void startFilling()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += fillWithData;
            worker.RunWorkerCompleted += onWorkerCompleted;
            Cursor.Current = Cursors.WaitCursor;
            worker.RunWorkerAsync();
        }

        private void onWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
        private void fillWithData(object sender, DoWorkEventArgs e)
        {
            fillPositions();
        }

        private void fillPositions()
        {
            foreach (var item in Enum.GetValues(typeof(Common.EmployeeTypes.Types)))
            {
                Common.UISynchronizer.synchronizeWithUI(positionsCombobox, x => positionsCombobox.Items.Add(x), item);
            }

            Common.UISynchronizer.synchronizeWithUI(positionsCombobox, x => positionsCombobox.SelectedIndex = x, 0);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checkIfEmpty())
            {
                Cursor.Current = Cursors.WaitCursor;

                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    CinemaModel.Employees employee = new CinemaModel.Employees();

                    employee.name = nameTextbox.Text;
                    employee.surname = surnameTextbox.Text;
                    employee.login = loginTextbox.Text;
                    employee.password = passwordTextbox.Text;
                    employee.position = (int)(Common.EmployeeTypes.Types)Enum.Parse(typeof(Common.EmployeeTypes.Types), positionsCombobox.Text);
                    employee.isFired = false;

                    ctx.Employees.Add(employee);
                    ctx.Entry(employee).State = System.Data.Entity.EntityState.Added;

                    ctx.SaveChanges();
                }

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Dodano nowego pracownika", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij wszystkie pola", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool checkIfEmpty()
        {
            if (nameTextbox.Text == string.Empty ||
                surnameTextbox.Text == string.Empty ||
                loginTextbox.Text == string.Empty ||
                passwordTextbox.Text == string.Empty ||
                positionsCombobox.Text == string.Empty)
                return false;
            return true;
        }
    }
}
