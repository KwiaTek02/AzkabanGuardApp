using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzkabanGuardApp
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient http = new HttpClient();
        private static readonly string integrationBase =
            Environment.GetEnvironmentVariable("INTEGRATION_URL") ?? "http://localhost:5000";

        private bool darkMode = true;
        private readonly int guardId;

        public MainForm(int guardId)
        {
            this.guardId = guardId;
            InitializeComponent();
            ApplyTheme();
        }

        // 🔄 Tryb ciemny / jasny
        private void btnTheme_Click(object sender, EventArgs e)
        {
            darkMode = !darkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            Color backColor = darkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
            Color foreColor = darkMode ? Color.WhiteSmoke : Color.Black;
            Color accentColor = darkMode ? Color.FromArgb(60, 120, 220) : Color.FromArgb(40, 90, 160);

            this.BackColor = backColor;
            tabControl1.BackColor = backColor;
            tabControl1.ForeColor = foreColor;

            foreach (TabPage page in tabControl1.TabPages)
            {
                page.BackColor = backColor;
                page.ForeColor = foreColor;

                foreach (Control ctrl in page.Controls)
                {
                    if (ctrl is Label lbl)
                        lbl.ForeColor = foreColor;

                    if (ctrl is TextBox txt)
                    {
                        txt.BackColor = darkMode ? Color.FromArgb(50, 50, 50) : Color.White;
                        txt.ForeColor = foreColor;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                    }

                    if (ctrl is ComboBox cb)
                    {
                        cb.BackColor = darkMode ? Color.FromArgb(50, 50, 50) : Color.White;
                        cb.ForeColor = foreColor;
                        cb.FlatStyle = FlatStyle.Flat;
                    }

                    if (ctrl is Button btn)
                    {
                        btn.BackColor = accentColor;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Cursor = Cursors.Hand;
                    }
                }
            }

            btnTheme.BackColor = Color.Transparent;
            btnTheme.ForeColor = foreColor;
            btnTheme.FlatStyle = FlatStyle.Flat;
            btnTheme.FlatAppearance.BorderSize = 0;
            btnTheme.Text = darkMode ? "☀️" : "🌙";
            btnTheme.Font = new Font("Segoe UI Emoji", 12);
            btnTheme.Image = null;
        }

        // 🧱 Logika: dodawanie więźnia
        private async void btnAddPrisoner_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrisonerName.Text) || string.IsNullOrWhiteSpace(txtCell.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prisoner = new PrisonerDto
            {
                prisoner_id = Guid.NewGuid().ToString(),
                name = txtPrisonerName.Text,
                cell = txtCell.Text,
                remarks = txtRemarks.Text
            };

            var json = JsonSerializer.Serialize(prisoner);
            var req = new HttpRequestMessage(HttpMethod.Post, integrationBase.TrimEnd('/') + "/api/prisoners");
            req.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // <-- dodajemy nagłówek z ID strażnika
            req.Headers.Add("X-Guard-Id", guardId.ToString());

            var response = await http.SendAsync(req);
            var respText = await response.Content.ReadAsStringAsync();
            txtStatus.Text = $"{(int)response.StatusCode} {response.ReasonPhrase}: {respText}";
        }

        // 🧱 Logika: zgłaszanie incydentu
        private async void btnReportIncident_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIncidentPrisonerId.Text))
            {
                MessageBox.Show("Podaj ID więźnia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var incident = new IncidentDto
            {
                incident_id = Guid.NewGuid().ToString(),  // ✅ wymagane przez API
                prisoner_id = txtIncidentPrisonerId.Text,
                incident_type = cbIncidentStatus.SelectedItem?.ToString() ?? "żyje",
                description = txtIncidentDesc.Text,
                reported_by = guardId.ToString(),
                timestamp = DateTime.UtcNow.ToString("o")
            };

            var json = JsonSerializer.Serialize(incident);
            var resp = await PostJson("/api/incidents", json);
            txtStatus.Text = resp;
        }

        // 🌐 Wysyłanie JSON do API
        private async Task<string> PostJson(string path, string json)
        {
            try
            {
                var url = integrationBase.TrimEnd('/') + path;
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await http.PostAsync(url, content);
                var respText = await response.Content.ReadAsStringAsync();
                return $"{(int)response.StatusCode} {response.ReasonPhrase}: {respText}";
            }
            catch (Exception ex)
            {
                return $"ERROR: {ex.Message}";
            }
        }
    }

    // ✅ Używamy tych samych DTO co w backendzie
    public sealed class PrisonerDto
    {
        public string prisoner_id { get; set; } = default!;
        public string name { get; set; } = default!;
        public string? birth_date { get; set; }
        public string? intake_date { get; set; }
        public string cell { get; set; } = default!;
        public string? remarks { get; set; }
    }

    public sealed class IncidentDto
    {
        public string incident_id { get; set; } = default!;
        public string prisoner_id { get; set; } = default!;
        public string incident_type { get; set; } = default!;
        public string? timestamp { get; set; }
        public string? description { get; set; }
        public string? reported_by { get; set; }
    }
}
