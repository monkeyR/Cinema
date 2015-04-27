using System;
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
       


        private void FIllComboBox()
        {

          using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {

                var halls = (from t in ctx.Halls
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
            FIllComboBox();
        }


     
      private void HallEditSaveToDatabase(int hallID, string matrix)
        {
            // zapis zmian w sali do bazy danych


        }

        private string HallReadFromDatabase(int hallID)
        {
            // wyciągnięcie informacji o sali z bazy danych

            return "";
        }
    
       

        private void AddColumn(int column)
        {
            
        }

        private void AddRow(int row)
        {
            
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

        private void displayHallButton_Click(object sender, EventArgs e)
        {
            HallCreateTableLayoutPanel.Controls.Clear();

            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();
             string hallName = "";
            int n=0;
            int row = 0;
            int col = 0;
            string matrix;

            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    var halls = (from t in ctx.Halls
                                 where t.title == hallNameComboBox.Text
                                 select new {t}).Single();


                    hallName = halls.t.title;
                    n = halls.t.number;
                    matrix = halls.t.matrix;
                   
                }
                HallNameLabel.Text = "Nazwa sali: " + hallName;
                NumberOfHallLabel.Text = "Numer sali: " + n.ToString();
                tableOfButtons = matrix.Split(',');
                row = (Convert.ToInt32(tableOfButtons[0]))-1;
                col = (Convert.ToInt32(tableOfButtons[1]))-2;
                NumberOfRowsLabel.Text = "Rzędy " + row;
                NumberOfColumnsLabel.Text = "Kolumny: " + col;
                
                GenerateTable(matrix);
            }
            

        }
        private void GenerateTableWithString(string matrix)
        {
            int columnCount = Convert.ToInt32(tableOfButtons[1]);
            int rowCount = Convert.ToInt32(tableOfButtons[0]);
            // generowanie sali 

           
            buttons.Clear();

            // wyświetlenie napisu EKRAN na środku wygenerowanej sali
           DisplayScreenLabel(columnCount);

            // wyczyszczenie poprzednich wyświetleń sali
           AllClean(columnCount,rowCount);



            //ChangeNumerationInTable(rowCount, columnCount);
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
            int columnCount = Convert.ToInt32(tableOfButtons[1]);
            int rowCount = Convert.ToInt32(tableOfButtons[0]);
            buttons.Clear();

           Common.XMLparse parseStringToListOfButtons=new XMLparse();
           buttons= parseStringToListOfButtons.HallStringToListButton(matrix);
            
            // wyświetlenie napisu EKRAN na środku wygenerowanej sali
            DisplayScreenLabel(columnCount);

            // wyczyszczenie poprzednich wyświetleń sali
            AllClean(columnCount, rowCount);


            MessageBox.Show("Liczba wierszy:" + buttons.Count);




            // c -> A w kodzie ASCII 
            //  int c = 65;



            /* for (int y = 0; y < rowCount; y++)
            {
               List<Button> buttons1 = new List<Button>();
                for (int x = 0; x < columnCount; x++)
                {

                    // tworzenie nowego buttona w tabeli
                   Button cmd = new Button
                    {
                        Text = string.Format(" "),
                        Width = 27,
                        Height = 27,
                        Margin = new System.Windows.Forms.Padding(0, 0, 0, 0),
                        Padding = new Padding(0, 0, 0, 0),
                        TextAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Gray,
                        Font = new Font(
                            "Arial",
                            6)
                    };
                    

                    
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
        
            }*/
        }


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
                            for (int i = 1; i < columnCount - 1; i++)
                            {
                                (buttons[d][i]).BackColor = Color.LavenderBlush;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HallNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemoveHallButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć salę " + hallNameComboBox.Text, "Usuwanie sali kinowej ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {

                    var halls = (from t in ctx.Halls
                                 where t.title == hallNameComboBox.Text
                                 select t);
                   // ctx.Entry(halls).State = EntityState.Deleted;
                    // USUNIĘCIE TEJ SALI
                    ctx.SaveChanges();
                }
                MessageBox.Show("Poprawnie usunięto salę kinową");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Podczas usuwania wystąpił błąd");
            }
        }

        private void HallEditButton_Click(object sender, EventArgs e)
        {
            HallCreateTableLayoutPanel.Controls.Clear();

            HallCreateTableLayoutPanel.ColumnStyles.Clear();
            HallCreateTableLayoutPanel.RowStyles.Clear();
            string hallName = "";
            int n = 0;
            int row = 0;
            int col = 0;
            string matrix;

            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {
                    var halls = (from t in ctx.Halls
                                 where t.title == hallNameComboBox.Text
                                 select new { t }).Single();


                    hallName = halls.t.title;
                    n = halls.t.number;
                    matrix = halls.t.matrix;

                }
                HallNameLabel.Text = "Nazwa sali: " + hallName;
                NumberOfHallLabel.Text = "Numer sali: " + n.ToString();
                tableOfButtons = matrix.Split(',');
                row = (Convert.ToInt32(tableOfButtons[0])) - 1;
                col = (Convert.ToInt32(tableOfButtons[1])) - 2;
                NumberOfRowsLabel.Text = "Rzędy " + row;
                NumberOfColumnsLabel.Text = "Kolumny: " + col;

                GenerateTable(matrix);
            }
        }
        
    }
}
