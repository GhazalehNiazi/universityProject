namespace project
{
    partial class sellingCar
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
            this.comboCarNum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SellDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCarNum
            // 
            this.comboCarNum.FormattingEnabled = true;
            this.comboCarNum.Items.AddRange(new object[] {
            "بله",
            "خیر"});
            this.comboCarNum.Location = new System.Drawing.Point(115, 174);
            this.comboCarNum.Name = "comboCarNum";
            this.comboCarNum.Size = new System.Drawing.Size(171, 23);
            this.comboCarNum.TabIndex = 47;
          //  this.comboCarNum.SelectedIndexChanged += new System.EventHandler(this.comboCarNum_SelectedIndexChanged);
         //   this.comboCarNum.SelectionChangeCommitted += new System.EventHandler(this.comboCarNum_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "تاریخ خرید";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(115, 272);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(171, 23);
            this.txtCustomerName.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "نام";
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToOrderColumns = true;
            this.SellDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(354, 148);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowTemplate.Height = 25;
            this.SellDGV.Size = new System.Drawing.Size(449, 290);
            this.SellDGV.TabIndex = 43;
         //   this.SellDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(520, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "لیست فروش";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 128);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 23);
            this.txtId.TabIndex = 39;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(148, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 38;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(231, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 37;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(148, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 36;
            this.button2.Text = "تغییر";
            this.button2.UseVisualStyleBackColor = true;
          //  this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(65, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 35;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "کد مشتری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "آیدی";
          //  this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "کد خودرو";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 100);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اطلاعات فروش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(249, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "سیستم خرید خودرو";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 23);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Items.AddRange(new object[] {
            "بله",
            "خیر"});
            this.comboBoxCustomerId.Location = new System.Drawing.Point(115, 226);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(171, 23);
            this.comboBoxCustomerId.TabIndex = 50;
        //    this.comboBoxCustomerId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerId_SelectedIndexChanged);
            this.comboBoxCustomerId.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCustomerId_SelectionChangeCommitted);
            // 
            // sellingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.comboBoxCustomerId);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboCarNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SellDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "sellingCar";
            this.Text = "sellingCar";
            this.Load += new System.EventHandler(this.sellingCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboCarNum;
        private Label label8;
        private TextBox txtCustomerName;
        private Label label7;
        private DataGridView SellDGV;
        private Label label6;
        private TextBox txtId;
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxCustomerId;
    }
}