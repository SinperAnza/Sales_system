namespace Sales_system
{
    partial class Form1
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
            this.bagType = new System.Windows.Forms.ListBox();
            this.Numericquantity = new System.Windows.Forms.NumericUpDown();
            this.Overnightbtn = new System.Windows.Forms.RadioButton();
            this.Three_Daybtn = new System.Windows.Forms.RadioButton();
            this.Standardbtn = new System.Windows.Forms.RadioButton();
            this.CalculateButton_Click = new System.Windows.Forms.Button();
            this.ClearButton_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numericquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // bagType
            // 
            this.bagType.FormattingEnabled = true;
            this.bagType.ItemHeight = 16;
            this.bagType.Items.AddRange(new object[] {
            "Full Decorative ",
            "Beaded",
            "Needlepoint Design",
            "Fringed Beaded",
            "Plain"});
            this.bagType.Location = new System.Drawing.Point(24, 113);
            this.bagType.Name = "bagType";
            this.bagType.Size = new System.Drawing.Size(164, 132);
            this.bagType.TabIndex = 0;
            // 
            // Numericquantity
            // 
            this.Numericquantity.Location = new System.Drawing.Point(630, 88);
            this.Numericquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numericquantity.Name = "Numericquantity";
            this.Numericquantity.Size = new System.Drawing.Size(120, 22);
            this.Numericquantity.TabIndex = 1;
            this.Numericquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Overnightbtn
            // 
            this.Overnightbtn.AutoSize = true;
            this.Overnightbtn.Location = new System.Drawing.Point(94, 265);
            this.Overnightbtn.Name = "Overnightbtn";
            this.Overnightbtn.Size = new System.Drawing.Size(85, 20);
            this.Overnightbtn.TabIndex = 2;
            this.Overnightbtn.TabStop = true;
            this.Overnightbtn.Text = "Overnight";
            this.Overnightbtn.UseVisualStyleBackColor = true;
            // 
            // Three_Daybtn
            // 
            this.Three_Daybtn.AutoSize = true;
            this.Three_Daybtn.Location = new System.Drawing.Point(344, 264);
            this.Three_Daybtn.Name = "Three_Daybtn";
            this.Three_Daybtn.Size = new System.Drawing.Size(92, 20);
            this.Three_Daybtn.TabIndex = 3;
            this.Three_Daybtn.TabStop = true;
            this.Three_Daybtn.Text = "Three Day";
            this.Three_Daybtn.UseVisualStyleBackColor = true;
            // 
            // Standardbtn
            // 
            this.Standardbtn.AutoSize = true;
            this.Standardbtn.Location = new System.Drawing.Point(560, 265);
            this.Standardbtn.Name = "Standardbtn";
            this.Standardbtn.Size = new System.Drawing.Size(83, 20);
            this.Standardbtn.TabIndex = 4;
            this.Standardbtn.TabStop = true;
            this.Standardbtn.Text = "Standard";
            this.Standardbtn.UseVisualStyleBackColor = true;
            // 
            // CalculateButton_Click
            // 
            this.CalculateButton_Click.Location = new System.Drawing.Point(323, 363);
            this.CalculateButton_Click.Name = "CalculateButton_Click";
            this.CalculateButton_Click.Size = new System.Drawing.Size(160, 43);
            this.CalculateButton_Click.TabIndex = 5;
            this.CalculateButton_Click.Text = "Calculate Total";
            this.CalculateButton_Click.UseVisualStyleBackColor = true;
            this.CalculateButton_Click.Click += new System.EventHandler(this.CalculateButton_Click_Click);
            // 
            // ClearButton_Click
            // 
            this.ClearButton_Click.Location = new System.Drawing.Point(516, 363);
            this.ClearButton_Click.Name = "ClearButton_Click";
            this.ClearButton_Click.Size = new System.Drawing.Size(164, 43);
            this.ClearButton_Click.TabIndex = 6;
            this.ClearButton_Click.Text = "Clear Selection";
            this.ClearButton_Click.UseVisualStyleBackColor = true;
            this.ClearButton_Click.Click += new System.EventHandler(this.ClearButton_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton_Click);
            this.Controls.Add(this.CalculateButton_Click);
            this.Controls.Add(this.Standardbtn);
            this.Controls.Add(this.Three_Daybtn);
            this.Controls.Add(this.Overnightbtn);
            this.Controls.Add(this.Numericquantity);
            this.Controls.Add(this.bagType);
            this.Name = "Form1";
            this.Text = "AD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numericquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bagType;
        private System.Windows.Forms.NumericUpDown Numericquantity;
        private System.Windows.Forms.RadioButton Overnightbtn;
        private System.Windows.Forms.RadioButton Three_Daybtn;
        private System.Windows.Forms.RadioButton Standardbtn;
        private System.Windows.Forms.Button CalculateButton_Click;
        private System.Windows.Forms.Button ClearButton_Click;
    }
}

