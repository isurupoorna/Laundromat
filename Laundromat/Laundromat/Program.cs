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
            Application.Run(new adminHome());

            
        }
        public static string serverIp = ConfigurationManager.AppSettings["serverIp"];
        public static string server = "Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True";


        public static string logedUser = "";
        public static DateTime login;
    }
}
