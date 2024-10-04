using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace ACS_EX5B_Shell
{
    public partial class frmPublishers : Form
    {
        public frmPublishers()
        {
            InitializeComponent();
        }

        CurrencyManager publishersManager;
        string myState;
        int myBookmark;

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            try
            {
                //Command statement
                ProgOps.PublisherCommand(tbxPubID, tbxPubName, tbxCompanyName, tbxPubAddress, tbxPubCity, tbxPubState, tbxPubZip, tbxPubTelephone, tbxPubFAX, tbxPubComments);
                // establish currency manager 
                publishersManager = (CurrencyManager)this.BindingContext[ProgOps.DTPublishersTable];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error (P1) establishing Publishers table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
            SetText();
        }

        private void frmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("You must finish the current edit before stopping the application.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    // save changes to database
                    ProgOps.UpdatePublishersOnClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error (P2) saving database to file: \r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            publishersManager.Position--;
            SetText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == publishersManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            publishersManager.Position++;
            SetText();
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
                publishersManager.RemoveAt(publishersManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (P3) deleting record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            string savedName = tbxPubName.Text;
            int savedRow;
            try
            {
                publishersManager.EndCurrentEdit();
                ProgOps.DTPublishersTable.DefaultView.Sort = "Name";
                savedRow = ProgOps.DTPublishersTable.DefaultView.Find(savedName);
                publishersManager.Position = savedRow;
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (P4) saving record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }

        private void SetState(string appState)
        {
            myState = appState;
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
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    gbxFindPublisher.Enabled = true;
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
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    gbxFindPublisher.Enabled = false;
                    tbxPubName.Focus();
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = publishersManager.Position;
                publishersManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error P5) adding record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            publishersManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                publishersManager.Position = myBookmark;
            }
            SetState("View");
            SetText();
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            // Check for name
            if (tbxPubName.Text.Trim().Equals(""))
            {
                message = "You must enter an Publisher Name." + "\r\n";
                tbxPubName.Focus();
                allOK = false;
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
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
                    case "txtPubCity":
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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            publishersManager.Position = 0;
            SystemSounds.Beep.Play();
            SetText();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            publishersManager.Position = publishersManager.Count - 1;
            SystemSounds.Beep.Play();
            SetText();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ProgOps.DisposePub();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tbxFind.Text.Equals(""))
            {
                return;
            }
            int savedRow = publishersManager.Position;
            DataRow[] foundRows;
            ProgOps.DTPublishersTable.DefaultView.Sort = "Name";
            foundRows = ProgOps.DTPublishersTable.Select("Name LIKE '" + tbxFind.Text + "*'");
            if (foundRows.Length == 0)
            {
                publishersManager.Position = savedRow;
            }
            else
            {
                publishersManager.Position = ProgOps.DTPublishersTable.DefaultView.Find(foundRows[0]["Name"]);
            }

        }

        private void SetText()
        {
            this.Text = "Publishers - Record " + (publishersManager.Position + 1).ToString() + 
                " of " + publishersManager.Count.ToString() + " Records";
        }
    }
}
