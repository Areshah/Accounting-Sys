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
    public partial class VendrGroup : Form
    {
        connect cnt = new connect();
        int _GrpCode;
        public VendrGroup()
        {

            InitializeComponent();
        }

        private void VendrGroup_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DgvVndrGrp);
            cnt.mydgv("select GroupCode,GroupName, PriceList from ocrg where Grouptype='S'", "ocrg", DgvVndrGrp);
            _GrpCode = cnt.GetSeries("select max(cast(GroupCode as int)) as MaxNo from ocrg where Grouptype='S'");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnt.mycon());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Open)
            {
                cmd.CommandText = "insert into ocrg([GroupCode],[GroupName],[Grouptype]) values (@GroupCode,@GroupName,@grouptype)";
                cmd.Parameters.AddWithValue("@GroupCode", _GrpCode);
                cmd.Parameters.AddWithValue("GroupName", TxVendNane.Text);
                cmd.Parameters.AddWithValue("@Grouptype", 'S');
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    con.Close();
                }
                catch (Exception c) { MessageBox.Show(c.Message + "Data Not Added"); }
            }
        }
    }
}
