using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Accounting_Sys
{
    public partial class custledger : Form
    {

        connect cnt = new connect();

        public custledger()
        {
            InitializeComponent();
        }

      

        private void custledger_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
          //  cnt.mycmb("select CardCode,CardName from ocrd", "ocrd", "CardName", "CardCode", cmbLedgeAcct);
             }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", "Confirmatuon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnLdger_Click(object sender, EventArgs e)
        {
            string directory, sql;
            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "select * from ledgerView where ledgername ='" + cmbLedgeAcct.Text +"'";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "ledgerView");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\LedgerRpt.rpt");
             cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "Ledger Report");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();
        }
    }
    
    
}
