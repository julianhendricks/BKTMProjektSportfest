namespace SportsFestivalManagement.View
{
    partial class SportsFestivalManagementGUI
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabBenchmarks = new System.Windows.Forms.TabPage();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.tabCompetitions = new System.Windows.Forms.TabPage();
            this.tabDisciplines = new System.Windows.Forms.TabPage();
            this.tabDisciplineSets = new System.Windows.Forms.TabPage();
            this.tabMeasures = new System.Windows.Forms.TabPage();
            this.tabVariants = new System.Windows.Forms.TabPage();
            this.tabRelations = new System.Windows.Forms.TabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabCompetitionDisciplineSet = new System.Windows.Forms.TabPage();
            this.tabDisciplineSetDisciplines = new System.Windows.Forms.TabPage();
            this.benchmarksGrid = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabBenchmarks.SuspendLayout();
            this.tabRelations.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benchmarksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnReset);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 471);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(770, 43);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Location = new System.Drawing.Point(538, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseCustomForeColor = true;
            this.btnReset.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(654, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Speichern";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.mainTabControl);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(770, 411);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabBenchmarks);
            this.mainTabControl.Controls.Add(this.tabCompetitions);
            this.mainTabControl.Controls.Add(this.tabCategories);
            this.mainTabControl.Controls.Add(this.tabDisciplines);
            this.mainTabControl.Controls.Add(this.tabDisciplineSets);
            this.mainTabControl.Controls.Add(this.tabMeasures);
            this.mainTabControl.Controls.Add(this.tabVariants);
            this.mainTabControl.Controls.Add(this.tabRelations);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(770, 411);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.UseSelectable = true;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            this.mainTabControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.metroTabControl1_Deselecting);
            // 
            // tabBenchmarks
            // 
            this.tabBenchmarks.Controls.Add(this.benchmarksGrid);
            this.tabBenchmarks.Location = new System.Drawing.Point(4, 38);
            this.tabBenchmarks.Name = "tabBenchmarks";
            this.tabBenchmarks.Size = new System.Drawing.Size(762, 369);
            this.tabBenchmarks.TabIndex = 0;
            this.tabBenchmarks.Text = "Richtwerte";
            // 
            // tabCategories
            // 
            this.tabCategories.Location = new System.Drawing.Point(4, 38);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Size = new System.Drawing.Size(762, 369);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "Kategorien";
            // 
            // tabCompetitions
            // 
            this.tabCompetitions.Location = new System.Drawing.Point(4, 38);
            this.tabCompetitions.Name = "tabCompetitions";
            this.tabCompetitions.Size = new System.Drawing.Size(762, 369);
            this.tabCompetitions.TabIndex = 2;
            this.tabCompetitions.Text = "Wettkämpfe";
            // 
            // tabDisciplines
            // 
            this.tabDisciplines.Location = new System.Drawing.Point(4, 38);
            this.tabDisciplines.Name = "tabDisciplines";
            this.tabDisciplines.Size = new System.Drawing.Size(762, 369);
            this.tabDisciplines.TabIndex = 3;
            this.tabDisciplines.Text = "Disziplinen";
            // 
            // tabDisciplineSets
            // 
            this.tabDisciplineSets.Location = new System.Drawing.Point(4, 38);
            this.tabDisciplineSets.Name = "tabDisciplineSets";
            this.tabDisciplineSets.Size = new System.Drawing.Size(762, 369);
            this.tabDisciplineSets.TabIndex = 4;
            this.tabDisciplineSets.Text = "Disziplin-Sets";
            // 
            // tabMeasures
            // 
            this.tabMeasures.Location = new System.Drawing.Point(4, 38);
            this.tabMeasures.Name = "tabMeasures";
            this.tabMeasures.Size = new System.Drawing.Size(762, 369);
            this.tabMeasures.TabIndex = 5;
            this.tabMeasures.Text = "Einheiten";
            // 
            // tabVariants
            // 
            this.tabVariants.Location = new System.Drawing.Point(4, 38);
            this.tabVariants.Name = "tabVariants";
            this.tabVariants.Size = new System.Drawing.Size(762, 369);
            this.tabVariants.TabIndex = 6;
            this.tabVariants.Text = "Varianten";
            // 
            // tabRelations
            // 
            this.tabRelations.Controls.Add(this.metroTabControl2);
            this.tabRelations.Location = new System.Drawing.Point(4, 38);
            this.tabRelations.Name = "tabRelations";
            this.tabRelations.Size = new System.Drawing.Size(762, 369);
            this.tabRelations.TabIndex = 7;
            this.tabRelations.Text = "Relationen";
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabCompetitionDisciplineSet);
            this.metroTabControl2.Controls.Add(this.tabDisciplineSetDisciplines);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(762, 369);
            this.metroTabControl2.TabIndex = 0;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabCompetitionDisciplineSet
            // 
            this.tabCompetitionDisciplineSet.Location = new System.Drawing.Point(4, 38);
            this.tabCompetitionDisciplineSet.Name = "tabCompetitionDisciplineSet";
            this.tabCompetitionDisciplineSet.Size = new System.Drawing.Size(754, 327);
            this.tabCompetitionDisciplineSet.TabIndex = 0;
            this.tabCompetitionDisciplineSet.Text = "Wettkampf - Disciplin-Set";
            // 
            // tabDisciplineSetDisciplines
            // 
            this.tabDisciplineSetDisciplines.Location = new System.Drawing.Point(4, 38);
            this.tabDisciplineSetDisciplines.Name = "tabDisciplineSetDisciplines";
            this.tabDisciplineSetDisciplines.Size = new System.Drawing.Size(754, 327);
            this.tabDisciplineSetDisciplines.TabIndex = 1;
            this.tabDisciplineSetDisciplines.Text = "Disziplin-Sets - Disziplinen";
            // 
            // benchmarksGrid
            // 
            this.benchmarksGrid.AllowUserToAddRows = false;
            this.benchmarksGrid.AllowUserToDeleteRows = false;
            this.benchmarksGrid.AllowUserToResizeRows = false;
            this.benchmarksGrid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.benchmarksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benchmarksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benchmarksGrid.Location = new System.Drawing.Point(0, 0);
            this.benchmarksGrid.MultiSelect = false;
            this.benchmarksGrid.Name = "benchmarksGrid";
            this.benchmarksGrid.RowHeadersVisible = false;
            this.benchmarksGrid.Size = new System.Drawing.Size(762, 369);
            this.benchmarksGrid.TabIndex = 0;
            // 
            // SportsFestivalManagementGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 534);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SportsFestivalManagementGUI";
            this.Text = "Grunddaten";
            this.Shown += new System.EventHandler(this.SportsFestivalManagementGUI_Shown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabBenchmarks.ResumeLayout(false);
            this.tabRelations.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.benchmarksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabBenchmarks;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabCompetitions;
        private System.Windows.Forms.TabPage tabDisciplines;
        private System.Windows.Forms.TabPage tabDisciplineSets;
        private System.Windows.Forms.TabPage tabMeasures;
        private System.Windows.Forms.TabPage tabVariants;
        private System.Windows.Forms.TabPage tabRelations;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private System.Windows.Forms.TabPage tabCompetitionDisciplineSet;
        private System.Windows.Forms.TabPage tabDisciplineSetDisciplines;
        private MetroFramework.Controls.MetroButton btnReset;
        private System.Windows.Forms.DataGridView benchmarksGrid;
    }
}