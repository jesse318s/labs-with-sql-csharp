﻿
namespace ITSE2353Mod6Lecture
{
    partial class frmViewer
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
            this.crvViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvViewer
            // 
            this.crvViewer.ActiveViewIndex = -1;
            this.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvViewer.Location = new System.Drawing.Point(0, 0);
            this.crvViewer.Name = "crvViewer";
            this.crvViewer.Size = new System.Drawing.Size(800, 450);
            this.crvViewer.TabIndex = 0;
            this.crvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvViewer);
            this.Name = "frmViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvViewer;
    }
}