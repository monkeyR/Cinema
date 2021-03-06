﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
   public class XMLparse
    {
        public string hallToString = "";
       private List<List<Button>> hallButtonList = new List<List<Button>>();

       private List<String> nameOfButtonColumnList = new List<string>();
       private List<String> nameOfButtonRowList = new List<string>();

        private int i = 0;
        private int y = 0;
        private int columnCount = 0;


        public string ParseToString(List<List<Button>> hall)
        {
            // zapisywanie sali w bazie danych jako string 
            columnCount = hall[0].Count;
            hallToString += hall.Count.ToString();
            hallToString += "," + columnCount;
          
            for (i = 1; i < hall.Count; i++)
            {
                for (y = 1; y < columnCount - 1; y++)
                {
                    if (hall[i][y].BackColor != Color.Gray)
                    {
                        hallToString += ",0";
                    }
                    else hallToString += ",1";
                }
            }
            return hallToString;
        }

        public List<List<Button>> HallStringToListButton(string hallString)
        {
            // wyświetlanie sali ze stringa 
            int nextButtonInMatrix = 2;
            int rows = 0;
            int columns = 0;
            string[] matrixChar = hallString.Split(',');
            rows = Convert.ToInt32(matrixChar[0]);
            columns = Convert.ToInt32(matrixChar[1]);
            
            hallButtonList.Clear();

         
            // c -> A w kodzie ASCII 
            int c = 65;

            for (int y = 0; y < rows; y++)
            {
                List<Button> buttons1 = new List<Button>();
                for (int x = 0; x < columns; x++)
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
                    //else if (y == 0 && x == columnCount - 1)
                    else if (y == 0 && x == columns-1 )
                    {
                        // ukrycie komórki [0,columnCount-1]
                        cmd.Name = "0" + (columns-1).ToString();
                        cmd.Hide();
                    }
                    else
                    {
                        //if (y == 0 && x != 0 && x != columnCount - 1)

                        if (y == 0 && x != 0 && x != columns-1)
                        {
                            // wiersz 0  ( nazwy kolumn )
                            cmd.BackColor = Color.Crimson;
                            cmd.Text = x.ToString();
                            cmd.Name = x.ToString();
                            //nameOfButtonColumnList.Add(cmd.Name.ToString());
                        }
                        if (x == 0 || x == columns-1 )
                        {
                            // kolumna 0 i columnCount  ( nazwy wierszy )
                            if (y != 0)
                            {
                                //---------------->     // DODAĆ - co będzie, gdy skńczy się alfabet ? 
                                if (x == columns-1 )
                                {
                                    // ostatnia kolumna 
                                    cmd.Text = ((Char) c).ToString();
                                    cmd.BackColor = Color.Crimson;
                                    cmd.Name = ((Char) c).ToString();
                                   c++;
                                }
                                else
                                {
                                    // pierwsza kolumna
                                    cmd.Text = ((Char) c).ToString();
                                    cmd.BackColor = Color.Crimson;
                                    cmd.Name = ((Char) c).ToString();
                                }
                               
                            }

                        }
                        // Jeśli nie ma nazwy - są to "siedzenia", im nadajemy nazwy 1A,1B itd...
                        if (cmd.Name == "")
                        {
                            cmd.Name = x.ToString() + ((char) c).ToString();
                            if (matrixChar[nextButtonInMatrix] == 1.ToString())
                            {
                                cmd.BackColor = Color.Gray;

                            }
                            else if (matrixChar[nextButtonInMatrix] == 0.ToString())
                            {
                                cmd.BackColor = Color.FromArgb(123, 156, 204);
                            }
                            nextButtonInMatrix++;
                        }

                    }
                  
                    buttons1.Add(cmd);
                }
               hallButtonList.Add(buttons1);

            }

            return hallButtonList;
        }



    }
}
