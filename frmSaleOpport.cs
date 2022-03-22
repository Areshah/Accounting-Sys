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
    public partial class frmSaleOpport : Form
    {
        connect cnt = new connect();
        public frmSaleOpport()
        {
            InitializeComponent();
        }

        private void frmSaleOpport_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvSlOppPot);
        }
    }
}
