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
            this.lbActiveDisciplines = new System.Windows.Forms.ListBox();
            this.pnlShiftControls = new MetroFramework.Controls.MetroPanel();
            this.btnRight = new MetroFramework.Controls.MetroTile();
            this.btnLeft = new MetroFramework.Controls.MetroTile();
            this.lbAvailableDisciplines = new System.Windows.Forms.ListBox();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.chbUpgrade = new MetroFramework.Controls.MetroCheckBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlClient.SuspendLayout();
            this.pnlShiftControls.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.lbActiveDisciplines);
            this.pnlClient.Controls.Add(this.pnlShiftControls);
            this.pnlClient.Controls.Add(this.lbAvailableDisciplines);
            this.pnlClient.Controls.Add(this.pnlControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.HorizontalScrollbarBarColor = true;
            this.pnlClient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlClient.HorizontalScrollbarSize = 10;
            this.pnlClient.Location = new System.Drawing.Point(20, 60);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(984, 470);
            this.pnlClient.TabIndex = 0;
            this.pnlClient.VerticalScrollbarBarColor = true;
            this.pnlClient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlClient.VerticalScrollbarSize = 10;
            // 
            // lbActiveDisciplines
            // 
            this.lbActiveDisciplines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbActiveDisciplines.FormattingEnabled = true;
            this.lbActiveDisciplines.Items.AddRange(new object[] {
            " "});
            this.lbActiveDisciplines.Location = new System.Drawing.Point(574, 0);
            this.lbActiveDisciplines.Name = "lbActiveDisciplines";
            this.lbActiveDisciplines.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbActiveDisciplines.Size = new System.Drawing.Size(410, 420);
            this.lbActiveDisciplines.TabIndex = 7;
            // 
            // pnlShiftControls
            // 
            this.pnlShiftControls.Controls.Add(this.btnRight);
            this.pnlShiftControls.Controls.Add(this.btnLeft);
            this.pnlShiftControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShiftControls.HorizontalScrollbarBarColor = true;
            this.pnlShiftControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlShiftControls.HorizontalScrollbarSize = 10;
            this.pnlShiftControls.Location = new System.Drawing.Point(400, 0);
            this.pnlShiftControls.Name = "pnlShiftControls";
            this.pnlShiftControls.Size = new System.Drawing.Size(174, 420);
            this.pnlShiftControls.TabIndex = 5;
            this.pnlShiftControls.VerticalScrollbarBarColor = true;
            this.pnlShiftControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlShiftControls.VerticalScrollbarSize = 10;
            // 
            // btnRight
            // 
            this.btnRight.ActiveControl = null;
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Location = new System.Drawing.Point(50, 183);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(74, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">>";
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRight.UseSelectable = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.ActiveControl = null;
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.Location = new System.Drawing.Point(50, 214);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(74, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<<";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLeft.UseSelectable = true;
            // 
            // lbAvailableDisciplines
            // 
            this.lbAvailableDisciplines.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAvailableDisciplines.FormattingEnabled = true;
            this.lbAvailableDisciplines.Items.AddRange(new object[] {
            " "});
            this.lbAvailableDisciplines.Location = new System.Drawing.Point(0, 0);
            this.lbAvailableDisciplines.Name = "lbAvailableDisciplines";
            this.lbAvailableDisciplines.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAvailableDisciplines.Size = new System.Drawing.Size(400, 420);
            this.lbAvailableDisciplines.TabIndex = 3;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chbUpgrade);
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.btnOK);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 420);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(984, 50);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // chbUpgrade
            // 
            this.chbUpgrade.AutoSize = true;
            this.chbUpgrade.Location = new System.Drawing.Point(13, 18);
            this.chbUpgrade.Name = "chbUpgrade";
            this.chbUpgrade.Size = new System.Drawing.Size(130, 15);
            this.chbUpgrade.TabIndex = 4;
            this.chbUpgrade.Text = "Schüler hochstufen?";
            this.chbUpgrade.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(784, 0);
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
            this.btnOK.Location = new System.Drawing.Point(884, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            // 
            // NewSportsFestivalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 550);
            this.Controls.Add(this.pnlClient);
            this.Name = "NewSportsFestivalGUI";
            this.Text = "Neues Sportfest";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlShiftControls.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlClient;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private System.Windows.Forms.ListBox lbAvailableDisciplines;
        private System.Windows.Forms.ListBox lbActiveDisciplines;
        private MetroFramework.Controls.MetroPanel pnlShiftControls;
        private MetroFramework.Controls.MetroTile btnRight;
        private MetroFramework.Controls.MetroTile btnLeft;
        private MetroFramework.Controls.MetroCheckBox chbUpgrade;
    }
}