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
    public partial class APCreditmemo : Form
    {
        public APCreditmemo()
        {
            InitializeComponent();
        }

        private void APCreditmemo_Load(object sender, EventArgs e)
        {
            connect cnt = new connect();
            cnt.ContrlParameter(this);
            cnt.GridVw(DGarcrmu);
        }
    }
}