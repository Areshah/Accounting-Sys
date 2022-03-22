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
    public partial class wheSetUp : Form
    {
        connect cnt = new connect();
        string qry = "select whscode,whsname,county ,binactivat from owhs";
        
        public wheSetUp()
        {
            InitializeComponent();
        }

        private void wheSetUp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvWhelst);
            cnt.mydgv("select whscode,whsname,county ,binactivat from owhs", "owhs", DGvWhelst);
        }

        private void TxFindWhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection conn = new SqlConnection(cnt.mycon());
            SqlDataAdapter da = new SqlDataAdapter(qry, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "owhs"); DataView Dv;
             Dv = new DataView(ds.Tables[0], "whsname like '" + TxFindWhe.Text + "%'", "whscode Desc", DataViewRowState.CurrentRows);
            DGvWhelst.DataSource = Dv;
        }

        private void CmbTaxSetUp_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select code, name from ostc", "ostc", "code", "name", CmbTaxSetUp);
        }

        private void CmbTaxSetUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxVatTx.Text = (CmbTaxSetUp.SelectedItem as DataRowView)["code"].ToString();
        }

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into OWHS ([WhsCode],[whsname] ,[locked] ,[vatgroup], [Street], [ZipCode],[state],[Block],[city],[country],[dropship], [UseTax], [nettable],[county], [createDate],[binactivat], [GlblLocNum]) Values(@WhsCode, @whsname, @locked, @vatgroup, @Street,@ZipCode, @state, @Block, @city, @country, @dropship, @UseTax, @nettable, @county, @createDate, @binactivat, @GlblLocNum)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@WhsCode", TxwheCode.Text);
                cmd.Parameters.AddWithValue("@whsname", TxCardName.Text);
                cmd.Parameters.AddWithValue("@locked", ChKInactive.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@vatgroup", TxVatTx.Text);
                cmd.Parameters.AddWithValue("@Street", TxStreetPO.Text);
                cmd.Parameters.AddWithValue("@ZipCode", TxZipCode.Text);
                cmd.Parameters.AddWithValue("@state", TxCountry.Text);
                cmd.Parameters.AddWithValue("@Block", TxBlk.Text);
                cmd.Parameters.AddWithValue("@city", TxCity.Text);
                cmd.Parameters.AddWithValue("@country", TxCountry.Text);
                cmd.Parameters.AddWithValue("@dropship", ChkDRpShp.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@UseTax", ChkAlowTax.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@nettable", CHKNtable.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@county", TxCounty.Text);
                cmd.Parameters.AddWithValue("@createDate",DateTime.Now);
                cmd.Parameters.AddWithValue("@binactivat", ChkEnblBinLoc.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@GlblLocNum", TxGloblNum.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                finally { }
            }
        }

        private void TxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxCountry.TextLength > 2)
            {
                e.Handled = true;
            }
        }
    }
}
