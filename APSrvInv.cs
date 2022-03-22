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
    public partial class APSrvInv : Form
    {
        connect cnt = new connect();
        public APSrvInv()
        {
            InitializeComponent();
        }

        private void APSrvInv_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvAPServ);
            DGvAPServ.Columns[0].ReadOnly = true;
            DGvAPServ.Columns[1].ReadOnly = true;
            DGvAPServ.Columns[3].ReadOnly = true;
            DGvAPServ.Columns[4].ReadOnly = true;


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
            DGvAPServ.Columns.Insert(1, cmbusr);
            string qry2 = "select concat(Acctcode,'-' , AcctName) AccountName from OACT  where FatherNum in('Cogs','Expense','Financial Exp','Revenue Exp','Sale Dist Exp') and levels in(3,4)";
             SqlCommand cmd2 = new SqlCommand(qry2, con);
            SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
            DataTable dtable2 = new DataTable();
            DataSet dtset2 = new DataSet();
            adap2.Fill(dtset2, "oact");
            dtable2 = dtset2.Tables[0];
            BindingSource bindingSourceItem2 = new BindingSource();
            bindingSourceItem2.DataSource = dtable2;
            DataGridViewComboBoxColumn cmbact = new DataGridViewComboBoxColumn();
            cmbact.DataPropertyName ="AccountName";
            cmbact.HeaderText = "Account Description";
            cmbact.Width = 200;
            cmbact.FlatStyle = FlatStyle.Flat;
            cmbact.DataSource = bindingSourceItem2;
                       cmbact.DisplayMember = "AccountName";
            cmbact.ValueMember = "AccountName";
            DGvAPServ.Columns.Insert(3, cmbact);
        }

        private void CmbCur_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode,ChkName from ocrn", "ocrn", "curcode", "ChkName", CmbCur);
        }

        private void CmbCur_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotAmtLbl.Text = "Total Amount Applied : " + (CmbCur.SelectedItem as DataRowView)["ChkName"].ToString();
        }

       

        private void CmBSuppInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardID.Text = (CmBSuppInv.SelectedItem as DataRowView)["CardCode"].ToString();
        }

        private void CmBSuppInv_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='v'", "ocrd", "CardName", "CardCode", CmBSuppInv);

        }

        private void CMBTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CMBTax);
        }

        private void CMBTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxRate.Text = (CMBTax.SelectedItem as DataRowView)["Rate"].ToString();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
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
            dv = new DataView(dtset.Tables[0], "itemcode = '" + DGvAPServ.CurrentRow.Cells[1].Value.ToString() + "'", "itemcode   Desc", DataViewRowState.CurrentRows);
    
            
          //  DGvAPServ.CurrentRow.Cells[0].Value = ts.ToString();
           
         //   DGvAPServ.CurrentRow.Cells[5].Value = ts1.ToString();
            int i, mant = 0;
            decimal Txmnt;
            for (i = 0; i <= DGvAPServ.Rows.Count - 1; i++)
                mant = mant + Convert.ToInt32(DGvAPServ.Rows[i].Cells[5].Value);
            Txmnt = mant * Convert.ToDecimal(TxRate.Text);
            TxTotWoutDis.Text = mant.ToString();
            TxInvAmt.Text = Convert.ToString(Txmnt);
            TxTotAmAply.Text = Convert.ToString(mant + Txmnt);
        }
    }
    }

