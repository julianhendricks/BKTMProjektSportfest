namespace SportsFestivalManagement.View
{
    partial class NewSportsFestivalGUI
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlClient = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerSportsFestival = new System.Windows.Forms.DateTimePicker();
            this.competitionGrid = new System.Windows.Forms.DataGridView();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionGrid)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.label2);
            this.pnlClient.Controls.Add(this.label1);
            this.pnlClient.Controls.Add(this.dateTimePickerSportsFestival);
            this.pnlClient.Controls.Add(this.competitionGrid);
            this.pnlClient.Controls.Add(this.pnlControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(873, 422);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wettkämpfe auswählen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datum:";
            // 
            // dateTimePickerSportsFestival
            // 
            this.dateTimePickerSportsFestival.Location = new System.Drawing.Point(47, 8);
            this.dateTimePickerSportsFestival.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerSportsFestival.Name = "dateTimePickerSportsFestival";
            this.dateTimePickerSportsFestival.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerSportsFestival.TabIndex = 4;
            // 
            // competitionGrid
            // 
            this.competitionGrid.AllowUserToAddRows = false;
            this.competitionGrid.AllowUserToDeleteRows = false;
            this.competitionGrid.AllowUserToResizeRows = false;
            this.competitionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitionGrid.Location = new System.Drawing.Point(0, 44);
            this.competitionGrid.Margin = new System.Windows.Forms.Padding(2);
            this.competitionGrid.MultiSelect = false;
            this.competitionGrid.Name = "competitionGrid";
            this.competitionGrid.RowHeadersVisible = false;
            this.competitionGrid.RowTemplate.Height = 28;
            this.competitionGrid.Size = new System.Drawing.Size(873, 323);
            this.competitionGrid.TabIndex = 3;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.btnOK);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 372);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(873, 50);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(673, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbruch";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(773, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NewSportsFestivalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 502);
            this.Controls.Add(this.pnlClient);
            this.Name = "NewSportsFestivalGUI";
            this.Text = "Neues Sportfest";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionGrid)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private System.Windows.Forms.DataGridView competitionGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSportsFestival;
        private System.Windows.Forms.Label label2;
    }
}