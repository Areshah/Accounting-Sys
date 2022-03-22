using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hafiz.Reports
{
    public partial class frmRptCashBook : Form
    {
        public static string Caller = "";
        public frmRptCashBook()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Classes.DBLayer objDB = new Hafiz.Classes.DBLayer();
            DataTable dt = objDB.GetDataTable("exec Sp_CashBook '" + objDB.SetDateForSave(dtpFrom) + "','" + objDB.SetDateForSave(dtpTo) + "'");
            Reports.rptCashBook rpt = new rptCashBook();
            rpt.SetDataSource(dt);
            rpt.SetParameterValue(2, frmMain.CompanyName);
            rpt.SetParameterValue(3, "Cash Book From :" + (dtpFrom.Value.Day + "/" + dtpFrom.Value.Month + "/" + dtpFrom.Value.Year) + " To " + (dtpTo.Value.Day + "/" + dtpTo.Value.Month + "/" + dtpTo.Value.Year));

            string Query = "select IsNull(Sum(T.Debit),0)-Isnull(Sum(T.Credit),0) OpeningBalance from tblTransactions T Inner Join tblAccounts A on T.AccountId=A.Id Where AccountCode='03-02-00001'and T.Date<'" + (dtpFrom.Value.Year + "/" + dtpFrom.Value.Month + "/" + dtpFrom.Value.Day).ToString() + "'";
            string OpeningBalance = objDB.GetDataField(Query, "OpeningBalance");
            Query = "select IsNull(Sum(T.Debit),0)-Isnull(Sum(T.Credit),0) ClosingBalance from tblTransactions T Inner Join tblAccounts A on T.AccountId=A.Id Where AccountCode='03-02-00001'and T.Date<='" + (dtpTo.Value.Year + "/" + dtpTo.Value.Month + "/" + dtpTo.Value.Day).ToString() + "'";
            string ClosingBalance = objDB.GetDataField(Query, "ClosingBalance");

            rpt.SetParameterValue("OpeningBalance", OpeningBalance);
            rpt.SetParameterValue("ClosingBalance", ClosingBalance);
            frmViewer frm = new frmViewer();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Show();
        }

        private void frmRptDailyIn_Load(object sender, EventArgs e)
        {
            this.dtpFrom.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
