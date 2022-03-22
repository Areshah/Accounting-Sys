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
    public partial class frmJrnlEntry : Form
    {
        connect cnt = new connect();
        SqlConnection con = new SqlConnection();
        DataTable dtable = new DataTable();
            
        public frmJrnlEntry()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", "Confirmatuon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsbQuit_Click(object sender, EventArgs e)
        {
            connect cnt = new connect();
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void JournalEntry_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cnt.mycon());
            cnt.ContrlParameter(this);
            cnt.GridVw(DGVEntry);
            string qry = "Select * from oact";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet dtset = new DataSet();
            adap.Fill(dtset, "oact");
            dtable = dtset.Tables[0];
            BindingSource bindingSourceItem = new BindingSource();
            bindingSourceItem.DataSource = dtable;
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.DataPropertyName = "AcctName";
            cmb.HeaderText = "Account Name";
            cmb.Width = 340;
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.DataSource = bindingSourceItem;
            cmb.ValueMember = "AcctCode";
            cmb.DisplayMember = "AcctName";
            DGVEntry.Columns.Insert(1, cmb);
         //   DGVEntry.CellValueChanged += new DataGridViewCellEventHandler(DGVEntry_CellValueChanged);



        }


    }
}