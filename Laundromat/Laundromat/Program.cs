using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Laundromat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());

            
        }
        public static string serverIp = ConfigurationManager.AppSettings["serverIp"];
        public static string server = "Data Source=" + serverIp + ";Initial Catalog=londromat;User ID=dandl;Password=d&lpassword01 ";



        public static string logedUser = "";
        public static DateTime login;
    }
}
