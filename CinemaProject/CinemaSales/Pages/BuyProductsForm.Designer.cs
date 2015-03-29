namespace CinemaSales.Main
{
    partial class BuyProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyProductsForm));
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.MainProductsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MainProductsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(195)))));
            this.CategoriesPanel.Location = new System.Drawing.Point(504, 0);
            this.CategoriesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(100, 482);
            this.CategoriesPanel.TabIndex = 2;
            // 
            // MainProductsPanel
            // 
            this.MainProductsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProductsPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainProductsPanel.Location = new System.Drawing.Point(0, 0);
            this.MainProductsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainProductsPanel.Name = "MainProductsPanel";
            this.MainProductsPanel.Size = new System.Drawing.Size(499, 482);
            this.MainProductsPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CinemaSales.Properties.Resources.coca_cola;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(109, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(215, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BuyProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(156)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.MainProductsPanel);
            this.Controls.Add(this.CategoriesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyProductsForm";
            this.Text = "BuyProductsForm";
            this.Load += new System.EventHandler(this.BuyProductsForm_Load);
            this.MainProductsPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.Panel MainProductsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

    }
}