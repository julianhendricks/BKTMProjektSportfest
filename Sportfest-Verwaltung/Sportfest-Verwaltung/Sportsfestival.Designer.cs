namespace Sportfest_Verwaltung
{
    partial class Sportsfestival
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sportsfestival));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlClient = new MetroFramework.Controls.MetroPanel();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDisciplines = new MetroFramework.Controls.MetroButton();
            this.btnStudentsAndClasses = new MetroFramework.Controls.MetroButton();
            this.btnResults = new MetroFramework.Controls.MetroButton();
            this.GridSportsFestival = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlClient.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSportsFestival)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.GridSportsFestival);
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
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlControls.Controls.Add(this.btnResults);
            this.pnlControls.Controls.Add(this.btnDelete);
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
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 5;
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
            // btnResults
            // 
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.Location = new System.Drawing.Point(0, 80);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(150, 40);
            this.btnResults.TabIndex = 6;
            this.btnResults.Text = "Ergebnisse";
            this.btnResults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnResults.UseCustomBackColor = true;
            this.btnResults.UseCustomForeColor = true;
            this.btnResults.UseSelectable = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // GridSportsFestival
            // 
            this.GridSportsFestival.AllowUserToAddRows = false;
            this.GridSportsFestival.AllowUserToResizeRows = false;
            this.GridSportsFestival.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSportsFestival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSportsFestival.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridSportsFestival.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSportsFestival.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridSportsFestival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSportsFestival.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridSportsFestival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSportsFestival.EnableHeadersVisualStyles = false;
            this.GridSportsFestival.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridSportsFestival.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSportsFestival.Location = new System.Drawing.Point(150, 0);
            this.GridSportsFestival.Name = "GridSportsFestival";
            this.GridSportsFestival.ReadOnly = true;
            this.GridSportsFestival.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSportsFestival.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridSportsFestival.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridSportsFestival.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSportsFestival.Size = new System.Drawing.Size(594, 482);
            this.GridSportsFestival.TabIndex = 3;
            // 
            // Sportsfestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sportsfestival";
            this.Text = "Sportfeste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSportsFestival)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnStudentsAndClasses;
        private MetroFramework.Controls.MetroButton btnDisciplines;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnResults;
        private MetroFramework.Controls.MetroGrid GridSportsFestival;
    }
}

