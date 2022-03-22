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
    public partial class frmCurrency : Form
    {
        connect cnt = new connect();
        public frmCurrency()
        {
            InitializeComponent();
        }


        private void frmCurrency_Load(object sender, EventArgs e)
        {

            cnt.ContrlParameter(this);
            cnt.GridVw(dgvcurr);
            cnt.mydgv("select * from OCRN", "Ocrn", dgvcurr);
        }



        private void btnClose_Click(object sender, EventArgs e)
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

       
        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            connect cnt = new connect();
            SqlConnection conn = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into OCRN([curcode],[CurName],[Rate],[ChkName],[DocCode],[ForgnName],[Locked],[DateSure]) values(@curcode,@CurName,@Rate,@ChkName,@DocCode,@ForgnName,@Locked,@DateSure)";


            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@curcode", cnt.GetProperCase(txtCurrCode.Text));
                cmd.Parameters.AddWithValue("@CurName", cnt.GetProperCase(txtCurrency.Text));
                cmd.Parameters.AddWithValue("@rate", txtRate.Text);
                cmd.Parameters.AddWithValue("@ChkName", txtAbbr.Text);
                cmd.Parameters.AddWithValue("@DocCode", txtSymbol.Text);
               cmd.Parameters.AddWithValue("@ForgnName", cnt.GetProperCase(TxForgnName.Text));
                cmd.Parameters.AddWithValue("@Locked", ChkLocked.Checked?1:0);
                cmd.Parameters.AddWithValue("@DateSure", dttmpic.Value);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                    cnt.mydgv("select * from OCRN", "Ocrn", dgvcurr);

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

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }

        private void txtCurrCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCurrCode.TextLength > 2)
            {
                e.Handled = true;
            }
        }
    }
    }
