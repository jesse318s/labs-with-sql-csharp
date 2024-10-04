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

namespace ACS_Lab2B_SitesJ
{
    public partial class frmMain : Form
    {
        SqlConnection dbConnection;
        //array of buttons used to search
        Button[] arryBtnRolodex1 = new Button[9];
        Button[] arryBtnRolodex2 = new Button[6];
        Button[] arryBtnRolodex3 = new Button[6];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //build connection to database
            dbConnection = new SqlConnection("Server=cstnt.tstc.edu;" +
            "Database= itse2353sp22;User Id=jsitessp222353;" +
            "password=1234567");
            //open connection to database
            dbConnection.Open();
            //message saying connection was success
            MessageBox.Show("Connection to db was opened successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int width, length, top, left;
            int height = 33;
            width = Convert.ToInt32(this.ClientSize.Width / 9);
            //center buttons on form
            left = Convert.ToInt32(0.5 * (this.ClientSize.Width - 9 * width));
            length = left;
            top = lblOptions1.Top + lblOptions1.Height + 2;

            //populate first button array
            for (int i = 0; i < 9; i++)
            {
                //create new btn
                arryBtnRolodex1[i] = new Button();
                arryBtnRolodex1[i].TabStop = false;
                //set txt prop
                arryBtnRolodex1[i].Text = "#&" + (i + 1).ToString();
                //position
                arryBtnRolodex1[i].Width = width;
                arryBtnRolodex1[i].Height = height;
                arryBtnRolodex1[i].Left = length;
                arryBtnRolodex1[i].Top = top;
                //color
                arryBtnRolodex1[i].BackColor = Color.Blue;
                arryBtnRolodex1[i].ForeColor = Color.White;
                //add butoon to form
                this.Controls.Add(arryBtnRolodex1[i]);
                //event handler for btnSqlAll
                arryBtnRolodex1[i].Click += new System.EventHandler(this.btnAll_Click);
                length += width;
            }

            //resize width
            width = Convert.ToInt32(this.ClientSize.Width / 6);
            //center buttons on form
            left = Convert.ToInt32(0.5 * (this.ClientSize.Width - 6 * width));
            //reset length to the value of left
            length = left;

            //populate second button array
            for (int i = 0; i < 6; i++)
            {
                //change top to next label
                top = lblOptions2.Top + lblOptions2.Height + 2;
                //create new btn
                arryBtnRolodex2[i] = new Button();
                arryBtnRolodex2[i].TabStop = false;
                //set txt prop
                arryBtnRolodex2[i].Text = ("&" + (char)(65 + i)).ToString() + ": UnitsInStock";
                switch (i)
                {
                    case 0:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " <= 10";
                        break;
                    case 1:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " > 10, < 20";
                        break;
                    case 2:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " >= 20, <= 26";
                        break;
                    case 3:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " > 26, < 40";
                        break;
                    case 4:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " >= 40, <= 80";
                        break;
                    case 5:
                        arryBtnRolodex2[i].Text = arryBtnRolodex2[i].Text + " > 80";
                        break;

                }
                //position
                arryBtnRolodex2[i].Width = width;
                arryBtnRolodex2[i].Height = height;
                arryBtnRolodex2[i].Left = length;
                arryBtnRolodex2[i].Top = top;
                //color
                arryBtnRolodex2[i].BackColor = Color.Yellow;
                arryBtnRolodex2[i].ForeColor = Color.DarkGreen;
                //add butoon to form
                this.Controls.Add(arryBtnRolodex2[i]);
                //event handler for btnSqlAll
                arryBtnRolodex2[i].Click += new System.EventHandler(this.btnAll_Click);
                length += width;
            }

            //resize width
            width = Convert.ToInt32(this.ClientSize.Width / 6);
            //center buttons on form
            left = Convert.ToInt32(0.5 * (this.ClientSize.Width - 6 * width));
            //reset length to the value of left
            length = left;

            //populate third button array
            for (int i = 0; i < 6; i++)
            {
                //change top to next label
                top = lblOptions3.Top + lblOptions3.Height + 2;
                //create new btn
                arryBtnRolodex3[i] = new Button();
                arryBtnRolodex3[i].TabStop = false;
                //set txt prop
                arryBtnRolodex3[i].Text = ((char)(71 + i)).ToString() + ": UnitPrice";
                switch (i)
                {
                    case 0:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " <= 10.00";
                        break;
                    case 1:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " > 10.00, <= 16.00";
                        break;
                    case 2:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " > 16.00, <= 20.00";
                        break;
                    case 3:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " > 20.00, <= 30.00";
                        break;
                    case 4:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " > 30.00, <= 50.00";
                        break;
                    case 5:
                        arryBtnRolodex3[i].Text = arryBtnRolodex3[i].Text + " > 50.00";
                        break;

                }
                //position
                arryBtnRolodex3[i].Width = width;
                arryBtnRolodex3[i].Height = height;
                arryBtnRolodex3[i].Left = length;
                arryBtnRolodex3[i].Top = top;
                //color
                arryBtnRolodex3[i].BackColor = Color.DodgerBlue;
                arryBtnRolodex3[i].ForeColor = Color.OrangeRed;
                //add butoon to form
                this.Controls.Add(arryBtnRolodex3[i]);
                //event handler for btnSqlAll
                arryBtnRolodex3[i].Click += new System.EventHandler(this.btnAll_Click);
                length += width;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close connection
            dbConnection.Close();
            //dispose of db
            dbConnection.Dispose();
            MessageBox.Show("Connection to db was closed successfully",
            "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //exit application
            Application.Exit();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the instructions form
            frmInstructions frmInstructions = new frmInstructions();
            frmInstructions.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the about form
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCmd = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();
            DataTable resultsTable = new DataTable();
            String sqlStatement = "SELECT ";
            //determine which button was clicked and create sql
            Button buttonClicked = (Button)sender;
            //commands for units in stock
            if (buttonClicked.Text.Contains("UnitsInStock"))
            {
                //determine comparison
                if (buttonClicked.Text.Contains("<= 10"))
                {
                    sqlStatement += "* FROM jsitessp222353.Products WHERE UnitsInStock <= 10;";
                }
                else if (buttonClicked.Text.Contains("> 10"))
                {
                    sqlStatement += "ProductID, ProductName, UnitPrice FROM jsitessp222353.Products " +
                        "WHERE UnitsInStock > 10 AND UnitsInStock < 20 ORDER BY ProductName, UnitPrice DESC;";
                }
                else if (buttonClicked.Text.Contains(">= 20"))
                {
                    sqlStatement += "ProductName, Products.SupplierID, CompanyName, Address, City, Region, Country " +
                        "FROM jsitessp222353.Products, jsitessp222353.Suppliers WHERE UnitsInStock >= 20 AND UnitsInStock <= 26 " +
                        "ORDER BY Country, CompanyName;";
                }
                else if (buttonClicked.Text.Contains("> 26"))
                {
                    sqlStatement += "ProductName, CategoryID, CompanyName, Suppliers.SupplierID " +
                        "FROM jsitessp222353.Products, jsitessp222353.Suppliers WHERE UnitsInStock > 26 AND UnitsInStock < 40 " +
                        "ORDER BY CategoryID, SupplierID;";
                }
                else if (buttonClicked.Text.Contains(">= 40"))
                {
                    sqlStatement += "ProductName, CompanyName, CategoryName " +
                        "FROM jsitessp222353.Products, jsitessp222353.Suppliers, jsitessp222353.Categories " +
                        "WHERE UnitsInStock >= 40 AND UnitsInStock <= 80 ORDER BY CompanyName, CategoryName, ProductName DESC;";
                }
                else
                {
                    sqlStatement += "* FROM jsitessp222353.Products WHERE UnitsInStock > 80 ORDER BY ProductName, UnitPrice, SupplierID DESC;";
                }
            }
            //commands for unit price in stock
            else if (buttonClicked.Text.Contains("UnitPrice"))
            {
                //determine comparison
                if (buttonClicked.Text.Contains("<= 10"))
                {
                    sqlStatement += "* FROM jsitessp222353.Products, jsitessp222353.Categories WHERE UnitPrice <= 10.00;";
                }
                else if (buttonClicked.Text.Contains("> 10"))
                {
                    sqlStatement += "ProductName, CategoryName, CompanyName " +
                        "FROM jsitessp222353.Products, jsitessp222353.Categories, jsitessp222353.Suppliers " +
                        "WHERE UnitPrice > 10.00 AND UnitPrice <= 16.00 ORDER BY CategoryName DESC;";
                }
                else if (buttonClicked.Text.Contains("> 16"))
                {
                    sqlStatement += "ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder FROM jsitessp222353.Products " +
                        "WHERE UnitPrice > 16.00 AND UnitPrice <= 20.00 ORDER BY UnitPrice;";
                }
                else if (buttonClicked.Text.Contains("> 20"))
                {
                    sqlStatement += "ProductID, ProductName, Categories.CategoryID, CategoryName " +
                        "FROM jsitessp222353.Products, jsitessp222353.Categories " +
                        "WHERE UnitPrice > 20.00 AND UnitPrice <= 30.00 ORDER BY ProductID DESC;";
                }
                else if (buttonClicked.Text.Contains("> 30"))
                {
                    sqlStatement += "ProductName FROM jsitessp222353.Products WHERE UnitPrice > 30.00 AND UnitPrice <= 50.00;";
                }
                else
                {
                    sqlStatement += "* FROM jsitessp222353.Products WHERE UnitPrice > 50.00 ORDER BY CategoryID DESC;";
                }
            }
            else
            {
                //switch by first product id number
                switch (buttonClicked.Text.Substring(2))
                {
                    case "1":
                        sqlStatement += "ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM jsitessp222353.Products " +
                            "WHERE ProductID LIKE '1%';";
                        break;
                    case "2":
                        sqlStatement += "ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM jsitessp222353.Products " +
                            "WHERE ProductID LIKE '2%' ORDER BY ProductID DESC;";
                        break;
                    case "3":
                        sqlStatement += "ProductID, ProductName FROM jsitessp222353.Products WHERE ProductID LIKE '3%';";
                        break;
                    case "4":
                        sqlStatement += "ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM jsitessp222353.Products " +
                            "WHERE ProductID LIKE '4%' ORDER BY ProductName DESC;";
                        break;
                    case "5":
                        sqlStatement += "ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM jsitessp222353.Products " +
                            "WHERE ProductID LIKE '5%' ORDER BY UnitPrice, ProductName DESC;";
                        break;
                    case "6":
                        sqlStatement += "ProductID, ProductName, UnitPrice, UnitsInStock, CategoryName, Description " +
                            "FROM jsitessp222353.Products, jsitessp222353.Categories WHERE ProductID LIKE '6%' ORDER BY ProductName, CategoryName;";
                        break;
                    case "7":
                        sqlStatement += "ProductID, ProductName, Categories.CategoryID, CategoryName, Description " +
                            "FROM jsitessp222353.Products, jsitessp222353.Categories WHERE ProductID LIKE '7%' ORDER BY ProductID DESC;";
                        break;
                    case "8":
                        sqlStatement += "ProductID, ProductName, UnitPrice, UnitsInStock, Categories.CategoryID, CategoryName, Description " +
                            "FROM jsitessp222353.Products, jsitessp222353.Categories WHERE ProductID LIKE '8%' ORDER BY CategoryID, ProductName DESC;";
                        break;
                    case "9":
                        sqlStatement += "* FROM jsitessp222353.Products WHERE ProductID LIKE '9%';";
                        break;

                }
            }
            //apply SQL
            try
            {
                //est cmd obj and da
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                resultsAdapter.SelectCommand = resultsCmd;
                resultsAdapter.Fill(resultsTable);
                //bind grid to table
                dgvResult.DataSource = resultsTable;

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
    }
}
