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

namespace ACSAssignment2A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close the db when frmMain closes
            ProgOps.CloseDatabase();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //dbcommand w tbx, dgv, and label sent as parameter
            ProgOps.DatabaseCommand(tbxTester, dgvTester, lblRecords);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
