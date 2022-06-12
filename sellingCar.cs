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
    public partial class sellingCar : Form
    {
        public sellingCar()
        {
            InitializeComponent();
        }
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void fillCombo()
        {
            Con.Open();
            string query = "select RegNum from CarTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum",typeof(string));
            dt.Load(rdr);
            comboCarNum.ValueMember = "RegNum";
            comboCarNum.DataSource = dt;
            Con.Close();

        }
        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustId from CustomerTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(rdr);
            comboBoxCustomerId.ValueMember = "CustId";
            comboBoxCustomerId.DataSource = dt;
            Con.Close();
        }
        private void customerName()
        {
            Con.Open();
            string query = "select * from CustomerTbl where CustId="+comboBoxCustomerId.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach(DataRow dataRow in dt.Rows)
            {
                txtCustomerName.Text= dataRow["CustName"].ToString();
            }
            Con.Close();
        }
        private void Populate()
        {
            Con.Open();
            string query = "select * from SellTbl";
            SqlDataAdapter adapter = new(query, Con);
            SqlCommandBuilder builder = new(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            SellDGV.DataSource = dataset.Tables[0];
            Con.Close();
        }
        private void sellingCar_Load(object sender, EventArgs e)
        {
            fillCombo();
            fillCustomer();
            Populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void comboBoxCustomerId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            customerName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtId.Text == "" )
            {
                MessageBox.Show("اطلاعات ناقص هستند");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into SellTbl values('" + txtId.Text + "','" + comboCarNum.Text.ToString() + "','" + txtCustomerName.Text + "','" + dateTimePicker1.Value + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("خودرو باموفقیت فروخته شد");
                    Populate();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

      
    }
}
