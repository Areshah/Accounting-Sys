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
    public partial class frmPurRetrn : Form
    {
        connect cnt = new connect();
        public frmPurRetrn()
        {
            InitializeComponent();
        }

        

        private void tsbQuit_Click(object sender, EventArgs e)
        {
            
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmPurRetrn_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGPurRtrn);
        }
    }
}
