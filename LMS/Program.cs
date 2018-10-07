using LMSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
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

            // Initialiaze the database connection
            GlobalConfig.InitialiazeConnections(DatabaseType.SqlServer);
            //Application.Run(new Registration());
            //Application.Run(new Login());
            Application.Run(new Dashboard());
            //Application.Run(new IssueItem());
            //Application.Run(new ViewItems());
        }
    }
}
