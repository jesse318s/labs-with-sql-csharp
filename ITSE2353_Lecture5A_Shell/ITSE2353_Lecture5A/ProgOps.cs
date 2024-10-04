using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace ITSE2353_Lecture5A
{
    class ProgOps
    {
        //connection string to phone database
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to phone database
        private static SqlConnection _cntPhoneDatabase = new SqlConnection(CONNECT_STRING);
        //add the command object
        private static SqlCommand _sqlPhoneCommand;
        //add the data adapter
        private static SqlDataAdapter _daPhone = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtPhoneTable = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();

        //prog ops getter
        public static DataTable PhoneTable
        {
            get { return _dtPhoneTable; }
        }

        public static void OpenDatabase()
        {
            //method to open database
            try
            {
                //open the connection to phone database
                _cntPhoneDatabase.Open();
                //message stating that connection to database was succesful
                MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                if(ex is SqlException)
                {//handles more specific SqlException here.
                    for(int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CloseDisposeDatabase()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntPhoneDatabase.Close();
                //message stating that connection to database was succesful
                MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dispose of the sql objects
                _cntPhoneDatabase.Dispose();
                _sqlPhoneCommand.Dispose();
                _daPhone.Dispose();
                _dtPhoneTable.Dispose();
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
                    MessageBox.Show(errorMessages.ToString(), "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
            
        }

        public static void DatabaseCommand(TextBox txID, TextBox txName, TextBox txNumber)
        {
            try
            {
                //statement for the command string
                string sqlStatement = "Select * From jsitessp222353.phoneTable ORDER BY ContactName";
                //establish command object
                _sqlPhoneCommand = new SqlCommand(sqlStatement, _cntPhoneDatabase);
                //establish data adapter
                _daPhone.SelectCommand = _sqlPhoneCommand;
                //fill data table
                _daPhone.Fill(_dtPhoneTable);
                //bind controls to data table
                txID.DataBindings.Add("Text", _dtPhoneTable, "ContactID");
                txName.DataBindings.Add("Text", _dtPhoneTable, "ContactName");
                txNumber.DataBindings.Add("Text", _dtPhoneTable, "ContactNumber");
            }
            catch(SqlException ex)
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
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }      
        }

        public static void UpdateOnClose()
        {
            try
            {
                //save the updated phone table
                SqlCommandBuilder phoneAdapterCommands = new SqlCommandBuilder(_daPhone);
                _daPhone.Update(_dtPhoneTable);
            }
            catch(SqlException ex)
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
