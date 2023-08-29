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
using System.Configuration;
using System.Diagnostics;

namespace PC_Shop_Management_System
{
    public partial class DataEntryOperator : Form
    {
        public bool deoClosed = false;
        public DataEntryOperator()
        {
            InitializeComponent();
        }

        private void logoutDeoBt_Click(object sender, EventArgs e)
        {
            deoClosed = true;
            stopwatch.Stop();
            this.Close();
            Program.loginForm.Show();
            GC.Collect();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            GC.Collect();
            Application.Exit();
        }

        private void DataEntryOperator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!deoClosed)
            {
                Application.Exit();
            }
            stopwatch.Stop();
            GC.Collect();
        }

        private void deoNoticeBt_Click(object sender, EventArgs e)
        {
            noticeDEO nd = new noticeDEO();
            nd.ShowDialog();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            accountSettingsDataEntryOperator sd = new accountSettingsDataEntryOperator();
            sd.ShowDialog();
        }
        DateTime start;
        DateTime end;
        private void DataEntryOperator_Load(object sender, EventArgs e)
        {
            bindProductData();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            start = DateTime.Now;
        }
        public void bindProductData()                                                              
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from ProductTB";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }
        public string productIdGeneraotor()
        {
            int sn = 0;
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from productSNcounterTB";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sd = cmd.ExecuteReader();
            if (sd.Read())
            {
                sn = (int)sd["serial"];
            }
            con.Close();
            query = "update productSNcounterTB set serial=@serial where sn=0";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@serial", sn + 1);
            cmd.ExecuteNonQuery();
            return "PD-" + sn;
        }

        public void insertPrductInfoToDatabase()
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "insert into ProductTB values(@pdId, @pdName, @companyName, @modelName, @price, @availableQuantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("pdId", productIdGeneraotor());
            cmd.Parameters.AddWithValue("@pdName", guna2ComboBox1.Text);
            cmd.Parameters.AddWithValue("@companyName", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@modelName", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@price", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@availableQuantity ", guna2TextBox10.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            con.Close();
        }
        public void resetProductForm()
        {
            guna2TextBox8.Clear();
            guna2TextBox1.Clear();
            guna2TextBox9.Clear();
            guna2TextBox10.Clear();
            guna2TextBox4.Clear();
            guna2TextBox4.Clear();
        }

        private void insertBt_Click(object sender, EventArgs e)
        {
            insertPrductInfoToDatabase();
            bindProductData();
            resetProductForm();
        }

        private void guna2DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2ComboBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox8.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox9.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox10.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "delete from ProductTB where pdId = @pdId";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pdId", guna2DataGridView1.SelectedRows[0].Cells[0].Value);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Data Not Deleted.");
            }
            con.Close();
            bindProductData();
            resetProductForm();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "update ProductTB set pdName=@pdName, companyName=@companyName, modelName=@modelName, price=@price, availableQuantity=@availableQuantity where pdId=@pdId";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pdId", guna2DataGridView1.SelectedRows[0].Cells[0].Value);
            cmd.Parameters.AddWithValue("@pdName", guna2ComboBox1.Text);
            cmd.Parameters.AddWithValue("@companyName", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@modelName", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@price", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@availableQuantity", Int32.Parse(guna2TextBox10.Text) + (int)guna2DataGridView1.SelectedRows[0].Cells[5].Value);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Data Not Updated.");
            }
            con.Close();
            bindProductData();
            resetProductForm();
        }

        private void searchIDBt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from ProductTB where pdId=@pdId";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pdId", guna2TextBox4.Text);
            SqlDataReader sd = cmd.ExecuteReader();
            if (sd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(sd);
                guna2DataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            con.Close();
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            bindProductData();
            resetProductForm();
        }

        private void searchNameBt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from ProductTB where pdName=@searchedName or companyName=@searchedName or modelName=@searchedName";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@searchedName", guna2TextBox4.Text);
            SqlDataReader sd = cmd.ExecuteReader();
            if (sd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(sd);
                guna2DataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            con.Close();
        }
        Stopwatch stopwatch;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void DataEntryOperator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clickedStatus)
            {
                stopwatch.Stop();
                end = DateTime.Now;
                saveWorkingDuration();
            }
            //watchSaveWDData();
        }
        //private void watchSaveWDData()
        //{
        //    int duration = 0;
        //    SqlConnection con = new SqlConnection(Program.connectionString);
        //    string query = "select * from RegularWorkingDurationTB where post=@post";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.Parameters.AddWithValue("@post", "Data Entry Operator");
        //    SqlDataReader sd = cmd.ExecuteReader();
        //    if (sd.Read())
        //    {
        //        duration = (int)sd["duration"];
        //    }
        //    con.Close();
        //    MessageBox.Show(duration.ToString());
        //}
        private void saveWorkingDuration()
        {
            int duration = 0;
            TimeSpan ts = end - start;

            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from RegularWorkingDurationTB where post=@post";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@post", "Data Entry Operator");
            SqlDataReader sd = cmd.ExecuteReader();
            if (sd.Read())
            {
                duration = (int)sd["duration"];
            }
            con.Close();
            query = "update RegularWorkingDurationTB set duration=@duration where post=@post";
            con.Open();
            cmd = new SqlCommand(query, con);
            duration += Convert.ToInt32(ts.TotalSeconds);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@post", "Data Entry Operator");
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private bool clickedStatus = false;
        private void breakBt_Click(object sender, EventArgs e)      //break button.
        {
            if (!clickedStatus)
            {
                guna2Panel2.FillColor = Color.FromArgb(255, 82, 96);
                clickedStatus = true;
                stopwatch.Stop();
                end = DateTime.Now;
                saveWorkingDuration();
            }
            else
            {
                guna2Panel2.FillColor = Color.FromArgb(14, 180, 138);
                clickedStatus = false;
                stopwatch.Start();
                start = DateTime.Now;
            }
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
