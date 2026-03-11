using People_Management__full_pro__1set.applictions;
using People_Management__full_pro__1set.mange_user;
using People_Management__full_pro__1set.mangePepole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //using (LoginForm login = new LoginForm())
            //{
            //    if (login.ShowDialog() == DialogResult.OK) 
            //    {

            //        Application.Run(new Form1 ());
            //    }
            //    else
            //    {

            //        Application.Exit();
            //    }
            //}
        }
    }
    }

