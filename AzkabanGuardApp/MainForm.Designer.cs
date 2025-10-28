namespace AzkabanGuardApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrisoner;
        private System.Windows.Forms.TabPage tabIncident;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPrisonerName;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnAddPrisoner;

        private System.Windows.Forms.TextBox txtIncidentPrisonerId;
        private System.Windows.Forms.TextBox txtIncidentDesc;
        private System.Windows.Forms.ComboBox cbIncidentStatus;
        private System.Windows.Forms.Button btnReportIncident;

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnTheme;
        

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrisoner = new System.Windows.Forms.TabPage();
            this.tabIncident = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPrisonerName = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddPrisoner = new System.Windows.Forms.Button();

            this.txtIncidentPrisonerId = new System.Windows.Forms.TextBox();
            this.txtIncidentDesc = new System.Windows.Forms.TextBox();
            this.cbIncidentStatus = new System.Windows.Forms.ComboBox();
            this.btnReportIncident = new System.Windows.Forms.Button();

            this.txtStatus = new System.Windows.Forms.TextBox();



            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "🛡️ GuardApp (Azkaban)";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Left = 20;
            this.lblTitle.Top = 12;
            this.lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(this.lblTitle);



            this.btnTheme = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabPrisoner.SuspendLayout();
            this.tabIncident.SuspendLayout();
            this.SuspendLayout();

            // TabControl
            this.tabControl1.Controls.Add(this.tabPrisoner);
            this.tabControl1.Controls.Add(this.tabIncident);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Size = new System.Drawing.Size(600, 350);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            // Zakładka "Dodaj więźnia"
            this.tabPrisoner.Text = "Dodaj więźnia";
            this.tabPrisoner.Controls.Add(new Label() { Text = "Imię i nazwisko:", Location = new System.Drawing.Point(20, 30), AutoSize = true });
            this.txtPrisonerName.Location = new System.Drawing.Point(150, 25);
            this.txtPrisonerName.Size = new System.Drawing.Size(200, 25);

            this.tabPrisoner.Controls.Add(new Label() { Text = "Cela:", Location = new System.Drawing.Point(20, 70), AutoSize = true });
            this.txtCell.Location = new System.Drawing.Point(150, 65);
            this.txtCell.Size = new System.Drawing.Size(200, 25);

            this.tabPrisoner.Controls.Add(new Label() { Text = "Status:", Location = new System.Drawing.Point(20, 110), AutoSize = true });
            this.cbStatus.Location = new System.Drawing.Point(150, 105);
            this.cbStatus.Size = new System.Drawing.Size(200, 25);
            this.cbStatus.Items.AddRange(new string[] { "żyje", "nie_żyje", "uciekł" });

            this.tabPrisoner.Controls.Add(new Label() { Text = "Uwagi:", Location = new System.Drawing.Point(20, 150), AutoSize = true });
            this.txtRemarks.Location = new System.Drawing.Point(150, 145);
            this.txtRemarks.Size = new System.Drawing.Size(300, 80);
            this.txtRemarks.Multiline = true;

            this.btnAddPrisoner.Text = "Dodaj więźnia";
            this.btnAddPrisoner.Location = new System.Drawing.Point(150, 250);
            this.btnAddPrisoner.Size = new System.Drawing.Size(150, 35);
            this.btnAddPrisoner.Click += new System.EventHandler(this.btnAddPrisoner_Click);

            this.tabPrisoner.Controls.Add(this.txtPrisonerName);
            this.tabPrisoner.Controls.Add(this.txtCell);
            this.tabPrisoner.Controls.Add(this.cbStatus);
            this.tabPrisoner.Controls.Add(this.txtRemarks);
            this.tabPrisoner.Controls.Add(this.btnAddPrisoner);

            // Zakładka "Zgłoś incydent"
            this.tabIncident.Text = "Zgłoś incydent";
            this.tabIncident.Controls.Add(new Label() { Text = "ID więźnia:", Location = new System.Drawing.Point(20, 30), AutoSize = true });
            this.txtIncidentPrisonerId.Location = new System.Drawing.Point(150, 25);
            this.txtIncidentPrisonerId.Size = new System.Drawing.Size(200, 25);

            this.tabIncident.Controls.Add(new Label() { Text = "Status:", Location = new System.Drawing.Point(20, 70), AutoSize = true });
            this.cbIncidentStatus.Location = new System.Drawing.Point(150, 65);
            this.cbIncidentStatus.Size = new System.Drawing.Size(200, 25);
            this.cbIncidentStatus.Items.AddRange(new string[] { "żyje", "nie_żyje", "uciekł" });

            this.tabIncident.Controls.Add(new Label() { Text = "Opis:", Location = new System.Drawing.Point(20, 110), AutoSize = true });
            this.txtIncidentDesc.Location = new System.Drawing.Point(150, 105);
            this.txtIncidentDesc.Size = new System.Drawing.Size(300, 120);
            this.txtIncidentDesc.Multiline = true;

            this.btnReportIncident.Text = "Zgłoś incydent";
            this.btnReportIncident.Location = new System.Drawing.Point(150, 250);
            this.btnReportIncident.Size = new System.Drawing.Size(150, 35);
            this.btnReportIncident.Click += new System.EventHandler(this.btnReportIncident_Click);

            this.tabIncident.Controls.Add(this.txtIncidentPrisonerId);
            this.tabIncident.Controls.Add(this.cbIncidentStatus);
            this.tabIncident.Controls.Add(this.txtIncidentDesc);
            this.tabIncident.Controls.Add(this.btnReportIncident);

            // Pole statusu
            this.txtStatus.Location = new System.Drawing.Point(12, 410);
            this.txtStatus.Multiline = true;
            this.txtStatus.Size = new System.Drawing.Size(600, 60);
            this.txtStatus.ScrollBars = ScrollBars.Vertical;
            this.txtStatus.ReadOnly = true;

            // Przycisk trybu
            this.btnTheme.Location = new System.Drawing.Point(560, 10);
            this.btnTheme.Size = new System.Drawing.Size(40, 30);
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);

            // Form główny
            this.ClientSize = new System.Drawing.Size(630, 490);
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
