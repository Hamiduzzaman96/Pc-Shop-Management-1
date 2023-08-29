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
    public partial class DashboardAdminUF : UserControl
    {
        public DashboardAdminUF()
        {
            InitializeComponent();
        }

        private void exitAdminBt_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void noticeAdminBt_Click(object sender, EventArgs e)
        {
            noticeAdmin notAdmin = new noticeAdmin();
            notAdmin.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            accountSettingsAdmin sa = new accountSettingsAdmin();
            sa.ShowDialog();
        }
    }
}
