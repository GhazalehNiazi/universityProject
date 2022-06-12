using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class UserCars : Form
    {
        public UserCars()
        {
            InitializeComponent();
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Con.Open();
          //  string query = "Select from SellTbl where CustName='" + txtUserName.Text + "';";
          //  SqlDataAdapter adapter = new(query, Con);
          //  SqlCommandBuilder builder = new(adapter);
          //  var dataset = new DataSet();
          //  adapter.Fill(dataset);
          //  UsersCarDGV.DataSource = dataset.Tables[0];
          //  Con.Close();



        }

        private void UserCars_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
