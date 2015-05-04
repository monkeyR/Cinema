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
    public partial class ShiftsForm : Form
    {
        public ShiftsForm()
        {
            InitializeComponent();

            fillWeeks();

            Cursor.Current = Cursors.WaitCursor;
            fillShifts();
            Cursor.Current = Cursors.Default;
        }

        private void fillShifts()
        {
            shiftsFlowLayoutPanel.Controls.Clear();
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var shifts = ctx.Shifts;
                var actualWeek = ((ComboboxItem)weeksComboBox.SelectedItem).Value;
                foreach (var shift in shifts)
                {
                    if (shift.shiftWeek.Equals(actualWeek))
                    {
                        shiftsFlowLayoutPanel.Controls.Add(new SubPages.ShiftUserControl(shift, shiftsFlowLayoutPanel));
                    }
                }
            }
        }

        private void fillWeeks()
        {
            DateTime monday = StartOfWeek(DateTime.Now, DayOfWeek.Monday);
            DateTime sunday = monday.AddDays(6);

            for (int i = 0; i < 10; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = string.Format("{0} - {1}", monday.AddDays(i * 7).ToString("dd.MM.yy"), sunday.AddDays(i * 7).ToString("dd.MM.yy"));
                item.Value = monday.AddDays(i * 7);
                this.weeksComboBox.Items.Add(item);
            }
            weeksComboBox.SelectedIndex = 0;
        }


        public DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-1 * diff).Date;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            SubPages.AddShiftForm form = new SubPages.AddShiftForm(((ComboboxItem)weeksComboBox.SelectedItem).Value);
            form.ShowDialog();
            Cursor.Current = Cursors.WaitCursor;
            fillShifts();
            Cursor.Current = Cursors.Default;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public DateTime Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void weeksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fillShifts();
            Cursor.Current = Cursors.Default;
        }
    }
}

