using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
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
            groupBox1.Hide();
            HallCreateAddHallButton.Hide();
            ScreenLabel.Hide();
            nameOfHallLabel.Hide();
            FIllComboBox();
            RemoveHallButton.Hide();
            

        }


        private void CreateHallONButton_Click(object sender, EventArgs e)
        {
            HallNameLabel.Refresh();
            RowsLabel.Refresh();
            ColumnsLabel.Refresh();
            HallInfo.Show();
            HallCreateAddHallButton.Show();
            HallNameLabel.Text = "Nazwa sali: " + HallCreatorHallNameTextBox.Text;
            RowsLabel.Text = "Liczba wierszy: " + HallCreatorRowsNumberTextBox.Text;
            ColumnsLabel.Text = "Liczba kolumn: " + HallCreatorColumsNumberTextBox.Text;
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
                      
                        GenerateTable(columns+2,rows+1);

                    }
                }
            }

        }

        private void HallCreateGenetrateMatrix( List<List<Button>> buttList)
        {
            int rows=0;
            int columns = 0;
            //  tablica, gdzie będą zapisywane miejsca 
            rows = buttList.Count;
            for (int h = 0; h < rows; h++)
            {
                columns = buttons[h].Count;
            }
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
            ScreenLabel.Size=new Size(columnCount*27,35);
            ScreenLabel.AutoSize = false;
            ScreenLabel.TextAlign=ContentAlignment.MiddleCenter;
            ScreenLabel.BackColor = Color.FromKnownColor(KnownColor.Control);
            ScreenLabel.Show();
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
                            nameOfButtonColumnList.Add(cmd.Name.ToString());

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
                if (buttons1[0].Name != "00")
                {
                    nameOfButtonRowList.Add(buttons1[0].Name.ToString());
                    
                }
                
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

        private string HallCreateGenerateXML()
        {
            XmlRootAttribute oRootAttr = new XmlRootAttribute();
            
            oRootAttr.ElementName = "Sala";
            oRootAttr.IsNullable = true;
            XmlSerializer oSerializer = new XmlSerializer(typeof(List<List<Button>>), oRootAttr);
            StreamWriter oStreamWriter = null;
            try
            {
                oStreamWriter = new StreamWriter("hall.xml");
                oSerializer.Serialize(oStreamWriter, buttons);
            }
            catch (Exception oException)
            {
                Console.WriteLine("Aplikacja wygenerowała następujący wyjątek: " + oException.Message);
            }
            finally
            {
                if (null != oStreamWriter)
                {
                    oStreamWriter.Dispose();
                }
            }





            return "";
        }

        private void HallCreateSaveToDatabase()
        {


        }

        private void HallCreateTableGenerateFinishedTable()
        {
            string next = "";
            int o = 0;
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
                            // wyłączenie z widoku skrajnie lewej klumny 
                            (buttons[i][a]).Name = buttons[i - 1][a].Name.ToString();
                            (buttons[i][a]).BackColor = Color.FromKnownColor(KnownColor.Control);
                            (buttons[i][a]).Text = string.Format(" ");
                            (buttons[i][a]).ForeColor = Color.FromKnownColor(KnownColor.Control);

                            // "wyłączenie" z widoku skrajnie prawej kolumny
                            (buttons[i][columnCount - 1]).BackColor = Color.FromKnownColor(KnownColor.Control);
                            (buttons[i][columnCount - 1]).Text = string.Format(" ");
                            (buttons[i][columnCount - 1]).ForeColor = Color.FromKnownColor(KnownColor.Control);



                        }

                        // wyłączenie z widoku rzędu 
                        else
                        {
                            (buttons[i][a]).Name = buttons[i][a - 1].Name.ToString();
                            (buttons[i][a]).BackColor = Color.FromKnownColor(KnownColor.Control);
                            (buttons[i][a]).Text = string.Format(" ");
                            (buttons[i][a]).ForeColor = Color.FromKnownColor(KnownColor.Control);





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
            ChangeNumerationInTable(rowsCount, columnCount);
        }

        private void ChangeNumerationInTable(int rows, int columns)
        {
            for (int i = 1; i < rows; i++)
            {
                if (buttons[i][0].BackColor != Color.FromKnownColor((KnownColor.Control)) || buttons[i][columns-1].BackColor != Color.FromKnownColor((KnownColor.Control)))
                    if (nameOfButtonRowList.Count != 0)
                    {
                        buttons[i][0].Text = nameOfButtonRowList.First();
                        buttons[i][columns-1].Text = nameOfButtonRowList.First();
                        nameOfButtonRowList.Remove(buttons[i][0].Text);
                    }

            }

            for (int i = 1; i < columns-1; i++)
            {
                if (buttons[0][i].BackColor != Color.FromKnownColor((KnownColor.Control)) )
                    if (nameOfButtonColumnList.Count != 0)
                    {
                        buttons[0][i].Text = nameOfButtonColumnList.First();
                       nameOfButtonColumnList.Remove(buttons[0][i].Text);
                    }

            }
        }

        private void AddColumn(int column)
        {
            
        }

        private void AddRow(int row)
        {
            
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            groupBox1.Show(); 
            nameOfHallLabel.Hide();
            HallInfo.Hide();
            HallCreatePanel.Show();
            
        }

        private void GenerateTableWithXML()
        {
            // generowanie widok tabeli z pliku

        }
        private void HallCreateAddHallButton_Click(object sender, EventArgs e)
        {
            HallCreateTableGenerateFinishedTable();
            HallCreateGenerateXML();
            HallCreateSaveToDatabase();



        }
        
        private void HallCreateTableLayoutPanel_Paint(object sender, PaintEventArgs e) { }

        private void HallCreatorForm_Load(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            RemoveHallButton.Show();
            ScreenLabel.Hide();
              HallCreateTableLayoutPanel.Controls.Clear();

           HallCreateTableLayoutPanel.ColumnStyles.Clear();
           HallCreateTableLayoutPanel.RowStyles.Clear();

           HallCreateTableLayoutPanel.ColumnCount = 3;
           HallCreateTableLayoutPanel.RowCount = 4;
            if (hallNameComboBox.Text == "") MessageBox.Show("Nie wybrano sali.");
            else
            {
                nameOfHallLabel.Show();
         
                nameOfHallLabel.Text = "Sala: " + hallNameComboBox.Text;
            }
        }

        private void RemoveHallButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć salę " + hallNameComboBox.Text, "Usuwanie sali kinowej " , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
                {

                    var halls = (from t in ctx.Halls
                                 where t.title==hallNameComboBox.Text
                                 select t);
                    ctx.Entry(halls).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
                MessageBox.Show("Poprawnie usunięto salę kinową");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        
    }
}
