
namespace SitesJ_Lab05A_ACS
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
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnProductInfo = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainItmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmEmployeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmOrderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.Location = new System.Drawing.Point(91, 155);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(82, 23);
            this.btnCustomerInfo.TabIndex = 0;
            this.btnCustomerInfo.Text = "&Customer Info";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.Location = new System.Drawing.Point(196, 155);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(233, 23);
            this.btnProductInfo.TabIndex = 1;
            this.btnProductInfo.Text = "&Products Info for Non-Discontinued Products";
            this.btnProductInfo.UseVisualStyleBackColor = true;
            this.btnProductInfo.Click += new System.EventHandler(this.btnProductInfo_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(520, 24);
            this.mnuMain.TabIndex = 2;
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
            this.mnuMainItmEmployeeInfo,
            this.mnuMainItmOrderInfo});
            this.mnuMainItmPrint.Name = "mnuMainItmPrint";
            this.mnuMainItmPrint.Size = new System.Drawing.Size(180, 22);
            this.mnuMainItmPrint.Text = "Print";
            // 
            // mnuMainItmEmployeeInfo
            // 
            this.mnuMainItmEmployeeInfo.Name = "mnuMainItmEmployeeInfo";
            this.mnuMainItmEmployeeInfo.Size = new System.Drawing.Size(232, 22);
            this.mnuMainItmEmployeeInfo.Text = "&Employee Info";
            this.mnuMainItmEmployeeInfo.Click += new System.EventHandler(this.mnuMainItmEmployeeInfo_Click);
            // 
            // mnuMainItmOrderInfo
            // 
            this.mnuMainItmOrderInfo.Name = "mnuMainItmOrderInfo";
            this.mnuMainItmOrderInfo.Size = new System.Drawing.Size(232, 22);
            this.mnuMainItmOrderInfo.Text = "&Order Info for EmployeeID > 4";
            this.mnuMainItmOrderInfo.Click += new System.EventHandler(this.mnuMainItmOrderInfo_Click);
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
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btnProductInfo);
            this.Controls.Add(this.btnCustomerInfo);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal Reports Lab";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnProductInfo;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmOrderInfo;
    }
}

