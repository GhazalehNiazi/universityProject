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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
       
        private void dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCars userCars = new UserCars();
            userCars.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
