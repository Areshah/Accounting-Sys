using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Accounting_Sys
{
    public partial class frmChqSelection : Form
    {
        connect cnt = new connect();
        public frmChqSelection()
        {
            InitializeComponent();
        }

        private void frmChqSelection_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(dgvChqSelect);
        }
    }
}
