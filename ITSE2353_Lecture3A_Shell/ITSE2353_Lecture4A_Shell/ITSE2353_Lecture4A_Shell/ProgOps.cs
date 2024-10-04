using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITSE2353_Lecture4A_Shell
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= itse2353sp22;User Id=jsitessp222353;password=1234567";
        //build a connection to books db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add cmd object
        private static SqlCommand _sqlAuthorsCommand;
        //add the data adapter
        private static SqlDataAdapter _daAuthors = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtAuthorsTable = new DataTable();

        //setters and getters for ProgOps
        public static DataTable AuthorsTable
        {//just have to get this object in the main form
            get { return _dtAuthorsTable; }
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
            _sqlAuthorsCommand.Dispose();
            _daAuthors.Dispose();
            _dtAuthorsTable.Dispose();
        }
        public static void DatabaseCommand(TextBox tbAuthorID, TextBox tbAuthor, TextBox tbYearBorn)
        {
            try
            {
                //string to build query
                string query = "SELECT * FROM jsitessp222353.Authors ORDER BY Author";
                //est cmd obj
                _sqlAuthorsCommand = new SqlCommand(query, _cntDatabase);
                //est data adapter
                _daAuthors = new SqlDataAdapter();
                _daAuthors.SelectCommand = _sqlAuthorsCommand;
                //fill data table
                _dtAuthorsTable = new DataTable();
                _daAuthors.Fill(_dtAuthorsTable);
                //bind to controls to data table
                tbAuthorID.DataBindings.Add("Text", _dtAuthorsTable, "Au_ID");
                tbAuthor.DataBindings.Add("Text", _dtAuthorsTable, "Author");
                tbYearBorn.DataBindings.Add("Text", _dtAuthorsTable, "Year_Born");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
