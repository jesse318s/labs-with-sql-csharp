namespace ACS_EX5B_Shell
{
    partial class frmPublishers
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
            this.gbxFindPublisher = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tbxPubComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbxPubFAX = new System.Windows.Forms.TextBox();
            this.lblPubFAX = new System.Windows.Forms.Label();
            this.tbxPubTelephone = new System.Windows.Forms.TextBox();
            this.lblPubPhone = new System.Windows.Forms.Label();
            this.tbxPubZip = new System.Windows.Forms.TextBox();
            this.lblPubZip = new System.Windows.Forms.Label();
            this.tbxPubState = new System.Windows.Forms.TextBox();
            this.lblPubState = new System.Windows.Forms.Label();
            this.tbxPubCity = new System.Windows.Forms.TextBox();
            this.lblPubCity = new System.Windows.Forms.Label();
            this.tbxPubAddress = new System.Windows.Forms.TextBox();
            this.lblPubAddress = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbxPubName = new System.Windows.Forms.TextBox();
            this.lblPubName = new System.Windows.Forms.Label();
            this.tbxPubID = new System.Windows.Forms.TextBox();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.lblPubID = new System.Windows.Forms.Label();
            this.gbxFindPublisher.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFindPublisher
            // 
            this.gbxFindPublisher.Controls.Add(this.btnFind);
            this.gbxFindPublisher.Controls.Add(this.tbxFind);
            this.gbxFindPublisher.Controls.Add(this.lblInstructions);
            this.gbxFindPublisher.Location = new System.Drawing.Point(35, 380);
            this.gbxFindPublisher.Name = "gbxFindPublisher";
            this.gbxFindPublisher.Size = new System.Drawing.Size(200, 79);
            this.gbxFindPublisher.TabIndex = 63;
            this.gbxFindPublisher.TabStop = false;
            this.gbxFindPublisher.Text = "Find Publisher";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(112, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxFind
            // 
            this.tbxFind.Location = new System.Drawing.Point(112, 19);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(75, 20);
            this.tbxFind.TabIndex = 1;
            this.tbxFind.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(6, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(100, 39);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Type first few letters of Publisher Name";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(40, 288);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 62;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(279, 288);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 61;
            this.btnLast.TabStop = false;
            this.btnLast.Text = "Last >|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // tbxPubComments
            // 
            this.tbxPubComments.BackColor = System.Drawing.Color.White;
            this.tbxPubComments.Location = new System.Drawing.Point(118, 262);
            this.tbxPubComments.Name = "tbxPubComments";
            this.tbxPubComments.ReadOnly = true;
            this.tbxPubComments.Size = new System.Drawing.Size(236, 20);
            this.tbxPubComments.TabIndex = 47;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(33, 265);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 60;
            this.lblComments.Text = "Comments";
            // 
            // tbxPubFAX
            // 
            this.tbxPubFAX.BackColor = System.Drawing.Color.White;
            this.tbxPubFAX.Location = new System.Drawing.Point(118, 236);
            this.tbxPubFAX.Name = "tbxPubFAX";
            this.tbxPubFAX.ReadOnly = true;
            this.tbxPubFAX.Size = new System.Drawing.Size(132, 20);
            this.tbxPubFAX.TabIndex = 46;
            // 
            // lblPubFAX
            // 
            this.lblPubFAX.AutoSize = true;
            this.lblPubFAX.Location = new System.Drawing.Point(33, 239);
            this.lblPubFAX.Name = "lblPubFAX";
            this.lblPubFAX.Size = new System.Drawing.Size(27, 13);
            this.lblPubFAX.TabIndex = 59;
            this.lblPubFAX.Text = "FAX";
            // 
            // tbxPubTelephone
            // 
            this.tbxPubTelephone.BackColor = System.Drawing.Color.White;
            this.tbxPubTelephone.Location = new System.Drawing.Point(118, 210);
            this.tbxPubTelephone.Name = "tbxPubTelephone";
            this.tbxPubTelephone.ReadOnly = true;
            this.tbxPubTelephone.Size = new System.Drawing.Size(132, 20);
            this.tbxPubTelephone.TabIndex = 44;
            // 
            // lblPubPhone
            // 
            this.lblPubPhone.AutoSize = true;
            this.lblPubPhone.Location = new System.Drawing.Point(33, 213);
            this.lblPubPhone.Name = "lblPubPhone";
            this.lblPubPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPubPhone.TabIndex = 58;
            this.lblPubPhone.Text = "Telephone";
            // 
            // tbxPubZip
            // 
            this.tbxPubZip.BackColor = System.Drawing.Color.White;
            this.tbxPubZip.Location = new System.Drawing.Point(118, 184);
            this.tbxPubZip.Name = "tbxPubZip";
            this.tbxPubZip.ReadOnly = true;
            this.tbxPubZip.Size = new System.Drawing.Size(132, 20);
            this.tbxPubZip.TabIndex = 42;
            // 
            // lblPubZip
            // 
            this.lblPubZip.AutoSize = true;
            this.lblPubZip.Location = new System.Drawing.Point(33, 187);
            this.lblPubZip.Name = "lblPubZip";
            this.lblPubZip.Size = new System.Drawing.Size(22, 13);
            this.lblPubZip.TabIndex = 57;
            this.lblPubZip.Text = "Zip";
            // 
            // tbxPubState
            // 
            this.tbxPubState.BackColor = System.Drawing.Color.White;
            this.tbxPubState.Location = new System.Drawing.Point(118, 158);
            this.tbxPubState.Name = "tbxPubState";
            this.tbxPubState.ReadOnly = true;
            this.tbxPubState.Size = new System.Drawing.Size(132, 20);
            this.tbxPubState.TabIndex = 40;
            // 
            // lblPubState
            // 
            this.lblPubState.AutoSize = true;
            this.lblPubState.Location = new System.Drawing.Point(33, 161);
            this.lblPubState.Name = "lblPubState";
            this.lblPubState.Size = new System.Drawing.Size(32, 13);
            this.lblPubState.TabIndex = 56;
            this.lblPubState.Text = "State";
            // 
            // tbxPubCity
            // 
            this.tbxPubCity.BackColor = System.Drawing.Color.White;
            this.tbxPubCity.Location = new System.Drawing.Point(118, 132);
            this.tbxPubCity.Name = "tbxPubCity";
            this.tbxPubCity.ReadOnly = true;
            this.tbxPubCity.Size = new System.Drawing.Size(236, 20);
            this.tbxPubCity.TabIndex = 39;
            // 
            // lblPubCity
            // 
            this.lblPubCity.AutoSize = true;
            this.lblPubCity.Location = new System.Drawing.Point(33, 135);
            this.lblPubCity.Name = "lblPubCity";
            this.lblPubCity.Size = new System.Drawing.Size(24, 13);
            this.lblPubCity.TabIndex = 55;
            this.lblPubCity.Text = "City";
            // 
            // tbxPubAddress
            // 
            this.tbxPubAddress.BackColor = System.Drawing.Color.White;
            this.tbxPubAddress.Location = new System.Drawing.Point(118, 106);
            this.tbxPubAddress.Name = "tbxPubAddress";
            this.tbxPubAddress.ReadOnly = true;
            this.tbxPubAddress.Size = new System.Drawing.Size(236, 20);
            this.tbxPubAddress.TabIndex = 37;
            // 
            // lblPubAddress
            // 
            this.lblPubAddress.AutoSize = true;
            this.lblPubAddress.Location = new System.Drawing.Point(33, 109);
            this.lblPubAddress.Name = "lblPubAddress";
            this.lblPubAddress.Size = new System.Drawing.Size(45, 13);
            this.lblPubAddress.TabIndex = 54;
            this.lblPubAddress.Text = "Address";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(245, 375);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 53;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(245, 346);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 52;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "D&one";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(83, 346);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 50;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(83, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(199, 288);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 43;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(118, 288);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 41;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.BackColor = System.Drawing.Color.White;
            this.tbxCompanyName.Location = new System.Drawing.Point(118, 80);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.ReadOnly = true;
            this.tbxCompanyName.Size = new System.Drawing.Size(236, 20);
            this.tbxCompanyName.TabIndex = 36;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(33, 83);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 38;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbxPubName
            // 
            this.tbxPubName.BackColor = System.Drawing.Color.White;
            this.tbxPubName.Location = new System.Drawing.Point(118, 54);
            this.tbxPubName.Name = "tbxPubName";
            this.tbxPubName.ReadOnly = true;
            this.tbxPubName.Size = new System.Drawing.Size(236, 20);
            this.tbxPubName.TabIndex = 34;
            // 
            // lblPubName
            // 
            this.lblPubName.AutoSize = true;
            this.lblPubName.Location = new System.Drawing.Point(33, 57);
            this.lblPubName.Name = "lblPubName";
            this.lblPubName.Size = new System.Drawing.Size(35, 13);
            this.lblPubName.TabIndex = 35;
            this.lblPubName.Text = "Name";
            // 
            // tbxPubID
            // 
            this.tbxPubID.BackColor = System.Drawing.Color.White;
            this.tbxPubID.Location = new System.Drawing.Point(118, 28);
            this.tbxPubID.Name = "tbxPubID";
            this.tbxPubID.ReadOnly = true;
            this.tbxPubID.Size = new System.Drawing.Size(100, 20);
            this.tbxPubID.TabIndex = 33;
            this.tbxPubID.TabStop = false;
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Location = new System.Drawing.Point(33, 31);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(64, 13);
            this.lblPubID.TabIndex = 32;
            this.lblPubID.Text = "Publisher ID";
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 508);
            this.ControlBox = false;
            this.Controls.Add(this.gbxFindPublisher);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.tbxPubComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.tbxPubFAX);
            this.Controls.Add(this.lblPubFAX);
            this.Controls.Add(this.tbxPubTelephone);
            this.Controls.Add(this.lblPubPhone);
            this.Controls.Add(this.tbxPubZip);
            this.Controls.Add(this.lblPubZip);
            this.Controls.Add(this.tbxPubState);
            this.Controls.Add(this.lblPubState);
            this.Controls.Add(this.tbxPubCity);
            this.Controls.Add(this.lblPubCity);
            this.Controls.Add(this.tbxPubAddress);
            this.Controls.Add(this.lblPubAddress);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.tbxPubName);
            this.Controls.Add(this.lblPubName);
            this.Controls.Add(this.tbxPubID);
            this.Controls.Add(this.lblPubID);
            this.Name = "frmPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.gbxFindPublisher.ResumeLayout(false);
            this.gbxFindPublisher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFindPublisher;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox tbxPubComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbxPubFAX;
        private System.Windows.Forms.Label lblPubFAX;
        private System.Windows.Forms.TextBox tbxPubTelephone;
        private System.Windows.Forms.Label lblPubPhone;
        private System.Windows.Forms.TextBox tbxPubZip;
        private System.Windows.Forms.Label lblPubZip;
        private System.Windows.Forms.TextBox tbxPubState;
        private System.Windows.Forms.Label lblPubState;
        private System.Windows.Forms.TextBox tbxPubCity;
        private System.Windows.Forms.Label lblPubCity;
        private System.Windows.Forms.TextBox tbxPubAddress;
        private System.Windows.Forms.Label lblPubAddress;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbxPubName;
        private System.Windows.Forms.Label lblPubName;
        private System.Windows.Forms.TextBox tbxPubID;
        private System.Windows.Forms.HelpProvider hlpPublishers;
        private System.Windows.Forms.Label lblPubID;
    }
}