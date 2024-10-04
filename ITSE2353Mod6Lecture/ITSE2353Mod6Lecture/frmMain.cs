using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSE2353Mod6Lecture
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            //create an obect of the Report
            CrystalReports.crptTitle title = new CrystalReports.crptTitle();
            //set the database logon for the report
            title.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an onject of the frmViewer so we can use crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = title;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void mnuMainItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMainItmGreaterThan200_Click(object sender, EventArgs e)
        {
            //create an obect of the Report
            CrystalReports.crptPubIDGreaterThan200 greater = new CrystalReports.crptPubIDGreaterThan200();
            //set the database logon for the report
            greater.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an onject of the frmViewer so we can use crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = greater;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void mnuMainItmLessThan1990_Click(object sender, EventArgs e)
        {
            //create an obect of the Report
            CrystalReports.crptYrPubLessThan1990 less = new CrystalReports.crptYrPubLessThan1990();
            //set the database logon for the report
            less.SetDatabaseLogon("jsitessp222353", "1234567");
            //create an onject of the frmViewer so we can use crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = less;
            //then show the form with the crvViewer on it
            viewer.Show();
        }
    }
}
