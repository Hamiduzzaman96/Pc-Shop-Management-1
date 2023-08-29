using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PC_Shop_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        internal static Login loginForm;
        internal static Admin adminForm;
        internal static Manager managerForm;
        internal static DataEntryOperator dataEntryOperatorForm;
        internal static SalesMan salesmanForm;
        internal static string connectionString;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            loginForm = new Login();
            Application.Run(loginForm);
        }
    }
}
