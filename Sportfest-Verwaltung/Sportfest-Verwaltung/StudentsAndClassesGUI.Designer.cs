namespace Sportfest_Verwaltung
{
    partial class StudentsAndClassesGUI
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
            this.components = new System.ComponentModel.Container();
            this.pnlClient = new MetroFramework.Controls.MetroPanel();
            this.tcStudentsAndClasses = new MetroFramework.Controls.MetroTabControl();
            this.pagStudents = new System.Windows.Forms.TabPage();
            this.pnlStudents = new MetroFramework.Controls.MetroPanel();
            this.pagClasses = new System.Windows.Forms.TabPage();
            this.pnlClasses = new MetroFramework.Controls.MetroPanel();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnImport = new MetroFramework.Controls.MetroButton();
            this.btnUpgrade = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlClient.SuspendLayout();
            this.tcStudentsAndClasses.SuspendLayout();
            this.pagStudents.SuspendLayout();
            this.pagClasses.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.tcStudentsAndClasses);
            this.pnlClient.Controls.Add(this.pnlControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(744, 482);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // tcStudentsAndClasses
            // 
            this.tcStudentsAndClasses.Controls.Add(this.pagStudents);
            this.tcStudentsAndClasses.Controls.Add(this.pagClasses);
            this.tcStudentsAndClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStudentsAndClasses.Location = new System.Drawing.Point(150, 0);
            this.tcStudentsAndClasses.Name = "tcStudentsAndClasses";
            this.tcStudentsAndClasses.SelectedIndex = 1;
            this.tcStudentsAndClasses.Size = new System.Drawing.Size(594, 482);
            this.tcStudentsAndClasses.TabIndex = 3;
            this.tcStudentsAndClasses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tcStudentsAndClasses.UseSelectable = true;
            // 
            // pagStudents
            // 
            this.pagStudents.Controls.Add(this.pnlStudents);
            this.pagStudents.Location = new System.Drawing.Point(4, 38);
            this.pagStudents.Name = "pagStudents";
            this.pagStudents.Size = new System.Drawing.Size(586, 440);
            this.pagStudents.TabIndex = 0;
            this.pagStudents.Text = "Schüler";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudents.HorizontalScrollbarBarColor = true;
            this.pnlStudents.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStudents.HorizontalScrollbarSize = 10;
            this.pnlStudents.Location = new System.Drawing.Point(0, 0);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(586, 440);
            this.pnlStudents.TabIndex = 0;
            this.pnlStudents.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnlStudents.VerticalScrollbarBarColor = true;
            this.pnlStudents.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStudents.VerticalScrollbarSize = 10;
            // 
            // pagClasses
            // 
            this.pagClasses.Controls.Add(this.pnlClasses);
            this.pagClasses.Location = new System.Drawing.Point(4, 38);
            this.pagClasses.Name = "pagClasses";
            this.pagClasses.Size = new System.Drawing.Size(586, 440);
            this.pagClasses.TabIndex = 1;
            this.pagClasses.Text = "Klassen";
            // 
            // pnlClasses
            // 
            this.pnlClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClasses.HorizontalScrollbarBarColor = true;
            this.pnlClasses.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClasses.HorizontalScrollbarSize = 10;
            this.pnlClasses.Location = new System.Drawing.Point(0, 0);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(586, 440);
            this.pnlClasses.TabIndex = 0;
            this.pnlClasses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnlClasses.VerticalScrollbarBarColor = true;
            this.pnlClasses.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClasses.VerticalScrollbarSize = 10;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlControls.Controls.Add(this.btnClose);
            this.pnlControls.Controls.Add(this.btnImport);
            this.pnlControls.Controls.Add(this.btnUpgrade);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnNew);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.ForeColor = System.Drawing.Color.White;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(150, 482);
            this.pnlControls.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnlControls.TabIndex = 2;
            this.pnlControls.UseCustomBackColor = true;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(0, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schließen";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnImport.Location = new System.Drawing.Point(0, 120);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 40);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Importieren";
            this.btnImport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImport.UseCustomBackColor = true;
            this.btnImport.UseCustomForeColor = true;
            this.btnImport.UseSelectable = true;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpgrade.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpgrade.Location = new System.Drawing.Point(0, 80);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(150, 40);
            this.btnUpgrade.TabIndex = 4;
            this.btnUpgrade.Text = "Hochstufen";
            this.btnUpgrade.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpgrade.UseCustomBackColor = true;
            this.btnUpgrade.UseCustomForeColor = true;
            this.btnUpgrade.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(0, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 40);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Neu";
            this.btnNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseCustomForeColor = true;
            this.btnNew.UseSelectable = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // StudentsAndClassesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlClient);
            this.Name = "StudentsAndClassesGUI";
            this.Text = "Schüler und Klassen";
            this.pnlClient.ResumeLayout(false);
            this.tcStudentsAndClasses.ResumeLayout(false);
            this.pagStudents.ResumeLayout(false);
            this.pagClasses.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroTabControl tcStudentsAndClasses;
        private System.Windows.Forms.TabPage pagStudents;
        private MetroFramework.Controls.MetroPanel pnlStudents;
        private System.Windows.Forms.TabPage pagClasses;
        private MetroFramework.Controls.MetroPanel pnlClasses;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnImport;
        private MetroFramework.Controls.MetroButton btnUpgrade;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}