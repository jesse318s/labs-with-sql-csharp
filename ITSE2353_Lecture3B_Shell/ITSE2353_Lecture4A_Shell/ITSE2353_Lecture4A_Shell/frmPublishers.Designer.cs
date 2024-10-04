namespace ITSE2353_Lecture4A_Shell
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
            this.tbxPubComments = new System.Windows.Forms.TextBox();
            this.lblPubComments = new System.Windows.Forms.Label();
            this.tbxPubFAX = new System.Windows.Forms.TextBox();
            this.lblPubFax = new System.Windows.Forms.Label();
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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.lblPubID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPubComments
            // 
            this.tbxPubComments.BackColor = System.Drawing.Color.White;
            this.tbxPubComments.Location = new System.Drawing.Point(148, 299);
            this.tbxPubComments.Name = "tbxPubComments";
            this.tbxPubComments.ReadOnly = true;
            this.tbxPubComments.Size = new System.Drawing.Size(236, 20);
            this.tbxPubComments.TabIndex = 79;
            this.tbxPubComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubComments
            // 
            this.lblPubComments.AutoSize = true;
            this.lblPubComments.Location = new System.Drawing.Point(69, 306);
            this.lblPubComments.Name = "lblPubComments";
            this.lblPubComments.Size = new System.Drawing.Size(56, 13);
            this.lblPubComments.TabIndex = 92;
            this.lblPubComments.Text = "Comments";
            // 
            // tbxPubFAX
            // 
            this.tbxPubFAX.BackColor = System.Drawing.Color.White;
            this.tbxPubFAX.Location = new System.Drawing.Point(148, 270);
            this.tbxPubFAX.Name = "tbxPubFAX";
            this.tbxPubFAX.ReadOnly = true;
            this.tbxPubFAX.Size = new System.Drawing.Size(132, 20);
            this.tbxPubFAX.TabIndex = 78;
            this.tbxPubFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubFax
            // 
            this.lblPubFax.AutoSize = true;
            this.lblPubFax.Location = new System.Drawing.Point(98, 277);
            this.lblPubFax.Name = "lblPubFax";
            this.lblPubFax.Size = new System.Drawing.Size(27, 13);
            this.lblPubFax.TabIndex = 91;
            this.lblPubFax.Text = "FAX";
            // 
            // tbxPubTelephone
            // 
            this.tbxPubTelephone.BackColor = System.Drawing.Color.White;
            this.tbxPubTelephone.Location = new System.Drawing.Point(147, 238);
            this.tbxPubTelephone.Name = "tbxPubTelephone";
            this.tbxPubTelephone.ReadOnly = true;
            this.tbxPubTelephone.Size = new System.Drawing.Size(132, 20);
            this.tbxPubTelephone.TabIndex = 76;
            this.tbxPubTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubPhone
            // 
            this.lblPubPhone.AutoSize = true;
            this.lblPubPhone.Location = new System.Drawing.Point(66, 245);
            this.lblPubPhone.Name = "lblPubPhone";
            this.lblPubPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPubPhone.TabIndex = 90;
            this.lblPubPhone.Text = "Telephone";
            // 
            // tbxPubZip
            // 
            this.tbxPubZip.BackColor = System.Drawing.Color.White;
            this.tbxPubZip.Location = new System.Drawing.Point(147, 209);
            this.tbxPubZip.Name = "tbxPubZip";
            this.tbxPubZip.ReadOnly = true;
            this.tbxPubZip.Size = new System.Drawing.Size(132, 20);
            this.tbxPubZip.TabIndex = 74;
            this.tbxPubZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubZip
            // 
            this.lblPubZip.AutoSize = true;
            this.lblPubZip.Location = new System.Drawing.Point(102, 216);
            this.lblPubZip.Name = "lblPubZip";
            this.lblPubZip.Size = new System.Drawing.Size(22, 13);
            this.lblPubZip.TabIndex = 89;
            this.lblPubZip.Text = "Zip";
            // 
            // tbxPubState
            // 
            this.tbxPubState.BackColor = System.Drawing.Color.White;
            this.tbxPubState.Location = new System.Drawing.Point(147, 179);
            this.tbxPubState.Name = "tbxPubState";
            this.tbxPubState.ReadOnly = true;
            this.tbxPubState.Size = new System.Drawing.Size(132, 20);
            this.tbxPubState.TabIndex = 72;
            this.tbxPubState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubState
            // 
            this.lblPubState.AutoSize = true;
            this.lblPubState.Location = new System.Drawing.Point(92, 186);
            this.lblPubState.Name = "lblPubState";
            this.lblPubState.Size = new System.Drawing.Size(32, 13);
            this.lblPubState.TabIndex = 88;
            this.lblPubState.Text = "State";
            // 
            // tbxPubCity
            // 
            this.tbxPubCity.BackColor = System.Drawing.Color.White;
            this.tbxPubCity.Location = new System.Drawing.Point(147, 144);
            this.tbxPubCity.Name = "tbxPubCity";
            this.tbxPubCity.ReadOnly = true;
            this.tbxPubCity.Size = new System.Drawing.Size(236, 20);
            this.tbxPubCity.TabIndex = 71;
            this.tbxPubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubCity
            // 
            this.lblPubCity.AutoSize = true;
            this.lblPubCity.Location = new System.Drawing.Point(101, 151);
            this.lblPubCity.Name = "lblPubCity";
            this.lblPubCity.Size = new System.Drawing.Size(24, 13);
            this.lblPubCity.TabIndex = 87;
            this.lblPubCity.Text = "City";
            // 
            // tbxPubAddress
            // 
            this.tbxPubAddress.BackColor = System.Drawing.Color.White;
            this.tbxPubAddress.Location = new System.Drawing.Point(148, 117);
            this.tbxPubAddress.Name = "tbxPubAddress";
            this.tbxPubAddress.ReadOnly = true;
            this.tbxPubAddress.Size = new System.Drawing.Size(236, 20);
            this.tbxPubAddress.TabIndex = 69;
            this.tbxPubAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubAddress
            // 
            this.lblPubAddress.AutoSize = true;
            this.lblPubAddress.Location = new System.Drawing.Point(79, 124);
            this.lblPubAddress.Name = "lblPubAddress";
            this.lblPubAddress.Size = new System.Drawing.Size(45, 13);
            this.lblPubAddress.TabIndex = 86;
            this.lblPubAddress.Text = "Address";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(276, 432);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 85;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 84;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(114, 403);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 82;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 80;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 374);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 77;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(229, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 75;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(148, 345);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 73;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.BackColor = System.Drawing.Color.White;
            this.tbxCompanyName.Location = new System.Drawing.Point(147, 89);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.ReadOnly = true;
            this.tbxCompanyName.Size = new System.Drawing.Size(236, 20);
            this.tbxCompanyName.TabIndex = 68;
            this.tbxCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(47, 96);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 70;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbxPubName
            // 
            this.tbxPubName.BackColor = System.Drawing.Color.White;
            this.tbxPubName.Location = new System.Drawing.Point(147, 59);
            this.tbxPubName.Name = "tbxPubName";
            this.tbxPubName.ReadOnly = true;
            this.tbxPubName.Size = new System.Drawing.Size(236, 20);
            this.tbxPubName.TabIndex = 66;
            this.tbxPubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // lblPubName
            // 
            this.lblPubName.AutoSize = true;
            this.lblPubName.Location = new System.Drawing.Point(89, 66);
            this.lblPubName.Name = "lblPubName";
            this.lblPubName.Size = new System.Drawing.Size(35, 13);
            this.lblPubName.TabIndex = 67;
            this.lblPubName.Text = "Name";
            // 
            // tbxPubID
            // 
            this.tbxPubID.BackColor = System.Drawing.Color.White;
            this.tbxPubID.Location = new System.Drawing.Point(147, 31);
            this.tbxPubID.Name = "tbxPubID";
            this.tbxPubID.ReadOnly = true;
            this.tbxPubID.Size = new System.Drawing.Size(100, 20);
            this.tbxPubID.TabIndex = 65;
            this.tbxPubID.TabStop = false;
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Location = new System.Drawing.Point(65, 38);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(64, 13);
            this.lblPubID.TabIndex = 64;
            this.lblPubID.Text = "Publisher ID";
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 493);
            this.ControlBox = false;
            this.Controls.Add(this.tbxPubComments);
            this.Controls.Add(this.lblPubComments);
            this.Controls.Add(this.tbxPubFAX);
            this.Controls.Add(this.lblPubFax);
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
            this.Controls.Add(this.btnClose);
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
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPubComments;
        private System.Windows.Forms.Label lblPubComments;
        private System.Windows.Forms.TextBox tbxPubFAX;
        private System.Windows.Forms.Label lblPubFax;
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
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.Label lblPubID;
    }
}