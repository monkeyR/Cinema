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
        public AddShiftForm()
        {
            InitializeComponent();

            fillEmployees();
        }

        private void fillEmployees()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employees;

                foreach (var employee in employees)
                {
                    employeesComboBox.Items.Add(string.Format("{0} {1}", employee.name, employee.surname));
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
            this.Close();
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkBox.Equals(moMCheckBox))
                {
                    moACheckBox.Checked = false;
                }
                if (checkBox.Equals(moACheckBox))
                {
                    moMCheckBox.Checked = false;
                }

                if (checkBox.Equals(tuMCheckBox))
                {
                    tuACheckBox.Checked = false;
                }
                if (checkBox.Equals(tuACheckBox))
                {
                    tuMCheckBox.Checked = false;
                }

                if (checkBox.Equals(weMCheckBox))
                {
                    weACheckBox.Checked = false;
                }
                if (checkBox.Equals(weACheckBox))
                {
                    weMCheckBox.Checked = false;
                }

                if (checkBox.Equals(thMCheckBox))
                {
                    thACheckBox.Checked = false;
                }
                if (checkBox.Equals(thACheckBox))
                {
                    thMCheckBox.Checked = false;
                }


                if (checkBox.Equals(frMCheckBox))
                {
                    frACheckBox.Checked = false;
                }
                if (checkBox.Equals(frACheckBox))
                {
                    frMCheckBox.Checked = false;
                }


                if (checkBox.Equals(saMCheckBox))
                {
                    saACheckBox.Checked = false;
                }
                if (checkBox.Equals(saACheckBox))
                {
                    saMCheckBox.Checked = false;
                }

                if (checkBox.Equals(suMCheckBox))
                {
                    suACheckBox.Checked = false;
                }
                if (checkBox.Equals(suACheckBox))
                {
                    suMCheckBox.Checked = false;
                }
            }
        }
    }
}
