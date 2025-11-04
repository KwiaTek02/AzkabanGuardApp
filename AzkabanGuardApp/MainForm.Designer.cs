using System;
using System.Drawing;
using System.Windows.Forms;

namespace AzkabanGuardApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabPrisoner;
        private TabPage tabIncident;

        private Label lblTitle;
        private TextBox txtPrisonerName;
        private TextBox txtCell;
        private TextBox txtRemarks;
        private ComboBox cbStatus;
        private Button btnAddPrisoner;

        private TextBox txtIncidentPrisonerId;
        private TextBox txtIncidentDesc;
        private ComboBox cbIncidentStatus;
        private Button btnReportIncident;

        private TextBox txtStatus;
        private Button btnTheme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabPrisoner = new TabPage();
            this.tabIncident = new TabPage();

            this.lblTitle = new Label();
            this.txtPrisonerName = new TextBox();
            this.txtCell = new TextBox();
            this.txtRemarks = new TextBox();
            this.cbStatus = new ComboBox();
            this.btnAddPrisoner = new Button();

            this.txtIncidentPrisonerId = new TextBox();
            this.txtIncidentDesc = new TextBox();
            this.cbIncidentStatus = new ComboBox();
            this.btnReportIncident = new Button();

            this.txtStatus = new TextBox();
            this.btnTheme = new Button();

            this.tabControl1.SuspendLayout();
            this.tabPrisoner.SuspendLayout();
            this.tabIncident.SuspendLayout();
            this.SuspendLayout();

            // ======== 🧩 Tytuł ========
            this.lblTitle.Text = "🛡️ GuardApp (Azkaban)";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Left = 20;
            this.lblTitle.Top = 12;
            this.lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(this.lblTitle);

            // ======== 🧩 TabControl ========
            this.tabControl1.Controls.Add(this.tabPrisoner);
            this.tabControl1.Controls.Add(this.tabIncident);
            this.tabControl1.Location = new Point(12, 50);
            this.tabControl1.Size = new Size(600, 350);
            this.tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // ======== 🧱 Zakładka: Dodaj więźnia ========
            this.tabPrisoner.Text = "Dodaj więźnia";
            this.tabPrisoner.Controls.Add(new Label()
            {
                Text = "Imię i nazwisko:",
                Location = new Point(20, 30),
                AutoSize = true
            });
            this.txtPrisonerName.Location = new Point(150, 25);
            this.txtPrisonerName.Size = new Size(200, 25);

            this.tabPrisoner.Controls.Add(new Label()
            {
                Text = "Cela:",
                Location = new Point(20, 70),
                AutoSize = true
            });
            this.txtCell.Location = new Point(150, 65);
            this.txtCell.Size = new Size(200, 25);

            this.tabPrisoner.Controls.Add(new Label()
            {
                Text = "Status:",
                Location = new Point(20, 110),
                AutoSize = true
            });
            this.cbStatus.Location = new Point(150, 105);
            this.cbStatus.Size = new Size(200, 25);
            this.cbStatus.Items.AddRange(new string[] { "żyje", "nie_żyje", "uciekł" });

            this.tabPrisoner.Controls.Add(new Label()
            {
                Text = "Uwagi:",
                Location = new Point(20, 150),
                AutoSize = true
            });
            this.txtRemarks.Location = new Point(150, 145);
            this.txtRemarks.Size = new Size(300, 80);
            this.txtRemarks.Multiline = true;

            this.btnAddPrisoner.Text = "Dodaj więźnia";
            this.btnAddPrisoner.Location = new Point(150, 250);
            this.btnAddPrisoner.Size = new Size(150, 35);
            this.btnAddPrisoner.Click += new EventHandler(this.btnAddPrisoner_Click);

            this.tabPrisoner.Controls.Add(this.txtPrisonerName);
            this.tabPrisoner.Controls.Add(this.txtCell);
            this.tabPrisoner.Controls.Add(this.cbStatus);
            this.tabPrisoner.Controls.Add(this.txtRemarks);
            this.tabPrisoner.Controls.Add(this.btnAddPrisoner);

            // ======== ⚠️ Zakładka: Zgłoś incydent ========
            this.tabIncident.Text = "Zgłoś incydent";
            this.tabIncident.Controls.Add(new Label()
            {
                Text = "ID więźnia:",
                Location = new Point(20, 30),
                AutoSize = true
            });
            this.txtIncidentPrisonerId.Location = new Point(150, 25);
            this.txtIncidentPrisonerId.Size = new Size(200, 25);

            this.tabIncident.Controls.Add(new Label()
            {
                Text = "Typ incydentu:",
                Location = new Point(20, 70),
                AutoSize = true
            });
            this.cbIncidentStatus.Location = new Point(150, 65);
            this.cbIncidentStatus.Size = new Size(200, 25);
            this.cbIncidentStatus.Items.AddRange(new string[] { "death", "escape", "other" });

            this.tabIncident.Controls.Add(new Label()
            {
                Text = "Opis:",
                Location = new Point(20, 110),
                AutoSize = true
            });
            this.txtIncidentDesc.Location = new Point(150, 105);
            this.txtIncidentDesc.Size = new Size(300, 120);
            this.txtIncidentDesc.Multiline = true;

            this.btnReportIncident.Text = "Zgłoś incydent";
            this.btnReportIncident.Location = new Point(150, 250);
            this.btnReportIncident.Size = new Size(150, 35);
            this.btnReportIncident.Click += new EventHandler(this.btnReportIncident_Click);

            this.tabIncident.Controls.Add(this.txtIncidentPrisonerId);
            this.tabIncident.Controls.Add(this.cbIncidentStatus);
            this.tabIncident.Controls.Add(this.txtIncidentDesc);
            this.tabIncident.Controls.Add(this.btnReportIncident);

            // ======== 📜 Pole statusu ========
            this.txtStatus.Location = new Point(12, 410);
            this.txtStatus.Multiline = true;
            this.txtStatus.Size = new Size(600, 60);
            this.txtStatus.ScrollBars = ScrollBars.Vertical;
            this.txtStatus.ReadOnly = true;

            // ======== 🌙 Przycisk trybu ========
            this.btnTheme.Location = new Point(560, 10);
            this.btnTheme.Size = new Size(40, 30);
            this.btnTheme.Click += new EventHandler(this.btnTheme_Click);

            // ======== 🪟 Form główny ========
            this.ClientSize = new Size(630, 490);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtStatus);
            this.Text = "GuardApp (Azkaban)";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.tabControl1.ResumeLayout(false);
            this.tabPrisoner.ResumeLayout(false);
            this.tabIncident.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
