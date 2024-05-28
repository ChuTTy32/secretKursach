using Libs;
using Microsoft.EntityFrameworkCore;

namespace View
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());

            ApplicationConfiguration.Initialize();
            Application.Run(new MainFrame(/*Dbcontext*/));
        }
    }
}