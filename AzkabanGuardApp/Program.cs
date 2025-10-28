using System;
using System.Windows.Forms;
using AzkabanGuardApp;

namespace GuardApp.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                int guardId = loginForm.LoggedGuardId;
                Application.Run(new MainForm(guardId));
            }
        }
    }
}