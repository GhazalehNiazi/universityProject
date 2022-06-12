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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            Con.Open();
            string query = "select * from CarTbl";
            SqlDataAdapter adapter = new(query, Con);
            SqlCommandBuilder builder = new(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            CarDGV.DataSource = dataset.Tables[0];
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" || txtCarModel.Text == "" || txtCarBrand.Text == "" ||txtCarPrice.Text == "" )
            {
                MessageBox.Show("اطلاعات ناقص هستند");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTbl values('" + txtRegNo.Text + "','" + txtCarBrand.Text + "','" + txtCarModel.Text + "','" + comboCarAvailable.SelectedItem.ToString()  + "','" + txtCarPrice.Text+ "')";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("ماشین با موفقیت افزوده شد");
                    Populate();

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "")
            {
                MessageBox.Show("اطلاعات ناقص میباشد");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Select from CarTbl where RegNum='" + txtRegNo.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("خودرو با موفقیت حذف شد");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
