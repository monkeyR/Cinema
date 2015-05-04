using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.SubPages
{
    public partial class ShiftUserControl : UserControl
    {
        public ShiftUserControl()
        {
            InitializeComponent();
        }

        public ShiftUserControl(bool activated, CinemaModel.Employees emp)
        {
            InitializeComponent();

            if (!activated)
            {
                moACheckBox.Enabled = false;
                moMCheckBox.Enabled = false;
                tuACheckBox.Enabled = false;
                tuMCheckBox.Enabled = false;
                weACheckBox.Enabled = false;
                weMCheckBox.Enabled = false;
                thACheckBox.Enabled = false;
                thMCheckBox.Enabled = false;
                frACheckBox.Enabled = false;
                frMCheckBox.Enabled = false;
                saACheckBox.Enabled = false;
                saMCheckBox.Enabled = false;
                suACheckBox.Enabled = false;
                suMCheckBox.Enabled = false;
            }

            employeeName.Text = emp.name + " " + emp.surname;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guziol");
        }

        public void ChangeLabel(CinemaModel.Employees emp)
        {
            employeeName.Text = emp.name + " " + emp.surname;
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if(checkBox.Checked){
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
