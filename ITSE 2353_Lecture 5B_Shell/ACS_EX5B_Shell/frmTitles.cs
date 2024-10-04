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
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }

        CurrencyManager titlesManager;
        string myState;
        int myBookmark;
   


        private void frmTitles_Load(object sender, EventArgs e)
        {
            try
            {
                // connect to books database 
                ProgOps.OpenDatabase();
                ProgOps.TitlesCommand(tbxTitle, tbxYear, tbxISBN, tbxDescription, tbxNotes,
                    tbxSubject, tbxComments, cbxPublisher);
                titlesManager = (CurrencyManager)this.BindingContext[ProgOps.DTTitlesTable];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Titles table." , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
            SetText();

        }

        private void frmTitles_FormClosing(object sender, FormClosingEventArgs e)
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
                    //save changes to database
                    ProgOps.UpdateTitlesOnClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving database to file: \r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // close the connection and dispose of sql objects
                ProgOps.CloseDisposeDatabase();   
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
            SystemSounds.Beep.Play();
            SetText();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            titlesManager.Position--;
            SetText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            titlesManager.Position++;
            SetText();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
            SystemSounds.Beep.Play();
            SetText();
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            return (allOK);
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    tbxTitle.ReadOnly = true;
                    tbxYear.ReadOnly = true;
                    tbxISBN.ReadOnly = true;
                    tbxISBN.BackColor = Color.White;
                    tbxISBN.ForeColor = Color.Black;
                    tbxDescription.ReadOnly = true;
                    tbxNotes.ReadOnly = true;
                    tbxSubject.ReadOnly = true;
                    tbxComments.ReadOnly = true;
                    gbxFindTitle.Enabled = true;
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnExit.Enabled = true;
                    tbxTitle.Focus();
                    cbxPublisher.Enabled = false;

                    break;
                default: // Add or Edit if not View 
                    tbxTitle.ReadOnly = false;
                    tbxYear.ReadOnly = false;
                    tbxISBN.ReadOnly = false;
                    if (myState.Equals("Edit"))
                    {
                        tbxISBN.BackColor = Color.Red;
                        tbxISBN.ForeColor = Color.White;
                        tbxISBN.ReadOnly = true;
                        tbxISBN.TabStop = false;
                    }
                    else
                    {
                        tbxISBN.TabStop = true;
                    }
                    tbxDescription.ReadOnly = false;
                    tbxNotes.ReadOnly = false;
                    tbxSubject.ReadOnly = false;
                    tbxComments.ReadOnly = false;
                    gbxFindTitle.Enabled = false;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnExit.Enabled = false;
                    tbxTitle.Focus();
                    cbxPublisher.Enabled = true;
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = titlesManager.Position;
                titlesManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                titlesManager.RemoveAt(titlesManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            titlesManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                titlesManager.Position = myBookmark;
            }
            SetState("View");
            SetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            string savedName = tbxTitle.Text;
            int savedRow;
            try
            {
                titlesManager.EndCurrentEdit();
                ProgOps.DTTitlesTable.DefaultView.Sort = "Title";
                savedRow = ProgOps.DTTitlesTable.DefaultView.Find(savedName);

                titlesManager.Position = savedRow;
                MessageBox.Show("Record Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tbxFind.Text.Equals(""))
            {
                return;
            }
            int savedRow = titlesManager.Position;
            DataRow[] foundRows;
            ProgOps.DTTitlesTable.DefaultView.Sort = "Title";
            foundRows = ProgOps.DTTitlesTable.Select("Title LIKE '" + tbxFind.Text + "*'");
            if(foundRows.Length == 0)
            {
                titlesManager.Position = savedRow;
            }
            else
            {
                titlesManager.Position = ProgOps.DTTitlesTable.DefaultView.Find(foundRows[0]["Title"]);
            }
            SetText();
        }

        private void SetText()
        {
            this.Text = "Titles - Record " + (titlesManager.Position + 1).ToString() + " of " + titlesManager.Count.ToString() + " Records";
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            frmPublishers pub = new frmPublishers();
            pub.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }
    }
}


