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

            initializeEmployeeListView();
        }

        private void initializeEmployeeListView()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employees;

                foreach (var employee in employees)
                {
                    List<string> listItem = new List<string>(4);

                    listItem.Add(employee.name);
                    listItem.Add(employee.surname);
                    listItem.Add(employee.login);
                    switch (employee.position)
                    {
                        case (int)Common.EmployeeTypes.Types.Manager:
                            listItem.Add("Manager");
                            break;
                        case (int)Common.EmployeeTypes.Types.Saler:
                            listItem.Add("Sprzedawca");
                            break;
                    }

                    ListViewItem item = new ListViewItem(listItem.ToArray());

                    Common.UISynchronizer.synchronizeWithUI(employeeListView, x => employeeListView.Items.Add(x), item);
                }
            }
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void employeeListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && employeeListView.FocusedItem != null)
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
            throw new NotImplementedException();
        }

        private void editEmployeeItemClick(object objectSender, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
