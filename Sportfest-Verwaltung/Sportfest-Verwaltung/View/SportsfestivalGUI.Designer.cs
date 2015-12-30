namespace SportsFestivalManagement.View
{
    partial class SportsFestivalGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsFestivalGUI));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlClient = new MetroFramework.Controls.MetroPanel();
            this.sportsFestivalGrid = new System.Windows.Forms.DataGridView();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnResults = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDisciplines = new MetroFramework.Controls.MetroButton();
            this.btnStudentsAndClasses = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportsFestivalGrid)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.sportsFestivalGrid);
            this.pnlClient.Controls.Add(this.pnlControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(744, 482);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // sportsFestivalGrid
            // 
            this.sportsFestivalGrid.AllowUserToAddRows = false;
            this.sportsFestivalGrid.AllowUserToDeleteRows = false;
            this.sportsFestivalGrid.AllowUserToResizeRows = false;
            this.sportsFestivalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sportsFestivalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sportsFestivalGrid.Location = new System.Drawing.Point(150, 0);
            this.sportsFestivalGrid.MultiSelect = false;
            this.sportsFestivalGrid.Name = "sportsFestivalGrid";
            this.sportsFestivalGrid.RowHeadersVisible = false;
            this.sportsFestivalGrid.Size = new System.Drawing.Size(594, 482);
            this.sportsFestivalGrid.TabIndex = 5;
            this.sportsFestivalGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sportsFestivalGrid_CellContentDoubleClick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlControls.Controls.Add(this.btnResults);
            this.pnlControls.Controls.Add(this.btnNew);
            this.pnlControls.Controls.Add(this.btnDisciplines);
            this.pnlControls.Controls.Add(this.btnStudentsAndClasses);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.ForeColor = System.Drawing.Color.White;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(150, 482);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.UseCustomBackColor = true;
            this.pnlControls.UseCustomForeColor = true;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnResults
            // 
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.Location = new System.Drawing.Point(0, 40);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(150, 40);
            this.btnResults.TabIndex = 8;
            this.btnResults.Text = "Ergebnisse";
            this.btnResults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnResults.UseCustomBackColor = true;
            this.btnResults.UseCustomForeColor = true;
            this.btnResults.UseSelectable = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 40);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Neu";
            this.btnNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseCustomForeColor = true;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDisciplines
            // 
            this.btnDisciplines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDisciplines.Location = new System.Drawing.Point(0, 402);
            this.btnDisciplines.Name = "btnDisciplines";
            this.btnDisciplines.Size = new System.Drawing.Size(150, 40);
            this.btnDisciplines.TabIndex = 3;
            this.btnDisciplines.Text = "Disziplinen";
            this.btnDisciplines.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDisciplines.UseCustomBackColor = true;
            this.btnDisciplines.UseCustomForeColor = true;
            this.btnDisciplines.UseSelectable = true;
            this.btnDisciplines.Click += new System.EventHandler(this.btnDisciplines_Click);
            // 
            // btnStudentsAndClasses
            // 
            this.btnStudentsAndClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStudentsAndClasses.Location = new System.Drawing.Point(0, 442);
            this.btnStudentsAndClasses.Name = "btnStudentsAndClasses";
            this.btnStudentsAndClasses.Size = new System.Drawing.Size(150, 40);
            this.btnStudentsAndClasses.TabIndex = 2;
            this.btnStudentsAndClasses.Text = "Schüler und Klassen";
            this.btnStudentsAndClasses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStudentsAndClasses.UseCustomBackColor = true;
            this.btnStudentsAndClasses.UseCustomForeColor = true;
            this.btnStudentsAndClasses.UseSelectable = true;
            this.btnStudentsAndClasses.Click += new System.EventHandler(this.btnStudentsAndClasses_Click_1);
            // 
            // SportsFestivalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SportsFestivalGUI";
            this.Text = "Sportfeste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sportsfestival_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sportsFestivalGrid)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroButton btnStudentsAndClasses;
        private MetroFramework.Controls.MetroButton btnDisciplines;
        private MetroFramework.Controls.MetroButton btnNew;
        private System.Windows.Forms.DataGridView sportsFestivalGrid;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnResults;
    }
}

