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

namespace ITSE2353_Lecture4A_Shell
{
    public partial class frmPublishers : Form
    {
        public frmPublishers()
        {
            InitializeComponent();
        }

        CurrencyManager publishersManager;

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            //call DatabaseCommandPub
            ProgOps.DatabaseCommandPub(tbxPubID, tbxPubName, tbxCompanyName, tbxPubAddress, tbxPubCity,
                tbxPubState, tbxPubZip, tbxPubTelephone, tbxPubFAX, tbxPubComments);

            //establish CurrencyManager
            publishersManager = (CurrencyManager)this.BindingContext[ProgOps.DTPublishersTable];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            publishersManager.Position--;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == publishersManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            publishersManager.Position++;
        }

        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    tbxPubID.BackColor = Color.White;
                    tbxPubID.ForeColor = Color.Black;
                    tbxPubName.ReadOnly = true;
                    tbxCompanyName.ReadOnly = true;
                    tbxPubAddress.ReadOnly = true;
                    tbxPubCity.ReadOnly = true;
                    tbxPubState.ReadOnly = true;
                    tbxPubZip.ReadOnly = true;
                    tbxPubTelephone.ReadOnly = true;
                    tbxPubFAX.ReadOnly = true;
                    tbxPubComments.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    tbxPubName.Focus();
                    break;
                default: // Add or Edit if not View 
                    tbxPubID.BackColor = Color.Red;
                    tbxPubID.ForeColor = Color.White;
                    tbxPubName.ReadOnly = false;
                    tbxCompanyName.ReadOnly = false;
                    tbxPubAddress.ReadOnly = false;
                    tbxPubCity.ReadOnly = false;
                    tbxPubState.ReadOnly = false;
                    tbxPubZip.ReadOnly = false;
                    tbxPubTelephone.ReadOnly = false;
                    tbxPubFAX.ReadOnly = false;
                    tbxPubComments.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    tbxPubName.Focus();
                    break;
            }
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox whichBox = (TextBox)sender;
            if ((int)e.KeyChar == 13)
            {
                switch (whichBox.Name)
                {
                    case "tbxPubName":
                        tbxCompanyName.Focus();
                        break;
                    case "tbxCompanyName":
                        tbxPubAddress.Focus();
                        break;
                    case "tbxPubAddress":
                        tbxPubCity.Focus();
                        break;
                    case "tbxPubCity":
                        tbxPubState.Focus();
                        break;
                    case "tbxPubState":
                        tbxPubZip.Focus();
                        break;
                    case "tbxPubZip":
                        tbxPubTelephone.Focus();
                        break;
                    case "tbxPubTelephone":
                        tbxPubFAX.Focus();
                        break;
                    case "tbxPubFAX":
                        tbxPubComments.Focus();
                        break;
                    case "tbxPubComments":
                        tbxPubName.Focus();
                        break;
                }
            }
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            // Check for name 
            if (tbxPubName.Text.Trim().Equals(""))
            {
                message = "You must enter a Publisher Name." + "\r\n";
                tbxPubName.Focus();
                allOK = false;
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
            //return to a view state at the end of Cancel
            SetState("View");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //We want to switch to Add state at the top of the code
                SetState("Add");
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error deleting record. Error 203.", "Delete Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ProgOps.DisposePub();
            this.Close();
        }
    }
}
