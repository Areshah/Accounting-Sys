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
    public partial class FrmUomStUp : Form
    {
        connect cnt = new connect();
        public FrmUomStUp()
        {
            InitializeComponent();
        }

        private void FrmUomStUp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvUomStup);
            cnt.mydgv("select  uomEntry,uomcode ,locked,length1,len1unit,width1,height1,volume  from ouom", "ouom", DGvUomStup);
        }

           }
}
