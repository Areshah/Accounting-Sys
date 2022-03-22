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
    public partial class authurization : Form
    {
        public authurization()
        {
            InitializeComponent();
        }

    

        private void tsbQuit_Click(object sender, EventArgs e)
        {
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", "Confirmatuon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void authurization_Load(object sender, EventArgs e)
        {
            connect cnt = new connect();
            cnt.ContrlParameter(this);
            cnt.GridVw(dgwauthor);
            cnt.mycmb("Select user_code from ousr", "ousr", "user_code", "user_code", cmbUserID);
                       string qry = "Select user_code from ousr";
            SqlConnection connection = new SqlConnection(cnt.mycon());
            connection.Open();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataSet dtset = new DataSet();
            adap.Fill(dtset);
            DataTable dataTbl = new DataTable();
            dataTbl = dtset.Tables[0];
            dgwauthor.DataSource = dataTbl;
            //  dgview.DataBind();
            connection.Close();

        }

        
        

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
