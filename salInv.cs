using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Sys
{
    public partial class salInv : Form
    {
        connect cnt = new connect();
        public salInv()
        {
            InitializeComponent();
        }



        private void salInv_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGSlInv);
            string qry = "Select itemcode,  Itemname  from OITM  where itemtype='i' ";
            SqlConnection con = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            DataSet dtset = new DataSet();
            adap.Fill(dtset, "oact");
            dtable = dtset.Tables[0];
            BindingSource bindingSourceItem = new BindingSource();
            bindingSourceItem.DataSource = dtable;
            DataGridViewComboBoxColumn cmbusr = new DataGridViewComboBoxColumn();
            cmbusr.DataPropertyName = "Itemname";
            cmbusr.HeaderText = "Item Name";
            cmbusr.Width = 260;
            cmbusr.DataSource = bindingSourceItem;
            cmbusr.ValueMember = "itemcode";
            cmbusr.DisplayMember = "Itemname";
            DGSlInv.Columns.Insert(1, cmbusr);

        }



        

        private void CmBCustInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardID.Text = (CmBCustInv.SelectedItem as DataRowView)["CardCode"].ToString();
        }

        private void CmBCustInv_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='c'", "ocrd", "CardName", "CardCode", CmBCustInv);

        }



        private void CmbCur_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode,ChkName from ocrn", "ocrn", "curcode", "ChkName", CmbCur);
        }

        private void CmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxRate.Text = (CmbTax.SelectedItem as DataRowView)["Rate"].ToString();
        }

        private void CmbTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CmbTax);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string qry = "Select itemcode,  Itemname  ,AvgPrice,InvntryUom from OITM  ";
            SqlConnection con = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            DataSet dtset = new DataSet();
            adap.Fill(dtset, "oitm");
            dtable = dtset.Tables[0];
            BindingSource bindingSourceItem = new BindingSource();
            bindingSourceItem.DataSource = dtable;
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            adap.Fill(dtset, "Oitm"); DataView dv;
            dv = new DataView(dtset.Tables[0], "itemcode = '" + DGSlInv.CurrentRow.Cells[1].Value.ToString() + "'", "itemcode   Desc", DataViewRowState.CurrentRows);
            filterGD.DataSource = dv;
            string ts = filterGD.CurrentRow.Cells[0].Value.ToString();
            DGSlInv.CurrentRow.Cells[0].Value = ts.ToString();
            int ts1 = Convert.ToInt32(filterGD.CurrentRow.Cells[2].Value);
            string ts2 = filterGD.CurrentRow.Cells[3].Value.ToString();
            DGSlInv.CurrentRow.Cells[5].Value = ts1.ToString();
            DGSlInv.CurrentRow.Cells[4].Value = ts2.ToString();
            Convert.ToDecimal(DGSlInv.CurrentRow.Cells[8].Value = Convert.ToUInt32(DGSlInv.CurrentRow.Cells[3].Value) * ts1);
            int i, mant = 0;
            decimal Txmnt;
            for (i = 0; i <= DGSlInv.Rows.Count - 1; i++)
                mant = mant + Convert.ToInt32(DGSlInv.Rows[i].Cells[8].Value);
            Txmnt = mant * Convert.ToDecimal(TxRate.Text);
            TxTotWoutDis.Text = mant.ToString();
            TxInvAmt.Text = Convert.ToString(Txmnt);
            TxTotAmAply.Text = Convert.ToString(mant + Txmnt);
        }

        private void CmbCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotAmtLbl.Text = "Total Amount Applied : "+(CmbCur.SelectedItem as DataRowView)["ChkName"].ToString();
        }
    }
}
    

