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
        public AddShiftForm(DateTime mondayOfWeek)
        {            
            this.mondayOfWeek = mondayOfWeek;

            InitializeComponent();

            fillDaysArray();

            fillEmployees();
            fillWorkpositions();
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

        private void fillWorkpositions()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var workpositions = ctx.Workpositions;

                foreach (var workposition in workpositions)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = workposition.name;
                    item.Value = workposition.workpositionID;
                    workpositionComboBox.Items.Add(item);
                }
                workpositionComboBox.SelectedIndex = 0;
            }
        }

        private void fillEmployees()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employees;

                foreach (var employee in employees)
                {
                    if (!(bool)employee.isFired)
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
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Shifts shift = new CinemaModel.Shifts();

                shift.employeeID = ((ComboboxItem)employeesComboBox.SelectedItem).Value;
                shift.workpositionID = ((ComboboxItem)workpositionComboBox.SelectedItem).Value;

                for (int i = 0; i < 7; i++)
                {
                    
                }

            }
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
