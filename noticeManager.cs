using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Shop_Management_System
{
    public partial class noticeManager : Form
    {
        public noticeManager()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "insert into noticeTB values(@message)";
            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.Parameters.AddWithValue("@message", guna2TextBox8.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Message sent");
                //BindGridView();
                //ResetControl();
            }
            else
            {
                MessageBox.Show("message faild !");
            }
            con.Close();
        }
        void BindGridView()
        {
            //connection gridview and database
            SqlConnection con = new SqlConnection(Program.connectionString);
            //string query = "select empNId,empName,post,empAddress,phoneNumber,email,picture from EmployeeTB";
            string query = "select message from noticeTB";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //Data in Gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            guna2DataGridView1.DataSource = data;
            con.Close();
        }
    }
}
