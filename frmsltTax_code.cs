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
    public partial class frmsltTax_code : Form
    {
        public frmsltTax_code()
        {
            InitializeComponent();
        }

        connect cnt = new connect();

        private void Tax_code_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(dgv_tax);
            cnt.mydgv("Select [Code],[Name],[Rate],[ValidforAP],[ValidforAR],[IsItmLevel],[Lock] from OSTC", "OSTC", dgv_tax);



        }

        private void tsbQuit_Click(object sender, EventArgs e)
        {            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)            {
                this.Close();            }
        }

                private void txttxrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back)){  
                // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                    e.Handled = true;       }
            else if (txttxrt.TextLength > 2)
            {
                e.Handled = true;
            }
        }

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            taxcode.Text = cmbTaxType.Text.Substring(0,1) + txttxrt.Text;
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
                 SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into OSTC ([Code],[Name],[Rate],[ValidforAP],[ValidforAR],[IsItmLevel],[Lock]) values(@Code, @Name ,@Rate,@ValidforAP,@ValidforAR ,@IsItmLevel,@Lock)";
            if (conn.State == ConnectionState.Open)            {
                cmd.Parameters.AddWithValue("@Code", taxcode.Text);
                cmd.Parameters.AddWithValue("@Name", cmbTaxType.Text);
                cmd.Parameters.AddWithValue("@Rate", (Convert.ToDouble(txttxrt.Text)));
                cmd.Parameters.AddWithValue("@ValidforAP", ChkvldfAP.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@ValidforAR", ChkvldfAR.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@IsItmLevel", ChkItmLevl.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@Lock", ChkLock.Checked ? 'Y' : 'N');
                           try                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();                }
                catch (SqlException ex)                {
                    MessageBox.Show(ex.Source + " data");
                    conn.Close();                }
            }
            else            {
                MessageBox.Show("Connection Failed");            }
        }

        private void cmbTaxType_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select AbsId, Name from ostt", "ostt", "Name", "AbsId", cmbTaxType);
        }
    }
}
