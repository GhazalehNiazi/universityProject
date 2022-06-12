namespace project
{
    partial class UserCars
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UsersCarDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersCarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Crimson;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(293, 377);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 40);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "خروج";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 100);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "سیستم خرید خودرو";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(388, 135);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(197, 23);
            this.txtUserName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "لطفا نام کاربری خود را وارد کنید";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(498, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsersCarDGV
            // 
            this.UsersCarDGV.AllowUserToOrderColumns = true;
            this.UsersCarDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsersCarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersCarDGV.Location = new System.Drawing.Point(99, 239);
            this.UsersCarDGV.Name = "UsersCarDGV";
            this.UsersCarDGV.RowTemplate.Height = 25;
            this.UsersCarDGV.Size = new System.Drawing.Size(486, 131);
            this.UsersCarDGV.TabIndex = 44;
            // 
            // UserCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.UsersCarDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Name = "UserCars";
            this.Text = "UserCars";
            this.Load += new System.EventHandler(this.UserCars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersCarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Panel panel1;
        private Label label2;
        private TextBox txtUserName;
        private Label label1;
        private Button button1;
        private DataGridView UsersCarDGV;
    }
}