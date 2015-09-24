namespace SportsfestivalManagement.View
{
    partial class ConnectionSetupGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlClient = new MetroFramework.Controls.MetroPanel();
            this.edtPort = new System.Windows.Forms.NumericUpDown();
            this.edtHost = new MetroFramework.Controls.MetroTextBox();
            this.edtPassword = new MetroFramework.Controls.MetroTextBox();
            this.edtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.edtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblDatabase = new MetroFramework.Controls.MetroLabel();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.lblHost = new MetroFramework.Controls.MetroLabel();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnTerminate = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnTestConnection = new MetroFramework.Controls.MetroButton();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtPort)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.edtHost);
            this.pnlClient.Controls.Add(this.edtPort);
            this.pnlClient.Controls.Add(this.lblPort);
            this.pnlClient.Controls.Add(this.edtDatabase);
            this.pnlClient.Controls.Add(this.lblDatabase);
            this.pnlClient.Controls.Add(this.edtUsername);
            this.pnlClient.Controls.Add(this.lblUsername);
            this.pnlClient.Controls.Add(this.edtPassword);
            this.pnlClient.Controls.Add(this.lblPassword);
            this.pnlClient.Controls.Add(this.lblHost);
            this.pnlClient.Controls.Add(this.lblDescription);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Margin = new System.Windows.Forms.Padding(0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(760, 420);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // edtPort
            // 
            this.edtPort.Location = new System.Drawing.Point(260, 87);
            this.edtPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.edtPort.Name = "edtPort";
            this.edtPort.Size = new System.Drawing.Size(150, 20);
            this.edtPort.TabIndex = 1;
            this.edtPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // edtHost
            // 
            this.edtHost.Lines = new string[0];
            this.edtHost.Location = new System.Drawing.Point(260, 47);
            this.edtHost.MaxLength = 32767;
            this.edtHost.Name = "edtHost";
            this.edtHost.PasswordChar = '\0';
            this.edtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edtHost.SelectedText = "";
            this.edtHost.Size = new System.Drawing.Size(150, 23);
            this.edtHost.TabIndex = 0;
            this.edtHost.UseSelectable = true;
            // 
            // edtPassword
            // 
            this.edtPassword.Lines = new string[0];
            this.edtPassword.Location = new System.Drawing.Point(260, 204);
            this.edtPassword.MaxLength = 32767;
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edtPassword.SelectedText = "";
            this.edtPassword.Size = new System.Drawing.Size(150, 23);
            this.edtPassword.TabIndex = 4;
            this.edtPassword.UseSelectable = true;
            // 
            // edtDatabase
            // 
            this.edtDatabase.Lines = new string[0];
            this.edtDatabase.Location = new System.Drawing.Point(260, 124);
            this.edtDatabase.MaxLength = 32767;
            this.edtDatabase.Name = "edtDatabase";
            this.edtDatabase.PasswordChar = '\0';
            this.edtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edtDatabase.SelectedText = "";
            this.edtDatabase.Size = new System.Drawing.Size(150, 23);
            this.edtDatabase.TabIndex = 2;
            this.edtDatabase.UseSelectable = true;
            // 
            // edtUsername
            // 
            this.edtUsername.Lines = new string[0];
            this.edtUsername.Location = new System.Drawing.Point(260, 164);
            this.edtUsername.MaxLength = 32767;
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.PasswordChar = '\0';
            this.edtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edtUsername.SelectedText = "";
            this.edtUsername.Size = new System.Drawing.Size(150, 23);
            this.edtUsername.TabIndex = 3;
            this.edtUsername.UseSelectable = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(157, 206);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Passwort:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(157, 166);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 19);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Benutzername:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(157, 126);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(74, 19);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Datenbank:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(157, 88);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 19);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(156, 49);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(38, 19);
            this.lblHost.TabIndex = 6;
            this.lblHost.Text = "Host:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(156, 11);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(530, 19);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Die Verbindung zur Datenbank ist gescheitert. Bitte geben Sie eine gültige Verbin" +
    "dung an.";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlControls.Controls.Add(this.btnTerminate);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.btnTestConnection);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.ForeColor = System.Drawing.Color.White;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(20, 60);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(150, 420);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlControls.UseCustomBackColor = true;
            this.pnlControls.UseCustomForeColor = true;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTerminate.Location = new System.Drawing.Point(0, 380);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(150, 40);
            this.btnTerminate.TabIndex = 2;
            this.btnTerminate.Text = "Programm beenden";
            this.btnTerminate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTerminate.UseCustomBackColor = true;
            this.btnTerminate.UseCustomForeColor = true;
            this.btnTerminate.UseSelectable = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(0, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Speichern";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestConnection.Location = new System.Drawing.Point(0, 0);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(150, 40);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Verbindung testen";
            this.btnTestConnection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTestConnection.UseCustomBackColor = true;
            this.btnTestConnection.UseCustomForeColor = true;
            this.btnTestConnection.UseSelectable = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // ConnectionSetupGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionSetupGUI";
            this.Resizable = false;
            this.Text = "Datenbankverbindung bearbeiten";
            this.Load += new System.EventHandler(this.SetupConnectionGUI_Load);
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtPort)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnTerminate;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnTestConnection;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblDatabase;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroLabel lblHost;
        private MetroFramework.Controls.MetroTextBox edtUsername;
        private System.Windows.Forms.NumericUpDown edtPort;
        private MetroFramework.Controls.MetroTextBox edtHost;
        private MetroFramework.Controls.MetroTextBox edtPassword;
        private MetroFramework.Controls.MetroTextBox edtDatabase;
    }
}