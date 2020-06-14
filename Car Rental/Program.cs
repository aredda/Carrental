using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    static class Program
    {

        public static RentalEntities context;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            context = new RentalEntities();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //try
            //{
            //    string sever = Helper.getServerName();
            //}
            //catch (Exception)
            //{
            //    new FormServer().ShowDialog();
            //}

            Application.Run(new Form1());
        }
    }
}
