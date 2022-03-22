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
    public partial class frmlogin : Form
    {
        connect cnt = new connect();
        public delegate void LoginDel(int a, string str);
        event LoginDel LogEvent;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           
                DialogResult rslt;
                rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rslt == DialogResult.Yes)
                {
                    this.Close();
                }
            }
                private void chmgpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChngpass FrmChngpass1 = new FrmChngpass();
            FrmChngpass1.Show();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string qry = "select User_code ,group1 from ousr where User_code='" + UserID.Text + "' and Password='" + Password.Text + "'";
           
            SqlConnection con = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand();
                   con.Open();
            cmd.Connection = con;
            cmd.CommandText = qry;
            SqlDataReader drdr = cmd.ExecuteReader();

            if (drdr.HasRows)            {
                MessageBox.Show("Confirm login", cnt.HdrName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FrmMDI fmrlogn = new FrmMDI();
                drdr.Read();
              LogEvent += new LoginDel(fmrlogn.grppoicy);
                this.LogEvent((int)drdr["Group1"], drdr["user_code"].ToString());
                                SqlCommand cmdIns = new SqlCommand("Insert into usr5 values(@user_code, @group, @logtime)", con);
                cmdIns.Connection = con;
                cmdIns.Parameters.AddWithValue(@"user_code", drdr["user_code"]);
                cmdIns.Parameters.AddWithValue(@"group", drdr["Group1"]);
                cmdIns.Parameters.AddWithValue(@"logtime", DateTime.Now);
                fmrlogn.Show();
                drdr.Close();
                cmd.Dispose();
                cmdIns.ExecuteNonQuery();
                cmdIns.Dispose();
                con.Close();
                             con.Close();
                this.Close();

            }
           else
            {
                MessageBox.Show("login Failed", "AccErp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

                }
        
               private void frmlogin_Load(object sender, EventArgs e)        {
            connect cnt = new connect();
            cnt.ContrlParameter(this);       }
    }
}
