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
    public partial class frmnewitem : Form
    {
        connect cnt = new connect();
        private static string itmtprow ;
        private static Int32 ItmsGrpCod, locfirmCode;
        private static Int32 UgpEntry;

        public frmnewitem()         {             InitializeComponent();        }

   
        private void frmnewitem_Load(object sender, EventArgs e)        {
            
            cnt.ContrlParameter(this);
           
            
                        CmbItemType.DataSource = cnt.cmbsrwl();
            CmbItemType.DisplayMember = "DisplayMember";
            CmbItemType.ValueMember = "ValueMember";        }

               private void cmbUgpEntry_SelectedIndexChanged(object sender, EventArgs e)        {  
           UgpEntry = Convert.ToInt32((cmbUgpEntry.SelectedItem as DataRowView)["umocode"]);        }
                private void cmbItmsGrpCod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ItmsGrpCod = Convert.ToInt32((cmbItmsGrpCod.SelectedItem as DataRowView)["groupcode"]);
        }

         
        private void CmbManuf_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select firmcode,Firmname from omrc", "omrc", "Firmname", "firmcode", CmbManuf);
        }

        private void CmbManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            locfirmCode = Convert.ToInt32((CmbManuf.SelectedItem as DataRowView)["FirmCode"]);
        }

        private void ChToolStrpAdd_Click_1(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into OITM ([itemcode],[ItemName],[ItemType],[ItmsGrpCod],[InvntItem],[SellItem],[PrchseItem],[CodeBars],[NoDiscount],[VATLiable],[AvgPrice],[InvntryUom],[FirmCode]) values(@itemcode,@ItemName,@ItemType,@ItmsGrpCod,@InvntItem,@SellItem,@PrchseItem,@CodeBars,@NoDiscount,@VATLiable,@AvgPrice,@InvntryUom,@FirmCode)";
            if (conn.State == ConnectionState.Open)             {
                 cmd.Parameters.AddWithValue("@ItemCode", ItemCode.Text);
                cmd.Parameters.AddWithValue("@ItemName", TxItemName.Text);
                //  cmd.Parameters.AddWithValue("@FrgnName", TxFrgnName.Text);
                cmd.Parameters.AddWithValue("@ItemType", itmtprow);
                cmd.Parameters.AddWithValue("@ItmsGrpCod", Convert.ToInt32(ItmsGrpCod));
                cmd.Parameters.AddWithValue("@InvntItem", ChkInvntItem.Checked ? "Y" : "N");
                cmd.Parameters.AddWithValue("@SellItem", ChkSellItem.Checked ? "Y" : "N");
                cmd.Parameters.AddWithValue("@PrchseItem", ChkPrchseItem.Checked ? "Y" : "N");
                cmd.Parameters.AddWithValue("@CodeBars", TxCodeBars.Text);
                cmd.Parameters.AddWithValue("@NoDiscount", ChkNoDiscount.Checked ? "Y" : "N");
                cmd.Parameters.AddWithValue("@VATLiable", ChkVATLiable.Checked ? "Y" : "N");
                cmd.Parameters.AddWithValue("@AvgPrice", TxItmCost.Text);
                cmd.Parameters.AddWithValue("@InvntryUom", TxInvUom.Text);
                cmd.Parameters.AddWithValue("@FirmCode", Convert.ToInt32(locfirmCode));
                try                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();                }
                finally { }
            }
        }

        private void cmbItmsGrpCod_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select ItmsGrpCod,ItmsGrpNam from  oitb", "oitb", "ItmsGrpNam", "ItmsGrpCod", cmbItmsGrpCod);
        }

        private void cmbUgpEntry_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select uomcode,UomName  from ouom", "ouom", "uomcode", "UomName", cmbUgpEntry);
        }

        private void CmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            itmtprow = (CmbItemType.SelectedItem as DataRowView)["ValueMember"].ToString();
        }
    }
}