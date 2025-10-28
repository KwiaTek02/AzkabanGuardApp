using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace AzkabanGuardApp
{
    public partial class LoginForm : Form
    {
        public int LoggedGuardId { get; private set; } = -1;

        private bool darkMode = true;
        private List<LoginUser> users;

        public LoginForm()
        {
            InitializeComponent();
            LoadUsers();
            ApplyTheme();
        }

        private void LoadUsers()
        {
            try
            {
                string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "loginy.json");
                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    users = JsonSerializer.Deserialize<List<LoginUser>>(json);
                }
                else
                {
                    MessageBox.Show("Brak pliku loginy.json!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    users = new List<LoginUser>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wczytywania użytkowników: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                users = new List<LoginUser>();
            }
        }

        private void ApplyTheme()
        {
            Color back = darkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
            Color fore = darkMode ? Color.White : Color.Black;
            Color accent = darkMode ? Color.FromArgb(60, 120, 220) : Color.FromArgb(40, 90, 160);

            this.BackColor = back;
            lblTitle.ForeColor = fore;
            lblLogin.ForeColor = fore;
            lblPassword.ForeColor = fore;

            txtLogin.BackColor = darkMode ? Color.FromArgb(50, 50, 50) : Color.White;
            txtLogin.ForeColor = fore;
            txtPassword.BackColor = darkMode ? Color.FromArgb(50, 50, 50) : Color.White;
            txtPassword.ForeColor = fore;

            btnLogin.BackColor = accent;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnTheme.Text = darkMode ? "☀️" : "🌙";
            btnTheme.Font = new Font("Segoe UI Emoji", 12);
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            darkMode = !darkMode;
            ApplyTheme();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {
                LoggedGuardId = user.Id;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private class LoginUser
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("login")]
            public string Login { get; set; }
            [JsonPropertyName("password")]
            public string Password { get; set; }
        }
    }
}
