using EntityFrameworkWinFormApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkWinFormApp
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
            Application.Run(new Form1());

            using (NorthwindContext context = new NorthwindContext())
            {
                var results = context.Customers;
                foreach (var customer in results)
                {
                    Console.WriteLine(customer.ToString());
                }
            }
        }
    }
}
