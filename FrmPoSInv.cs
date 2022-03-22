using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Sys
{
    public partial class FrmPoSInv : Form
    {
        connect cnt = new connect();
        public FrmPoSInv()
        {
            InitializeComponent();
        }

        private void APInvoice_Load(object sender, EventArgs e)
        {

            cnt.ContrlParameter(this);
               cnt.GridVw(DGvPOS1);
            TxGrtotal1.Font = new System.Drawing.Font("Calibri", 24);
            TxGrpItm.Font= new System.Drawing.Font("Calibri", 24);
            CmbCustPOS1.Text = "Cash";
            cnt.mydgv("select productId,ProductName ,CategoryId,Discontinued,UnitPrice,(CategoryId *UnitPrice -Discontinued) As TotalAmount from Nwind17.dbo.Product","product",DGvPOS1);
        }

        private void CmbCustPOS1_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='c'", "ocrd", "CardName", "CardCode", CmbCustPOS1);
        }

        private void CmbCustPOS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxCardIDPOS1.Text = (CmbCustPOS1.SelectedItem as DataRowView)["CardCode"].ToString();
        }

      //  private void CmbItmName1_Enter(object sender, EventArgs e)
     ///////   {
          //  cnt.mycmb("Select itemcode, Itemname  from OITM  where itemtype = 'i' ", "OITM", "Itemname", "itemcode", CMBItMPos1);
      //  }

        private void CMBItMPos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxItmPos1.Text = (CMBItMPos1.SelectedItem as DataRowView)["itemcode"].ToString();
        }

       

        private void CmbCustPOS2_SelectedIndexChanged(object sender, EventArgs e)
        {
         ////   TxCardIDPOS2.Text = (CmbCustPOS2.SelectedItem as DataRowView)["CardCode"].ToString();
        }

       

       
        private void CMBItMPos1_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("Select itemcode, Itemname  from OITM  where itemtype = 'i' ", "OITM", "Itemname", "itemcode", CMBItMPos1);
        }

        private void CmbTax_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select name,Rate from OSTC", "OSTC", "name", "Rate", CmbTax);
        }

        private void CmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
              TxRate.Text = (CmbTax.SelectedItem as DataRowView)["Rate"].ToString();
        }
    }
}
