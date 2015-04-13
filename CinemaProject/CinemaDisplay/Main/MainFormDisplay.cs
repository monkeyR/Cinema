using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDisplay.Main
{
    public partial class MainFormDisplay : Form
    {
        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                askForLeaving();
        }

        private void askForLeaving()
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }
    }
}
