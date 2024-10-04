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

namespace ACS_LAB3A_SitesJ
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        CurrencyManager employeesManager;

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            //connect to employees database and open connection
            ProgOps.OpenDatabase();

            //call the database command with parameters of textboxes
            ProgOps.DatabaseCommand(tbxEmployeeID, tbxLastName, tbxFirstName, tbxExtension);

            //fill currency manager
            employeesManager = (CurrencyManager)this.BindingContext[ProgOps.EmployeesTable];

            //to be in View State when application is inititalized
            SetState("View");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to exit?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }

            try
            {
                //close the connection and dispose of all the database objects
                ProgOps.CloseDatabase();
                //Exit the Program
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error exiting application.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (employeesManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            employeesManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (employeesManager.Position == employeesManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            employeesManager.Position++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validates and "saves" record
            try
            {
                if (!ValidateData())
                {
                    return;
                }
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error saving record.  Error 104", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //"deletes" record
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }

            try
            {
                //record deletion code would go here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error deleting record. Error 103.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetState(string appState)
        {
            //create state cases
            switch (appState)
            {
                case "View":
                    tbxLastName.ReadOnly = true;
                    tbxFirstName.ReadOnly = true;
                    tbxExtension.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    break;
                case "Edit":
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    tbxExtension.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case "Add New":
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    tbxExtension.ReadOnly = false;
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //We want to switch to Add New state at the top of the code
                SetState("Add New");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error adding record.  Error 102", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //we want to switch to Edit state at the top of the code
                SetState("Edit");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error editing record. Error 101", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //return to a view state at the end of Cancel
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error canceling operation. Error 100", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            // Validation checks
            string message = "";
            int inputExtension = 0;
            bool allOK = true;
            try
            {
                // Check for last name 
                if (tbxLastName.Text.Trim().Equals(""))
                {
                    message += "You must enter a Last Name.\r\n";
                    tbxLastName.Focus();
                    allOK = false;
                }
                // Check for first name
                if (tbxFirstName.Text.Trim().Equals(""))
                {
                    message += "You must enter a First Name.\r\n";
                    tbxFirstName.Focus();
                    allOK = false;
                }
                // Check range on extension
                if (!tbxExtension.Text.Trim().Equals(""))
                {
                    inputExtension = Convert.ToInt32(tbxExtension.Text);
                    if (inputExtension > 8888 || inputExtension < 1111)
                    {
                        message = "Extension must be a number between 1111 and 8888.\r\n";
                        tbxExtension.Focus();
                        allOK = false;
                    }
                }
                if (!allOK)
                {
                    MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Validation process error.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (allOK);
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int inputExtension;
                //check range of extension
                if (!tbxExtension.Text.Trim().Equals(""))
                {
                    inputExtension = Convert.ToInt32(tbxExtension.Text);
                    if (inputExtension > 8888 || inputExtension < 1111)
                    {
                        e.Handled = true;
                        MessageBox.Show("Extension must be a number between 1111 and 8888.");
                        tbxExtension.Focus();
                    }
                }
                // Check for first name 
                if (tbxFirstName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a first name.");
                    tbxFirstName.Focus();
                }
                //convert lower
                if (tbxLastName.Text.Trim().Equals(""))
                {
                    if (char.IsLower(e.KeyChar))
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Last Name input error.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int inputExtension;
                //check range of extension
                if (!tbxExtension.Text.Trim().Equals(""))
                {
                    inputExtension = Convert.ToInt32(tbxExtension.Text);
                    if (inputExtension > 8888 || inputExtension < 1111)
                    {
                        e.Handled = true;
                        MessageBox.Show("Extension must be a number between 1111 and 8888.");
                        tbxExtension.Focus();
                    }
                }
                // Check for last name 
                if (tbxLastName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a last name.");
                    tbxLastName.Focus();
                }
                //convert lower
                if (tbxFirstName.Text.Trim().Equals(""))
                {
                    if (char.IsLower(e.KeyChar))
                    {
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " First Name input error.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            int inputNum = 0;
            bool isNumber = int.TryParse(e.KeyChar.ToString(), out inputNum);
            try
            {
                // Check for first name 
                if (tbxFirstName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a first name.");
                    tbxFirstName.Focus();
                }
                // Check for last name 
                if (tbxLastName.Text.Trim().Equals(""))
                {
                    e.Handled = true;
                    MessageBox.Show("You must enter a last name.");
                    tbxLastName.Focus();
                }
                //test extension key
                if (!(e.KeyChar == ((char)Keys.Back)))
                {
                    if (isNumber)
                    {
                        //check length of extension
                        if (tbxExtension.Text.Length > 3)
                        {
                            SystemSounds.Beep.Play();
                        }
                    }
                    else
                    {
                        //unacceptable keystroke
                        e.Handled = true;
                        //make it beep because its a unacceptable keypress
                        SystemSounds.Beep.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Extension input error.", "Employees Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
