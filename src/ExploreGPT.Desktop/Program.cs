using ExploreGPT.Desktop.Data;
using System.Configuration;

namespace ExploreGPT.Desktop {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppConstants.OpenAIKey = ConfigurationManager.AppSettings["OpenAIKey"];
            AppConstants.OrgID = ConfigurationManager.AppSettings["OrgID"];
            Application.Run(new Form1());

           
        }
    }
}