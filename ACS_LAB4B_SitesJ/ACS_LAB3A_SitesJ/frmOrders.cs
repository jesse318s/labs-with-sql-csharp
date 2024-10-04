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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        CurrencyManager ordersManager;
        string myState;
        int myBookmark;

        private void frmOrders_Load(object sender, EventArgs e)
        {
            //call the database command with parameters of textboxes
            ProgOps.DatabaseCommandOrd(tbxOrderID, tbxCustomerID, tbxEmployeeID, tbxOrderDate, tbxRequiredDate, tbxShippedDate, tbxShipVia,
                tbxFreight, tbxShipName, tbxShipAddress, tbxShipCity, tbxShipRegion, tbxShipPostalCode, tbxShipCountry);

            //fill currency manager
            ordersManager = (CurrencyManager)this.BindingContext[ProgOps.OrdersTable];

            //to be in View State when application is inititalized
            SetState("View");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ordersManager.Position = 0;
            SystemSounds.Beep.Play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ordersManager.Position == 0)
            {
                SystemSounds.Beep.Play();
            }
            ordersManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ordersManager.Position == ordersManager.Count - 1)
            {
                SystemSounds.Beep.Play();
            }
            ordersManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ordersManager.Position = ordersManager.Count - 1;
            SystemSounds.Beep.Play();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbxEmployeeID.Text = ProgOps.employeeID;
            ordersManager.EndCurrentEdit();
            MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetState("View");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ordersManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                ordersManager.Position = myBookmark;
            }
            SetState("View");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            myBookmark = ordersManager.Position;
            ordersManager.AddNew();
            SetState("Add");
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
                ordersManager.RemoveAt(ordersManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            ProgOps.UpdateOnCloseOrd();
            ProgOps.DisposeOrd();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form displays a list of all orders under the EmployeeID in the main form." +
                "The EmployeeID, CustomerID, and OrderID can't be edited." +
                "You may delete records, edit, and add records under the current EmployeeID.");
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    tbxOrderDate.ReadOnly = true;
                    tbxRequiredDate.ReadOnly = true;
                    tbxShippedDate.ReadOnly = true;
                    tbxShipVia.ReadOnly = true;
                    tbxFreight.ReadOnly = true;
                    tbxShipName.ReadOnly = true;
                    tbxShipAddress.ReadOnly = true;
                    tbxShipCity.ReadOnly = true;
                    tbxShipRegion.ReadOnly = true;
                    tbxShipPostalCode.ReadOnly = true;
                    tbxShipCountry.ReadOnly = true;
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAddNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnReturnToMain.Enabled = true;
                    btnHelp.Enabled = true;
                    break;
                default: // Add or Edit if not View
                    tbxOrderDate.ReadOnly = false;
                    tbxRequiredDate.ReadOnly = false;
                    tbxShippedDate.ReadOnly = false;
                    tbxShipVia.ReadOnly = false;
                    tbxFreight.ReadOnly = false;
                    tbxShipName.ReadOnly = false;
                    tbxShipAddress.ReadOnly = false;
                    tbxShipCity.ReadOnly = false;
                    tbxShipRegion.ReadOnly = false;
                    tbxShipPostalCode.ReadOnly = false;
                    tbxShipCountry.ReadOnly = false;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAddNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnReturnToMain.Enabled = false;
                    btnHelp.Enabled = true;
                    break;
            }
        }
    }
}
