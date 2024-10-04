using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ACS_Lab1A_SitesJ
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to books db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add cmd object
        private static SqlCommand _sqlCustomersCommand;
        //add the data adapter
        private static SqlDataAdapter _daCustomers = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtCustomersTable = new DataTable();

        //textboxes from frmTitles
        private static TextBox _tbxCustomerID;
        private static TextBox _tbxCompanyName;
        private static TextBox _tbxContactName;
        private static TextBox _tbxContactTitle;

        //setters and getters from frmTitles
        public static TextBox TbxCustomerID
        {
            get { return _tbxCustomerID; }
            set { _tbxCustomerID = value; }
        }
        public static TextBox TbxCompanyName
        {
            get { return _tbxCompanyName; }
            set { _tbxCompanyName = value; }
        }
        public static TextBox TbxContactName
        {
            get { return _tbxContactName; }
            set { _tbxContactName = value; }
        }
        public static TextBox TbxContactTitle
        {
            get { return _tbxContactTitle; }
            set { _tbxContactTitle = value; }
        }

        //setters and getters for ProgOps

        public static DataTable DTCustomersTable
        {
            get { return _dtCustomersTable; }
            set { _dtCustomersTable = value; }
        }
        public static void OpenCreateData()
        {
            //method to open db and to allow use of data
            //open connection to books database
            _cntDatabase.Open();
            //establish cmd object
            _sqlCustomersCommand = new SqlCommand("Select * From jsitessp222353.Customers", _cntDatabase);
            //est data adapter
            _daCustomers.SelectCommand = _sqlCustomersCommand;
            //est data table
            _daCustomers.Fill(_dtCustomersTable);
            //bind
            TbxCustomerID.DataBindings.Add("Text", _dtCustomersTable, "CustomerID");
            TbxCompanyName.DataBindings.Add("Text", _dtCustomersTable, "CompanyName");
            TbxContactName.DataBindings.Add("Text", _dtCustomersTable, "ContactName");
            TbxContactTitle.DataBindings.Add("Text", _dtCustomersTable, "ContactTitle");
        }

        public static void CloseDisposeData()
        {
            //method to close data and dispose of all objects
            //close connection
            _cntDatabase.Close();
            //dispose of connection and command objects
            _cntDatabase.Dispose();
            _sqlCustomersCommand.Dispose();
            _daCustomers.Dispose();
            _dtCustomersTable.Dispose();
        }
    }
}
