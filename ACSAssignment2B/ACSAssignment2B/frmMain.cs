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

namespace ACSAssignment2B
{
    public partial class frmMain : Form
    {
        SqlConnection dbConnection;
        //var to hold default sql statement
        String sqlAll;
        //array of buttons used to search
        Button[] arryBtnRolodex = new Button[26];
        public frmMain()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            dbConnection.Dispose();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection("Server=cstnt.tstc.edu;" +
                "Database= itse2353sp22;User Id=jsitessp222353;" +
                "password=1234567");
            dbConnection.Open();
            int width, length, top, left;
            int height = 33;
            width = Convert.ToInt32(this.ClientSize.Width / 14);
            //center buttons on form
            left = Convert.ToInt32(0.5 * (this.ClientSize.Width - 13 * width));
            length = left;
            top = dgvBooks.Top + dgvBooks.Height + 2;

            for(int i = 0; i < 26; i++)
            {
                //create new btn
                arryBtnRolodex[i] = new Button();
                arryBtnRolodex[i].TabStop = false;
                //set txt prop
                arryBtnRolodex[i].Text = ((char)(65 + i)).ToString();
                //position
                arryBtnRolodex[i].Width = width;
                arryBtnRolodex[i].Height = height;
                arryBtnRolodex[i].Left = length;
                arryBtnRolodex[i].Top = top;
                //color
                arryBtnRolodex[i].BackColor = Color.DarkOrchid;
                arryBtnRolodex[i].ForeColor = Color.White;
                //add butoon to form
                this.Controls.Add(arryBtnRolodex[i]);
                //event handler for btnSqlAll
                arryBtnRolodex[i].Click += new System.EventHandler(this.btnAll_Click);
                //next row
                length += width;
                if (i == 12)
                {
                    //move to next row
                    length = left;
                    top += height;
                }
            }
            //Build SQL statement
            sqlAll = "SELECT Authors.Author, Titles.Title, Publishers.Company_Name ";
            sqlAll += "FROM jsitessp222353.Authors, jsitessp222353.Titles, " +
                "jsitessp222353.Publishers, jsitessp222353.Title_Author " +
                "WHERE Titles.ISBN = Title_Author.ISBN " +
                "AND Authors.Au_ID = Title_Author.Au_ID " +
                "AND Titles.PubID = Publishers.PubID";
            this.Show();
            btnAll.PerformClick();

        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            String sqlStatement;
            //determine which button was clicked and create sql
            Button buttonClicked = (Button)sender;
            switch(buttonClicked.Text)
            {
                case "Show All Records":
                    sqlStatement = sqlAll;
                    break;
                case "Z":
                    //append to sqlAll and limit to Z Authors
                    sqlStatement = sqlAll + " AND Authors.Author > 'Z'";
                    break;
                default:
                    //letter other than z is clicked...append that letter
                    int index = (int)(Convert.ToChar(buttonClicked.Text)) - 65;
                    sqlStatement = sqlAll + " And Authors.Author > '" +
                        arryBtnRolodex[index].Text + "'";
                    sqlStatement += " AND Authors.Author < '" +
                        arryBtnRolodex[index+1].Text + "'";
                    break;

            }
            sqlStatement += " ORDER BY Authors.Author";
            //apply SQL
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvBooks.DataSource = resultsTable;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resultsCmd.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }

    }
}
