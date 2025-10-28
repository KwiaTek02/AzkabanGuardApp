using System.Drawing;
using System.Windows.Forms;

namespace AzkabanGuardApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnTheme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblLogin = new Label();
            this.lblPassword = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnTheme = new Button();
            this.SuspendLayout();

            // Tytuł
            this.lblTitle.Text = "🛡️ GuardApp (Azkaban)";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Left = 60;
            this.lblTitle.Top = 30;

            // Login
            this.lblLogin.Text = "Login:";
            this.lblLogin.Left = 40;
            this.lblLogin.Top = 100;
            this.lblLogin.AutoSize = true;

            this.txtLogin.Left = 120;
            this.txtLogin.Top = 95;
            this.txtLogin.Width = 200;

            // Hasło
            this.lblPassword.Text = "Hasło:";
            this.lblPassword.Left = 40;
            this.lblPassword.Top = 140;
            this.lblPassword.AutoSize = true;

            this.txtPassword.Left = 120;
            this.txtPassword.Top = 135;
            this.txtPassword.Width = 200;
            this.txtPassword.PasswordChar = '●';

            // Przycisk logowania
            this.btnLogin.Text = "Zaloguj się";
            this.btnLogin.Left = 120;
            this.btnLogin.Top = 190;
            this.btnLogin.Width = 200;
            this.btnLogin.Height = 35;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Przycisk trybu
            this.btnTheme.Left = 300;
            this.btnTheme.Top = 10;
            this.btnTheme.Width = 40;
            this.btnTheme.Height = 30;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);

            // Okno logowania
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnTheme);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Logowanie - GuardApp";
            this.ResumeLayout(false);
        }
    }
}
