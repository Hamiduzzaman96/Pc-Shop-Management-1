using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace PC_Shop_Management_System
{
    public partial class Manager : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public bool managerFrm = false;
        private bool clickedStatus;
        private DateTime end;
        private DateTime start;
        public Manager()
        {
            InitializeComponent();
            BindGridView();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!managerFrm)
            {
                Application.Exit();
            }
            GC.Collect();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void logoutManagerBt_Click(object sender, EventArgs e)
        {
            managerFrm = true;
            this.Close();
            Program.loginForm.Show();
            GC.Collect();
        }

        private void managerNoticeBt_Click(object sender, EventArgs e)
        {
            noticeManager nm = new noticeManager();
            nm.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            accountSettingsManager sm = new accountSettingsManager();
            sm.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select image.";
            ofd.Filter = "PNG File (*.png) | *.png";
            //ofd.Filter = "JPG File (*.jpg) | *.jpg";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            guna2TextBox11.Clear();
            guna2TextBox10.Clear();
            guna2TextBox9.Clear();
            guna2TextBox8.Clear();  
            guna2TextBox7.Clear();
            guna2PictureBox1.Image = Properties.Resources.user_white1;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "insert into EmployeeTB values(@empNId, @empName, @post, 0, null, null, @empAddress, @phoneNumber, @email, @picture)";
            //insert into EmployeeTB values(@empNId, @empName, @post ,null,null, null, @empAddress, @phoneNumber, @email, @picture");
            SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader sqdr = cmd.ExecuteReader();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable(); 
            //sqlDataAdapter.Fill(dt);
            con.Open();
            cmd.Parameters.AddWithValue("@empNId", guna2TextBox7.Text);
            cmd.Parameters.AddWithValue("@empName", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@post", guna2ComboBox1.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", guna2TextBox10.Text);
            cmd.Parameters.AddWithValue("@email", guna2TextBox11.Text);
            cmd.Parameters.AddWithValue("@empAddress", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());
            
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data not inserted !");
            }
            con.Close();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            guna2PictureBox1.Image.Save(ms, guna2PictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        void BindGridView()
        {
            //connection gridview and database
            SqlConnection con = new SqlConnection(Program.connectionString);
            //string query = "select empNId,empName,post,empAddress,phoneNumber,email,picture from EmployeeTB";
            string query = "select empNId,empName,post,empAddress,phoneNumber,email,picture from EmployeeTB";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //Data in Gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            guna2DataGridView1.DataSource = data;
            con.Close();

            //Column Adjust in gridview
            /*DataGridViewImageColumn dvg = new DataGridViewImageColumn();
            dvg = (DataGridViewImageColumn)guna2DataGridView1.Columns[6];
            dvg.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //autosize table column 
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //image row height
            guna2DataGridView1.RowTemplate.Height = 45;
            ResetControl();*/
        }

        private void guna2Button9_Click(object sender, EventArgs e)         //break button.
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

        private void saveWorkingDuration()
        {
            int duration = 0;
            TimeSpan ts = end - start;

            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from RegularWorkingDurationTB where post=@post";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@post", "Manager");
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
            cmd.Parameters.AddWithValue("@post", "Manager");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Manager_Load(object sender, EventArgs e)                    //conn form                          
        {
            
            //employeeData();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            start = DateTime.Now;
        }

        /*private void employeeData()
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * EmployeeTB";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sd);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }*/

        private void bindProductData()
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Stopwatch stopwatch;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void welcomeUserIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clickedStatus)
            {
                stopwatch.Stop();
                end = DateTime.Now;
                saveWorkingDuration();
            }
        }

        private void Manager_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2TextBox7.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox8.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            guna2ComboBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox9.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox10.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox11.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            guna2PictureBox1.Image = GetPhoto((byte[])guna2DataGridView1.SelectedRows[0].Cells[6].Value);
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void refreshBt_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "update into EmployeeTB set (empName=@empName, post=@post, salary=0, receivableSalary=null, workingDuration=null, empAddress=@empAddress, phoneNumber=@phoneNumber, email=@email, picture=@picture,where empNId=@empNId)"; 
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@empNId", guna2TextBox7.Text);
            cmd.Parameters.AddWithValue("@empName", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@post", guna2ComboBox1.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", guna2TextBox10.Text);
            cmd.Parameters.AddWithValue("@email", guna2TextBox11.Text);
            cmd.Parameters.AddWithValue("@empAddress", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("Data updated Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Update unsuccesful !");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from EmployeeTB where empName=@searchedName";
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            string query = "select * from EmployeeTB where empNId=@searchedNId";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@searchedNId", guna2TextBox4.Text);
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
    }
}
