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
    public partial class frmcustinfo : Form
    {
        public frmcustinfo()
        {
            InitializeComponent();
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

        private void tsbSave_Click(object sender, EventArgs e)
        {
            connect cnt = new connect();
            SqlConnection conn = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Insert into OCRD ([CardCode],[CardName],[CardType],[Address],[Phone1],[CntctPrsn],[Balance],[CreditLine],[City],[County],[E_Mail],[CreateDate],[ShipToDef],[Box1099],[CrtfcateNO],[ExpireDate],[Notes],[DocEntry]) values(@CardCode,@CardName,@CardType,@Address,@Phone1,@CntctPrsn,@Balance,@CreditLine,@City,@County,@E_Mail,@CreateDate,@ShipToDef,@xBox1099,@CrtfcateNO,@ExpireDate,@Notes,@DocEntry)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@CardCode", TxCardCode.Text);
                cmd.Parameters.AddWithValue("@CardName", TxCardName.Text);
                cmd.Parameters.AddWithValue("@CardType", "C");
                cmd.Parameters.AddWithValue("@Address", TxAddress.Text);
                cmd.Parameters.AddWithValue("@Phone1", TxPhone1.Text);
                cmd.Parameters.AddWithValue("@CntctPrsn", TxCntctPrsn.Text);
                cmd.Parameters.AddWithValue("@Balance", TxBalance.Text);
                cmd.Parameters.AddWithValue("@CreditLine", TxCreditLine.Text);
                cmd.Parameters.AddWithValue("@City", TxCity.Text);
                cmd.Parameters.AddWithValue("@County", TxCounty.Text);
                cmd.Parameters.AddWithValue("@E_Mail", TxE_Mail.Text);
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@ShipToDef", TxShipToDef.Text);
                cmd.Parameters.AddWithValue("@xBox1099", TxBox1099.Text);
                cmd.Parameters.AddWithValue("@CrtfcateNO", TxCrtfcateNO.Text);
                cmd.Parameters.AddWithValue("@ExpireDate", dtpcrt.Value);
                cmd.Parameters.AddWithValue("@Notes", TxRemark1.Text);
                cmd.Parameters.AddWithValue("@DocEntry", TxCardCode.Text);
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

        private void frmcustinfo_Load(object sender, EventArgs e)
        {
            connect cnt = new connect();
            cnt.ContrlParameter(this);
        }

        private void TxCardCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8               // backspace
                e.Handled = true;
                // enter && keyChar != 'X' && keyChar != 'x' &&   hyphen    Do not display the keystroke

            }
        }

        private void TxPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8               // backspace
                e.Handled = true;
                // enter && keyChar != 'X' && keyChar != 'x' &&   hyphen    Do not display the keystroke

            }
        }

        private void TxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8               // backspace
                e.Handled = true;
                // enter && keyChar != 'X' && keyChar != 'x' &&   hyphen    Do not display the keystroke

            }
        }

     

        private void TxBox1099_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8               // backspace
                e.Handled = true;
                // enter && keyChar != 'X' && keyChar != 'x' &&   hyphen    Do not display the keystroke

            }




        }

        private void TxCreditLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8               // backspace
                e.Handled = true;
                // enter && keyChar != 'X' && keyChar != 'x' &&   hyphen    Do not display the keystroke

            }
        }
    }
}
    
