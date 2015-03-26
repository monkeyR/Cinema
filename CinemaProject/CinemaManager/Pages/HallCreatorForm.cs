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
            int columns = 0;
            string hallName = null;

            if (String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                MessageBox.Show(new MessageStrings().NoFillAllTextBox);

            }
            else if (!String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                if (!int.TryParse(HallCreatorColumsNumberTextBox.Text, out columns) || !int.TryParse(HallCreatorRowsNumberTextBox.Text, out rows))
                {
                    MessageBox.Show(new MessageStrings().NoNumberValue);
                    return;
                }
                else
                {
                    bool IfHallNameExist = false ;
                    hallName = HallCreatorHallNameTextBox.Text;
                    using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                    {
                        
                        var halls = (from t in ctx.Halls
                                     where t.title.Equals(hallName)
                                     select t);
                            IfHallNameExist = (halls.Count() > 0);
                    }

                    if (IfHallNameExist)
                    {
                        MessageBox.Show("Sala kinowa o takiej nazwie juz istnieje.");
                    }
                    else
                    {
                        HallCreatorNmeOfHallLabel.Text = hallName;
                        HallCteatorHowManyRowsLabel.Text = "Ilość rzędów: " + rows;
                        HallCteatorHowManyCollumnsLabel.Text = "Ilość kolumn: " + columns;
                        HallCreateGenetrateMatrix(rows, columns);

                    }
                }
            }

        }

        private void HallCreateGenetrateMatrix(int rows, int columns)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            int i = 0;
            int sizeOfCell = 30;
            HallCreateTable.BackColor = Color.Beige;
            this.HallCreateTable.Size = new System.Drawing.Size((columns * sizeOfCell)+columns-1, (rows * sizeOfCell)+rows-1);
            
            this.HallCreateTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;    
           
            this.HallCreateTable.ColumnCount = columns;
            for (i = 0; i <= columns; i++)
            {
                this.HallCreateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, sizeOfCell)); 
            }

            this.HallCreateTable.RowCount = rows;
            for (i = 0; i <= rows; i++)
            {
                this.HallCreateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, sizeOfCell));
            }
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
