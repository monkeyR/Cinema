namespace CinemaManager.Pages
{
    partial class EmployeesManagementForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firedListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.addNewEmployeeButton);
            this.panel2.Controls.Add(this.employeeListView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 263);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Location = new System.Drawing.Point(670, 2);
            this.addNewEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(90, 44);
            this.addNewEmployeeButton.TabIndex = 18;
            this.addNewEmployeeButton.Text = "Dodaj nowego";
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.employeeListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeeListView.FullRowSelect = true;
            this.employeeListView.GridLines = true;
            this.employeeListView.Location = new System.Drawing.Point(3, 51);
            this.employeeListView.MultiSelect = false;
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(757, 207);
            this.employeeListView.TabIndex = 6;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            this.employeeListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.employeeListView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Imię";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwisko";
            this.columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stanowisko";
            this.columnHeader3.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Login";
            this.columnHeader4.Width = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista pracowników";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.firedListView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 252);
            this.panel1.TabIndex = 19;
            // 
            // firedListView
            // 
            this.firedListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.firedListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firedListView.FullRowSelect = true;
            this.firedListView.GridLines = true;
            this.firedListView.Location = new System.Drawing.Point(7, 49);
            this.firedListView.MultiSelect = false;
            this.firedListView.Name = "firedListView";
            this.firedListView.Size = new System.Drawing.Size(752, 200);
            this.firedListView.TabIndex = 19;
            this.firedListView.UseCompatibleStateImageBehavior = false;
            this.firedListView.View = System.Windows.Forms.View.Details;
            this.firedListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.firedListView_MouseUp);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Imię";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nazwisko";
            this.columnHeader6.Width = 212;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Stanowisko";
            this.columnHeader7.Width = 143;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Login";
            this.columnHeader8.Width = 121;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data zwolnienia";
            this.columnHeader9.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista zwolnionych";
            // 
            // EmployeesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(786, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EmployeesManagementForm";
            this.Text = "EmployeesManagementForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView firedListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;

    }
}