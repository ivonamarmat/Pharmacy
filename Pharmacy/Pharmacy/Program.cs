using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public static class Program
    {
        public static int currentUserId = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new LogInForm();
            Application.Run(login);
            

            //Application.Run(new MainPharmacistForm());
            //Application.Run(new NewReceiptForm());
            //Application.Run(new Form1());
            //Application.Run(new NewUserForm());

            //Application.Run(new MainAdminForm());
        }
    }
}
