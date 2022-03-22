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
    public partial class frmItemGrp : Form
    {
        connect cnt = new connect();
       string InvntSy="" , PlaningSy="" , PrcrmntMt="";
        int UgpEntrNo=0, OdrIntvl=0,OrderMulti=0;
        int _firmCode;
        public frmItemGrp()
        {
            InitializeComponent();
        }

        private void ItemGrp_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGVItmGrpwhe);
            cnt.mydgv("select whscode, whsName, grp_code from owhs", "owhs", DGVItmGrpwhe);
            _firmCode = cnt.GetSeries("select max(cast(itmsgrpcod as integer))  + 1 as MaxNo from oitb");
            TxGrpItmCode.Text = _firmCode.ToString();

        }
        public DataTable CmbPlnMethDisValue()
        {
            DataTable DtblDSource = new DataTable();
            DtblDSource.Columns.Add("DisplayMember");
            DtblDSource.Columns.Add("ValueMember");
            DtblDSource.Rows.Add("MRP", 'M');
            DtblDSource.Rows.Add("None", 'N');


            return DtblDSource;
        }


         public DataTable CmbProCurmentDisValue()        {
            DataTable DtblDSource = new DataTable();
            DtblDSource.Columns.Add("DisplayMember");
            DtblDSource.Columns.Add("ValueMember");
            DtblDSource.Rows.Add("Buy", 'B');
            DtblDSource.Rows.Add("Make", 'M');
            
            return DtblDSource;
        }
        private void CmbPlnMeth_Enter(object sender, EventArgs e)
        {
            CmbPlnMeth.DataSource = CmbPlnMethDisValue();
            CmbPlnMeth.DisplayMember = "DisplayMember";
            CmbPlnMeth.ValueMember = "ValueMember";

    }
        
            public DataTable CmbDlutValutionDisValue()
        {
            DataTable DtblDSource = new DataTable();
            DtblDSource.Columns.Add("DisplayMember");
            DtblDSource.Columns.Add("ValueMember");
            DtblDSource.Rows.Add("Moving Average", 'A');
            DtblDSource.Rows.Add("Standard", 'S');
            DtblDSource.Rows.Add("FIFO", 'F');

            return DtblDSource;
        }

        private void CmbProCurment_Enter(object sender, EventArgs e)
        {
            CmbProCurment.DataSource = CmbProCurmentDisValue();
            CmbProCurment.DisplayMember = "DisplayMember";
            CmbProCurment.ValueMember = "ValueMember";

        }

        private void CmbDfltUomGrp_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select ugpcode,ugpEntry from ougp", "ougp","ugpcode", "ugpEntry", CmbDfltUomGrp);
        }

        private void CmbDlutValution_Enter(object sender, EventArgs e)
        {
            CmbDlutValution.DataSource = CmbDlutValutionDisValue();
                          CmbDlutValution.DisplayMember = "DisplayMember";
            CmbDlutValution.ValueMember = "ValueMember";
        }

        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Oitb([ItmsGrpCod] ,[ItmsGrpNam] ,[Locked] ,[InvntSys] ,[PlaningSys] ,[PrcrmntMtd],[OrdrIntrvl] ,[OrdrMulti] ,[createDate] ,[UgpEntry] ,[LeadTime] ,[ToleranDay]) values (@ItmsGrpCod ,@ItmsGrpNam ,@Locked ,@InvntSys ,@PlaningSys ,@PrcrmntMtd,@OrdrIntrvl,@OrdrMulti ,@createDate ,@UgpEntry,@LeadTime ,@ToleranDay)";
            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@ItmsGrpCod", _firmCode);
                cmd.Parameters.AddWithValue("@ItmsGrpNam", TxItemGrpNm.Text);
                cmd.Parameters.AddWithValue("@Locked", ChkLocked.Checked?'Y':'N');
                cmd.Parameters.AddWithValue("@InvntSys", InvntSy);
                cmd.Parameters.AddWithValue("@PlaningSys", PlaningSy);
                cmd.Parameters.AddWithValue("@PrcrmntMtd", PrcrmntMt);
                cmd.Parameters.AddWithValue("@OrdrIntrvl", OdrIntvl);
                cmd.Parameters.AddWithValue("@OrdrMulti", OrderMulti);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@UgpEntry", UgpEntrNo);
                cmd.Parameters.AddWithValue("@LeadTime", TxLeadTime.Text);
                cmd.Parameters.AddWithValue("@ToleranDay", TxTolrnDay.Text);
                 try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                finally { }
            }
        }

        private void CmbProCurment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrcrmntMt = (CmbProCurment.SelectedItem as DataRowView)["ValueMember"].ToString();
        }

        private void CmbDfltUomGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UgpEntrNo = Convert.ToInt32((CmbDfltUomGrp.SelectedItem as DataRowView)["ugpEntry"]);
        }

        private void CmbPlnMeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaningSy=(CmbPlnMeth.SelectedItem as DataRowView)["ValueMember"].ToString();
    }

        private void CmbDlutValution_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvntSy =  (CmbDlutValution.SelectedItem as DataRowView)["ValueMember"].ToString();
        }
    }
}
