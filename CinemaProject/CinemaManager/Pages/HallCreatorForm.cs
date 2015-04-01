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
        private List<List<Button>> buttons = new List<List<Button>>();

        
        public HallCreatorForm()
        {
            InitializeComponent();
            groupBox1.Hide();
        }


        private void CreateHallONButton_Click(object sender, EventArgs e)
        {
            HallInfo.Show();
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
                    bool IfHallNameExist = false;
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
                       // HallCreatorNmeOfHallLabel.Text = hallName;
                       // HallCteatorHowManyRowsLabel.Text = "Ilość rzędów: " + rows;
                       // HallCteatorHowManyCollumnsLabel.Text = "Ilość kolumn: " + columns;
                        //HallCreateGenetrateMatrix(rows + 1, columns + 1);
                        GenerateTable(columns+2,rows+1);

                    }
                }
            }

        }

        private void HallCreateGenetrateMatrix(int rows, int columns)
        {
            
            //  tablica, gdzie będą zapisywane miejsca 
            int[,] hallTable = new int[rows + 1, columns + 2];
            for (int i = 0; i <= rows; i++)
            {
                for (int w = 0; w <= columns + 1; w++)
                {
                    hallTable[i, w] = 0;
                }
            }



        }

        private void GenerateTable(int columnCount, int rowCount)
        {

            buttons.Clear();

            HallCreateTableLayoutPanel.Controls.Clear();

            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();

            HallCreateTableLayoutPanel.ColumnCount = columnCount;
            HallCreateTableLayoutPanel.RowCount = rowCount;

            int c = 65;

            int ile = 0;

           


            for (int y = 0; y < rowCount; y++)
            {
                List<Button> buttons1 = new List<Button>();
                for (int x = 0; x < columnCount; x++)
                {

                    Button cmd = new Button
                    {
                        Text = string.Format(" "),
                        Width = 26,
                        Height = 26,
                        Margin = new System.Windows.Forms.Padding(0, 0, 0, 0),
                        Padding = new Padding(0, 0, 0, 0),
                        TextAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Gray,
                        Font = new Font(
                            "Arial",
                            6)


                    };

                    if (y == 0 && x == 0)
                    {
                        // komórka [0,0] 
                        cmd.Name = "00";
                        cmd.Hide();

                    }
                    else if (y == 0 && x == columnCount - 1)
                    {
                        // komórka [0,columnCount]
                        cmd.Name = "0Columns-1";
                        cmd.Hide();
                    }
                    else
                    {
                        if (y == 0 && x != 0 && x != columnCount - 1)
                        {
                            // wiersz 0
                            cmd.BackColor = Color.Crimson;
                            cmd.Text = x.ToString();
                            cmd.Name = x.ToString();
                        }
                        ile = 0;
                        if (x == 0 || x == columnCount - 1)
                        {

                            if (y != 0)
                            {
                                //---------------->     // DODAĆ - co będzie, gdy skńczy się alfabet ? 
                                if (x == columnCount - 1)
                                {
                                    // ostatnia kolumna 
                                    cmd.Text = ((Char)c).ToString();
                                    cmd.BackColor = Color.Crimson;
                                    cmd.Name = ((Char)c).ToString();
                                    c++;
                                }
                                else
                                {
                                    // pierwsza kolumna
                                    cmd.Text = ((Char)c).ToString();
                                    cmd.BackColor = Color.Crimson;
                                    cmd.Name = ((Char)c).ToString();
                                }

                            }

                        }
                        if (cmd.Name == "") cmd.Name = x.ToString() + ((char)c).ToString();


                    }
                    cmd.Click += btn_Click;
                    buttons1.Add(cmd);
                    HallCreateTableLayoutPanel.Controls.Add(cmd, x, y);
                }
                buttons.Add(buttons1);
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {

            Button nb = (Button)sender;

            //sprawdza numer columny zaznaczonej komórki
            string numerOfColumn = new String(nb.Name.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
            string numerOfRow = new String(nb.Name.ToCharArray().Where(c => Char.IsLetter(c)).ToArray());

            // liczba wierszy w macierzy 
            int rowsCount = buttons.Count;
            int columnCount = 0;
            for (int h = 0; h < rowsCount; h++)
            {
                columnCount = buttons[h].Count;
            }
            if (nb.Text == string.Format(" "))
            {
                if (nb.BackColor == Color.LavenderBlush)
                {
                    nb.BackColor = Color.Gray;

                }
                else
                {
                    nb.BackColor = Color.LavenderBlush;

                }
            }
            else
            {
                int ifNumber = 0;
                bool bNum = int.TryParse(numerOfColumn, out ifNumber);
                if (bNum)
                {
                    // zaznaczanie kolumnami 
                    if (buttons[0][Convert.ToInt32(numerOfColumn)].BackColor == Color.Crimson)
                    {
                        for (int i = 1; i < rowsCount; i++)
                        {
                            (buttons[i][Convert.ToInt32(numerOfColumn)]).BackColor = Color.LavenderBlush;
                        }
                        buttons[0][Convert.ToInt32(numerOfColumn)].BackColor = Color.FromArgb(255, 220, 19, 60);

                    }
                    else if (buttons[0][Convert.ToInt32(numerOfColumn)].BackColor == Color.FromArgb(255, 220, 19, 60))
                    {
                        for (int i = 1; i < rowsCount; i++)
                        {
                            (buttons[i][Convert.ToInt32(numerOfColumn)]).BackColor = Color.Gray;
                        }
                        buttons[0][Convert.ToInt32(numerOfColumn)].BackColor = Color.Crimson;

                    }

                }
                else
                {
                    //zaznaczanie rzędami
                    for (int d = 0; d < rowsCount; d++)
                    {

                        if (buttons[d][0].BackColor == Color.Crimson && buttons[d][0].Name == nb.Name)
                        {
                            for (int i = 1; i < rowsCount - 2; i++)
                            {
                                (buttons[d][i]).BackColor = Color.LavenderBlush;
                            }
                            buttons[d][0].BackColor = Color.FromArgb(255, 220, 19, 60);

                        }
                        else if (buttons[d][0].BackColor == Color.FromArgb(255, 220, 19, 60) && buttons[d][0].Name == nb.Name)
                        {
                            for (int i = 1; i < rowsCount - 2; i++)
                            {
                                (buttons[d][i]).BackColor = Color.Gray;
                            }
                            buttons[d][0].BackColor = Color.Crimson;

                        }
                    }

                }
            }
        }

        private string HallCreateGenerateXML()
        {
            // generowanie XML z miejscami na sali

            return "";
        }

        private void HallCreateSaveToDatabase()
        {


        }
        private void HallCreateTableGenerateFinishedTable()
        {
            // generowanie gotowej sali 
            HallCreateTableLayoutPanel.Controls.Clear();
            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();

            int rowsCount = buttons.Count;
            int columnCount = 0;
            for (int h = 0; h < rowsCount; h++)
            {
                columnCount = buttons[h].Count;
            }
            HallCreateTableLayoutPanel.RowCount = rowsCount;
            HallCreateTableLayoutPanel.ColumnCount = columnCount;
            int ifNumber = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int a = 0; a < columnCount; a++)
                {
                    if (buttons[i][a].BackColor == Color.FromArgb(255, 220, 19, 60))
                    {
                        string numerOfCell =
                            new String(buttons[i][a].Name.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
                        bool bNum = int.TryParse(numerOfCell, out ifNumber);

                        if (bNum == false)
                        {
                            (buttons[i][a]).Name = buttons[i - 1][a].Name.ToString() + "empty";
                        }
                        else if (bNum == true)
                        {
                            (buttons[i][a]).Name = buttons[i][a - 1].Name.ToString() + "empty";
                        }


                        MessageBox.Show(buttons[i][a].Name);

                        for (int u = 1; u < rowsCount; u++)
                        {


                        }
                        //buttons[0][a].BackColor = Color.FromArgb(255, 220, 19, 60);
                    }
                    HallCreateTableLayoutPanel.Controls.Add(buttons[i][a], a, i);
                    buttons[i][a].Enabled = false;

                    if (buttons[i][a].BackColor == Color.LavenderBlush)
                    {
                        buttons[i][a].Hide();
                    }
                }

            }



       

        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            groupBox1.Show(); 
            HallInfo.Hide();
            HallCreatePanel.Show();
            
        }

          /* sprawdzenie, która komórka tableLayoutPanel została kliknięta
           * selectedCell = new Point(e.X / ((HallCreateTable.Width + HallCreateTable.ColumnCount) / HallCreateTable.ColumnCount), e.Y / ((HallCreateTable.Height + HallCreateTable.RowCount) / HallCreateTable.RowCount));
            MessageBox.Show("selectedCell.X.ToString: " + selectedCell.X.ToString() + " \nselectedCell.Y.ToString: " + selectedCell.Y.ToString());
           */
     

    }
}
