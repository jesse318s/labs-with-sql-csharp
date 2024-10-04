
namespace ACS_LAB3A_SitesJ
{
    partial class frmEmployees
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
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpEmployees = new System.Windows.Forms.HelpProvider();
            this.btnOrders = new System.Windows.Forms.Button();
            this.gbxFindEmployee = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.gbxFindEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.BackColor = System.Drawing.Color.White;
            this.tbxEmployeeID.Location = new System.Drawing.Point(539, 11);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(78, 26);
            this.tbxEmployeeID.TabIndex = 0;
            this.tbxEmployeeID.TabStop = false;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(539, 65);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.ReadOnly = true;
            this.tbxLastName.Size = new System.Drawing.Size(297, 26);
            this.tbxLastName.TabIndex = 1;
            this.tbxLastName.TabStop = false;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(539, 119);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.ReadOnly = true;
            this.tbxFirstName.Size = new System.Drawing.Size(297, 26);
            this.tbxFirstName.TabIndex = 2;
            this.tbxFirstName.TabStop = false;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // tbxExtension
            // 
            this.tbxExtension.BackColor = System.Drawing.Color.White;
            this.tbxExtension.Location = new System.Drawing.Point(539, 173);
            this.tbxExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.ReadOnly = true;
            this.tbxExtension.Size = new System.Drawing.Size(148, 26);
            this.tbxExtension.TabIndex = 3;
            this.tbxExtension.TabStop = false;
            this.tbxExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxExtension_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(338, 17);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(104, 20);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(338, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(338, 125);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(338, 178);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(83, 20);
            this.lblExtension.TabIndex = 7;
            this.lblExtension.Text = "Extension:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(648, 447);
            this.btnExit.Margin = new System.Windows.Forms.Padding(9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 91);
            this.btnExit.TabIndex = 38;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(84, 447);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(264, 91);
            this.btnAddNew.TabIndex = 37;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 447);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 91);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(648, 337);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(264, 91);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 337);
            this.btnSave.Margin = new System.Windows.Forms.Padding(9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 91);
            this.btnSave.TabIndex = 34;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 337);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(264, 91);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(489, 228);
            this.btnNext.Margin = new System.Windows.Forms.Padding(9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(264, 91);
            this.btnNext.TabIndex = 32;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">= &Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(207, 228);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(9);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(264, 91);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= &Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(366, 553);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(264, 86);
            this.btnSuppliers.TabIndex = 40;
            this.btnSuppliers.TabStop = false;
            this.btnSuppliers.Text = "Su&ppliers Info";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(84, 553);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(264, 86);
            this.btnHelp.TabIndex = 39;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(648, 553);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(264, 86);
            this.btnOrders.TabIndex = 41;
            this.btnOrders.TabStop = false;
            this.btnOrders.Text = "&Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // gbxFindEmployee
            // 
            this.gbxFindEmployee.Controls.Add(this.btnFind);
            this.gbxFindEmployee.Controls.Add(this.tbxFind);
            this.gbxFindEmployee.Controls.Add(this.lblInstructions);
            this.gbxFindEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbxFindEmployee.Location = new System.Drawing.Point(990, 228);
            this.gbxFindEmployee.Name = "gbxFindEmployee";
            this.gbxFindEmployee.Size = new System.Drawing.Size(200, 79);
            this.gbxFindEmployee.TabIndex = 75;
            this.gbxFindEmployee.TabStop = false;
            this.gbxFindEmployee.Text = "Find Employee";
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
            this.lblInstructions.Text = "Type first few letters of Employee Last Name";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 692);
            this.Controls.Add(this.gbxFindEmployee);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.tbxExtension);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxEmployeeID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hlpEmployees.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployees";
            this.hlpEmployees.SetShowHelp(this, true);
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.gbxFindEmployee.ResumeLayout(false);
            this.gbxFindEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpEmployees;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox gbxFindEmployee;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Label lblInstructions;
    }
}

