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
    public partial class SalesMan : Form
    {
        public bool salesmanFrmClosed = false;
        public SalesMan()
        {
            InitializeComponent();
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void SalesMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!salesmanFrmClosed)
            {
                Program.loginForm.Close();
            }
            GC.Collect();
        }

        private void logoutSalesmanBt_Click(object sender, EventArgs e)
        {
            salesmanFrmClosed = true;
            this.Close();
            Program.loginForm.Show();
            GC.Collect();
        }

        private void noticeSMBt_Click(object sender, EventArgs e)
        {
            noticeSalesMan ns = new noticeSalesMan();
            ns.ShowDialog();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            accountSettingsSalesman ss = new accountSettingsSalesman();
            ss.ShowDialog();
        }
    }
}
