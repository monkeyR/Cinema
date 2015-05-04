using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace CinemaManager.SubPages
{
    public partial class AddNewHall : UserControl
    {
        private List<List<Button>> buttons = new List<List<Button>>();
        private List<String> nameOfButtonColumnList = new List<string>();
        private List<String> nameOfButtonRowList = new List<string>();

        public AddNewHall()
        {
            InitializeComponent();
            panel1.Refresh();
            HallCreatorHallNameTextBox.Text = "Nazwa sali";
            HallCreatorColumsNumberTextBox.Text = 10.ToString();
            HallCreatorRowsNumberTextBox.Text = 8.ToString();
            HallCreateTableLayoutPanel.Controls.Clear();
            ScreenLabel.Hide();
            HallCreatePanel.Hide();
           
        }

        private void GenerateTable(int columnCount, int rowCount)
        {

            buttons.Clear();

            // wyświetlenie napisu EKRAN na środku wygenerowanej sali
            DisplayScreenLabel(columnCount);

            // wyczyszczenie poprzednich wyświetleń sali
            HallCreateTableLayoutPanel.Controls.Clear();
            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();

            HallCreateTableLayoutPanel.ColumnCount = columnCount;
            HallCreateTableLayoutPanel.RowCount = rowCount;

            // c -> A w kodzie ASCII 
            int c = 65;

            for (int y = 0; y < rowCount; y++)
            {
                List<Button> buttons1 = new List<Button>();
                for (int x = 0; x < columnCount; x++)
                {

                    // tworzenie nowego buttona w tabeli
                    Button cmd = new Button
                    {
                        Text = string.Format(" "),
                        Width = 30,
                        Height = 30,
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
                        // ukrycie komórki [0,0]
                        cmd.Name = "00";
                        cmd.Hide();

                    }
                    else if (y == 0 && x == columnCount - 1)
                    {
                        // ukrycie komórki [0,columnCount-1]
                        cmd.Name = "0" + (columnCount - 1).ToString();
                        cmd.Hide();
                    }
                    else
                    {
                        if (y == 0 && x != 0 && x != columnCount - 1)
                        {
                            // wiersz 0  ( nazwy kolumn )
                            cmd.BackColor = Color.Crimson;
                            cmd.Text = x.ToString();
                            cmd.Name = x.ToString();
                            nameOfButtonColumnList.Add(cmd.Name.ToString());

                        }
                        if (x == 0 || x == columnCount - 1)
                        {
                            // kolumna 0 i columnCount-1  ( nazwy wierszy )
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
                        // Jeśli nie ma nazwy - są to "siedzenia", im nadajemy nazwy 1A,1B itd...
                        if (cmd.Name == "") cmd.Name = x.ToString() + ((char)c).ToString();

                    }
                    cmd.Click += btn_Click;
                    buttons1.Add(cmd);
                    HallCreateTableLayoutPanel.Controls.Add(cmd, x, y);
                }
                if (buttons1[0].Name != "00")
                {
                    // lista stringów potrzebna do wyświetlania text na buttonach 
                    nameOfButtonRowList.Add(buttons1[0].Name);

                }

                // dodanie listy buttonów (jednego całego wiersza) do <List<List<Buttons>>
                buttons.Add(buttons1);
            }
        }

        // obsługa klikania w tabelę 
        protected void btn_Click(object sender, EventArgs e)
        {

            Button nb = (Button)sender;

            //sprawdza numer columny zaznaczonej komórki
            string numerOfColumn = new String(nb.Name.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
            string numerOfRow = new String(nb.Name.ToCharArray().Where(c => Char.IsLetter(c)).ToArray());

            // liczba wierszy i kolumn w macierzy 
            int rowsCount = buttons.Count;
            int columnCount = 0;
            for (int h = 0; h < rowsCount; h++)
            {
                columnCount = buttons[h].Count;
            }

            if (nb.Text == string.Format(" "))
            {

                // kliknięcie w pojedyńczą komórkę
                if (nb.BackColor == Color.FromArgb(123, 156, 204)) 
                
                {
                    nb.BackColor = Color.Gray;

                }
                else
                {
                    nb.BackColor = Color.FromArgb(123, 156, 204);
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
                            (buttons[i][Convert.ToInt32(numerOfColumn)]).BackColor = Color.FromArgb(123, 156, 204);
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
                            for (int i = 1; i < columnCount - 1; i++)
                            {
                                (buttons[d][i]).BackColor = Color.FromArgb(123, 156, 204);
                            }
                            buttons[d][0].BackColor = Color.FromArgb(255, 220, 19, 60);
                        }
                        else if (buttons[d][0].BackColor == Color.FromArgb(255, 220, 19, 60) && buttons[d][0].Name == nb.Name)
                        {
                            for (int i = 1; i < columnCount - 1; i++)
                            {
                                (buttons[d][i]).BackColor = Color.Gray;
                            }
                            buttons[d][0].BackColor = Color.Crimson;
                        }
                    }
                }
            }
        }


        private void HallCreateSaveToDatabase(string title, string matrix)
        {
            // zapis nowej sali do bazy danych
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                CinemaModel.Halls hall = new CinemaModel.Halls();

                hall.title = title;
                hall.matrix = matrix;
                hall.number = 4;
                hall.isEnable = 1;

                ctx.Halls.Add(hall);
                ctx.Entry(hall).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Dodano nową salę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

            for (int i = 1; i < columns - 1; i++)
            {
                if (buttons[0][i].BackColor != Color.FromArgb(123, 156, 204))
                    if (nameOfButtonColumnList.Count != 0)
                    {
                        buttons[0][i].Text = nameOfButtonColumnList.First();
                        nameOfButtonColumnList.Remove(buttons[0][i].Text);
                    }

            }
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
                            // "wyłączenie" z widoku skrajnie lewej kolumny 
                            (buttons[i][a]).Name = buttons[i - 1][a].Name.ToString();
                            (buttons[i][a]).BackColor = Color.FromArgb(123,156,204);
                            (buttons[i][a]).Text = string.Format(" ");
                            (buttons[i][a]).ForeColor = Color.FromArgb(123, 156, 204);
                          
                            // "wyłączenie" z widoku skrajnie prawej kolumny
                            (buttons[i][columnCount - 1]).BackColor = Color.FromArgb(123, 156, 204);
                            (buttons[i][columnCount - 1]).Text = string.Format(" ");
                            (buttons[i][columnCount - 1]).ForeColor = Color.FromArgb(123, 156, 204);
                           



                        }

                        // wyłączenie z widoku rzędu 
                        else
                        {
                            (buttons[i][a]).Name = buttons[i][a - 1].Name.ToString();
                            (buttons[i][a]).BackColor = Color.FromArgb(123, 156, 204);
                            (buttons[i][a]).Text = string.Format(" ");
                            (buttons[i][a]).ForeColor = Color.FromArgb(123, 156, 204);





                        }

                        //buttons[0][a].BackColor = Color.FromArgb(255, 220, 19, 60);
                    }
                    HallCreateTableLayoutPanel.Controls.Add(buttons[i][a], a, i);
                    buttons[i][a].Enabled = false;


                    if (buttons[i][a].BackColor == Color.FromArgb(123, 156, 204))
                    {

                        buttons[i][a].Hide();

                    }


                }

            }
            ChangeNumerationInTable(rowsCount, columnCount);
        }


        
        

        private void HallCreatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HallInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RowsLabel_Click(object sender, EventArgs e)
        {

        }

        private void HallNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HallCreatorHallNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HallCreatorColumsNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HallCreatorRowsNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ColumnsLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nameOfHallLabel_Click(object sender, EventArgs e)
        {

        }

        private void ScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void HallCreateTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayScreenLabel(int columnCount)
        {
            ScreenLabel.Size = new Size(columnCount * 30, 35);
            ScreenLabel.AutoSize = false;
            ScreenLabel.TextAlign = ContentAlignment.TopCenter;
            ScreenLabel.BackColor = Color.FromArgb(123, 156, 204);

            ScreenLabel.Show();
        }

        private void CreateHallONButton_Click_2(object sender, EventArgs e)
        {
            HallCreatePanel.Show();
         
            // tworzenie szkieletu sali 

            HallNameLabel.Refresh();
            RowsLabel.Refresh();
            ColumnsLabel.Refresh();
            HallInfo.Show();
            HallCreateAddHallButton.Show();
           
            int rows = 0;
            int columns = 0;
            string hallName = null;

            if (String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                MessageBox.Show(new MessageStrings().NoFillAllTextBox);

            }
            else if (!String.IsNullOrEmpty(HallCreatorColumsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorRowsNumberTextBox.Text) || !String.IsNullOrEmpty(HallCreatorHallNameTextBox.Text))
            {
                if (!int.TryParse(HallCreatorColumsNumberTextBox.Text, out columns) ||
                    !int.TryParse(HallCreatorRowsNumberTextBox.Text, out rows))
                {
                    MessageBox.Show(new MessageStrings().NoNumberValue);
                    return;
                }
                else
                {
                    // sprawdzenie czy nie przekroczono maksymalnej liczby kolumn i wierszy 
                    // maksyymalnie 25 wierszy i 35 kolumn
                    int.TryParse(HallCreatorColumsNumberTextBox.Text, out columns);
                    int.TryParse(HallCreatorRowsNumberTextBox.Text, out rows);
                    if (columns>36 || rows>25)
                    {
                        MessageBox.Show("Maksymalnie możesz dodać 35 kolumn i 25 rzędów.", "Zbyt duża liczba kolumn lub rzędów", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
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
                            HallNameLabel.Text = "Nazwa sali: " + HallCreatorHallNameTextBox.Text;
                            RowsLabel.Text = "Rzędy: " + HallCreatorRowsNumberTextBox.Text;
                            ColumnsLabel.Text = "Kolumny: " + HallCreatorColumsNumberTextBox.Text;
                            DisplayScreenLabel(Convert.ToInt32(HallCreatorColumsNumberTextBox.Text));
                            GenerateTable(columns + 2, rows + 1);

                        }
                    }
                }
            }

        }

        private void HallCreateAddHallButton_Click_1(object sender, EventArgs e)
        {
            string hallString = "";
            HallCreateTableGenerateFinishedTable();

            Common.XMLparse stringParse = new XMLparse();
            hallString = stringParse.ParseToString(buttons);
            HallCreateSaveToDatabase(HallCreatorHallNameTextBox.Text, hallString);
        }
        
    }
}
