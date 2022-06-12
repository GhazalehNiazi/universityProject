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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void Populate()
        {
            Con.Open();
            string query = "select * from userTbl";
            SqlDataAdapter adapter = new(query,Con);
            SqlCommandBuilder builder = new(adapter);
            var dataset  = new DataSet();
            adapter.Fill(dataset);
            UserDGV.DataSource = dataset.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUserId.Text == "" || txtUserPassword.Text == "")
            {
                
                MessageBox.Show("اطلاعات ناقص هستند");


            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into userTbl values('" + txtUserId.Text + "','" + txtUsername.Text + "','" + txtUserPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("کاربر با موفقیت افزوده شد");
                    
                    Populate();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                MessageBox.Show("اطلاعات ناقص میباشد");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where Id=" + txtUserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("کاربر با موفقیت حذف شد");
                    Con.Close();
                    Populate();
                }catch(Exception ex)
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
