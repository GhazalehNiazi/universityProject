namespace project
{
    partial class Car
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
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCarAvailable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarDGV
            // 
            this.CarDGV.AllowUserToOrderColumns = true;
            this.CarDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDGV.Location = new System.Drawing.Point(366, 135);
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.RowTemplate.Height = 25;
            this.CarDGV.Size = new System.Drawing.Size(545, 290);
            this.CarDGV.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(565, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "لیست خودروها";
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(120, 167);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(171, 23);
            this.txtCarBrand.TabIndex = 24;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(120, 210);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(171, 23);
            this.txtCarModel.TabIndex = 23;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(120, 125);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(171, 23);
            this.txtRegNo.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(173, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 21;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(256, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(173, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "تغییر";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(90, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "مدل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "کد خودرو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "برند";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 100);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اطلاعات خودروها";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(296, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "سیستم خرید خودرو";
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(120, 258);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(171, 23);
            this.txtCarPrice.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(45, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "قیمت";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "موجودی";
            // 
            // comboCarAvailable
            // 
            this.comboCarAvailable.FormattingEnabled = true;
            this.comboCarAvailable.Items.AddRange(new object[] {
            "بله",
            "خیر"});
            this.comboCarAvailable.Location = new System.Drawing.Point(120, 302);
            this.comboCarAvailable.Name = "comboCarAvailable";
            this.comboCarAvailable.Size = new System.Drawing.Size(171, 23);
            this.comboCarAvailable.TabIndex = 30;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 460);
            this.Controls.Add(this.comboCarAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CarDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CarDGV;
        private Label label6;
        private TextBox txtCarBrand;
        private TextBox txtCarModel;
        private TextBox txtRegNo;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtCarPrice;
        private Label label7;
        private Label label8;
        private ComboBox comboCarAvailable;
    }
}