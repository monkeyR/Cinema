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
        private Form parentForm;
        CheckBox[,] daysCheckboxes = new CheckBox[7, 2];
        CinemaModel.Shifts shift;

        public ShiftUserControl()
        {
            InitializeComponent();
        }

        public ShiftUserControl( CinemaModel.Shifts shift, Form parentForm)
        {
            this.shift = shift;

            InitializeComponent();

            fillDaysArray();

            this.parentForm = parentForm;
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Employees emp = ctx.Employees.First(x => x.employeeID.Equals(shift.employeeID));
                employeeName.Text = emp.name + " " + emp.surname;

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

        private void removeButton_Click(object sender, EventArgs e)
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                ctx.Entry(shift).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }
            //parentPanel.Controls.Remove(this);
            parentForm.Controls.Find("shiftsFlowLayoutPanel",false).First().Controls.Remove(this);

            if (parentForm.Controls.Find("shiftsFlowLayoutPanel", false).First().Controls.Count == 0)
            {
                Label emptyControlLabel = new Label();
                emptyControlLabel.AutoSize = true;
                emptyControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                emptyControlLabel.Location = new System.Drawing.Point(3, 0);
                emptyControlLabel.Name = "emptyControlLabel";
                emptyControlLabel.Size = new System.Drawing.Size(231, 20);
                emptyControlLabel.TabIndex = 7;
                emptyControlLabel.Text = "  Brak zmian w tym tygodniu";

                parentForm.Controls.Find("shiftsFlowLayoutPanel", false).First().Controls.Add(emptyControlLabel);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SubPages.AddShiftForm form = new AddShiftForm(shift);
            form.ShowDialog();
            parentForm.Refresh();
        }
    }
}
