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
    public partial class frmMnfact : Form
    {
        connect cnt = new connect();
        int _firmCode;
   
          
        public frmMnfact()
        {
            InitializeComponent();
        }

        private void firmMunfactr_Load(object sender, EventArgs e)
        {
           
            cnt.ContrlParameter(this);
            cnt.GridVw(dgwmanu);
            cnt.mydgv("select [FirmCode] ,[FirmName] from omrc","omrc", dgwmanu);
            _firmCode= cnt.GetSeries("Select MAX(CAST(FirmCode AS Integer)) + 1 as MaxNo From omrc");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxFirmName.Equals(""))
            {
                SqlConnection con = new SqlConnection(cnt.mycon());
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into omrc ([FirmCode] ,[FirmName]) values(@FirmCode , @FirmName)";
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
                if (con.State == ConnectionState.Open)                {
                    cmd.Parameters.AddWithValue("@FirmCode", _firmCode);
                    cmd.Parameters.AddWithValue("@FirmName", TxFirmName.Text);
                    try                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Added");
                        con.Close();                    }
                    catch (Exception c) { MessageBox.Show(c.Message + "Data Not Added"); }
                }
            }
            else { MessageBox.Show("Please Add Firm Name"); }

        }
    }
}
