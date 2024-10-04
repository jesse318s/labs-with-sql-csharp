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

namespace SitesJ_Lab6_ACS
{
    public partial class frmMain : Form
    {
        //instructor approved the lack of a ProgOps class
        SqlConnection dbConnection;
        String sqlStatement;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //point to help file
            hlpInstructions.HelpNamespace = Application.StartupPath + "\\INstructions.chm";

            //connect to db
            dbConnection = new SqlConnection("Server=cstnt.tstc.edu;" +
            "Database= SitesJsp22_MovieStore;User Id=jsitessp222353;" +
            "password=1234567");
            dbConnection.Open();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            sqlStatement = "SELECT * FROM Customers;";
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvMovieStore.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            sqlStatement = "SELECT * FROM Movies;";
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvMovieStore.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        private void btnPurchaseDetails_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            sqlStatement = "SELECT * FROM PurchaseDetails;";
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvMovieStore.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            sqlStatement = "SELECT * FROM Purchase;";
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvMovieStore.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            sqlStatement = "SELECT * FROM Payment;";
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvMovieStore.DataSource = resultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            //close and dispose db
            dbConnection.Close();
            dbConnection.Dispose();
            //message stating that closing database was succesful
            MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void mnuItemInstructions_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpInstructions.HelpNamespace);
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }
    }
}
