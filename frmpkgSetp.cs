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
    public partial class frmpkgSetp : Form
    {
        connect cnt = new connect();
        public frmpkgSetp()
        {
            InitializeComponent();
        }

        private void frmpackagSetp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvpkgStup);
            cnt.mydgv("select  pkgCode,pkgtype, length1,length2,len1unit,width1,width2,height1,volume  from opkg", "opkg", DGvpkgStup);

        }
    }
}
