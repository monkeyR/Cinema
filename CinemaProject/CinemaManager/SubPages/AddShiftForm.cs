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
    public partial class AddShiftForm : Form
    {
        CheckBox[,] daysCheckboxes = new CheckBox[7, 2];
        DateTime mondayOfWeek;
        CinemaModel.Shifts shift;

        public AddShiftForm(CinemaModel.Shifts shift)
        {
            this.shift = shift;

            InitializeComponent();
            fillDaysArray();
            this.okButton.Text = "Edytuj";

            this.Text = "Edytuj zmianę";

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employee = ctx.Employees.First(x => x.employeeID.Equals(shift.employeeID));
                ComboboxItem empItem = new ComboboxItem();
                empItem.Text = string.Format("{0} {1}", employee.name, employee.surname);
                empItem.Value = employee.employeeID;
                employeesComboBox.Items.Add(empItem);
                employeesComboBox.Enabled = false;
                employeesComboBox.SelectedIndex = 0;
            }
            fillCheckBoxes();
        }

        private void fillCheckBoxes()
        {
            for (int i = 0; i < 7; i++)
            {
                if (shift.typeShift.ElementAt(i).ToString() == "M")
                {
                    daysCheckboxes[i, 0].Checked = true;
                }
                else if (shift.typeShift.ElementAt(i).ToString() == "A")
                {
                    daysCheckboxes[i, 1].Checked = true;
                }
            }
        }
        public AddShiftForm(DateTime mondayOfWeek)
        {
            this.mondayOfWeek = mondayOfWeek;

            InitializeComponent();

            fillDaysArray();

            fillEmployees();
        }

        private void fillDaysArray()
        {
            daysCheckboxes[0, 0] = moMCheckBox;
            daysCheckboxes[0, 1] = moACheckBox;

            daysCheckboxes[1, 0] = tuMCheckBox;
            daysCheckboxes[1, 1] = tuACheckBox;

            daysCheckboxes[2, 0] = weMCheckBox;
            daysCheckboxes[2, 1] = weACheckBox;

            daysCheckboxes[3, 0] = thMCheckBox;
            daysCheckboxes[3, 1] = thACheckBox;

            daysCheckboxes[4, 0] = frMCheckBox;
            daysCheckboxes[4, 1] = frACheckBox;

            daysCheckboxes[5, 0] = saMCheckBox;
            daysCheckboxes[5, 1] = saACheckBox;

            daysCheckboxes[6, 0] = suMCheckBox;
            daysCheckboxes[6, 1] = suACheckBox;
        }

        private void fillEmployees()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employees;
                var shifts = ctx.Shifts;
                foreach (var employee in employees)
                {
                    if (!(bool)employee.isFired && shifts.FirstOrDefault(x => x.employeeID.Equals(employee.employeeID) && x.shiftWeek.Equals(mondayOfWeek)) == null)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = string.Format("{0} {1}", employee.name, employee.surname);
                        item.Value = employee.employeeID;
                        employeesComboBox.Items.Add(item);
                    }
                }
                employeesComboBox.SelectedIndex = 0;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (shift == null)
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    CinemaModel.Shifts tempShift = new CinemaModel.Shifts();

                    tempShift.employeeID = ((ComboboxItem)employeesComboBox.SelectedItem).Value;

                    string types = string.Empty;
                    for (int i = 0; i < 7; i++)
                    {
                        if (daysCheckboxes[i, 0].Checked)
                            types += "M";
                        else
                            if (daysCheckboxes[i, 1].Checked)
                                types += "A";
                            else
                                types += "0";
                    }

                    tempShift.typeShift = types;
                    tempShift.shiftWeek = mondayOfWeek;
                    tempShift.workpositionID = 1;
                    ctx.Shifts.Add(tempShift);
                    ctx.Entry(tempShift).State = System.Data.Entity.EntityState.Added;

                    ctx.SaveChanges();
                }
            }
            else
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    string types = string.Empty;
                    for (int i = 0; i < 7; i++)
                    {
                        if (daysCheckboxes[i, 0].Checked)
                            types += "M";
                        else
                            if (daysCheckboxes[i, 1].Checked)
                                types += "A";
                            else
                                types += "0";
                    }
                    shift.typeShift = types;
                    ctx.Entry(shift).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            this.Close();
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (checkBox.Equals(daysCheckboxes[i, 0]))
                    {
                        daysCheckboxes[i, 1].Checked = false;
                        break;
                    }
                    else if (checkBox.Equals(daysCheckboxes[i, 1]))
                    {
                        daysCheckboxes[i, 0].Checked = false;
                        break;
                    }
                }
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
