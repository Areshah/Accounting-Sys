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
    public partial class frmDeposit : Form
    {
        connect cnt = new connect();
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void frmBnkDeposit_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvDpCash);
            cnt.GridVw(DGvBnCCrd);
            cnt.GridVw(DGvBnChq);

            
        }

        private void frmBnkDeposit_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode from ocrn", "ocrn", "curcode", "curcode", CmBCurr);
        }

        private void CmBGLAcc_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select AcctName AcctCode from OACT  where levels in (3,4)","Oact", "AcctName", "AcctCode", CmBGLAcc);
        }

        private void CMbBnkBr_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("SELECT concat( BankName ,'-', Branch) BankBrach ,Account FROM  OCRB", "OCRB", "BankBrach", "Account", CMbBnkBr);
        }

        private void CMbBnkBr_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxBnkBrAcc.Text = (CMbBnkBr.SelectedItem as DataRowView)["Account"].ToString();
        }

        private void DGvBkDopChq_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            decimal Txtmnt = 0; int i;
            for (i = 0; i <= DGvBnChq.Rows.Count - 1; i++)
                Txtmnt = Txtmnt + Convert.ToInt32(DGvBnChq.Rows[i].Cells[5].Value);
            TxCshAmount.Text = Convert.ToString(Txtmnt);
        }
    }
}
