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

namespace ITSE2353_Lecture5A
{
    public partial class frmPhoneDB : Form
    {
        string myState;
        int myBookmark;
        public frmPhoneDB()
        {
            InitializeComponent();
        }

        CurrencyManager phoneManager;
        //variables to store the application state and any bookmark we use
        

        private void frmPhoneDB_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
            ProgOps.DatabaseCommand(tbxID, tbxName, tbxNumber);
            //establish currency manager to control buttons forward, back, next, last
            phoneManager = (CurrencyManager)this.BindingContext[ProgOps.PhoneTable];
            //add the SetState at the bottom 
            SetState("View");
        }

        private void frmPhoneDB_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(myState.Equals("Edit")|| myState.Equals("Add"))
            {
                MessageBox.Show("You must finish the current edit" +
                    "before stopping the application.", "Finish Edit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                ProgOps.UpdateOnClose();
                ProgOps.CloseDisposeDatabase();
            }
           
   
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {     
            phoneManager.Position = 0;
            SystemSounds.Beep.Play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(phoneManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            phoneManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (phoneManager.Position == phoneManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            phoneManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            phoneManager.Position = phoneManager.Count - 1;
            SystemSounds.Beep.Play();
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnExit.Enabled = true;
                    tbxID.BackColor = Color.White;
                    tbxID.ForeColor = Color.Black;
                    tbxName.ReadOnly = true;
                    tbxNumber.ReadOnly = true;
                    break;
                default: // "Edit" mode, "Add" mode  
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnExit.Enabled = false;
                    tbxID.BackColor = Color.Red;
                    tbxID.ForeColor = Color.White;
                    tbxName.ReadOnly = false;
                    tbxNumber.ReadOnly = false;
                    break;

            }
            tbxName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            phoneManager.EndCurrentEdit();
            ProgOps.PhoneTable.DefaultView.Sort = "ContactName";
            SetState("View");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            phoneManager.CancelCurrentEdit();
            if(myState.Equals("Add"))
            {
                phoneManager.Position = myBookmark;
            }
            SetState("View");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myBookmark = phoneManager.Position;
            SetState("Add");
            phoneManager.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this " +
                "record?", "Delete Record", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                ==DialogResult.Yes)
            {
                phoneManager.RemoveAt(phoneManager.Position);
            }
            SetState("View");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
