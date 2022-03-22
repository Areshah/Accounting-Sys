using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Sys
{
    public partial class frmgdsIssue : Form
    {
        connect cnt = new connect();
        public frmgdsIssue()
        {
            InitializeComponent();
        }

        private void frmgdsIssue_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DgvGoodsIssue);
        }
    }
}
