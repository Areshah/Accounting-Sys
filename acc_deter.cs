using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Accounting_Sys
{
    public partial class acc_deter : Form
    {
        connect cnt = new connect();
        public acc_deter()
        {
            InitializeComponent();
        }

        private void acc_deter_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(DGAccDetr);
                        string qry = "Select  acctcode,acctname from oact  ";
            SqlConnection con = new SqlConnection(cnt.mycon());
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            DataSet dtset = new DataSet();
            adap.Fill(dtset, "oact");
            dtable = dtset.Tables[0];
            BindingSource bindingSourceItem = new BindingSource();
            bindingSourceItem.DataSource = dtable;
            DataGridViewComboBoxColumn cmbusr = new DataGridViewComboBoxColumn();
            cmbusr.DataPropertyName = "acctname";
            cmbusr.HeaderText = "Chart of Account";
            cmbusr.Width = 340;
            cmbusr.DataSource = bindingSourceItem;
            cmbusr.ValueMember = "acctcode";
            cmbusr.DisplayMember = "acctname";
            DGAccDetr.Columns.Insert(0, cmbusr);
            //_______________________2nd Column
           
            string qry2 = "Select HeadName from Acctdeter";
            SqlCommand cmd2 = new SqlCommand(qry2, con);
            SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
            DataTable dtable2 = new DataTable();
           // DataSet dtset2 = new DataSet();
          //  adap2.Fill(dtset2, "AccTDeter");
          //  dtable2 = dtset2.Tables["AccTDeter"];
            BindingSource bindingSourceItem2 = new BindingSource();
            bindingSourceItem2.DataSource = dtable2;
            DataGridViewComboBoxColumn cmbusr2 = new DataGridViewComboBoxColumn();
            cmbusr2.DataPropertyName = "HeadName";
            cmbusr2.HeaderText = "Account Head";
            cmbusr2.Width = 340;
            cmbusr2.DataSource = bindingSourceItem2;
            cmbusr2.DisplayMember = "HeadName";
          //  DGAccDetr.Columns.Insert(1, cmbusr2);

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string urrnt;
            DataTable DTACCHdr= new DataTable();
            DTACCHdr.Columns.Add("COA");
            DTACCHdr.Columns.Add("Neader");
            for(int i=0; i< DGAccDetr.Rows.Count - 1; i++) { 
            DTACCHdr.Rows.Add(DGAccDetr.Rows[i].Cells[0].Value,DGAccDetr.Rows[i].Cells[1].Value);
            }
            urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            StreamWriter objWriter = new StreamWriter(urrnt + "ledger.txt", false);
            var result = new StringBuilder(); foreach (DataRow row in DTACCHdr.Rows)
            {
                for (int i = 0; i < DTACCHdr.Columns.Count; i++)
                {
                    result.Append(row[i].ToString());
                    result.Append(i == DTACCHdr.Columns.Count - 1 ? "\n" : ",");
                }
                result.AppendLine();
            }
            objWriter.WriteLine(result.ToString()); objWriter.Close();


        }
    }
}
