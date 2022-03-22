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
    public partial class JobOrderFrm : Form
    {
        public JobOrderFrm()
        {
            InitializeComponent();
        }
        connect cnt = new connect();
        private void JobOrderFrm_Load(object sender, EventArgs e)
        {
            cnt.ContrlParameter(this);
            cnt.GridVw(JoGdatagr);


        }





        private void CmbProd_KeyDown(object sender, KeyEventArgs e)
        {
            cnt.mycmb("Select itemcode,  Itemname  from OITM", "oitm", "ItemName", "itemcode", CmbItemGrp);
        }

        private void CHkISPic_CheckedChanged(object sender, EventArgs e)
        {
            if (CHkISPic.Checked) { AttachPic.Enabled = true; }
            else { AttachPic.Enabled = false; }
        }



        private void vendorcombo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void vendorcombo_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='v'", "ocrd", "CardName", "CardCode", vendorcombo);
        }

        private void CmbCustName_Enter(object sender, EventArgs e)
        {
            cnt.mycmb("select CardCode,CardName from ocrd where CardType ='c'", "ocrd", "CardName", "CardCode", CmbCustName);
        }

        private void txnocopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }

        private void selprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }

        private void txsqwith_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }
        private void txsqheigh_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }
        private void TXMetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    // 0 – 9 && keyChar != 8   backspace // enter && keyChar != 'X' && keyChar != 'x' &&

                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {    

                e.Handled = true;

            }
        }
    }
}