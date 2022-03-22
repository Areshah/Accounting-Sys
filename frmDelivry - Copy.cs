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
    public partial class frmDelivry : Form
    {
        connect cnt = new connect();
        public frmDelivry()
        {
            InitializeComponent();
        }

        private void frmDelivry_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvDlvy);

        }

        private void CmBCustInv_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='c'", "ocrd", "CardName", "CardCode", CmBCustInv);
        }

        private void CmBCustInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardID.Text = (CmBCustInv.SelectedItem as DataRowView)["CardCode"].ToString();
        }

        private void CmbCur_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode,ChkName from ocrn", "ocrn", "curcode", "ChkName", CmbCur);
        }

        private void CmbCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotAmtLbl.Text = "Total Amount Applied : " + (CmbCur.SelectedItem as DataRowView)["ChkName"].ToString();
        }

        private void CMBTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CMBTax);
        }

        private void CMBTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxRate.Text = (CMBTax.SelectedItem as DataRowView)["Rate"].ToString();
        }
    }
}

