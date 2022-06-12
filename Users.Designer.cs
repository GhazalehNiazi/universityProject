namespace project
{
    partial class Users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اطلاعات کاربران";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "سیستم خرید خودرو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام کاربری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "آیدی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "کلمه عبور";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(90, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(173, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "تغییر";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(256, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(173, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(120, 183);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(171, 23);
            this.txtUserId.TabIndex = 9;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(120, 280);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(171, 23);
            this.txtUserPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 23);
            this.txtUsername.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(544, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "لیست کاربران";
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToOrderColumns = true;
            this.UserDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(422, 159);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.RowTemplate.Height = 25;
            this.UserDGV.Size = new System.Drawing.Size(366, 243);
            this.UserDGV.TabIndex = 13;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtUserId;
        private TextBox txtUserPassword;
        private TextBox txtUsername;
        private Label label6;
        private DataGridView UserDGV;
    }
}