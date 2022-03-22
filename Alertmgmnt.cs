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
    public partial class Alertmgmnt : Form
    {
        public Alertmgmnt()
        {
            InitializeComponent();
        }

       

    

       

      

        private void Alertmgmnt_Load(object sender, EventArgs e)
        {
            connect cnt = new connect();
            cnt.ContrlParameter(this);
            cnt.GridVw(dgview);
            string qry = "Select user_code from ousr";
            SqlConnection connection = new SqlConnection(cnt.mycon());
            connection.Open();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataSet dtset = new DataSet();
            adap.Fill(dtset);
            DataTable dataTbl = new DataTable();
            dataTbl = dtset.Tables[0];
            dgview.DataSource = dataTbl;
            //  dgview.DataBind();
            connection.Close();

        }

        

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
