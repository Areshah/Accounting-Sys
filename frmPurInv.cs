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
    public partial class frmPurInv : Form
    {
        connect cnt = new connect();
        public frmPurInv()
        {
            InitializeComponent();
        }

        private void frmPurInv_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGPurInv);
            cnt.ContrlParameter(this);
            cnt.GridVw(DGPurInv);
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
            cmbusr.Width = 290;
            cmbusr.FlatStyle = FlatStyle.Flat;
            cmbusr.DataSource = bindingSourceItem;
            cmbusr.ValueMember = "itemcode";
            cmbusr.DisplayMember = "Itemname";
            DGPurInv.Columns.Insert(1, cmbusr);

        }

        private void CmBSuppInv_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='v'", "ocrd", "CardName", "CardCode", CmBSuppInv);
        }

        private void CmBSuppInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardID.Text = (CmBSuppInv.SelectedItem as DataRowView)["CardCode"].ToString();
        }

        private void CmbCur_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode,ChkName from ocrn", "ocrn", "curcode", "ChkName", CmbCur);
        }

        private void CmbCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotAmtLbl.Text = "Total Amount Applied : " + (CmbCur.SelectedItem as DataRowView)["ChkName"].ToString();
        }

        private void CmbTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CmbTax);
        }

        private void CmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxRate.Text = (CmbTax.SelectedItem as DataRowView)["Rate"].ToString();
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
            dv = new DataView(dtset.Tables[0], "itemcode = '" + DGPurInv.CurrentRow.Cells[1].Value.ToString() + "'", "itemcode   Desc", DataViewRowState.CurrentRows);
                   
           
           
           //  DGPurInv.CurrentRow.Cells[5].Value = ts1.ToString();
          //  DGPurInv.CurrentRow.Cells[4].Value = ts2.ToString();
          //  Convert.ToDecimal(DGPurInv.CurrentRow.Cells[8].Value = Convert.ToUInt32(DGPurInv.CurrentRow.Cells[3].Value) * ts1);
            int i, mant = 0;
            decimal Txmnt;
            for (i = 0; i <= DGPurInv.Rows.Count - 1; i++)
                mant = mant + Convert.ToInt32(DGPurInv.Rows[i].Cells[8].Value);
            Txmnt = mant * Convert.ToDecimal(TxRate.Text);
            TxTotWoutDis.Text = mant.ToString();
            TxInvAmt.Text = Convert.ToString(Txmnt);
            TxTotAmAply.Text = Convert.ToString(mant + Txmnt);
        }
    }
}
