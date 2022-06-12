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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellingCar sellingCar = new sellingCar();
            sellingCar.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users();
            user.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            customers customers = new customers();
            customers.Show();
        }
    }
}
