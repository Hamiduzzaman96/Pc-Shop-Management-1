using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Shop_Management_System
{
    public partial class Login : Form
    {
        bool mouseDown;
        private Point offset;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currScrPos = PointToScreen(e.Location);
                Location = new Point(currScrPos.X - offset.X, currScrPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if((userNameTb.Text.Length==0) && (passTb.Text.Length == 0))
            {
                MessageBox.Show("Please eneter you all informations");
            }
            
            if (userChecker() == 1)
            {
                this.Hide();
                Program.adminForm = new Admin();
                Program.adminForm.Show();
                GC.Collect();
            }
            else if (userChecker() == 2)
            {
                this.Hide();
                Program.salesmanForm = new SalesMan();
                Program.salesmanForm.Show();
                GC.Collect();
            }
            else if (userChecker() == 3)
            {
                this.Hide();
                Program.dataEntryOperatorForm = new DataEntryOperator();
                Program.dataEntryOperatorForm.Show();
                GC.Collect();
            }
            else if (userChecker() == 4)
            {
                this.Hide();
                Program.managerForm = new Manager();
                Program.managerForm.Show();
                GC.Collect();
            }
        }
        private int userChecker()
        {
            if(userNameTb.Text == "admin" && passTb.Text == "1234")
            {
                return 1;
            }
            else if(userNameTb.Text == "salesman" && passTb.Text == "1234")
            {
                return 2;
            }
            else if (userNameTb.Text == "deo" && passTb.Text == "1234")
            {
                return 3;
            }
            else if (userNameTb.Text == "manager" && passTb.Text == "1234")
            {
                return 4;
            }
            return 0;
        }
        private void forgetPassButton_Click(object sender, EventArgs e)
        {
            forgetPassword fp = new forgetPassword();
            fp.ShowDialog();
        }

        private void passTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by: Taz, Shahriar, Aniqa & Ramim");
        }
    }
}
