using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ITSE2353_Lecture4A_Shell
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add the command object
        private static SqlCommand _sqlAuthorsCommand;
        //add the data adapter
        private static SqlDataAdapter _daAuthors = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtAuthorsTable = new DataTable();
        //objects for publishers table
        private static SqlCommand _sqlPublishersCommand;
        private static SqlDataAdapter _daPublishers = new SqlDataAdapter();
        private static DataTable _dtPublishersTable = new DataTable();

        //ProgOps getter
        public static DataTable DTAuthorsTable
        {
            get { return _dtAuthorsTable; }
        }

        public static DataTable DTPublishersTable
        {
            get { return _dtPublishersTable; }
        }


        public static void OpenDatabase()
        {
            //method to open database

            //open the connection to books database
            _cntDatabase.Open();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CloseDatabaseDispose()
        {
            //method to close database and dispose of the connection object

            //close connection
            _cntDatabase.Close();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dispose of the connection object and command, adapter and table objects
            _cntDatabase.Dispose();
            _sqlAuthorsCommand.Dispose();
            _daAuthors.Dispose();
            _dtAuthorsTable.Dispose();
           
        }

        public static void DatabaseCommand(TextBox tbAuthorID, TextBox tbAuthor, TextBox tbYearBorn)
        {
            
            try
            {
                //string to build the query
                string query = "SELECT * FROM jsitessp222353.Authors ORDER BY Author";
                //establish command object
                _sqlAuthorsCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daAuthors = new SqlDataAdapter();
                _daAuthors.SelectCommand = _sqlAuthorsCommand;
                //fill data table
                _dtAuthorsTable = new DataTable();
                _daAuthors.Fill(_dtAuthorsTable);
                //bind controls to the textboxes
                tbAuthorID.DataBindings.Add("Text", _dtAuthorsTable, "Au_ID");
                tbAuthor.DataBindings.Add("Text", _dtAuthorsTable, "Author");
                tbYearBorn.DataBindings.Add("Text", _dtAuthorsTable, "Year_Born");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in establishing Authors Table. Error 301.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void DatabaseCommandPub(TextBox tbPubID, TextBox tbPubName, TextBox tbCompName,
            TextBox tbPubAddr, TextBox tbPubCity, TextBox tbPubState, TextBox tbPubZip,
            TextBox tbPubPhone, TextBox tbPubFax, TextBox tbPubComments)
        {
            try
            {
                //string to build the query
                string query = "SELECT * FROM jsitessp222353.Publishers ORDER BY Name";
                //establish command object
                _sqlPublishersCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daPublishers = new SqlDataAdapter();
                _daPublishers.SelectCommand = _sqlPublishersCommand;
                //fill data table
                _dtPublishersTable = new DataTable();
                _daPublishers.Fill(_dtPublishersTable);
                //bind controls to the textboxes
                tbPubID.DataBindings.Add("Text", _dtPublishersTable, "PubID");
                tbPubName.DataBindings.Add("Text", _dtPublishersTable, "Name");
                tbCompName.DataBindings.Add("Text", _dtPublishersTable, "Company_Name");
                tbPubAddr.DataBindings.Add("Text", _dtPublishersTable, "Address");
                tbPubCity.DataBindings.Add("Text", _dtPublishersTable, "City");
                tbPubState.DataBindings.Add("Text", _dtPublishersTable, "State");
                tbPubZip.DataBindings.Add("Text", _dtPublishersTable, "Zip");
                tbPubPhone.DataBindings.Add("Text", _dtPublishersTable, "Telephone");
                tbPubFax.DataBindings.Add("Text", _dtPublishersTable, "Fax");
                tbPubComments.DataBindings.Add("Text", _dtPublishersTable, "Comments");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in establishing Publishers Table. " +
                    "Error 302.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public static void DisposePub()
        {
            //dispose of publishers objects
            _sqlPublishersCommand.Dispose();
            _daPublishers.Dispose();
            _dtPublishersTable.Dispose();
        }
    }
}
