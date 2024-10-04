using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_Lab2A_SitesJ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //open the database when the first form loads
            ProgOps.OpenDatabase();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the database when the exit button is clicked
            ProgOps.CloseDatabase();
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

        private void btn1_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT * FROM jsitessp222353.Categories;", dgvResult);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT CompanyName, ContactName FROM jsitessp222353.Customers " +
                "WHERE Customers.Country = 'Ireland' OR Customers.Country = 'Brazil';", dgvResult);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT EmployeeID, LastName, FirstName, Title FROM jsitessp222353.Employees " +
                "WHERE Employees.ReportsTo = 2;", dgvResult);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT CategoryID, CategoryName, Description FROM jsitessp222353.Categories " +
                "WHERE Categories.Description LIKE '%dr%';", dgvResult);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT CustomerID, CompanyName, ContactName, COntactTitle, Phone FROM jsitessp222353.Customers " +
                "WHERE Customers.ContactName LIKE 'm%' " +
                "ORDER BY Customers.ContactName DESC;", dgvResult);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT ProductName, SupplierID, QuantityPerUnit, UnitPrice FROM jsitessp222353.Products " +
                "WHERE Products.SupplierID > 3 AND Products.SupplierID < 12 ORDER BY Products.SupplierID;", dgvResult);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT ProductName, SupplierID, QuantityPerUnit, UnitPrice AS 'Highest Cost' FROM jsitessp222353.Products " +
                "WHERE Products.SupplierID > 18 ORDER BY Products.SupplierID DESC;", dgvResult);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT ProductName, SupplierID, CategoryName, Description FROM jsitessp222353.Products, " +
                "jsitessp222353.Categories WHERE Products.CategoryID = Products.CategoryID AND Products.SupplierID > 0 " +
                "AND Products.SupplierID < 11 ORDER BY Products.SupplierID;", dgvResult);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT CategoryName, Description, CustomerID, CompanyName, City, Country FROM jsitessp222353.Categories, " +
                "jsitessp222353.Customers WHERE Categories.CategoryName LIKE '%c%' AND Customers.CustomerID LIKE '%a%' " +
                "ORDER BY Customers.City DESC;", dgvResult);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //db command w sql string and dgv sent as parameter
            ProgOps.DatabaseCommand("SELECT Categories.CategoryName, Categories.Description, " +
                "MAX(UnitPrice) AS 'HighestPrice', MIN(SupplierID) AS 'Lowest Supplier Number', ProductName " +
                "FROM jsitessp222353.Categories, jsitessp222353.Products " +
                "WHERE Categories.CategoryID = Products.CategoryID AND Products.UnitPrice > 50.00 " +
                "GROUP BY Categories.CategoryName, Categories.Description, Products.ProductName " +
                "ORDER BY Categories.CategoryName;", dgvResult);
        }
    }
}
