using HackatOrga.models;
using HackatOrga.Models;

namespace HackatOrga
{
    internal static class Program
    {
        public static MonDbContext cnx = new MonDbContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}