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
    public partial class frmSLQoute : Form
    {
        connect cnt = new connect();
        public frmSLQoute()
        {
            InitializeComponent();
        }

        private void frmSLQoute_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGSLQuot);
        }

        private void CmbTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CmbTax);
        }

        private void CmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxRate.Text = (CmbTax.SelectedItem as DataRowView)["Rate"].ToString();
        }
    }
}
