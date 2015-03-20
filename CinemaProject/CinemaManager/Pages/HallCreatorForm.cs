using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace CinemaManager.Pages
{
    public partial class HallCreatorForm : Form
    {
        public HallCreatorForm()
        {
            InitializeComponent();
        }

        private void CreateHallONButton_Click(object sender, EventArgs e)
        {
            int rows = 0;
            int colums = 0;
            string hallName = null;

            if (String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                MessageBox.Show(new MessageStrings().NoFillAllTextBox);

            }
            else if (!String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                int number;
                if (!int.TryParse(HallCreatorColumsNumberTextBox.Text, out number) || !int.TryParse(HallCreatorRowsNumberTextBox.Text, out number))
                {
                    MessageBox.Show(new MessageStrings().NoNumberValue);
                    return;
                }
                else
                {
                    hallName = HallCreatorHallNameTextBox.Text;
                    rows = Convert.ToInt32(HallCreatorRowsNumberTextBox.Text);
                    colums = Convert.ToInt32(HallCreatorColumsNumberTextBox.Text);
                    //MessageBox.Show("Nazwa sali: " + hallName + "ilość rzędów:" + rows.ToString());

                    HallNameOKLabel.Text = "Nazwa sali:    " + hallName;
                    HallCteatorHowManyRowsLabel.Text = "Ilość rzędów: " + rows;
                    HallCteatorHowManyCollumnsLabel.Text = "Ilość kolumn: " + colums;
                }


            }
        }
    }
}
