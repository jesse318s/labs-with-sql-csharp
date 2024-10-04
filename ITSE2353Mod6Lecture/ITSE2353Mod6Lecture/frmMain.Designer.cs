
namespace ITSE2353Mod6Lecture
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
            this.btnTitle = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainItmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmGreaterThan200 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmLessThan1990 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(160, 109);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "T&itle";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(406, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainItmFile
            // 
            this.mnuMainItmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmPrint,
            this.mnuMainItmExit});
            this.mnuMainItmFile.Name = "mnuMainItmFile";
            this.mnuMainItmFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainItmFile.Text = "File";
            // 
            // mnuMainItmPrint
            // 
            this.mnuMainItmPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmGreaterThan200,
            this.mnuMainItmLessThan1990});
            this.mnuMainItmPrint.Name = "mnuMainItmPrint";
            this.mnuMainItmPrint.Size = new System.Drawing.Size(180, 22);
            this.mnuMainItmPrint.Text = "Print";
            // 
            // mnuMainItmGreaterThan200
            // 
            this.mnuMainItmGreaterThan200.Name = "mnuMainItmGreaterThan200";
            this.mnuMainItmGreaterThan200.Size = new System.Drawing.Size(230, 22);
            this.mnuMainItmGreaterThan200.Text = "&PubID Greater Than 200";
            this.mnuMainItmGreaterThan200.Click += new System.EventHandler(this.mnuMainItmGreaterThan200_Click);
            // 
            // mnuMainItmLessThan1990
            // 
            this.mnuMainItmLessThan1990.Name = "mnuMainItmLessThan1990";
            this.mnuMainItmLessThan1990.Size = new System.Drawing.Size(230, 22);
            this.mnuMainItmLessThan1990.Text = "&Year Published Less than 1990";
            this.mnuMainItmLessThan1990.Click += new System.EventHandler(this.mnuMainItmLessThan1990_Click);
            // 
            // mnuMainItmExit
            // 
            this.mnuMainItmExit.Name = "mnuMainItmExit";
            this.mnuMainItmExit.Size = new System.Drawing.Size(180, 22);
            this.mnuMainItmExit.Text = "E&xit";
            this.mnuMainItmExit.Click += new System.EventHandler(this.mnuMainItmExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 249);
            this.ControlBox = false;
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal Reports";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmGreaterThan200;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmLessThan1990;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmExit;
    }
}

