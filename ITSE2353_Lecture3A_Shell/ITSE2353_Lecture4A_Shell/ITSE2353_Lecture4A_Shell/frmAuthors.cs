using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //using for database
using System.Media;             //using for beeps, sounds

namespace ITSE2353_Lecture4A_Shell
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        CurrencyManager authorsManager;

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            //connect to books database and open connection
            ProgOps.OpenDatabase();

            //call the database command with parameters of textboxes
            ProgOps.DatabaseCommand(tbxAuthorID, tbxAuthorName, tbxYearBorn);

            //fill currency manager
            authorsManager = (CurrencyManager)this.BindingContext[ProgOps.AuthorsTable];

            //to be in View State when application is inititalized
            this.Show();
            SetState("View");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the connection and dispose of all the database objects
            ProgOps.CloseDatabase();
            
            //Exit the Program
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(authorsManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            authorsManager.Position--;
          
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (authorsManager.Position == authorsManager.Count -1)
            {
                SystemSounds.Beep.Play();
            }
            authorsManager.Position++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(!ValidateData())
            {
                return;
            }
            
            try
            {
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return to a view state at the end of Save
                SetState("View");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult response;
                response = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if(response == DialogResult.No)
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    tbxAuthorID.BackColor = Color.White;
                    tbxAuthorID.ForeColor = Color.Black;
                    tbxAuthorName.ReadOnly = true;
                    tbxYearBorn.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    tbxAuthorName.Focus();
                    break;
                default: // Add or Edit if not View 
                    tbxAuthorID.BackColor = Color.Red;
                    tbxAuthorID.ForeColor = Color.White;
                    tbxAuthorName.ReadOnly = false;
                    tbxYearBorn.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    tbxAuthorName.Focus();
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //We want to switch to Add state at the top of the code
                SetState("Add");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error adding record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //we want to switch to Edit state at the top of the code
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //return to a view state at the end of Cancel
            SetState("View");
        }

        private void txtYearBorn_KeyPress(object sender, KeyPressEventArgs e)
        {
           if((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                //acceptable keystrokes
                e.Handled = false;
            }
           else if((int)e.KeyChar == 13)
            {
                tbxAuthorName.Focus();
            }
           else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private bool ValidateData()
        {
            string message = "";
            int inputYear, currentYear;
            bool allOK = true;
            // Check for name 
            if (tbxAuthorName.Text.Trim().Equals(""))
            {
                message = "You must enter an Author Name." + "\r\n";
                tbxAuthorName.Focus();
                allOK = false;
            }
            // Check length and range on Year Born 
            if (!tbxYearBorn.Text.Trim().Equals(""))
            {
                inputYear = Convert.ToInt32(tbxYearBorn.Text);
                currentYear = DateTime.Now.Year;
                if (inputYear > currentYear || inputYear < currentYear - 150)
                {
                    message += "Year born must be between " + (currentYear - 150).ToString() + " and " + currentYear.ToString();
                    tbxYearBorn.Focus();
                    allOK = false;
                }
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void tbxAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == 13)
            {
                tbxYearBorn.Focus();
            }
        }
    }
}
