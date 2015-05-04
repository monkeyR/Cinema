﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaModel;
using Common;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.XmlConfiguration;


namespace CinemaManager.Pages
{

    public partial class HallCreatorForm : Form
    {
        private List<List<Button>> buttons = new List<List<Button>>();
        private List<String> nameOfButtonColumnList = new List<string>();
        private List<String> nameOfButtonRowList = new List<string>();
        private string[] tableOfButtons;
        private string hallName = "";
        private int numberOfHall=0;
        private string temporaryMatrix;
       private string matrix;
        private int hallId;

        private void FIllComboBox()
        {

          using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var halls = (from t in ctx.Halls
                             where t.isEnable==1
                             select t);
                foreach (var hall in halls)
                {
                    Common.UISynchronizer.synchronizeWithUI(hallNameComboBox, x => hallNameComboBox.Items.Add(x), hall.title);
                }
            }
            
            
        
            
        }
        public HallCreatorForm()
        {
            InitializeComponent();
           
            ScreenLabel.Hide();
            HallEditPanel.Hide();
            FIllComboBox();
        }


        private bool checkIfEquals(CinemaModel.Halls editedHall, string matr)
        {
            if (editedHall.matrix == matr)
               return true;
            return false;
        }


        private void HallEditSaveToDatabase(int hallID, string hallMatrix)
        {
            // zapis zmian w sali do bazy danych
            // zapis nowej sali do bazy danych
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Halls editHall = new CinemaModel.Halls();

                //editHall.matrix = hallMatrix;
                editHall.hallID = hallID;
               
               
                if (!checkIfEquals(editHall, hallMatrix))
                {
                    if (hallMatrix!="")
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        editHall.matrix = hallMatrix;
                        ctx.Entry(hallMatrix).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();

                        MessageBox.Show("Zmiana została wykonana", "Informacja", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Cursor.Current = Cursors.Default;

                        this.Close();
                    }

                    else
                        MessageBox.Show("Błąd podczas zapisu do bazy", "Informacja", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }


            }
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
           
            // dodawanie nowej sali 
            SubPages.AddNewHall addNewHall = new SubPages.AddNewHall();
            HallMenagePanel.Hide();
            addNewHall.Dock = DockStyle.Fill;            
            addNewHall.ResetText();
            Common.UISynchronizer.synchronizeWithUI(panelMain, x => panelMain.Controls.Add(x), addNewHall);
           
           
        }

        private void HallCreateTableLayoutPanel_Paint(object sender, PaintEventArgs e) { }

        private void HallCreatorForm_Load(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void HallMenageButton_Click(object sender, EventArgs e)
        {
            HallMenagePanel.Show();
            HallMenagePanel.Refresh();
        }

        private void Matrix()
      {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    var halls = (from t in ctx.Halls
                                 where t.title == hallNameComboBox.Text
                                 select new {t}).Single();


                    hallName = halls.t.title;
                    numberOfHall = halls.t.number;
                    matrix = halls.t.matrix;
                    hallId = halls.t.hallID;
                }}
            
        private void displayHallButton_Click(object sender, EventArgs e)
        {
            HallCreateTableLayoutPanel.Controls.Clear();
            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();

          


            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                Matrix();
                temporaryMatrix = matrix;
            }
                HallNameLabel.Text = "Nazwa sali: " + hallName;
                NumberOfHallLabel.Text = "Numer sali: " + numberOfHall.ToString();
                tableOfButtons = matrix.Split(',');
            
                NumberOfRowsLabel.Text = "Rzędy " + (Convert.ToInt32(tableOfButtons[0])-1);;
                NumberOfColumnsLabel.Text = "Kolumny: " + (Convert.ToInt32(tableOfButtons[1])-2);
                
                GenerateTable(matrix);
            
           

        }
        
        private void ChangeNumerationInTable(int rows, int columns)
        {
            for (int i = 1; i < rows; i++)
            {
                if (buttons[i][0].BackColor != Color.FromArgb(123, 156, 204) || buttons[i][columns - 1].BackColor != Color.FromArgb(123, 156, 204))
                    if (nameOfButtonRowList.Count != 0)
                    {
                        buttons[i][0].Text = nameOfButtonRowList.First();
                        buttons[i][columns - 1].Text = nameOfButtonRowList.First();
                        nameOfButtonRowList.Remove(buttons[i][0].Text);
                    }

            }

            for (int i = 1; i < columns - 2; i++)
            {
                if (buttons[0][i].BackColor != Color.FromArgb(123, 156, 204))
                    if (nameOfButtonColumnList.Count != 0)
                    {
                        buttons[0][i].Text = nameOfButtonColumnList.First();
                        nameOfButtonColumnList.Remove(buttons[0][i].Text);
                    }

            }
        }

        private void DisplayScreenLabel(int columnCount)
        {
            ScreenLabel.Size = new Size(columnCount * 27, 35);
            ScreenLabel.AutoSize = false;
            ScreenLabel.TextAlign = ContentAlignment.TopCenter;
            ScreenLabel.BackColor = Color.FromArgb(123, 156, 204);

            ScreenLabel.Show();
        }

        private void AllClean(int columnCount,int rowCount)
        {
            HallCreateTableLayoutPanel.Controls.Clear();
            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();

            HallCreateTableLayoutPanel.ColumnCount = columnCount;
            HallCreateTableLayoutPanel.RowCount = rowCount;
        }

        private void GenerateTable( string matrix)
        {
            tableOfButtons = matrix.Split(',');
            int columnCount = Convert.ToInt32(tableOfButtons[1]);
            int rowCount = Convert.ToInt32(tableOfButtons[0]);
            int enableButtonInRowsCount = 0;
            int enableButtonInColumnsCount = 0;
            buttons.Clear();

           Common.XMLparse parseStringToListOfButtons=new XMLparse();
           buttons= parseStringToListOfButtons.HallStringToListButton(matrix);
            
            // wyświetlenie napisu EKRAN na środku wygenerowanej sali
            DisplayScreenLabel(columnCount);

            List<int> enableRowsList=new List<int>();
            List<int> enableColmunsList=new List<int>();


                // wyczyszczenie poprzednich wyświetleń sali
            AllClean(columnCount, rowCount);
            int c = 65; // w ascii A = 65
            int numberOfColumn = 1;
            // SPRAWDZENIE, CZY SĄ CAŁE ODZNACZONE WIERSZE + WYŁĄCZENIE MOŻLIWOŚCI KLIKANIA
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    HallCreateTableLayoutPanel.Controls.Add(buttons[y][x], x, y);
                    buttons[y][x].Enabled = false;
                    if (buttons[y][x].BackColor == Color.Gray) enableButtonInRowsCount++;
                }

              if (enableButtonInRowsCount ==0) enableRowsList.Add(y);
                enableButtonInRowsCount = 0;
            }


            // SPRAWDZENIE, CZY SĄ CAŁE ODZNACZONE KOLUMNY
            for (int y = 0; y < columnCount; y++)
            {
                for (int x = 0; x < rowCount; x++)
                {
                    if (buttons[x][y].BackColor == Color.Gray) enableButtonInColumnsCount++;
                }

                if (enableButtonInColumnsCount == 0) enableColmunsList.Add(y);
                enableButtonInColumnsCount = 0;
            }

            // próba zmiany numeracji bez użycia funkcji change numeration, gdy wycięta jest cała kolumna
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    // zmiana numeracji 
                    if (y == 0)
                    {
                        if (buttons[y][x].Name != "00" && buttons[y][x].Name != "0"+(columnCount-1).ToString())
                        {
                            if (!enableColmunsList.Contains(x))
                            {
                                buttons[y][x].Text = numberOfColumn.ToString();
                                numberOfColumn++;
                            }
                            else
                            {
                                buttons[y][x].Text = " ";
                                buttons[y][x].BackColor = Color.FromArgb(123, 156, 204);
                                //buttons[y][x].Hide();
                            }
                        }
                    }
                    else
                    {
                        if (x == 0)
                        {
                            if (!enableRowsList.Contains(y))
                            {
                                buttons[y][x].Text = ((char) c).ToString();
                            }
                            else
                            {
                                buttons[y][x].Text = " ";
                                buttons[y][x].BackColor = Color.FromArgb(123, 156, 204);
                                // buttons[y][x].Hide();
                            }
                        }
                        if (x == columnCount - 1)
                        {
                            if (!enableRowsList.Contains(y))
                            {
                                buttons[y][x].Text = ((char) c).ToString();
                                c++;
                            }
                            else
                            {
                                buttons[y][x].Text = " ";
                                buttons[y][x].BackColor = Color.FromArgb(123, 156, 204);
                                //  buttons[y][x].Hide();
                            }
                        }
                    }
                }
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {

            Button nb = (Button)sender;
            
           

            //sprawdza numer kolumny zaznaczonej komórki
            string numberOfColumn = new String(nb.Name.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
            string numerOfRow = new String(nb.Name.ToCharArray().Where(c => Char.IsLetter(c)).ToArray());

            // liczba wierszy i kolumn w macierzy 
            int rowsCount = buttons.Count;
            int columnCount =  buttons[0].Count;

            string[] nameOfButton = new string[2];

            int ifNumber = 0;
            bool bNum = int.TryParse(nb.Name, out ifNumber);

            /* w nameOfButton[0] przechowywany jest nr kolumny 
               w nameOfButton[1] przechowywany jest nr rzędu*/
            if (nb.Name.Length==3)
            {
                nameOfButton[0] = nb.Name[0].ToString() + nb.Name[1].ToString();
                nameOfButton[1] = nb.Name[2].ToString();
            }
            else if(nb.Name.Length==2)
            {
                nameOfButton[0] = nb.Name[1].ToString();
                nameOfButton[1] = nb.Name[0].ToString();
            }
            else if (nb.Name.Length == 1)
            {
                bool bNum2 = int.TryParse(nb.Name, out ifNumber);
                if (bNum2)
                {
                    nameOfButton[0] = "";
                    nameOfButton[1] = nb.Name[0].ToString();
                }
                else
                {
                    nameOfButton[0] = nb.Name[0].ToString();
                    nameOfButton[1] = "";
                }
            }


           

            if (!bNum && nameOfButton[1]!=" " && nb.Name.Length!=1)
            {
                // kliknięcie w pojedyńczą komórkę, która nie jest rzędem lub kolumną 
                if (nb.BackColor == Color.FromArgb(123, 156, 204) )
                {
                   nb.BackColor = Color.Gray;
                }
                else if (nb.BackColor == Color.Gray)
                {
                    nb.BackColor = Color.FromArgb(123, 156, 204);
                }
            }
            else if (!bNum && nameOfButton[1] != " " && nb.Name.Length == 1)
            {
                //kliknięcie w nazwę wiersza 

                if (nb.BackColor == Color.FromArgb(123, 156, 204))
                    nb.BackColor = Color.FromArgb(255, 220, 19, 60);
            
               for (int d = 1; d < rowsCount; d++)
                {
                    if (buttons[d][0].BackColor == Color.Crimson   && buttons[d][0].Name == nb.Name)
                    {
                        for (int i = 1; i < columnCount - 1; i++)
                        {
                            (buttons[d][i]).BackColor = Color.FromArgb(123, 156, 204);
                        }
                        buttons[d][0].BackColor = Color.FromArgb(255, 220, 19, 60);
                        buttons[d][columnCount - 1].BackColor = Color.FromArgb(255, 220, 19, 60);
                    }
                    else if (buttons[d][0].BackColor == Color.FromArgb(255, 220, 19, 60)  && buttons[d][0].Name == nb.Name)
                    {

                        for (int i = 1; i < columnCount - 1; i++)
                        {
                            (buttons[d][i]).BackColor = Color.Gray;
                        }
                        buttons[d][0].BackColor = Color.Crimson;
                        buttons[d][columnCount - 1].BackColor = Color.Crimson;
                    }
                    else  if (buttons[d][columnCount-1].BackColor == Color.Crimson && buttons[d][0].Name == nb.Name)
                    {
                        for (int i = 1; i < columnCount - 1; i++)
                        {
                            (buttons[d][i]).BackColor = Color.FromArgb(123, 156, 204);
                        }
                        buttons[d][0].BackColor = Color.FromArgb(255, 220, 19, 60);
                        buttons[d][columnCount - 1].BackColor = Color.FromArgb(255, 220, 19, 60);
                    }
                    else if (buttons[d][columnCount - 1].BackColor == Color.FromArgb(255, 220, 19, 60) && buttons[d][0].Name == nb.Name)
                    {
                        for (int i = 1; i < columnCount - 1; i++)
                        {
                            (buttons[d][i]).BackColor = Color.Gray;
                        }
                        buttons[d][0].BackColor = Color.Crimson;
                        buttons[d][columnCount - 1].BackColor = Color.Crimson;
                    }
                }
                
            }
            else
            {

                // kliknięcie w numer kolumny
                if(nb.BackColor == Color.FromArgb(123, 156, 204))
                    nb.BackColor = Color.FromArgb(255, 220, 19, 60);
               
               
                    if (buttons[0][Convert.ToInt32(numberOfColumn)].BackColor == Color.Crimson )
                    {
                        for (int i = 1; i < rowsCount; i++)
                        {
                            (buttons[i][Convert.ToInt32(numberOfColumn)]).BackColor = Color.FromArgb(123, 156, 204);
                        }
                        buttons[0][Convert.ToInt32(numberOfColumn)].BackColor = Color.FromArgb(255, 220, 19, 60);

                    }
                    else if (buttons[0][Convert.ToInt32(numberOfColumn)].BackColor == Color.FromArgb(255, 220, 19, 60) )
                    {
                        for (int i = 1; i < rowsCount; i++)
                        {
                            (buttons[i][Convert.ToInt32(numberOfColumn)]).BackColor = Color.Gray;
                        }
                        buttons[0][Convert.ToInt32(numberOfColumn)].BackColor = Color.Crimson;

                    }

                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HallNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemoveHallButton_Click_1(object sender, EventArgs e)
        {
            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć salę " + hallNameComboBox.Text,
                    "Usuwanie sali kinowej ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                    {

                        var halls = (from t in ctx.Halls

                            where t.title == hallNameComboBox.Text
                            select new {t}).Single();
                        halls.t.isEnable = 0;
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("Poprawnie usunięto salę kinową");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Podczas usuwania wystąpił błąd");
                }
            }
        }

        private void HallEditButton_Click(object sender, EventArgs e )
        {
            for (int y = 0; y < buttons.Count; y++)
            {
                for (int x = 0; x < buttons[0].Count; x++)
                {
                    if (buttons[y][x].Name != "0" && buttons[y][x].Name != buttons[0].Count.ToString())
                    {
                       if(y==0 && x==0)
                       {}
                       else
                       if (y == 0 && x == buttons[0].Count-1)
                       { }
                       else
                       {
                           buttons[y][x].Enabled = true;
                             buttons[y][x].Show();
                       }
                    }
                }
            }
            //HallCreateTableLayoutPanel.Controls.Clear();
            //HallCreateTableLayoutPanel.ColumnStyles.Clear();
            //HallCreateTableLayoutPanel.RowStyles.Clear();

            string hallName = "";
            int n = 0;
            int row = 0;
            int col = 0;

            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                if (buttons.Count != 0)
                {
                    HallEditPanel.Show();


                    for (int y = 0; y < buttons.Count; y++)
                    {
                        for (int x = 0; x < buttons[0].Count; x++)
                        {
                            
                            buttons[y][x].Enabled = true;
                            buttons[y][x].Click += btn_Click;

                        }

                    }
                }
                else MessageBox.Show("Aby edytować salę, najpierw ją wyświetl!");


            }
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            // dodawanie wierszy
            string newMatrix = "";
            int countOfCharInMatrix = 0;

            string[] tableOfButtonsAfterChange = temporaryMatrix.Split(',');

            newMatrix += (Convert.ToInt32(tableOfButtonsAfterChange[0]) + 1).ToString() + "," + (tableOfButtonsAfterChange[1]);
            int g = 2;

            for (int u = 2; u < tableOfButtonsAfterChange.Length; u++)
            {
                newMatrix += "," + tableOfButtonsAfterChange[u];
            }

            for (int y = 1; y < buttons[0].Count - 1; y++)
            {

                newMatrix += ",1";

            }

            temporaryMatrix = newMatrix;
            GenerateTable(newMatrix);
            
            }

        private void HallCreateTableLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
           }

        private void SubtractRowButton_Click(object sender, EventArgs e)
        {

            // usuwanie wierszy
            string newMatrix = "";
            int countOfCharInMatrix = 0;

            string[] tableOfButtonsAfterChange = temporaryMatrix.Split(',');

            newMatrix += (Convert.ToInt32(tableOfButtonsAfterChange[0]) - 1).ToString() + "," + (tableOfButtonsAfterChange[1]);
            int g = 2;

            for (int i = 1; i < buttons.Count - 1; i++)
            {
                for (int y = 1; y < buttons[0].Count - 1; y++)
                {
                    newMatrix += "," + tableOfButtonsAfterChange[g];
                    g++;
                }
            }

            temporaryMatrix = newMatrix;
            GenerateTable(newMatrix);

        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            // dodawanie kolumn
            string newMatrix = "";
            int countOfCharInMatrix = 0;
            string[] tableOfButtonsAfterChange = temporaryMatrix.Split(',');

            newMatrix += tableOfButtonsAfterChange[0] + "," + (Convert.ToInt32(tableOfButtonsAfterChange[1]) + 1);
            int g = 2;

            for (int i = 1; i < buttons.Count; i++)
            {
                for (int y = 1; y < buttons[0].Count; y++)
                {
                    if (y != buttons[0].Count - 1)
                    {
                        newMatrix += "," + tableOfButtonsAfterChange[g];
                        g++;
                    }
                    else
                    {
                        newMatrix += ",1";
                    }
                }
            }
            temporaryMatrix = newMatrix;
            GenerateTable(newMatrix);
        
        }

        private void SubColumnButton_Click(object sender, EventArgs e)
        {

            // odejmowanie kolumn
            string newMatrix = "";
            int countOfCharInMatrix = 0;
            string[] tableOfButtonsAfterChange = temporaryMatrix.Split(',');

            newMatrix += tableOfButtonsAfterChange[0] + "," + (Convert.ToInt32(tableOfButtonsAfterChange[1]) - 1);
            int g = 2;

            for (int i = 1; i < buttons.Count; i++)
            {
                for (int y = 1; y < buttons[0].Count - 1; y++)
                {
                    if (y != buttons[0].Count - 2)
                    { newMatrix += "," + tableOfButtonsAfterChange[g]; }
                    g++;

                }
            }
            temporaryMatrix = newMatrix;
            GenerateTable(newMatrix);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HallEditSaveToDatabase(hallId,temporaryMatrix);
        }
        
    }
}
