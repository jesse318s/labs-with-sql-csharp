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

namespace ACS_Lab1A_SitesJ
{
    public partial class frmCustomers : Form
    {
        //SqlConnection cntDatabase;
        CurrencyManager customersManager;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            //add textboxes to progops to use in createData method
            ProgOps.TbxCustomerID = tbxCustomerID;
            ProgOps.TbxCompanyName = tbxCompanyName;
            ProgOps.TbxContactName = tbxContactName;
            ProgOps.TbxContactTitle = tbxContactTitle;
            //create connection
            ProgOps.OpenCreateData();
            //establish currency manager
            customersManager = (CurrencyManager)BindingContext[ProgOps.DTCustomersTable];
            //close db and dispose
            ProgOps.CloseDisposeData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            customersManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            customersManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            customersManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            customersManager.Position = customersManager.Count - 1;
        }
    }
}
