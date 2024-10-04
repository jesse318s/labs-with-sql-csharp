using System;
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
        //objects for suppliers table
        private static SqlCommand _sqlSuppliersCommand;
        private static SqlDataAdapter _daSuppliers = new SqlDataAdapter();
        private static DataTable _dtSuppliersTable = new DataTable();
        //objects for orders table
        private static SqlCommand _sqlOrdersCommand;
        private static SqlDataAdapter _daOrders = new SqlDataAdapter();
        private static DataTable _dtOrdersTable = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();
        public static string employeeID;

        //setters and getters for ProgOps
        public static DataTable EmployeesTable
        {//just have to get this object in the main form
            get { return _dtEmployeesTable; }
        }

        public static DataTable SuppliersTable
        {
            get { return _dtSuppliersTable; }
        }

        public static DataTable OrdersTable
        {
            get { return _dtOrdersTable; }
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

        public static void UpdateOnClose()
        {
            try
            {
                //save the updated employees table
                SqlCommandBuilder employeesAdapterCommands = new SqlCommandBuilder(_daEmployees);
                _daEmployees.Update(_dtEmployeesTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DatabaseCommandSup(TextBox tbSupplierID, TextBox tbCompanyName, TextBox tbContactName,
        TextBox tbContactTitle, TextBox tbPhone)
        {
            try
            {
                //string to build the query
                string query = "SELECT * FROM jsitessp222353.Suppliers ORDER BY SupplierID";
                //establish command object
                _sqlSuppliersCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daSuppliers = new SqlDataAdapter();
                _daSuppliers.SelectCommand = _sqlSuppliersCommand;
                //fill data table
                _dtSuppliersTable = new DataTable();
                _daSuppliers.Fill(_dtSuppliersTable);
                //bind controls to the textboxes
                tbSupplierID.DataBindings.Add("Text", _dtSuppliersTable, "SupplierID");
                tbCompanyName.DataBindings.Add("Text", _dtSuppliersTable, "CompanyName");
                tbContactName.DataBindings.Add("Text", _dtSuppliersTable, "ContactName");
                tbContactTitle.DataBindings.Add("Text", _dtSuppliersTable, "ContactTitle");
                tbPhone.DataBindings.Add("Text", _dtSuppliersTable, "Phone");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in establishing Suppliers Table. " +
                    "Error 302.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisposeSup()
        {
            //dispose of Suppliers objects
            _sqlSuppliersCommand.Dispose();
            _daSuppliers.Dispose();
            _dtSuppliersTable.Dispose();
        }

        public static void DatabaseCommandOrd(TextBox tbOrderID, TextBox tbCustomerID, TextBox tbEmployeeID, TextBox tbOrderDate, TextBox tbRequiredDate,
            TextBox tbShippedDate, TextBox tbShipVia, TextBox tbFreight, TextBox tbShipName, TextBox tbShipAddress, TextBox tbShipCity, TextBox tbShipRegion,
            TextBox tbShipPostalCode, TextBox tbShipCountry)
        {
            try
            {
                //string to build the query
                string query = "SELECT * FROM jsitessp222353.Orders WHERE EmployeeID = " + employeeID + "ORDER BY CustomerID";
                //establish command object
                _sqlOrdersCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daOrders = new SqlDataAdapter();
                _daOrders.SelectCommand = _sqlOrdersCommand;
                //fill data table
                _dtOrdersTable = new DataTable();
                _daOrders.Fill(_dtOrdersTable);
                //bind controls to the textboxes
                tbOrderID.DataBindings.Add("Text", _dtOrdersTable, "OrderID");
                tbCustomerID.DataBindings.Add("Text", _dtOrdersTable, "CustomerID");
                tbEmployeeID.DataBindings.Add("Text", _dtOrdersTable, "EmployeeID");
                tbOrderDate.DataBindings.Add("Text", _dtOrdersTable, "OrderDate");
                tbRequiredDate.DataBindings.Add("Text", _dtOrdersTable, "RequiredDate");
                tbShippedDate.DataBindings.Add("Text", _dtOrdersTable, "ShippedDate");
                tbShipVia.DataBindings.Add("Text", _dtOrdersTable, "ShipVia");
                tbFreight.DataBindings.Add("Text", _dtOrdersTable, "Freight");
                tbShipName.DataBindings.Add("Text", _dtOrdersTable, "ShipName");
                tbShipAddress.DataBindings.Add("Text", _dtOrdersTable, "ShipAddress");
                tbShipCity.DataBindings.Add("Text", _dtOrdersTable, "ShipCity");
                tbShipRegion.DataBindings.Add("Text", _dtOrdersTable, "ShipRegion");
                tbShipPostalCode.DataBindings.Add("Text", _dtOrdersTable, "ShipPostalCode");
                tbShipCountry.DataBindings.Add("Text", _dtOrdersTable, "ShipCountry");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in establishing Orders Table. " +
                    "Error 302.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisposeOrd()
        {
            //dispose of Suppliers objects
            _sqlOrdersCommand.Dispose();
            _daOrders.Dispose();
            _dtOrdersTable.Dispose();
        }

        public static void UpdateOnCloseOrd()
        {
            try
            {
                //save the updated orders table
                SqlCommandBuilder ordersAdapterCommands = new SqlCommandBuilder(_daOrders);
                _daOrders.Update(_dtOrdersTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
