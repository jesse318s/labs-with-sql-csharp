using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ITSE2353_Lecture7_Shell
{
    class ProgOps
    {
        //connection string to books database
        //private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=itse2353sp20v2;User Id=teachksp202353;password=12345678";
        //build a connection to books database
        private static SqlConnection _cntBooksDatabase = new SqlConnection("Data Source= (LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename= " + Application.StartupPath + "\\SQLBooksDB.mdf; Integrated Security=True;" +
            "COnnect Timeout=30");
        //add the command object
        private static SqlCommand _sqlTitlesCommand;
        //add the data adapter
        private static SqlDataAdapter _daTitles = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtTitlesTable = new DataTable();
        private static StringBuilder _errorMessages = new StringBuilder();
        //publishers objects: Command, Adapter, and Table
        private static SqlCommand _sqlPublishersCommand;
        private static SqlDataAdapter _daPublishers = new SqlDataAdapter();
        private static DataTable _dtPublishersTable = new DataTable();



        //prog ops getter
        public static DataTable DTTitlesTable
        {
            get { return _dtTitlesTable; }
        }
        public static DataTable DTPublishersTable
        {
            get { return _dtPublishersTable; }
        }



        public static void OpenDatabase()
        {
            //method to open database
            try
            {
                //open the connection to phone database
                _cntBooksDatabase.Open();
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
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Open Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO1)", "Error Open Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CloseDisposeDatabase()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntBooksDatabase.Close();
                //message stating that connection to database was succesful
                MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dispose of the sql objects
                _cntBooksDatabase.Dispose();
                _sqlTitlesCommand.Dispose();
                _daTitles.Dispose();
                _dtTitlesTable.Dispose();
                //dispose of the sql command objects for publisher
                _sqlPublishersCommand.Dispose();
                _daPublishers.Dispose();
                _dtPublishersTable.Dispose();

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        public static void TitlesCommand(TextBox txTitle, TextBox txYear, MaskedTextBox txISBN, 
            TextBox txDesc, TextBox txNotes, TextBox txSubject, TextBox txComments, ComboBox cbPublisher)
        {
            try
            {
                //statement for the command string
                string sqlStatement = "Select * From Titles ORDER BY Title";
                //establish command object
                _sqlTitlesCommand = new SqlCommand(sqlStatement, _cntBooksDatabase);
                //establish data adapter
                _daTitles.SelectCommand = _sqlTitlesCommand;
                //fill data table
                _daTitles.Fill(_dtTitlesTable);
                //bind controls to data table
                txTitle.DataBindings.Add("Text", _dtTitlesTable, "Title");
                txYear.DataBindings.Add("Text", _dtTitlesTable, "Year_Published");
                txISBN.DataBindings.Add("Text", _dtTitlesTable, "ISBN");
                txDesc.DataBindings.Add("Text", _dtTitlesTable, "Description");
                txNotes.DataBindings.Add("Text", _dtTitlesTable, "Notes");
                txSubject.DataBindings.Add("Text", _dtTitlesTable, "Subject");
                txComments.DataBindings.Add("Text", _dtTitlesTable, "Comments");

                //establish a publisher table-combo box to pick publisher
                string sqlStatementP = "Select * From Publishers ORDER BY Name";
                _sqlPublishersCommand = new SqlCommand(sqlStatementP, _cntBooksDatabase);
                _daPublishers.SelectCommand = _sqlPublishersCommand;
                _daPublishers.Fill(_dtPublishersTable);
                cbPublisher.DataSource = _dtPublishersTable;
                cbPublisher.DisplayMember = "Name";
                cbPublisher.ValueMember = "PubID";
                cbPublisher.DataBindings.Add("SelectedItem", _dtPublishersTable, "PubID");
                cbPublisher.DataBindings.Add("SelectedValue", _dtTitlesTable, "PubID");
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Titles Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO3)", "Error Titles Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateTitlesOnClose()
        {
            try
            {
                //save the updated phone table
                SqlCommandBuilder titlesAdapterCommands = new SqlCommandBuilder(_daTitles);
                _daTitles.Update(_dtTitlesTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Update Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO4)", "Error Update Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void PublisherCommand(TextBox txPubID, TextBox txName, TextBox txCompanyName, TextBox txAddress, TextBox txCity, TextBox txState, TextBox txZip, TextBox txTelephone, TextBox txFAX, TextBox txComments)
        {//for Publishers Form Load Event
            
            try
            {
                string sqlStatementP = "Select * From Publishers ORDER BY Name";
                //establish the command object
                _sqlPublishersCommand = new SqlCommand(sqlStatementP, _cntBooksDatabase);
                //establish data adapter and data table
                _daPublishers = new SqlDataAdapter();
                _daPublishers.SelectCommand = _sqlPublishersCommand;
                _dtPublishersTable = new DataTable();
                _daPublishers.Fill(_dtPublishersTable);
                //bind controls to data table
                txPubID.DataBindings.Add("Text", _dtPublishersTable, "PubID");
                txName.DataBindings.Add("Text", _dtPublishersTable, "Name");
                txCompanyName.DataBindings.Add("Text", _dtPublishersTable, "Company_Name");
                txAddress.DataBindings.Add("Text", _dtPublishersTable, "Address");
                txCity.DataBindings.Add("Text", _dtPublishersTable, "City");
                txState.DataBindings.Add("Text", _dtPublishersTable, "State");
                txZip.DataBindings.Add("Text", _dtPublishersTable, "Zip");
                txTelephone.DataBindings.Add("Text", _dtPublishersTable, "Telephone");
                txFAX.DataBindings.Add("Text", _dtPublishersTable, "FAX");
                txComments.DataBindings.Add("Text", _dtPublishersTable, "Comments");
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Publishers Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO5)", "Error Publishers Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      
        public static void UpdatePublishersOnClose()
        {
            try
            {
                ////save the updated phone table
                SqlCommandBuilder publishersAdapterCommands = new SqlCommandBuilder(_daPublishers);
                _daPublishers.Update(_dtPublishersTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Update Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO7)", "Error Update Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
