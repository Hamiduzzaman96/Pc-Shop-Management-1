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
    public partial class Admin : Form
    {
        public bool adminFrmClose = false;
        public Admin()
        {
            InitializeComponent();
            dashboardButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            dashboardButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            overviewButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = true;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = false;
        }

        private void guna2CircleButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Logout", logoutAdminBt);
        }

        private void logoutAdminBt_Click(object sender, EventArgs e)
        {
            adminFrmClose = true;
            this.Close();
            Program.loginForm.Show();
        }
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!adminFrmClose)
            {
                Application.Exit();
            }
            GC.Collect();
        }

        private void productsButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.White;
            dashboardButtonAdmin.IconColor = Color.White;
            overviewButtonLBorderAdmin.BackColor = Color.Transparent;

            productsButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            productsButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            productsButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = false;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = true;
        }

        private void employeesButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.White;
            dashboardButtonAdmin.IconColor = Color.White;
            overviewButtonLBorderAdmin.BackColor = Color.Transparent;

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            employeesButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            employeeButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = false;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = true;
            productsAdminUF1.Visible = false;
        }


        private void discountsButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.White;
            dashboardButtonAdmin.IconColor = Color.White;
            overviewButtonLBorderAdmin.BackColor = Color.Transparent;

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            discountsButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            discountsButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = false;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = true;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = false;
        }

        private void passwordButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.White;
            dashboardButtonAdmin.IconColor = Color.White;
            overviewButtonLBorderAdmin.BackColor = Color.Transparent;

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            passwordButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            passwordsButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            dashboardAdminUF1.Visible = false;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = true;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = false;
        }

        private void overviewButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            dashboardButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            overviewButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.White;
            salarySheetButtonAdmin.IconColor = Color.White;
            salarySheetButtonLBorderAdmin.BackColor = Color.Transparent;

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = true;
            salarySheetAdminUF1.Visible = false;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = false;
        }

        private void salarySheetButtonAdmin_Click(object sender, EventArgs e)
        {
            dashboardButtonAdmin.ForeColor = Color.White;
            dashboardButtonAdmin.IconColor = Color.White;
            overviewButtonLBorderAdmin.BackColor = Color.Transparent;

            productsButtonAdmin.ForeColor = Color.White;
            productsButtonAdmin.IconColor = Color.White;
            productsButtonLBorderAdmin.BackColor = Color.Transparent;

            employeesButtonAdmin.ForeColor = Color.White;
            employeesButtonAdmin.IconColor = Color.White;
            employeeButtonLBorderAdmin.BackColor = Color.Transparent;

            salarySheetButtonAdmin.ForeColor = Color.FromArgb(45, 156, 252);
            salarySheetButtonAdmin.IconColor = Color.FromArgb(45, 156, 252);
            salarySheetButtonLBorderAdmin.BackColor = Color.FromArgb(45, 156, 252);

            discountsButtonAdmin.ForeColor = Color.White;
            discountsButtonAdmin.IconColor = Color.White;
            discountsButtonLBorderAdmin.BackColor = Color.Transparent;

            passwordButtonAdmin.ForeColor = Color.White;
            passwordButtonAdmin.IconColor = Color.White;
            passwordsButtonLBorderAdmin.BackColor = Color.Transparent;

            dashboardAdminUF1.Visible = false;
            salarySheetAdminUF1.Visible = true;
            passwordsAdminUF1.Visible = false;
            discountsOrCuponnAdminUF1.Visible = false;
            employeeAdminUF1.Visible = false;
            productsAdminUF1.Visible = false;
        }
    }
}
