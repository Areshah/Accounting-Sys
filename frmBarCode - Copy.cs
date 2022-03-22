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
    public partial class frmBarCode : Form
    { connect cnt = new connect();
        public frmBarCode()
        {
            InitializeComponent();
        }

        private void frmBarCode_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DgvUomGrp);
            cnt.GridVw(DgvTxBarcd);
        }
    }
}
