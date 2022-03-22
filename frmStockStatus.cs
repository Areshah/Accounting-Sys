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
    public partial class frmStockStatus : Form
    {
        connect cnt = new connect();
        public frmStockStatus()
        {
            InitializeComponent();
        }

        private void frmStockStatus_Load(object sender, EventArgs e)
        {
            
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvItemStck);
            cnt.mydgv("select itemcode, itemname, codebars, lastpurdat, invntryUoM, DfltWH, OnOrder, OnHand from oitm where itemtype = 'i'", "oitm", DGvItemStck);
        }

        private void TxFndItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnt.mydgv("select itemcode, itemname, codebars, lastpurdat, invntryUoM, DfltWH, OnOrder, OnHand from oitm where itemtype = 'i' and itemname like '" + TxFndItem.Text+"%'", "oitm", DGvItemStck);
        }
    }
}
