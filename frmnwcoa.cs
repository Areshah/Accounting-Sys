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
    public partial class frmnwcoa : Form
    {
        connect cnt = new connect();
        public frmnwcoa()
        {
            InitializeComponent();
        }

               private void frmnwcoa_Load(object sender, EventArgs e)
        {
            connect cnt =new  connect();
            cnt.ContrlParameter(this);
            cnt.GridVw(dgv_coa);
            cnt.mycmb("select curcode from ocrn", "ocrn", "curcode", "curcode",cmbactcurr);
           
        }

      

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            string Grop = "";
            char a = 'n';
            char Acctyp = 'y';
            

            
            if (rbtaacc.Checked == true || rbttitle.Checked == false)
            {
                a = 'y';

            }
            else if (rbtaacc.Checked == false || rbttitle.Checked == true)
            {

                a = 'n';

            }
            if (rbtnassets.Checked == true)
            {
                Grop = "Assets";

            }
            else if (rbtnliability.Checked == true)
            {
                Grop = "Liablity";
            }
            else if (rbtnsktholder.Checked == true)
            {
                Grop = "Equity";
            }
            else if (rbtnrevenue.Checked == true)
            {
                Grop = "Revenue";
            }

            else if (rbntcogs.Checked == true)
            {
                Grop = "COGS";
            }

            else if (rbntexp.Checked == true)
            {
                Grop = "Expense";
            }
            else if (rbtnfinincexp.Checked == true)
            {
                Grop = "Finacial Exp";
            }
            else if (rbtslDstexp.Checked == true)
            {
                Grop = "Sale Dist Exp";
            }

            if (acc_code.Equals("") || TxName.Equals("") || Grop == "")
            {
                MessageBox.Show("Acct Code or Acct Name Can not Be Blank");
            }

            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into OACT ([AcctCode],[AcctName],[CurrTotal],[Finanse],[Postable],[Levels],[actcurr],[FatherNum],[CreateDate],[UpdateDate],[LocManTran],[Segment_0],[Segment_1],[Segment_2],[actid]) values(@AcctCode,@AcctName,@CurrTotal,@Finanse,@Postable,@Levels,@actcurr,@FatherNum,@CreateDate,@UpdateDate,@LocManTran,@Segment_0,@Segment_1,@Segment_2,@actid)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@AcctCode", acc_code.Text);
                cmd.Parameters.AddWithValue("@AcctName", cnt.GetProperCase(TxName.Text));
                cmd.Parameters.AddWithValue("@CurrTotal", TxCurBalnc.Text);
                cmd.Parameters.AddWithValue("@Finanse", Acctyp);
                cmd.Parameters.AddWithValue("@Postable", a);
                cmd.Parameters.AddWithValue("@Levels", cmblevl.Text);
                cmd.Parameters.AddWithValue("@actcurr", cmbactcurr.Text);
                cmd.Parameters.AddWithValue("@FatherNum", Grop);
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@UpdateDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@LocManTran", 'Y');
                cmd.Parameters.AddWithValue("@Segment_0", seg_1.Text);
                cmd.Parameters.AddWithValue("@Segment_1", seg_2.Text);
                cmd.Parameters.AddWithValue("@Segment_2", seg_3.Text);
                cmd.Parameters.AddWithValue("@actid", acc_code.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Source + " data");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }

        }

        private void acc_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void seg_1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            { 
                e.Handled = true;

            }

        }

        private void seg_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            { // 0 – 9 && keyChar != 8 backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                e.Handled = true;

            }
        }

        private void seg_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            { // 0 – 9 && keyChar != 8 backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                e.Handled = true;

            }
        }

        private void TxCurBalnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            { // 0 – 9 && keyChar != 8 backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                e.Handled = true;

            }
        }

        private void rbtnassets_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Assets'", "Oact", dgv_coa);
        }

        private void rbtnliability_CheckedChanged(object sender, EventArgs e)
        {
          
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Liablity'", "Oact", dgv_coa);
        }

        private void rbtnsktholder_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Equity'", "Oact", dgv_coa);

        }

        private void rbtnrevenue_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Revenue'", "Oact", dgv_coa);

        }

        private void rbntcogs_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Cogs'", "Oact", dgv_coa);
            
        }

        private void rbntexp_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Expense'", "Oact", dgv_coa);

        }

        

        private void rbtnfinincexp_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Revenue Exp'", "Oact", dgv_coa);


        }

        private void rbtslDstexp_CheckedChanged(object sender, EventArgs e)
        {
            cnt.mydgv("select CONCAT(acctcode, segment_0, segment_1, segment_2) [Account Number], acctname, CurrTotal  from OACT where fatherNum= 'Sale & Distrubtion Exp'", "Oact", dgv_coa);

        }
    }
}
