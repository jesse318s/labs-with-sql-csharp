namespace ITSE2353_Lecture4A_Shell
{
    partial class frmAuthors
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbxYearBorn = new System.Windows.Forms.TextBox();
            this.lblYearBorn = new System.Windows.Forms.Label();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.tbxAuthorID = new System.Windows.Forms.TextBox();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.hlpSample = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(85, 486);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(176, 59);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(461, 415);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 59);
            this.btnExit.TabIndex = 30;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(85, 415);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(176, 59);
            this.btnAddNew.TabIndex = 29;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 59);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(461, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 59);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 59);
            this.btnSave.TabIndex = 25;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(85, 344);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 59);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(355, 273);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(176, 59);
            this.btnNext.TabIndex = 23;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">= &Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(167, 273);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(176, 59);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= &Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbxYearBorn
            // 
            this.tbxYearBorn.BackColor = System.Drawing.Color.White;
            this.tbxYearBorn.Location = new System.Drawing.Point(282, 172);
            this.tbxYearBorn.Margin = new System.Windows.Forms.Padding(6);
            this.tbxYearBorn.MaxLength = 4;
            this.tbxYearBorn.Name = "tbxYearBorn";
            this.tbxYearBorn.ReadOnly = true;
            this.tbxYearBorn.Size = new System.Drawing.Size(123, 29);
            this.tbxYearBorn.TabIndex = 2;
            this.tbxYearBorn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearBorn_KeyPress);
            // 
            // lblYearBorn
            // 
            this.lblYearBorn.AutoSize = true;
            this.lblYearBorn.Location = new System.Drawing.Point(125, 175);
            this.lblYearBorn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYearBorn.Name = "lblYearBorn";
            this.lblYearBorn.Size = new System.Drawing.Size(94, 24);
            this.lblYearBorn.TabIndex = 21;
            this.lblYearBorn.Text = "Year Born";
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.BackColor = System.Drawing.Color.White;
            this.tbxAuthorName.Location = new System.Drawing.Point(282, 109);
            this.tbxAuthorName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.ReadOnly = true;
            this.tbxAuthorName.Size = new System.Drawing.Size(376, 29);
            this.tbxAuthorName.TabIndex = 1;
            this.tbxAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAuthorName_KeyPress);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(101, 112);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(122, 24);
            this.lblAuthorName.TabIndex = 20;
            this.lblAuthorName.Text = "Author Name";
            // 
            // tbxAuthorID
            // 
            this.tbxAuthorID.BackColor = System.Drawing.Color.White;
            this.tbxAuthorID.Location = new System.Drawing.Point(282, 42);
            this.tbxAuthorID.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAuthorID.Name = "tbxAuthorID";
            this.tbxAuthorID.ReadOnly = true;
            this.tbxAuthorID.Size = new System.Drawing.Size(244, 29);
            this.tbxAuthorID.TabIndex = 18;
            this.tbxAuthorID.TabStop = false;
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(136, 55);
            this.lblAuthorID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(83, 24);
            this.lblAuthorID.TabIndex = 16;
            this.lblAuthorID.Text = "AuthorID";
            // 
            // btnPublishers
            // 
            this.btnPublishers.Location = new System.Drawing.Point(273, 486);
            this.btnPublishers.Margin = new System.Windows.Forms.Padding(6);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(176, 59);
            this.btnPublishers.TabIndex = 32;
            this.btnPublishers.TabStop = false;
            this.btnPublishers.Text = "Pu&blishers Info";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tbxYearBorn);
            this.Controls.Add(this.lblYearBorn);
            this.Controls.Add(this.tbxAuthorName);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.tbxAuthorID);
            this.Controls.Add(this.lblAuthorID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpSample.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAuthors";
            this.hlpSample.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbxYearBorn;
        private System.Windows.Forms.Label lblYearBorn;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox tbxAuthorID;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.HelpProvider hlpSample;
    }
}

