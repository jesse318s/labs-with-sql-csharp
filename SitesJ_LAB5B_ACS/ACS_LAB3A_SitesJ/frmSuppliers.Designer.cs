
namespace ACS_LAB3A_SitesJ
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            this.tbxSupplierID = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.btnSupplierID = new System.Windows.Forms.Label();
            this.btnCompanyName = new System.Windows.Forms.Label();
            this.btnContactName = new System.Windows.Forms.Label();
            this.btnContactTitle = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSupplierID
            // 
            this.tbxSupplierID.BackColor = System.Drawing.Color.White;
            this.tbxSupplierID.Location = new System.Drawing.Point(259, 77);
            this.tbxSupplierID.Name = "tbxSupplierID";
            this.tbxSupplierID.ReadOnly = true;
            this.tbxSupplierID.Size = new System.Drawing.Size(75, 20);
            this.tbxSupplierID.TabIndex = 0;
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.Color.White;
            this.tbxPhone.Location = new System.Drawing.Point(259, 181);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.ReadOnly = true;
            this.tbxPhone.Size = new System.Drawing.Size(122, 20);
            this.tbxPhone.TabIndex = 1;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.BackColor = System.Drawing.Color.White;
            this.tbxCompanyName.Location = new System.Drawing.Point(259, 103);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.ReadOnly = true;
            this.tbxCompanyName.Size = new System.Drawing.Size(237, 20);
            this.tbxCompanyName.TabIndex = 2;
            this.tbxCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCompanyName_KeyPress);
            // 
            // tbxContactName
            // 
            this.tbxContactName.BackColor = System.Drawing.Color.White;
            this.tbxContactName.Location = new System.Drawing.Point(259, 129);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.ReadOnly = true;
            this.tbxContactName.Size = new System.Drawing.Size(237, 20);
            this.tbxContactName.TabIndex = 3;
            this.tbxContactName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxContactName_KeyPress);
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.BackColor = System.Drawing.Color.White;
            this.tbxContactTitle.Location = new System.Drawing.Point(259, 155);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.ReadOnly = true;
            this.tbxContactTitle.Size = new System.Drawing.Size(237, 20);
            this.tbxContactTitle.TabIndex = 4;
            this.tbxContactTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxContactTitle_KeyPress);
            // 
            // btnSupplierID
            // 
            this.btnSupplierID.AutoSize = true;
            this.btnSupplierID.Location = new System.Drawing.Point(106, 84);
            this.btnSupplierID.Name = "btnSupplierID";
            this.btnSupplierID.Size = new System.Drawing.Size(56, 13);
            this.btnSupplierID.TabIndex = 5;
            this.btnSupplierID.Text = "SupplierID";
            // 
            // btnCompanyName
            // 
            this.btnCompanyName.AutoSize = true;
            this.btnCompanyName.Location = new System.Drawing.Point(106, 110);
            this.btnCompanyName.Name = "btnCompanyName";
            this.btnCompanyName.Size = new System.Drawing.Size(79, 13);
            this.btnCompanyName.TabIndex = 6;
            this.btnCompanyName.Text = "CompanyName";
            // 
            // btnContactName
            // 
            this.btnContactName.AutoSize = true;
            this.btnContactName.Location = new System.Drawing.Point(106, 136);
            this.btnContactName.Name = "btnContactName";
            this.btnContactName.Size = new System.Drawing.Size(72, 13);
            this.btnContactName.TabIndex = 7;
            this.btnContactName.Text = "ContactName";
            // 
            // btnContactTitle
            // 
            this.btnContactTitle.AutoSize = true;
            this.btnContactTitle.Location = new System.Drawing.Point(106, 162);
            this.btnContactTitle.Name = "btnContactTitle";
            this.btnContactTitle.Size = new System.Drawing.Size(64, 13);
            this.btnContactTitle.TabIndex = 8;
            this.btnContactTitle.Text = "ContactTitle";
            // 
            // btnPhone
            // 
            this.btnPhone.AutoSize = true;
            this.btnPhone.Location = new System.Drawing.Point(106, 188);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(38, 13);
            this.btnPhone.TabIndex = 9;
            this.btnPhone.Text = "Phone";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(306, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 92;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(144, 333);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 90;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 88;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(144, 304);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 87;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(259, 275);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 86;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(178, 275);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 85;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 396);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnContactTitle);
            this.Controls.Add(this.btnContactName);
            this.Controls.Add(this.btnCompanyName);
            this.Controls.Add(this.btnSupplierID);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxSupplierID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSupplierID;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.Label btnSupplierID;
        private System.Windows.Forms.Label btnCompanyName;
        private System.Windows.Forms.Label btnContactName;
        private System.Windows.Forms.Label btnContactTitle;
        private System.Windows.Forms.Label btnPhone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}