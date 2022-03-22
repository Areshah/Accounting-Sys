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
    public partial class frmUGrp : Form
    {
        connect cnt = new connect();
        public frmUGrp()
        {
            InitializeComponent();
        }

        private void frmUoMesurStupGrp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGvUoMStpGrp);
            cnt.mydgv("Select UgpEntry,ugpCode,UgpName from ougp", "ougp", DGvUoMStpGrp);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Ougp([UgpEntry],[ugpCode],[UgpName]) values(@UgpEntry ,@ugpCode,@UgpName)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@UgpEntry", UpgEntry.Text);
                cmd.Parameters.AddWithValue("@ugpCode", UgpCode.Text);
                cmd.Parameters.AddWithValue("@UgpName", UgpName.Text);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                finally { }
            }
        }

        private void BtnDefinition_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DGvUoMStpGrp.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
