﻿using System;
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
    public partial class FrmInvTransfr : Form
    {
        connect cnt = new connect();
        public FrmInvTransfr()
        {
            InitializeComponent();
        }

        private void FrmInvTransfr_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvInvTrnfrs);
        }
    }
}
