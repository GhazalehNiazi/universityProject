namespace project
{
    partial class customers
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(99, 299);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 23);
            this.txtPhone.TabIndex = 41;
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToOrderColumns = true;
            this.CustomerDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(311, 148);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowTemplate.Height = 25;
            this.CustomerDGV.Size = new System.Drawing.Size(445, 290);
            this.CustomerDGV.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(463, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "لیست مشتری ها";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(99, 194);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 23);
            this.txtUsername.TabIndex = 38;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(99, 247);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 23);
            this.txtAddress.TabIndex = 37;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(99, 138);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 23);
            this.txtId.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(118, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 35;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(201, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 34;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(118, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "تغییر";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 100);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اطلاعات مشتری ها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "سیستم خرید خودرو";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 46;
            this.label7.Text = "تلفن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "آدرس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "آیدی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "نام ";
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPhone;
        private DataGridView CustomerDGV;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtAddress;
        private TextBox txtId;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}