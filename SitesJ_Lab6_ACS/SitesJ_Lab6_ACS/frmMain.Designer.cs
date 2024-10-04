
namespace SitesJ_Lab6_ACS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMovieStore = new System.Windows.Forms.DataGridView();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnPurchaseDetails = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.hlpInstructions = new System.Windows.Forms.HelpProvider();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieStore)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile,
            this.mnuItemHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(93, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemInstructions,
            this.mnuItemAbout});
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuItemHelp.Text = "Help";
            // 
            // mnuItemInstructions
            // 
            this.mnuItemInstructions.Name = "mnuItemInstructions";
            this.mnuItemInstructions.Size = new System.Drawing.Size(136, 22);
            this.mnuItemInstructions.Text = "Instructions";
            this.mnuItemInstructions.Click += new System.EventHandler(this.mnuItemInstructions_Click);
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(136, 22);
            this.mnuItemAbout.Text = "About";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // dgvMovieStore
            // 
            this.dgvMovieStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieStore.Location = new System.Drawing.Point(12, 54);
            this.dgvMovieStore.Name = "dgvMovieStore";
            this.dgvMovieStore.Size = new System.Drawing.Size(776, 310);
            this.dgvMovieStore.TabIndex = 1;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(12, 396);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(85, 23);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.Text = "&Customer Info";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.DarkViolet;
            this.btnMovies.ForeColor = System.Drawing.Color.White;
            this.btnMovies.Location = new System.Drawing.Point(103, 396);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(75, 23);
            this.btnMovies.TabIndex = 3;
            this.btnMovies.TabStop = false;
            this.btnMovies.Text = "&Movie Stock Items";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnPurchaseDetails
            // 
            this.btnPurchaseDetails.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPurchaseDetails.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseDetails.Location = new System.Drawing.Point(184, 396);
            this.btnPurchaseDetails.Name = "btnPurchaseDetails";
            this.btnPurchaseDetails.Size = new System.Drawing.Size(97, 23);
            this.btnPurchaseDetails.TabIndex = 4;
            this.btnPurchaseDetails.TabStop = false;
            this.btnPurchaseDetails.Text = "Purchase &Details";
            this.btnPurchaseDetails.UseVisualStyleBackColor = false;
            this.btnPurchaseDetails.Click += new System.EventHandler(this.btnPurchaseDetails_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(287, 396);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(97, 23);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.TabStop = false;
            this.btnPurchase.Text = "Pu&rchase Info";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(390, 396);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(97, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.TabStop = false;
            this.btnPayment.Text = "Pa&yment Info";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnPurchaseDetails);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.dgvMovieStore);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpInstructions.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.hlpInstructions.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Johnson\'s Movie Parlor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemInstructions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.DataGridView dgvMovieStore;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnPurchaseDetails;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.HelpProvider hlpInstructions;
    }
}

