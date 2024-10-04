using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitesJ_Lab05A_ACS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            //create an object of the Report
            CrystalReports.crptCustomer customer = new CrystalReports.crptCustomer();
            //set the database logon for the report
            customer.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an object of the frmViewer so we can use the crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = customer;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            //create an object of the Report
            CrystalReports.crptProductDiscontinuedEqualFalse product = new CrystalReports.crptProductDiscontinuedEqualFalse();
            //set the database logon for the report
            product.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an object of the frmViewer so we can use the crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = product;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void mnuMainItmEmployeeInfo_Click(object sender, EventArgs e)
        {
            //create an object of the Report
            CrystalReports.crptEmployee employee = new CrystalReports.crptEmployee();
            //set the database logon for the report
            employee.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an object of the frmViewer so we can use the crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = employee;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void mnuMainItmOrderInfo_Click(object sender, EventArgs e)
        {
            //create an object of the Report
            CrystalReports.crptOrderEmployeeIDGreaterThan4 order = new CrystalReports.crptOrderEmployeeIDGreaterThan4();
            //set the database logon for the report
            order.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an object of the frmViewer so we can use the crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = order;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void mnuMainItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
