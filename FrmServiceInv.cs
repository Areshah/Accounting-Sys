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
    public partial class FrmServiceInv : Form
    {
        connect cnt = new connect();
        public FrmServiceInv()
        {
            InitializeComponent();
        }

        private void FrmServiceInv_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvServ);
            DGvServ.Columns[0].ReadOnly = true;
            DGvServ.Columns[1].ReadOnly = true;
            DGvServ.Columns[3].ReadOnly = true;
            string qry = "Select itemcode,  Itemname from OITM where itemtype='s' ";
            SqlConnection con = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            DataSet dtset = new DataSet();
            adap.Fill(dtset, "oitm");
            dtable = dtset.Tables[0];
            BindingSource bindingSourceItem = new BindingSource();
            bindingSourceItem.DataSource = dtable;
            DataGridViewComboBoxColumn cmbusr = new DataGridViewComboBoxColumn();
            cmbusr.DataPropertyName = "Itemname";
            cmbusr.HeaderText = "Service Description";
            cmbusr.Width = 200;
            cmbusr.FlatStyle = FlatStyle.Flat;
                cmbusr.DataSource = bindingSourceItem;
            cmbusr.ValueMember = "itemcode";
            cmbusr.DisplayMember = "Itemname";
            DGvServ.Columns.Insert(1, cmbusr);

            string qry2 = "select acctcode ,acctName from oact  where levels in(3,4)";
            
            SqlCommand cmd2 = new SqlCommand(qry2, con);
            SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
            DataTable dtable2 = new DataTable();
            DataSet dtset2 = new DataSet();
            adap2.Fill(dtset2, "oact");
            dtable2 = dtset2.Tables[0];
            BindingSource bindingSourceItem2 = new BindingSource();
            bindingSourceItem2.DataSource = dtable2;
            DataGridViewComboBoxColumn cmbact = new DataGridViewComboBoxColumn();
            cmbact.DataPropertyName = "acctName";
            cmbact.FlatStyle = FlatStyle.Flat;
            cmbact.HeaderText = "Account Description";
            cmbact.Width = 200   ;
            cmbact.DataSource = bindingSourceItem2;
            cmbact.ValueMember = "acctcode";
            cmbact.DisplayMember = "acctName";
            DGvServ.Columns.Insert(3, cmbact);        }
                private void CmbCur_Enter(object sender, EventArgs e)        {
            cnt.mycmb("Select curcode,ChkName from ocrn", "ocrn", "curcode", "ChkName", CmbCur);       }

        private void CmbCur_SelectedIndexChanged(object sender, EventArgs e)        {
            TotAmtLbl.Text = "Total Amount Applied : " + (CmbCur.SelectedItem as DataRowView)["ChkName"].ToString();
        }

        private void CmBCustInv_Enter(object sender, EventArgs e)
        {
            
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='c'", "ocrd", "CardName", "CardCode", CmBCustInv);
        }

        private void CmBCustInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardID.Text = (CmBCustInv.SelectedItem as DataRowView)["CardCode"].ToString();
        }

        private void CMBTax_Enter(object sender, EventArgs e)        {
                        cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CMBTax);
           }

        private void CMBTax_SelectedIndexChanged(object sender, EventArgs e)        {
            TxRate.Text = (CMBTax.SelectedItem as DataRowView)["Rate"].ToString();        }

        private void BtnInsert_Click_1(object sender, EventArgs e)        {
            string qry = "Select itemcode,  Itemname  ,AvgPrice from OITM where itemtype='s'  ";
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
            dv = new DataView(dtset.Tables[0], "itemcode = '" + DGvServ.CurrentRow.Cells[1].Value.ToString() + "'", "itemcode   Desc", DataViewRowState.CurrentRows);
       
          //  DGvServ.CurrentRow.Cells[0].Value ;
           
        //    DGvServ.CurrentRow.Cells[5].Value = ;
            int i, mant = 0;
            decimal Txmnt;
            for (i = 0; i <= DGvServ.Rows.Count - 1; i++)
            mant = mant + Convert.ToInt32(DGvServ.Rows[i].Cells[5].Value);
            Txmnt = mant * Convert.ToDecimal(TxRate.Text);
            TxTotWoutDis.Text = mant.ToString();
            TxInvAmt.Text = Convert.ToString(Txmnt);
            TxTotAmAply.Text = Convert.ToString(mant + Txmnt);
        }
    }
}
