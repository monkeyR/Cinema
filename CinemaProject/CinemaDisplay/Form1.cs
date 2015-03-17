using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var employees = ctx.Employeers;

                foreach (var employee in employees)
                {
                    textBox1.Text += string.Format("{0} {1}\r\n", employee.name, employee.surname);
                }
            }
        }
    }
}
