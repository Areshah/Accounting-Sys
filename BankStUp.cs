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
    public partial class BankStUp : Form
    {
        string CurStr;
        connect cnt = new connect();
        public BankStUp()
        {
            InitializeComponent();
        }

        
        private void BankStUp_Load(object sender, EventArgs e)
        {
           
            cnt.GridVw(bnkdgv);
            cnt.ContrlParameter(this);
            cnt.mydgv("Select BankName,Branch,Account,SwiftCode,Country,NextChequeNo from ocrb", "ocrb", bnkdgv);
            
        }

      

                private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
                        SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into OCRB ([BankName],[Branch],[Account],[curncy],[SwiftCode],[Country],[NextChequeNo]) values(@BankName,@Branch,@Account,@curncy,@SwiftCode,@Country,@NextChequeNo)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@BankName", cnt.GetProperCase(TxBnkName.Text));
                cmd.Parameters.AddWithValue("@Branch", cnt.GetProperCase(TxBrnCode.Text));
                cmd.Parameters.AddWithValue("@Account", TxAccNo.Text);
                cmd.Parameters.AddWithValue("@curncy", CurStr);
                cmd.Parameters.AddWithValue("@SwiftCode", TxSwiftCode.Text);
                cmd.Parameters.AddWithValue("@Country", cnt.GetProperCase(TxCountryCode.Text));
                cmd.Parameters.AddWithValue("@NextChequeNo", TxNxtChq.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    /// clear All Text;
                    TxBnkName.Clear();
                    TxBrnCode.Clear();
                    TxAccNo.Clear();
                     CurStr="";
                     TxSwiftCode.Clear();
                   TxCountryCode.Clear();
                    TxNxtChq.Clear();
                                        conn.Close();
                    // Refresh Grid Data
                    cnt.mydgv("Select BankName,Branch,Account,SwiftCode,Country,NextChequeNo from ocrb", "ocrb", bnkdgv);
                    

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

        private void cmbcurny_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select curcode from ocrn", "ocrn", "curcode", "curcode", cmbcurny);
        }

        private void cmbcurny_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurStr= (cmbcurny.SelectedItem as DataRowView)["curcode"].ToString();
        }
    }
    }

        