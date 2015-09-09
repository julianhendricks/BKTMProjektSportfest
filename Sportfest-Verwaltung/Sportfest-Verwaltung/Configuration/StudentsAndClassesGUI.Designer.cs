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
            this.lvClasses = new System.Windows.Forms.ListView();
            this.ClassId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classAbbreviation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlClassesControl = new MetroFramework.Controls.MetroPanel();
            this.edtShortcut = new MetroFramework.Controls.MetroTextBox();
            this.lblShortcut = new MetroFramework.Controls.MetroLabel();
            this.pnlClient.SuspendLayout();
            this.tcStudentsAndClasses.SuspendLayout();
            this.pagStudents.SuspendLayout();
            this.pagClasses.SuspendLayout();
            this.pnlClasses.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlClassesControl.SuspendLayout();
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
            this.pnlClasses.Controls.Add(this.pnlClassesControl);
            this.pnlClasses.Controls.Add(this.lvClasses);
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
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(0, 442);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // lvClasses
            // 
            this.lvClasses.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassId,
            this.classAbbreviation});
            this.lvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClasses.FullRowSelect = true;
            this.lvClasses.GridLines = true;
            this.lvClasses.HideSelection = false;
            this.lvClasses.Location = new System.Drawing.Point(0, 0);
            this.lvClasses.Name = "lvClasses";
            this.lvClasses.Size = new System.Drawing.Size(586, 440);
            this.lvClasses.TabIndex = 2;
            this.lvClasses.UseCompatibleStateImageBehavior = false;
            this.lvClasses.View = System.Windows.Forms.View.Details;
            this.lvClasses.Click += new System.EventHandler(this.lvClasses_Click);
            // 
            // ClassId
            // 
            this.ClassId.Text = "Id";
            this.ClassId.Width = 0;
            // 
            // classAbbreviation
            // 
            this.classAbbreviation.Text = "Kürzel";
            this.classAbbreviation.Width = 300;
            // 
            // pnlClassesControl
            // 
            this.pnlClassesControl.Controls.Add(this.lblShortcut);
            this.pnlClassesControl.Controls.Add(this.edtShortcut);
            this.pnlClassesControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlClassesControl.HorizontalScrollbarBarColor = true;
            this.pnlClassesControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClassesControl.HorizontalScrollbarSize = 10;
            this.pnlClassesControl.Location = new System.Drawing.Point(0, 340);
            this.pnlClassesControl.Name = "pnlClassesControl";
            this.pnlClassesControl.Size = new System.Drawing.Size(586, 100);
            this.pnlClassesControl.TabIndex = 3;
            this.pnlClassesControl.VerticalScrollbarBarColor = true;
            this.pnlClassesControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClassesControl.VerticalScrollbarSize = 10;
            // 
            // edtShortcut
            // 
            this.edtShortcut.Lines = new string[0];
            this.edtShortcut.Location = new System.Drawing.Point(58, 12);
            this.edtShortcut.MaxLength = 32767;
            this.edtShortcut.Name = "edtShortcut";
            this.edtShortcut.PasswordChar = '\0';
            this.edtShortcut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edtShortcut.SelectedText = "";
            this.edtShortcut.Size = new System.Drawing.Size(119, 23);
            this.edtShortcut.TabIndex = 3;
            this.edtShortcut.UseSelectable = true;
            this.edtShortcut.TextChanged += new System.EventHandler(this.edtShortcut_TextChanged);
            // 
            // lblShortcut
            // 
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(5, 12);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(47, 19);
            this.lblShortcut.TabIndex = 4;
            this.lblShortcut.Text = "Kürzel:";
            // 
            // StudentsAndClassesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlClient);
            this.Name = "StudentsAndClassesGUI";
            this.Text = "Schüler und Klassen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsAndClassesGUI_FormClosing);
            this.Load += new System.EventHandler(this.StudentsAndClassesGUI_Load);
            this.pnlClient.ResumeLayout(false);
            this.tcStudentsAndClasses.ResumeLayout(false);
            this.pagStudents.ResumeLayout(false);
            this.pagClasses.ResumeLayout(false);
            this.pnlClasses.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlClassesControl.ResumeLayout(false);
            this.pnlClassesControl.PerformLayout();
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
        private System.Windows.Forms.ListView lvClasses;
        private System.Windows.Forms.ColumnHeader ClassId;
        private System.Windows.Forms.ColumnHeader classAbbreviation;
        private MetroFramework.Controls.MetroPanel pnlClassesControl;
        private MetroFramework.Controls.MetroLabel lblShortcut;
        private MetroFramework.Controls.MetroTextBox edtShortcut;
    }
}