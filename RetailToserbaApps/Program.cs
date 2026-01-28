using System;
using System.Windows.Forms;
using RetailToserbaApps.Data;        
using RetailToserbaApps.Views.Auth;
using RetailToserbaApps.Views.Dashboard;
using RetailToserbaApps.Views.Pages;

namespace RetailToserbaApps
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DbInitializer.InitializeDatabase(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error DB: {ex.Message}");
            }

            Application.Run(new LoginForm());
        }
    }
}