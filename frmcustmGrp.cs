using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_Sys
{
    public partial class frmcustmGrp : Form
    {
        connect cnt = new connect();
        int _GrpCode;
        public frmcustmGrp()
        {
            InitializeComponent();
        }

        private void frmcustmGrp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DgvCstGrp);
           
        }

     

           


     
    }
}
