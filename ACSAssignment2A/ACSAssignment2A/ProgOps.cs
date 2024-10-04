using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ACSAssignment2A
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to books db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add cmd object
        private static SqlCommand _sqlResultsCommand;
        //add the data adapter
        private static SqlDataAdapter _daResults = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtResultsTable = new DataTable();

//setters and getters for ProgOps

        //public static DataTable DTResultsTable
        //{
        //    get { return _dtResultsTable; }
        //    set { _dtResultsTable = value; }
        //}
        public static void OpenDatabase()
        {
            //method to open db and to allow use of data
            //open connection to books database
            _cntDatabase.Open();
            //message saving connection was success
            MessageBox.Show("Connection to db was opened successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void CloseDatabase()
        {
            //close connection
            _cntDatabase.Close();
            //dispose of db
            _cntDatabase.Dispose();
            MessageBox.Show("Connection to db was closed successfully",
            "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void DatabaseCommand(TextBox tbxTester, DataGridView dgvTester, Label lblRecords)
        {
            //set cmd obj to null
            _sqlResultsCommand = null;
            //reset data adapter and datatable to new
            _daResults = new SqlDataAdapter();
            _dtResultsTable = new DataTable();

            try
            {
                //est cmd obj
                _sqlResultsCommand = new SqlCommand(tbxTester.Text, _cntDatabase);
                //est data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill data table
                _daResults.Fill(_dtResultsTable);
                //bind dgv to data table
                dgvTester.DataSource = _dtResultsTable;
                //display number of results 
                lblRecords.Text = _dtResultsTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of cmd, adapter, and table obj
            _sqlResultsCommand.Dispose();
            _daResults.Dispose();
            _dtResultsTable.Dispose();

        }
    }
}
