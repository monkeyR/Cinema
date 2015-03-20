﻿namespace CinemaManager.Main
{
    partial class MainFormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonGroup = new System.Windows.Forms.GroupBox();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.HallCreatorButton = new System.Windows.Forms.Button();
            this.MovieButton = new System.Windows.Forms.Button();
            this.MovieHallsButton = new System.Windows.Forms.Button();
            this.ShiftsAndPositionsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.MovieStatisticsButton = new System.Windows.Forms.Button();
            this.SalesStatisticsButton = new System.Windows.Forms.Button();
            this.ButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(293, 12);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1003, 729);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Controls.Add(this.ProductsButton);
            this.ButtonGroup.Controls.Add(this.HallCreatorButton);
            this.ButtonGroup.Controls.Add(this.MovieButton);
            this.ButtonGroup.Controls.Add(this.MovieHallsButton);
            this.ButtonGroup.Controls.Add(this.ShiftsAndPositionsButton);
            this.ButtonGroup.Controls.Add(this.EmployeesButton);
            this.ButtonGroup.Controls.Add(this.MovieStatisticsButton);
            this.ButtonGroup.Controls.Add(this.SalesStatisticsButton);
            this.ButtonGroup.Location = new System.Drawing.Point(12, 12);
            this.ButtonGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonGroup.Size = new System.Drawing.Size(267, 639);
            this.ButtonGroup.TabIndex = 1;
            this.ButtonGroup.TabStop = false;
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(7, 462);
            this.ProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(253, 57);
            this.ProductsButton.TabIndex = 7;
            this.ProductsButton.Text = "Produkty ";
            this.ProductsButton.UseVisualStyleBackColor = true;
            // 
            // HallCreatorButton
            // 
            this.HallCreatorButton.Location = new System.Drawing.Point(7, 399);
            this.HallCreatorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HallCreatorButton.Name = "HallCreatorButton";
            this.HallCreatorButton.Size = new System.Drawing.Size(253, 57);
            this.HallCreatorButton.TabIndex = 6;
            this.HallCreatorButton.Text = "Kreator sal";
            this.HallCreatorButton.UseVisualStyleBackColor = true;
            this.HallCreatorButton.Click += new System.EventHandler(this.HallCreatorButton_Click);
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(7, 336);
            this.MovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(253, 57);
            this.MovieButton.TabIndex = 5;
            this.MovieButton.Text = "Filmy";
            this.MovieButton.UseVisualStyleBackColor = true;
            // 
            // MovieHallsButton
            // 
            this.MovieHallsButton.Location = new System.Drawing.Point(7, 272);
            this.MovieHallsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieHallsButton.Name = "MovieHallsButton";
            this.MovieHallsButton.Size = new System.Drawing.Size(253, 57);
            this.MovieHallsButton.TabIndex = 4;
            this.MovieHallsButton.Text = "Sale";
            this.MovieHallsButton.UseVisualStyleBackColor = true;
            // 
            // ShiftsAndPositionsButton
            // 
            this.ShiftsAndPositionsButton.Location = new System.Drawing.Point(7, 209);
            this.ShiftsAndPositionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShiftsAndPositionsButton.Name = "ShiftsAndPositionsButton";
            this.ShiftsAndPositionsButton.Size = new System.Drawing.Size(253, 57);
            this.ShiftsAndPositionsButton.TabIndex = 3;
            this.ShiftsAndPositionsButton.Text = "Stanowiska i dyżury";
            this.ShiftsAndPositionsButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(7, 146);
            this.EmployeesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(253, 55);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Pracownicy";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // MovieStatisticsButton
            // 
            this.MovieStatisticsButton.Location = new System.Drawing.Point(7, 89);
            this.MovieStatisticsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieStatisticsButton.Name = "MovieStatisticsButton";
            this.MovieStatisticsButton.Size = new System.Drawing.Size(253, 50);
            this.MovieStatisticsButton.TabIndex = 1;
            this.MovieStatisticsButton.Text = "Statystyki filmów";
            this.MovieStatisticsButton.UseVisualStyleBackColor = true;
            // 
            // SalesStatisticsButton
            // 
            this.SalesStatisticsButton.Location = new System.Drawing.Point(7, 31);
            this.SalesStatisticsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesStatisticsButton.Name = "SalesStatisticsButton";
            this.SalesStatisticsButton.Size = new System.Drawing.Size(253, 50);
            this.SalesStatisticsButton.TabIndex = 0;
            this.SalesStatisticsButton.Text = "Statystyki sprzedaży";
            this.SalesStatisticsButton.UseVisualStyleBackColor = true;
            // 
            // MainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1311, 754);
            this.Controls.Add(this.ButtonGroup);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFormManager";
            this.Text = "MainFormMenager";
            this.ButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox ButtonGroup;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button HallCreatorButton;
        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.Button MovieHallsButton;
        private System.Windows.Forms.Button ShiftsAndPositionsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button MovieStatisticsButton;
        private System.Windows.Forms.Button SalesStatisticsButton;
    }
}