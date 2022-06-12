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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter adapter = new(query, Con);
            SqlCommandBuilder builder = new(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            CustomerDGV.DataSource = dataset.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPhone.Text == "" || txtId.Text == "" || txtAddress.Text == "")
            {

                MessageBox.Show("اطلاعات ناقص هستند");


            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values('" + txtId.Text + "','" + txtUsername.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("مشتری با موفقیت افزوده شد");

                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("اطلاعات ناقص میباشد");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTbl where CustId='" + txtId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("مشتری با موفقیت حذف شد");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
