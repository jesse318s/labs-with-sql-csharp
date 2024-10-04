using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSitesAssign1B
{
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itse2353sp22DataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.itse2353sp22DataSet.Titles);

        }
    }
}
