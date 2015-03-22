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
    public partial class EditEmployee : Form
    {
        CinemaModel.Employees employee;

        public EditEmployee(int empId)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                employee = ctx.Employees.FirstOrDefault(x => x.employeeID.Equals(empId));
            }

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
            insertEmployeeData();
        }

        private void insertEmployeeData()
        {
            Common.UISynchronizer.synchronizeWithUI(nameTextbox, x => nameTextbox.Text = x, employee.name);
            Common.UISynchronizer.synchronizeWithUI(surnameTextbox, x => surnameTextbox.Text = x, employee.surname);
            Common.UISynchronizer.synchronizeWithUI(loginTextbox, x => loginTextbox.Text = x, employee.login);
            Common.UISynchronizer.synchronizeWithUI(passwordTextbox, x => passwordTextbox.Text = x, employee.password);

            fillPositions();
        }

        private void fillPositions()
        {
            foreach (var item in Enum.GetValues(typeof(Common.EmployeeTypes.Types)))
            {
                Common.UISynchronizer.synchronizeWithUI(positionsCombobox, x => positionsCombobox.Items.Add(x), item);
            }

            Common.UISynchronizer.synchronizeWithUI(positionsCombobox, x => positionsCombobox.SelectedIndex = x, employee.position);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Employees editedEmployee = new CinemaModel.Employees();

                editedEmployee.name = nameTextbox.Text;
                editedEmployee.surname = surnameTextbox.Text;
                editedEmployee.login = loginTextbox.Text;
                editedEmployee.position = (int)(Common.EmployeeTypes.Types)Enum.Parse(typeof(Common.EmployeeTypes.Types), positionsCombobox.Text);
                editedEmployee.password = passwordTextbox.Text;

                if (!checkIfEquals(editedEmployee))
                {
                    if (checkIfEmpty())
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        changeEmployee(editedEmployee);
                        ctx.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();

                        MessageBox.Show("Zmiana została wykonana", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cursor.Current = Cursors.Default;

                        this.Close();
                    }

                    else
                        MessageBox.Show("Uzupełnij wszystkie pola", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Brak zmian do edycji pracownika", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkIfEquals(CinemaModel.Employees editedEmployee)
        {
            if (employee.name == editedEmployee.name &&
                employee.surname == editedEmployee.surname &&
                employee.position == editedEmployee.position &&
                employee.login == editedEmployee.login &&
                employee.password == editedEmployee.password)
                return true;
            return false;
        }

        private bool checkIfEmpty()
        {
            if (nameTextbox.Text == string.Empty ||
                surnameTextbox.Text == string.Empty ||
                loginTextbox.Text == string.Empty ||
                positionsCombobox.Text == string.Empty ||
                passwordTextbox.Text == string.Empty)
                return false;
            return true;
        }

        private void changeEmployee(CinemaModel.Employees editedEmployee)
        {
            this.employee.name = editedEmployee.name;
            this.employee.surname = editedEmployee.surname;
            this.employee.login = editedEmployee.login;
            this.employee.position = editedEmployee.position;
            this.employee.password = editedEmployee.password;
        }
    }
}
