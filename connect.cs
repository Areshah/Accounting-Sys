using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Accounting_Sys{
    class connect
    {
        string strcn;
        public string HdrName = "SMT Consulting Group";
        public static string UsrCode; 
           
      public  string mycon()        {

            //  this.strcn = @"Data Source=DESKTOP-IJURSQS;Initial Catalog=AccErp;Integrated Security=True";
            this.strcn = @"Server=(local);DataBase=Amio;Integrated Security=SSPI";
            // this.strcn = @"Provider =Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Fashio/Documents/Visual Studio 2012/Projects/Accounting Sys/Sap_db.accdb";
            return strcn;        }

      public void mydgv(string str, string tbl, DataGridView dgv)     {
                        SqlConnection con = new SqlConnection(mycon());           
          con.Open();
                   SqlDataAdapter   adap = new SqlDataAdapter(str, con);
          DataSet dtset = new DataSet();
          DataTable dttab = new DataTable();
         adap.Fill(dtset, tbl);
        dttab = dtset.Tables[0];
         dgv.DataSource = dttab;
          con.Close();
          con.Dispose();
      }
        public string GetProperCase(string StringForConvert)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo TextInfo = cultureInfo.TextInfo;
            return TextInfo.ToTitleCase(StringForConvert);        }

        public void ContrlParameter(Form frm)        {
            // Gride view 830, 340 951, 230  Form  1040, 491,  445, 378
            frm.BackColor = System.Drawing.Color.White;
            frm.Font = new System.Drawing.Font("Calibri", 11);
            frm.ForeColor = System.Drawing.Color.Black;
            // frm.MaximizeBox = false;
          //  frm.MinimizeBox = false;
           
            foreach (Control x in frm.Controls)
            {
                if (x is TextBox)
                {
                    x.BackColor = System.Drawing.Color.Cornsilk;
                    x.Font = new System.Drawing.Font("Calibri", 11);
                    x.ForeColor = System.Drawing.Color.DarkBlue;
                                    

                }

                else if (x is GroupBox)
                {
                    x.BackColor = System.Drawing.Color.Wheat;

                    x.ForeColor = System.Drawing.Color.Black;
                }

                else if (x is Button)
                {
                    x.BackColor = System.Drawing.Color.SlateBlue;
                    x.ForeColor = System.Drawing.Color.White;
                    GraphicsPath p = new GraphicsPath();
                    p.AddEllipse(1, 1, x.Width - 4, x.Height - 4);
                    x.Region = new Region(p);
                    
                }
                else if  (x is Label)
                {
                    x.BackColor = System.Drawing.Color.Transparent;

                    x.ForeColor = System.Drawing.Color.DarkBlue;
                }
                else if (x is ComboBox)
                {
                    x.BackColor = System.Drawing.Color.Wheat;
                    x.Font = new System.Drawing.Font("Calibri", 11);
                    x.ForeColor = System.Drawing.Color.DarkBlue;
                }
           

            }
        }
        public void mycmb(string str, string tbl, string distx, string valu, ComboBox cmb)
        {
            SqlConnection con = new SqlConnection(mycon());
         con.Open();
            SqlDataAdapter adap = new SqlDataAdapter(str, con);
            DataSet dtset = new DataSet();
            DataTable dttab = new DataTable();
            adap.Fill(dtset, tbl);
                        cmb.DataSource = dtset.Tables[0];
            cmb.ValueMember = valu;
            cmb.DisplayMember = distx;
                con.Close();
            con.Dispose();

        }


       public  void GridVw(DataGridView x)
        {
            x.EnableHeadersVisualStyles = false;
          //  x.AllowUserToAddRows = false;
            x.AllowUserToDeleteRows = false;
            x.AllowUserToOrderColumns = false;
           // x.ReadOnly = true;
            x.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            x.MultiSelect = false;
            x.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            x.AllowUserToResizeColumns = false;
            x.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            x.AllowUserToResizeRows = false;
            x.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        //  Dgv1.Columns["SupplierID"].DefaultCellStyle.Format = "y"; Error }
                        x.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               x.DefaultCellStyle.BackColor = Color.GhostWhite; //Change All Gride 
            x.DefaultCellStyle.SelectionForeColor = Color.Black; //Change selected Row's fore Color
            x.DefaultCellStyle.SelectionBackColor = Color.LightCoral; //Change selected Row's fore Color
            x.GridColor = SystemColors.ActiveBorder;
            x.RowHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            //  Dgv1.Columns["SupplierID"].DefaultCellStyle.Format = "y"; Error
           // x.DefaultCellStyle.BackColor = Color.NavajoWhite;
            x.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            x.DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
            x.BackgroundColor = Color.LavenderBlush;
            x.BorderStyle = BorderStyle.Fixed3D;
            x.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            x.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
        }
        public DataTable RtnQry(string qry)
        {
            SqlConnection con = new SqlConnection(mycon());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = qry;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            con.Close();
            return dtbl;
        }
            
         public void SaveDataMaster(string qry)        {
            SqlConnection con = new SqlConnection(mycon());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();        }

        public DataTable cmbsrwl()        {
            DataTable dtblDataSource = new DataTable();
            dtblDataSource.Columns.Add("DisplayMember");
            dtblDataSource.Columns.Add("ValueMember");
            dtblDataSource.Rows.Add("Items", "I");
            dtblDataSource.Rows.Add("Service", "S");
            dtblDataSource.Rows.Add("Travel", "T");
            return dtblDataSource;   }
             public DataTable FncUsrtype()        {
            DataTable DtblDSource = new DataTable();
            DtblDSource.Columns.Add("DisplayMember");
            DtblDSource.Columns.Add("ValueMember");
            DtblDSource.Rows.Add("Account / Finance", 10);
            DtblDSource.Rows.Add("Dispatch", 20);
            DtblDSource.Rows.Add("Inventory / Purchase", 30);
            DtblDSource.Rows.Add("Prepress", 40);
            DtblDSource.Rows.Add("Operations", 50);
            DtblDSource.Rows.Add("Sale / Marketing", 60);
            return DtblDSource;        }

        public int GetSeries(String str)
        {
            int _CustID;
            SqlConnection con = new SqlConnection(mycon());
            con.Open();
            string strSQL = str ;
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.Text;
            if (cmd.ExecuteNonQuery() > 0)
            {
               return _CustID = 1;
            }
            else
            {
               return _CustID = (int)cmd.ExecuteScalar();
            }
            con.Close();

        }




    }

}
