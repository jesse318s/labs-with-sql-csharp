using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ACS_LAB3A_SitesJ
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        CurrencyManager suppliersManager;
        int myBookmark;
        string myState;

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            //call DatabaseCommandSup
            ProgOps.DatabaseCommandSup(tbxSupplierID, tbxCompanyName, tbxContactName, tbxContactTitle, tbxPhone);

            //establish CurrencyManager
            suppliersManager = (CurrencyManager)this.BindingContext[ProgOps.SuppliersTable];

            //to be in View State when application is inititalized
            SetState("View");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (suppliersManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            suppliersManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (suppliersManager.Position == suppliersManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            suppliersManager.Position++;
        }

        private void SetState(string appState)
        {
            myState = appState;
            //create state cases
            switch (appState)
            {
                case "View":
                    tbxCompanyName.ReadOnly = true;
                    tbxContactName.ReadOnly = true;
                    tbxContactTitle.ReadOnly = true;
                    tbxPhone.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    break;
                case "Edit":
                    tbxCompanyName.ReadOnly = false;
                    tbxContactName.ReadOnly = false;
                    tbxContactTitle.ReadOnly = false;
                    tbxPhone.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case "Add New":
                    tbxCompanyName.ReadOnly = false;
                    tbxContactName.ReadOnly = false;
                    tbxContactTitle.ReadOnly = false;
                    tbxPhone.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void tbxCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //convert lower
                if (tbxCompanyName.Text.Trim().Equals(""))
                {
                    if (char.IsLower(e.KeyChar))
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                }
                // Check for contact name and contact title
                if (tbxContactName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter a Contact Name.");
                    tbxContactName.Focus();
                }
                if (tbxContactTitle.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter a Contact Title.");
                    tbxContactTitle.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error with Company Name input.", "Suppliers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //convert lower
                if (tbxContactName.Text.Trim().Equals(""))
                {
                    if (char.IsLower(e.KeyChar))
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                }
                // Check for company name and contact title
                if (tbxCompanyName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a Company Name.");
                    tbxCompanyName.Focus();
                }
                if (tbxContactTitle.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a Contact Title.");
                    tbxContactTitle.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error with Contact Name input.", "Suppliers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxContactTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //convert lower
                if (tbxContactTitle.Text.Trim().Equals(""))
                {
                    if (char.IsLower(e.KeyChar))
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                }
                // Check for company name and contact name
                if (tbxCompanyName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a Company Name.");
                    tbxCompanyName.Focus();
                }
                if (tbxContactName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a Contact Name.");
                    tbxContactName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error with Contact Title input", "Suppliers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int inputNum = 0;
            bool isNumber = int.TryParse(e.KeyChar.ToString(), out inputNum);
            try
            {
                // Check for company name, contact name, and contact title
                if (tbxCompanyName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter a Company Name.");
                    tbxCompanyName.Focus();
                }
                if (tbxContactName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter a Contact Name.");
                    tbxContactName.Focus();
                }
                if (tbxContactTitle.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter a Contact Title.");
                    tbxContactTitle.Focus();
                }
                //check for phone number/formatting input
                if (isNumber || e.KeyChar.ToString() == "-" || e.KeyChar.ToString() == " " || e.KeyChar.ToString() == "(" || e.KeyChar.ToString() == ")" ||
                    e.KeyChar == ((char)Keys.Back))
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error with Phone input.", "Suppliers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            // Check for company name, contact name, and contact title
            if (tbxCompanyName.Text.Trim().Equals(""))
            {
                message = "You must enter a Company Name." + "\r\n";
                tbxCompanyName.Focus();
                allOK = false;
            }
            if (tbxContactName.Text.Trim().Equals(""))
            {
                message = "You must enter a Contact Name." + "\r\n";
                tbxContactName.Focus();
                allOK = false;
            }
            if (tbxContactTitle.Text.Trim().Equals(""))
            {
                message = "You must enter a Contact Title." + "\r\n";
                tbxContactTitle.Focus();
                allOK = false;
            }
            // Check phone format
            if (!tbxPhone.Text.Trim().Equals(""))
            {

            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //we want to switch to Edit state at the top of the code
            SetState("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            try
            {
                suppliersManager.EndCurrentEdit();
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return to a view state at the end of Save

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error saving record.  Error 204", "Save Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetState("View");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                suppliersManager.CancelCurrentEdit();
                if (myState.Equals("Add"))
                {
                    suppliersManager.Position = myBookmark;
                }
                //return to a view state at the end of Cancel
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error canceling operation. Error 100", "Suppliers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = suppliersManager.Position;
                suppliersManager.AddNew();
                SetState("Add New");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error adding record.  Error 202", "Add New Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }

            try
            {
                suppliersManager.RemoveAt(suppliersManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error deleting record. Error 203.", "Delete Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ProgOps.UpdateOnCloseSup();
            ProgOps.DisposeSup();
            this.Close();
        }
    }
}
