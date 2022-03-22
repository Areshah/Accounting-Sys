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
    public partial class frmusrmgmnt : Form
    {
        connect cnt = new connect();
        int usgrp = 0;
        public frmusrmgmnt()
        {
            InitializeComponent();
        }

       



        private void frmusrmgmnt_Load(object sender, EventArgs e)
        {
           
            
            cnt.mydgv("select [UserID],[User_code],[UserName],[Group1] ,[Email] ,[Contact],[Branch] ,[Department] ,[SuperUsr],[MobileUser] from ousr", "ousr", dgwusr);
           cnt.GridVw(dgwusr);
            cnt.ContrlParameter(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", "Confirmatuon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void tsbQuit_Click_1(object sender, EventArgs e)
        {
            connect cnt = new connect();
            DialogResult rslt;
            rslt = MessageBox.Show("Are you Sure want to Quit", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rslt == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void ChToolStrpAdd_Click(object sender, EventArgs e)
        {
            connect cnt = new connect();
            SqlConnection conn = new SqlConnection(cnt.mycon());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;


            cmd.CommandText = "Insert into OUSR (User_code,Password,UserName,Group1,Email,Contact,Branch,Department,SuperUsr,MobileUser) values(@User_code,@Password,@UserName,@Group1,@Email,@Contact,@Branch,@Department,@SuperUsr,@MobileUser)";

            if (conn.State == ConnectionState.Open)
            {

                cmd.Parameters.AddWithValue("@User_code", TxUsrCode.Text);
                cmd.Parameters.AddWithValue("@Password", TxPassword.Text);
                cmd.Parameters.AddWithValue("@UserName", cnt.GetProperCase(TxUsrName.Text));
                cmd.Parameters.AddWithValue("@Group1", ChkSUpUsr.Checked ? 100 : usgrp);
                cmd.Parameters.AddWithValue("@Email", TxEmailID.Text);
                cmd.Parameters.AddWithValue("@Contact", TxMobile.Text);
                cmd.Parameters.AddWithValue("@Branch", cnt.GetProperCase(TxBranch.Text));
                cmd.Parameters.AddWithValue("@Department", CMDept.Text);
                cmd.Parameters.AddWithValue("@SuperUsr", ChkSUpUsr.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@MobileUser", TxMobileUsr.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Source + " data");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }

       private void ChkMobUsr_CheckedChanged(object sender, EventArgs e)
        {
            // ChkMobUsr.Checked ?TxMobileUsr.Locked=true:TxMobileUsr.Locked = false;
        }

        private void TxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back)) {
                // 0 – 9 && keyChar != 8 backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                e.Handled = true ;

            }
        }

        private void TxFaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 13) && (e.KeyChar != (char)Keys.Back))
            {
                // 0 – 9 && keyChar != 8 backspace // enter && keyChar != 'X' && keyChar != 'x' &&
                e.Handled = true;

            }
        }

        private void ChToolStrpPrev_Click(object sender, EventArgs e)
        {
            FrmMDI mdfrm = new FrmMDI();
            mdfrm.userListToolStripMenuItem_Click(sender,  e);
        }

        private void cmbUserType_Enter(object sender, EventArgs e)
        {
            cmbUserType.DataSource = cnt.FncUsrtype();
            cmbUserType.DisplayMember = "DisplayMember";
            cmbUserType.ValueMember = "ValueMember";

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            usgrp=Convert.ToInt32((cmbUserType.SelectedItem as DataRowView)["ValueMember"]);
        }
    }
}
