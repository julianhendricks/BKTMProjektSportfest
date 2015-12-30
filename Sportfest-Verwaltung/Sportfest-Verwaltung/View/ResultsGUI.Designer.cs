namespace SportsFestivalManagement.View
{
    partial class ResultsGUI
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
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lblPupil = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.cbStudent);
            this.pnlClient.Controls.Add(this.lblPupil);
            this.pnlClient.Controls.Add(this.cbClass);
            this.pnlClient.Controls.Add(this.lblClass);
            this.pnlClient.Controls.Add(this.dgvDisciplines);
            this.pnlClient.Controls.Add(this.pnlControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(760, 520);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(355, 8);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(191, 21);
            this.cbStudent.TabIndex = 9;
            this.cbStudent.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbStudent_Format);
            // 
            // lblPupil
            // 
            this.lblPupil.AutoSize = true;
            this.lblPupil.Location = new System.Drawing.Point(303, 11);
            this.lblPupil.Name = "lblPupil";
            this.lblPupil.Size = new System.Drawing.Size(46, 13);
            this.lblPupil.TabIndex = 8;
            this.lblPupil.Text = "Schüler:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(200, 8);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(85, 21);
            this.cbClass.TabIndex = 7;
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbClass_SelectionChangeCommitted);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(153, 11);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Klasse:";
            // 
            // dgvDisciplines
            // 
            this.dgvDisciplines.AllowUserToAddRows = false;
            this.dgvDisciplines.AllowUserToDeleteRows = false;
            this.dgvDisciplines.AllowUserToOrderColumns = true;
            this.dgvDisciplines.AllowUserToResizeColumns = false;
            this.dgvDisciplines.AllowUserToResizeRows = false;
            this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDisciplines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDisciplines.Location = new System.Drawing.Point(156, 38);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.RowHeadersVisible = false;
            this.dgvDisciplines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDisciplines.Size = new System.Drawing.Size(600, 482);
            this.dgvDisciplines.TabIndex = 5;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlControls.Controls.Add(this.btnClose);
            this.pnlControls.Controls.Add(this.btnPrint);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.ForeColor = System.Drawing.Color.White;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(150, 520);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.UseCustomBackColor = true;
            this.pnlControls.UseCustomForeColor = true;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Schließen";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Drucken";
            this.btnPrint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseCustomForeColor = true;
            this.btnPrint.UseSelectable = true;
            // 
            // ResultsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlClient);
            this.Name = "ResultsGUI";
            this.Text = "Ergebnisse";
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.Label lblPupil;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbStudent;
    }
}