﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ACS_LAB3A_SitesJ
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to books db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add cmd object
        private static SqlCommand _sqlEmployeesCommand;
        //add the data adapter
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtEmployeesTable = new DataTable();

        //setters and getters for ProgOps
        public static DataTable EmployeesTable
        {//just have to get this object in the main form
            get { return _dtEmployeesTable; }
        }

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
            MessageBox.Show("Connection to db was closed successfully",
            "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dispose of connection, cmd, adapter, and table obj
            _cntDatabase.Dispose();
            _sqlEmployeesCommand.Dispose();
            _daEmployees.Dispose();
            _dtEmployeesTable.Dispose();
        }
        public static void DatabaseCommand(TextBox tbEmployeeID, TextBox tbLastName, TextBox tbFirstName, TextBox tbExtension)
        {
            try
            {
                //string to build query
                string query = "SELECT * FROM jsitessp222353.Employees ORDER BY EmployeeID";
                //est cmd obj
                _sqlEmployeesCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daEmployees = new SqlDataAdapter();
                _daEmployees.SelectCommand = _sqlEmployeesCommand;
                //fill data table
                _dtEmployeesTable = new DataTable();
                _daEmployees.Fill(_dtEmployeesTable);
                //bind to controls to data table
                tbEmployeeID.DataBindings.Add("Text", _dtEmployeesTable, "EmployeeID");
                tbLastName.DataBindings.Add("Text", _dtEmployeesTable, "LastName");
                tbFirstName.DataBindings.Add("Text", _dtEmployeesTable, "FirstName");
                tbExtension.DataBindings.Add("Text", _dtEmployeesTable, "Extension");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
