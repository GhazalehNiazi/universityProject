using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin")
            {
                switch (txtPassword.Text)
                {
                    case "1234":
                            this.Hide();
                            MainForm main = new MainForm();
                            main.Show();
                    break;
                    default:
                        MessageBox.Show("اطلاعات نادرست هستند");
                        break;
                }
            }else
            {
                this.Hide();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }
    }
}
