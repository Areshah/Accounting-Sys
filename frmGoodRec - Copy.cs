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
    public partial class frmGoodRec : Form
    {
        connect cnt = new connect();
        public frmGoodRec()
        {
            InitializeComponent();
        }

        private void frmGoodRec_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGGdsRece);
        }
    }
}
