using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Pages
{
    public partial class EmployeesManagementForm : Form
    {
        public EmployeesManagementForm()
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
            Common.UISynchronizer.synchronizeWithUI(employeeListView, employeeListView.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(firedListView, firedListView.Items.Clear);

            insertEmployees();
        }

        private void insertEmployees()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employees;

                foreach (var employee in employees)
                {
                    List<string> listItem = new List<string>(4);

                    listItem.Add(employee.name);
                    listItem.Add(employee.surname);
                    switch (employee.position)
                    {
                        case (int)Common.EmployeeTypes.Types.Manager:
                            listItem.Add("Manager");
                            break;
                        case (int)Common.EmployeeTypes.Types.Saler:
                            listItem.Add("Sprzedawca");
                            break;
                    }
                    listItem.Add(employee.login);



                    if ((bool)employee.isFired)
                    {
                        listItem.Add(employee.firedDate.Value.ToLocalTime().ToShortDateString().ToString());
                        ListViewItem item = new ListViewItem(listItem.ToArray());

                        Common.UISynchronizer.synchronizeWithUI(firedListView, x => firedListView.Items.Add(x), item);
                        Common.UISynchronizer.synchronizeWithUI(firedListView,
                            id => firedListView.Items[firedListView.Items.Count - 1].Tag = id, employee.employeeID);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(listItem.ToArray());
                        Common.UISynchronizer.synchronizeWithUI(employeeListView, x => employeeListView.Items.Add(x), item);
                        Common.UISynchronizer.synchronizeWithUI(employeeListView,
                            id => employeeListView.Items[employeeListView.Items.Count - 1].Tag = id, employee.employeeID);
                    }
                }
            }
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            SubPages.AddNewEmployeeForm form = new SubPages.AddNewEmployeeForm();
            form.ShowDialog();

            startFilling();
        }

        private void employeeListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && employeeListView.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem editEmployeeItem = new MenuItem("Edytuj pracownika");
                editEmployeeItem.Click += (objectSender, args) =>
                    {
                        editEmployeeItemClick(objectSender, args);
                    };
                cm.MenuItems.Add(editEmployeeItem);

                MenuItem fireEmployeeItem = new MenuItem("Zwolnij pracownika");
                fireEmployeeItem.Click += (objectSender, args) =>
                    {
                        fireEmployeeItemClick(objectSender, args);
                    };
                cm.MenuItems.Add(fireEmployeeItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void fireEmployeeItemClick(object objectSender, EventArgs args)
        {
            int employeeID = (int)employeeListView.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Employees employeeToFire = ctx.Employees.FirstOrDefault(x => x.employeeID.Equals(employeeID));
                employeeToFire.isFired = true;

                ctx.Entry(employeeToFire).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }

            startFilling();
        }

        private void editEmployeeItemClick(object objectSender, EventArgs args)
        {
            SubPages.EditEmployee form = new SubPages.EditEmployee((int)employeeListView.SelectedItems[0].Tag);
            form.ShowDialog();

            startFilling();
        }

        private void firedListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && firedListView.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem employAgainEmployeeItem = new MenuItem("Zatrudnij z powrotem");
                employAgainEmployeeItem.Click += (objectSender, args) =>
                {
                    employAgainEmployeeItemClick(objectSender, args);
                };
                cm.MenuItems.Add(employAgainEmployeeItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void employAgainEmployeeItemClick(object objectSender, EventArgs args)
        {
            int employeeID = (int)firedListView.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Employees employeeToFire = ctx.Employees.FirstOrDefault(x => x.employeeID.Equals(employeeID));
                employeeToFire.isFired = false;

                ctx.Entry(employeeToFire).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }

            startFilling();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
