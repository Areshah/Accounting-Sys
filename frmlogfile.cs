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
    public partial class frmlogfile : Form
    {
        connect conct = new connect();
        public frmlogfile()
        {
            InitializeComponent();
        }

        private void frmlogfile_Load(object sender, EventArgs e)
        {
            
            conct.ContrlParameter(this);
            conct.GridVw(dgw);
            string qry = "select User_code ,LogTime from usr5 ";
                       SqlConnection con = new SqlConnection(conct.mycon());
            SqlCommand cmd = new SqlCommand();
      //      con.Open();
                        cmd.Connection = con;
            cmd.CommandText = qry;
            conct.mycmb(qry, "usr5", "User_code", "User_code", cmbUserID);
            SqlDataAdapter dtad = new SqlDataAdapter(cmd);
            DataSet dtset = new DataSet();
            DataTable dt = new DataTable();
            dtad.Fill(dtset, "usr5");
            dt = dtset.Tables["usr5"];
            dgw.DataSource = dt;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            connect cnt = new connect();
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
