using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;


namespace Accounting_Sys
{
    public partial class FrmMDI : Form
    {
        private int childFormNumber = 0;
        connect cnt = new connect();
        public FrmMDI()
        {
            InitializeComponent();
        }



        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin1 = new frmlogin();
            frmlogin1.MdiParent = this;
            frmlogin1.Show();
        }

        private void logFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmopcomp frmopcomp1 = new frmopcomp();
            frmopcomp1.MdiParent = this;
            frmopcomp1.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogfile frmlogfile1 = new frmlogfile();
            frmlogfile1.MdiParent = this;
            frmlogfile1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Calc");
        }





        private void customerLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custledger custledger1 = new custledger();
            custledger1.MdiParent = this;
            custledger1.Show();
        }

        private void profitLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proflost proflost1 = new proflost();
            proflost1.MdiParent = this;
            proflost1.Show();
        }
        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmusrmgmnt frmusrmgmnt1 = new frmusrmgmnt();
            frmusrmgmnt1.MdiParent = this;
            frmusrmgmnt1.Show();
        }

        private void productOnvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoSInv APInv = new FrmPoSInv();
            APInv.MdiParent = this;
            APInv.Show();
        }

        private void serviceInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiceInv FrmServiceInv1 = new FrmServiceInv();
            FrmServiceInv1.MdiParent = this;
            FrmServiceInv1.Show();
        }

        private void dataBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbackups frmbackups1 = new frmbackups();
                frmbackups1.MdiParent = this;
           frmbackups1.Show();

        }

        private void systemInitializationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sysinitial sysinitial1 = new sysinitial();
            sysinitial1.MdiParent = this;
            sysinitial1.Show();
        }

        private void approvalManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authurization authurization1 = new authurization();
            if (this.ActiveMdiChild != null || authurization1 != null)
            {

                authurization1.MdiParent = this;
                ToolStripManager.Merge(authurization1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            authurization1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, authurization1.ChToolStrip1);
            };

            authurization1.Show();

        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alertmgmnt Alertmgmnt1 = new Alertmgmnt();
            if (this.ActiveMdiChild != null || Alertmgmnt1 != null)
            {

                Alertmgmnt1.MdiParent = this;
                ToolStripManager.Merge(Alertmgmnt1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            Alertmgmnt1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, Alertmgmnt1.ChToolStrip1);
            };

            Alertmgmnt1.Show();
        }

        private void currencySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrency frmCurrency1 = new frmCurrency();


            if (this.ActiveMdiChild != null || frmCurrency1 != null)
            {

                frmCurrency1.MdiParent = this;
                ToolStripManager.Merge(frmCurrency1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmCurrency1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmCurrency1.ChToolStrip1);
            };
            frmCurrency1.Show();


        }

        private void taxCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salInv salInv1 = new salInv();
            //  ToolStripManager.RevertMerge(toolStrip);
            //  ToolStripManager.RevertMerge(menuStrip);
            if (this.ActiveMdiChild != null || salInv1 != null)
            {
                salInv1.MdiParent = this;
                ToolStripManager.Merge(salInv1.ChToolStrip1, this.MDIToolStrp);
            }
            salInv1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, salInv1.ChToolStrip1);
            };
            salInv1.Show();
        }

        private void taxAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiceInv FrmServiceInv1 = new FrmServiceInv();
            if (this.ActiveMdiChild != null || FrmServiceInv1 != null)
            {
                FrmServiceInv1.MdiParent = this;
                ToolStripManager.Merge(FrmServiceInv1.ChToolStrip1, this.MDIToolStrp);
            }
            FrmServiceInv1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, FrmServiceInv1.ChToolStrip1);
            };

            FrmServiceInv1.Show();
        }

        private void customerMgmntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustinfo frmcustinfo1 = new frmcustinfo();
            if (this.ActiveMdiChild != null || frmcustinfo1 != null)
            {
                frmcustinfo1.MdiParent = this;
                ToolStripManager.Merge(frmcustinfo1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmcustinfo1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmcustinfo1.ChToolStrip1);
            };

            frmcustinfo1.Show();
        }

             private void itemListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmnewitem frmnewitem1 = new frmnewitem();
            if (this.ActiveMdiChild != null || frmnewitem1 != null)
            {
                frmnewitem1.MdiParent = this;
                ToolStripManager.Merge(frmnewitem1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmnewitem1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmnewitem1.ChToolStrip1);
            };

            frmnewitem1.Show();
        }

                       private void FrmMDI_Load(object sender, EventArgs e)        {
             cnt.ContrlParameter(this);
            grppoicy(100, "sss");
            SysTrayApp strv = new SysTrayApp();
            strv.Show();
             }

                private void employeesLoanToolStripMenuItem_Click(object sender, EventArgs e)        {
            frmempLoans frmempLoans1 = new frmempLoans();
            frmempLoans1.MdiParent = this;
            frmempLoans1.Show();        }
                private void transferToolStripMenuItem_Click(object sender, EventArgs e)        {
            frmChqSelection frmbanktransfer1 = new frmChqSelection();
            frmbanktransfer1.MdiParent = this;
            frmbanktransfer1.Show();        }




       

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusrmgmnt frmusrmgmnt1 = new frmusrmgmnt();
            if (this.ActiveMdiChild != null || frmusrmgmnt1 != null)
            {
                frmusrmgmnt1.MdiParent = this;
                ToolStripManager.Merge(frmusrmgmnt1.ChToolStrip1, this.MDIToolStrp);
            }
            frmusrmgmnt1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmusrmgmnt1.ChToolStrip1);
            };
            frmusrmgmnt1.Show();
        }

        private void changePassWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChngpass FrmChngpass1 = new FrmChngpass();
            FrmChngpass1.MdiParent = this;
            FrmChngpass1.Show();
        }

       

        private void enterEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeesclu Employeesclu1 = new Employeesclu();
            Employeesclu1.MdiParent = this;
            Employeesclu1.Show();
        }

        



        private void chartOfAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnwcoa frmcoa = new frmnwcoa();
            if (this.ActiveMdiChild != null || frmcoa != null)
            {

                frmcoa.MdiParent = this;
                ToolStripManager.Merge(frmcoa.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmcoa.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmcoa.ChToolStrip1);
            };

            frmcoa.Show();
        }

        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            suppliermgmnt frmmgnt = new suppliermgmnt();

            if (this.ActiveMdiChild != null || frmmgnt != null)
            {
                frmmgnt.MdiParent = this;
                ToolStripManager.Merge(frmmgnt.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmmgnt.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmmgnt.ChToolStrip1);
            };

            frmmgnt.Show();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoSInv frmmPoS = new FrmPoSInv();
            if (this.ActiveMdiChild != null || frmmPoS != null)
            {
                frmmPoS.MdiParent = this;
                //   ToolStripManager.Merge(frmmPoS.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmmPoS.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ////    ToolStripManager.RevertMerge(this.MDIToolStrp, frmmPoS.ChToolStrip1);
            };

            frmmPoS.Show();

        }

                private void bankSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string directory, sql;

            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "SELECT BankName,Branch,Account,Curncy FROM  OCRB";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "OCRB");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\BnkStup.rpt");
            cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "Bank SetUP");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();
        }

        public void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string directory, sql;

            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "Select User_Code,UserName,Group1,Contact,MobileUser from OUSR";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "ousr");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\UserMgmt.rpt");
            cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "User Managment");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JobOrderFrm jborfrm = new JobOrderFrm();
            if (this.ActiveMdiChild != null || jborfrm != null)
            {
                jborfrm.MdiParent = this;
                ToolStripManager.Merge(jborfrm.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            jborfrm.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, jborfrm.ChToolStrip1);
            };

            jborfrm.Show();
        }
        public class SysTrayApp : Form
        {
            private NotifyIcon trayIcon;
            private ContextMenu trayMenu;
            public SysTrayApp()
            {
                // Create a simple tray menu with only one item.
                trayMenu = new ContextMenu();
                trayMenu.MenuItems.Add("Exit", OnExit);
                // Create a tray icon. In this example we use a
                // standard system icon for simplicity, but you
                // can of course use your own custom icon too.
                trayIcon = new NotifyIcon();
                trayIcon.Text = "SMT Consulting Group";
            //    trayIcon.Icon = new Icon(@"C: \Users\Fashio\Documents\Visual Studio 2015\Projects\Accounting Sys\Accounting Sys\Images\Users.ico", 40, 40);
                trayIcon.BalloonTipText = "SMT Account & Finanace ERP .";
                trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                trayIcon.BalloonTipTitle = "Administration Mode ";
                // Add menu to tray icon and show it.
                trayIcon.ContextMenu = trayMenu;
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(3000);
            }
            protected override void OnLoad(EventArgs e)
            {
                Visible = false; // Hide form window.
                ShowInTaskbar = false; // Remove from taskbar.
                base.OnLoad(e);
            }
            private void OnExit(object sender, EventArgs e)
            {
                Application.Exit();
            }
            protected override void Dispose(bool isDisposing)
            {
                if (isDisposing)
                {
                    // Release the icon resource.
                    trayIcon.Dispose();
                }
                base.Dispose(isDisposing);
            }
        }
        private void trayIcon_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.
            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            // Activate the form.
            this.Activate();
        }

        private void chartOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string directory, sql;

            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "select AcctCode,AcctName,Levels ,CurrTotal ,CreateDate,UpdateDate from OACT";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "oact");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\Acc_List.rpt");
            cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "Chart of Account");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string directory, sql;
            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "select AcctCode,AcctName,CurrTotal from OACT";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "oact");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\BalncSheet.rpt");
            // cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "Balance Sheet");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();

            MessageBox.Show("SqlEvent Insertion. Dll is Missing Please Reinstall", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmJrnlEntry JVEntry = new frmJrnlEntry();
            if (this.ActiveMdiChild != null || JVEntry != null)
            {
                JVEntry.MdiParent = this;
                ToolStripManager.Merge(JVEntry.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            JVEntry.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, JVEntry.ChToolStrip1);
            };
            JVEntry.Show();
        }

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemGrp ItmGrp = new frmItemGrp();
            if (this.ActiveMdiChild != null || ItmGrp != null)
            {
                ItmGrp.MdiParent = this;
                ToolStripManager.Merge(ItmGrp.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            ItmGrp.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, ItmGrp.ChToolStrip1);
            };
            ItmGrp.Show();
        }

        private void warehouseSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wheSetUp whestp = new wheSetUp();
            if (this.ActiveMdiChild != null || whestp != null)
            {
                whestp.MdiParent = this;
                ToolStripManager.Merge(whestp.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            whestp.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, whestp.ChToolStrip1);
            };
            whestp.Show();
        }

        private void manufacturerFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMnfact frmmanu = new frmMnfact();
            frmmanu.MdiParent = this;
            frmmanu.Show();


        }

        private void customerGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustGroup custgrp = new CustGroup();
            custgrp.MdiParent = this;
            custgrp.Show();
        }

        private void vendorGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendrGroup vndrGrp = new VendrGroup();
            vndrGrp.MdiParent = this;
            vndrGrp.Show();
        }

        private void salesTaxCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bedget Intialization Required Please Contact Your System Administration", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void costCentersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cost Center Intialization Required Please Contact Your System Administration", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }

        private void fixedAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fixed Assets Intialization Required Please Contact Your System Administration", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }

        private void projectCostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Costing intialization Required Please Contact Your System Administration", cnt.HdrName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }

        private void companySnapShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleOpport frmoprt = new frmSaleOpport();
            if (this.ActiveMdiChild != null || frmoprt != null)
            {
                frmoprt.MdiParent = this;
                ToolStripManager.Merge(frmoprt.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmoprt.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmoprt.ChToolStrip1);
            };
            frmoprt.Show();

        }

        private void stockingToolStripMenuItem_Click(object sender, EventArgs e)

        {
            frmStockStatus frmmStckt = new frmStockStatus();
            if (this.ActiveMdiChild != null || frmmStckt != null)
            {
                frmmStckt.MdiParent = this;
                ToolStripManager.Merge(frmmStckt.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmmStckt.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmmStckt.ChToolStrip1);
            };

            frmmStckt.Show();
        }

        

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelivry frmdlivry = new frmDelivry();

            if (this.ActiveMdiChild != null || frmdlivry != null)
            {
                frmdlivry.MdiParent = this;
                ToolStripManager.Merge(frmdlivry.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmdlivry.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmdlivry.ChToolStrip1);

            };
            frmdlivry.Show();
        }

       

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlOrder frmslordr = new frmSlOrder();
            if (this.ActiveMdiChild != null || frmslordr != null)
            {
                frmslordr.MdiParent = this;
                ToolStripManager.Merge(frmslordr.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmslordr.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmslordr.ChToolStrip1);
            };
            frmslordr.Show();

        }

        private void saleQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSLQoute slqut = new frmSLQoute();
            if (this.ActiveMdiChild != null || slqut != null)
            {
                slqut.MdiParent = this;
                ToolStripManager.Merge(slqut.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            slqut.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, slqut.ChToolStrip1);
            };
            slqut.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchRequstt purreq = new frmPurchRequstt();
            if (this.ActiveMdiChild != null || purreq != null)
            {
                purreq.MdiParent = this;
                ToolStripManager.Merge(purreq.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            purreq.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, purreq.ChToolStrip1);
            };
            purreq.Show();
        }

        private void createEstinateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurQuot frmprqou = new frmPurQuot();
            if (this.ActiveMdiChild != null || frmprqou != null)
            {
                frmprqou.MdiParent = this;
                ToolStripManager.Merge(frmprqou.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmprqou.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmprqou.ChToolStrip1);
            };
            frmprqou.Show();
        }

        private void createSaleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurOrdr frmpUPo = new frmPurOrdr();
            if (this.ActiveMdiChild != null || frmpUPo != null)
            {
                frmpUPo.MdiParent = this;
                ToolStripManager.Merge(frmpUPo.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmpUPo.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmpUPo.ChToolStrip1);
            };
            frmpUPo.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodRec gdsRecep = new frmGoodRec();
            if (this.ActiveMdiChild != null || gdsRecep != null)
            {
                gdsRecep.MdiParent = this;
                ToolStripManager.Merge(gdsRecep.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            gdsRecep.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, gdsRecep.ChToolStrip1);
            };
            gdsRecep.Show();

        }

        private void invoiceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurInv purInv = new frmPurInv();
            if (this.ActiveMdiChild != null || purInv != null)
            {
                purInv.MdiParent = this;
                ToolStripManager.Merge(purInv.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            purInv.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, purInv.ChToolStrip1);
            };
            purInv.Show();
        }

        private void aPCreditMemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmARCrMemo apcrmem = new frmARCrMemo();
            if (this.ActiveMdiChild != null || apcrmem != null)
            {
                apcrmem.MdiParent = this;
                ToolStripManager.Merge(apcrmem.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            apcrmem.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, apcrmem.ChToolStrip1);
            };

            apcrmem.Show();

        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposit frmbnkdpo = new frmDeposit();
            if (this.ActiveMdiChild != null || frmbnkdpo != null)
            {
                frmbnkdpo.MdiParent = this;
                ToolStripManager.Merge(frmbnkdpo.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmbnkdpo.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmbnkdpo.ChToolStrip1);
            };
            frmbnkdpo.Show();
        }

        private void outgoingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutPay frmOutPy = new frmOutPay();
            if (this.ActiveMdiChild != null || frmOutPy != null)
            {
                frmOutPy.MdiParent = this;
                ToolStripManager.Merge(frmOutPy.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmOutPy.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmOutPy.ChToolStrip1);
            };
            frmOutPy.Show();
        }

        private void incomingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncmPyvch FrmIncPay = new frmIncmPyvch();
            if (this.ActiveMdiChild != null || FrmIncPay != null)
            {
                FrmIncPay.MdiParent = this;
                ToolStripManager.Merge(FrmIncPay.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            FrmIncPay.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, FrmIncPay.ChToolStrip1);
            };
            FrmIncPay.Show();
        }

        private void productionOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdionOrdr frmprdnordr = new FrmProdionOrdr();
            if (this.ActiveMdiChild != null || frmprdnordr != null)
            {
                frmprdnordr.MdiParent = this;
                ToolStripManager.Merge(frmprdnordr.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmprdnordr.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmprdnordr.ChToolStrip1);
            };
            frmprdnordr.Show();
        }
          private void serviceContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicentry frmsrventr = new servicentry();
            if (this.ActiveMdiChild != null || frmsrventr != null)
            {
                frmsrventr.MdiParent = this;
                ToolStripManager.Merge(frmsrventr.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmsrventr.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmsrventr.ChToolStrip1);
            };
            frmsrventr.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PayrolSetUp frmpysetUp = new PayrolSetUp();
            if (this.ActiveMdiChild != null || frmpysetUp != null)
            {
                frmpysetUp.MdiParent = this;
                ToolStripManager.Merge(frmpysetUp.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmpysetUp.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmpysetUp.ChToolStrip1);
            };
            frmpysetUp.Show();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurRetrn frmpurRtrn = new frmPurRetrn();
            if (this.ActiveMdiChild != null || frmpurRtrn != null)
            {
                frmpurRtrn.MdiParent = this;
                ToolStripManager.Merge(frmpurRtrn.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmpurRtrn.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmpurRtrn.ChToolStrip1);
            };
            frmpurRtrn.Show();
        }

        private void aPCrediMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmARCrMemo frmmArCrMemgnt = new frmARCrMemo();

            if (this.ActiveMdiChild != null || frmmArCrMemgnt != null)
            {
                frmmArCrMemgnt.MdiParent = this;
                ToolStripManager.Merge(frmmArCrMemgnt.ChToolStrip1, this.MDIToolStrp);
            }

            frmmArCrMemgnt.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmmArCrMemgnt.ChToolStrip1);
            };
            frmmArCrMemgnt.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlook");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlook");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("word");
        }
        public void grppoicy(int bb ,string str1)
        {
            connect.UsrCode = str1;
            if (bb == 11)
            {
                // Admin tool Strip
                
                usersToolStripMenuItem.Enabled = false;
                dataBackupsToolStripMenuItem.Enabled = false;
                systemInitializationToolStripMenuItem1.Enabled = false;
                approvalManagerToolStripMenuItem.Enabled = false;
                authorizationToolStripMenuItem.Enabled = false;
                //------------------------------------General
                userToolStripMenuItem.Enabled = false;
                changePassWordToolStripMenuItem1.Enabled = false;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = false;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = false;
   
                saleTaxCodeToolStripMenuItem.Enabled = false;
                saleTaxDeterminationToolStripMenuItem.Enabled = false;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = false;
                houseBankAccountToolStripMenuItem.Enabled = false;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = false;
                warehouseSetupToolStripMenuItem.Enabled = false;
                uoMMeasureSetupToolStripMenuItem.Enabled = false;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = false;
                typeSetupToolStripMenuItem.Enabled = false;
                binLocationFieldActivationToolStripMenuItem.Enabled = false;
                binLocationAttributeCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = false;
                customsGroupToolStripMenuItem.Enabled = false;
                manufacturerFirmToolStripMenuItem.Enabled = false;
                inventoryCycleToolStripMenuItem.Enabled = false;


                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = false;
                vendorGroupToolStripMenuItem.Enabled = false;
                paymentTermSetuipToolStripMenuItem.Enabled = false;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = false;
                // ---------------Resource
                resoursceGroupToolStripMenuItem.Enabled = false;
                resourscePropertiesToolStripMenuItem.Enabled = false;
                //------------Service
                contractTemplateToolStripMenuItem.Enabled = false;
                queuesToolStripMenuItem.Enabled = false;

                //------------Finance
                toolStripMenuItem10.Enabled = false;
                chartOfAccToolStripMenuItem.Enabled = false;
                salesTaxCodeToolStripMenuItem.Enabled = false;
                fixedAssetsToolStripMenuItem.Enabled = false;
                projectCostingToolStripMenuItem.Enabled = false;
                costCentersToolStripMenuItem.Enabled = false;
                accountDeterminitionToolStripMenuItem.Enabled = false;

                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = false;
                taxAgencyToolStripMenuItem.Enabled = false;
                createInvoiceToolStripMenuItem.Enabled = false;
                aPCrediMemoToolStripMenuItem.Enabled = false;
                deliveryToolStripMenuItem.Enabled = false;
                saleOrderToolStripMenuItem.Enabled = false;
                saleQuotationToolStripMenuItem.Enabled = false;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = false;
                createEstinateToolStripMenuItem.Enabled = false;
                createSaleInvoiceToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = false;
                invoiceRequestToolStripMenuItem.Enabled = false;
                aPCreditMemosToolStripMenuItem.Enabled = false;
                purchaseReturnToolStripMenuItem.Enabled = false;
                aPServiceInvoiceToolStripMenuItem.Enabled = false;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = false;
                barCodeToolStripMenuItem.Enabled = false;
                binLocationToolStripMenuItem1.Enabled = false;
                itemManagementToolStripMenuItem.Enabled = false;
                alternativeItemsToolStripMenuItem.Enabled = false;
                businessPartnerCatalogToolStripMenuItem.Enabled = false;
                inventoryValuationMethodToolStripMenuItem.Enabled = false;
                inventoryTransactionToolStripMenuItem1.Enabled = false;
                inventoryTransactionToolStripMenuItem.Enabled = false;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = false;
                inventoryCountRecommendationToolStripMenuItem.Enabled = false;
                inventoryRevaluationToolStripMenuItem.Enabled = false;
                priceListToolStripMenuItem.Enabled = false;

                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = false;
                billOfMaterialToolStripMenuItem.Enabled = false;
                receiptFromProductionToolStripMenuItem.Enabled = false;
                issueForProductionToolStripMenuItem.Enabled = false;
                updateParentItemPriceToolStripMenuItem.Enabled = false;
                manufactureringOrderToolStripMenuItem.Enabled = false;
                productionSchedulerToolStripMenuItem.Enabled = false;
                billOfMaterialComponentsToolStripMenuItem.Enabled = false;
                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   
                               serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;

                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }

          

          else  if (bb == 20)
            {
                // Admin tool Strip
                // Admin tool Strip
               
                usersToolStripMenuItem.Enabled = false;
                dataBackupsToolStripMenuItem.Enabled = false;
                systemInitializationToolStripMenuItem1.Enabled = false;
                approvalManagerToolStripMenuItem.Enabled = false;
                authorizationToolStripMenuItem.Enabled = false;
                //------------------------------------General
                userToolStripMenuItem.Enabled = false;
                changePassWordToolStripMenuItem1.Enabled = false;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = false;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = false;
            
                saleTaxCodeToolStripMenuItem.Enabled = false;
                saleTaxDeterminationToolStripMenuItem.Enabled = false;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = false;
                houseBankAccountToolStripMenuItem.Enabled = false;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = false;
                warehouseSetupToolStripMenuItem.Enabled = false;
                uoMMeasureSetupToolStripMenuItem.Enabled = false;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = false;
                typeSetupToolStripMenuItem.Enabled = false;
                binLocationFieldActivationToolStripMenuItem.Enabled = false;
                binLocationAttributeCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = false;
                customsGroupToolStripMenuItem.Enabled = false;
                manufacturerFirmToolStripMenuItem.Enabled = false;
                inventoryCycleToolStripMenuItem.Enabled = false;


                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = false;
                vendorGroupToolStripMenuItem.Enabled = false;
                paymentTermSetuipToolStripMenuItem.Enabled = false;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = false;
                // ---------------Resource
                resoursceGroupToolStripMenuItem.Enabled = false;
                resourscePropertiesToolStripMenuItem.Enabled = false;
                //------------Service
                contractTemplateToolStripMenuItem.Enabled = false;
                queuesToolStripMenuItem.Enabled = false;


                //------------Finance
                toolStripMenuItem10.Enabled = false;
                chartOfAccToolStripMenuItem.Enabled = false;
                salesTaxCodeToolStripMenuItem.Enabled = false;
                fixedAssetsToolStripMenuItem.Enabled = false;
                projectCostingToolStripMenuItem.Enabled = false;
                costCentersToolStripMenuItem.Enabled = false;
                accountDeterminitionToolStripMenuItem.Enabled = false;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = false;
                taxAgencyToolStripMenuItem.Enabled = false;
                createInvoiceToolStripMenuItem.Enabled = false;
                aPCrediMemoToolStripMenuItem.Enabled = false;
                deliveryToolStripMenuItem.Enabled = false;
                saleOrderToolStripMenuItem.Enabled = false;
                saleQuotationToolStripMenuItem.Enabled = false;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = false;
                createEstinateToolStripMenuItem.Enabled = false;
                createSaleInvoiceToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = false;
                invoiceRequestToolStripMenuItem.Enabled = false;
                aPCreditMemosToolStripMenuItem.Enabled = false;
                purchaseReturnToolStripMenuItem.Enabled = false;
                aPServiceInvoiceToolStripMenuItem.Enabled = false;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = false;
                barCodeToolStripMenuItem.Enabled = false;
                binLocationToolStripMenuItem1.Enabled = false;
                itemManagementToolStripMenuItem.Enabled = false;
                alternativeItemsToolStripMenuItem.Enabled = false;
                businessPartnerCatalogToolStripMenuItem.Enabled = false;
                inventoryValuationMethodToolStripMenuItem.Enabled = false;
                inventoryTransactionToolStripMenuItem1.Enabled = false;
                inventoryTransactionToolStripMenuItem.Enabled = false;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = false;
                inventoryCountRecommendationToolStripMenuItem.Enabled = false;
                inventoryRevaluationToolStripMenuItem.Enabled = false;
                priceListToolStripMenuItem.Enabled = false;

                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = true;
                billOfMaterialToolStripMenuItem.Enabled = true;
                receiptFromProductionToolStripMenuItem.Enabled = true;
                issueForProductionToolStripMenuItem.Enabled = true;
                updateParentItemPriceToolStripMenuItem.Enabled = true;
                manufactureringOrderToolStripMenuItem.Enabled = true;
                productionSchedulerToolStripMenuItem.Enabled = true;
                billOfMaterialComponentsToolStripMenuItem.Enabled = true;
                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   

                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;

                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }
          else  if (bb == 30)
            {
                // Admin tool Strip
                
                usersToolStripMenuItem.Enabled = false;
                dataBackupsToolStripMenuItem.Enabled = false;
                systemInitializationToolStripMenuItem1.Enabled = false;
                approvalManagerToolStripMenuItem.Enabled = false;
                authorizationToolStripMenuItem.Enabled = false;
                //------------------------------------General
                userToolStripMenuItem.Enabled = false;
                changePassWordToolStripMenuItem1.Enabled = false;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = false;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = false;
              
                saleTaxCodeToolStripMenuItem.Enabled = false;
                saleTaxDeterminationToolStripMenuItem.Enabled = false;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = false;
                houseBankAccountToolStripMenuItem.Enabled = false;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = false;
                warehouseSetupToolStripMenuItem.Enabled = false;
                uoMMeasureSetupToolStripMenuItem.Enabled = false;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = false;
                typeSetupToolStripMenuItem.Enabled = false;
                binLocationFieldActivationToolStripMenuItem.Enabled = false;
                binLocationAttributeCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = false;
                customsGroupToolStripMenuItem.Enabled = false;
                manufacturerFirmToolStripMenuItem.Enabled = false;
                inventoryCycleToolStripMenuItem.Enabled = false;
                                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = false;
                vendorGroupToolStripMenuItem.Enabled = false;
                paymentTermSetuipToolStripMenuItem.Enabled = false;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = false;
                // ---------------Resource
                resoursceGroupToolStripMenuItem.Enabled = false;
                resourscePropertiesToolStripMenuItem.Enabled = false;
                //------------Service
                contractTemplateToolStripMenuItem.Enabled = false;
                queuesToolStripMenuItem.Enabled = false;
                                //------------Finance
                toolStripMenuItem10.Enabled = false;
                chartOfAccToolStripMenuItem.Enabled = false;
                salesTaxCodeToolStripMenuItem.Enabled = false;
                fixedAssetsToolStripMenuItem.Enabled = false;
                projectCostingToolStripMenuItem.Enabled = false;
                costCentersToolStripMenuItem.Enabled = false;
                accountDeterminitionToolStripMenuItem.Enabled = false;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = false;
                taxAgencyToolStripMenuItem.Enabled = false;
                createInvoiceToolStripMenuItem.Enabled = false;
                aPCrediMemoToolStripMenuItem.Enabled = false;
                deliveryToolStripMenuItem.Enabled = false;
                saleOrderToolStripMenuItem.Enabled = false;
                saleQuotationToolStripMenuItem.Enabled = false;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = true;
                createEstinateToolStripMenuItem.Enabled = true;
                createSaleInvoiceToolStripMenuItem.Enabled = true;
                createToolStripMenuItem.Enabled = true;
                invoiceRequestToolStripMenuItem.Enabled = true;
                aPCreditMemosToolStripMenuItem.Enabled = true;
                purchaseReturnToolStripMenuItem.Enabled = true;
                aPServiceInvoiceToolStripMenuItem.Enabled = true;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;  
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = false;
                barCodeToolStripMenuItem.Enabled = false;
                binLocationToolStripMenuItem1.Enabled = false;
                itemManagementToolStripMenuItem.Enabled = false;
                alternativeItemsToolStripMenuItem.Enabled = false;
                businessPartnerCatalogToolStripMenuItem.Enabled = false;
                inventoryValuationMethodToolStripMenuItem.Enabled = false;
                inventoryTransactionToolStripMenuItem1.Enabled = false;
                inventoryTransactionToolStripMenuItem.Enabled = false;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = false;
                inventoryCountRecommendationToolStripMenuItem.Enabled = false;
                inventoryRevaluationToolStripMenuItem.Enabled = false;
                priceListToolStripMenuItem.Enabled = false;

                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = false;
                billOfMaterialToolStripMenuItem.Enabled = false;
                receiptFromProductionToolStripMenuItem.Enabled = false;
                issueForProductionToolStripMenuItem.Enabled = false;
                updateParentItemPriceToolStripMenuItem.Enabled = false;
                manufactureringOrderToolStripMenuItem.Enabled = false;
                productionSchedulerToolStripMenuItem.Enabled = false;
                billOfMaterialComponentsToolStripMenuItem.Enabled = false;

                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   

                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;

                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }

            //-------------------
            else if (bb == 40)
            {
                // Admin tool Strip
                // Admin tool Strip
               
                usersToolStripMenuItem.Enabled = false;
                dataBackupsToolStripMenuItem.Enabled = false;
                systemInitializationToolStripMenuItem1.Enabled = false;
                approvalManagerToolStripMenuItem.Enabled = false;
                authorizationToolStripMenuItem.Enabled = false;
                //------------------------------------General
                userToolStripMenuItem.Enabled = false;
                changePassWordToolStripMenuItem1.Enabled = false;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = false;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = false;
             
                saleTaxCodeToolStripMenuItem.Enabled = false;
                saleTaxDeterminationToolStripMenuItem.Enabled = false;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = false;
                houseBankAccountToolStripMenuItem.Enabled = false;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = false;
                warehouseSetupToolStripMenuItem.Enabled = false;
                uoMMeasureSetupToolStripMenuItem.Enabled = false;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = false;
                typeSetupToolStripMenuItem.Enabled = false;
                binLocationFieldActivationToolStripMenuItem.Enabled = false;
                binLocationAttributeCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = false;
                customsGroupToolStripMenuItem.Enabled = false;
                manufacturerFirmToolStripMenuItem.Enabled = false;
                inventoryCycleToolStripMenuItem.Enabled = false;
                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = false;
                vendorGroupToolStripMenuItem.Enabled = false;
                paymentTermSetuipToolStripMenuItem.Enabled = false;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = false;
                // ---------------Resource
                resoursceGroupToolStripMenuItem.Enabled = false;
                resourscePropertiesToolStripMenuItem.Enabled = false;
                //------------Service
                contractTemplateToolStripMenuItem.Enabled = false;
                queuesToolStripMenuItem.Enabled = false;
                                //------------Finance
                toolStripMenuItem10.Enabled = false;
                chartOfAccToolStripMenuItem.Enabled = false;
                salesTaxCodeToolStripMenuItem.Enabled = false;
                fixedAssetsToolStripMenuItem.Enabled = false;
                projectCostingToolStripMenuItem.Enabled = false;
                costCentersToolStripMenuItem.Enabled = false;
                accountDeterminitionToolStripMenuItem.Enabled = false;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = false;
                taxAgencyToolStripMenuItem.Enabled = false;
                createInvoiceToolStripMenuItem.Enabled = false;
                aPCrediMemoToolStripMenuItem.Enabled = false;
                deliveryToolStripMenuItem.Enabled = false;
                saleOrderToolStripMenuItem.Enabled = false;
                saleQuotationToolStripMenuItem.Enabled = false;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = false;
                createEstinateToolStripMenuItem.Enabled = false;
                createSaleInvoiceToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = false;
                invoiceRequestToolStripMenuItem.Enabled = false;
                aPCreditMemosToolStripMenuItem.Enabled = false;
                purchaseReturnToolStripMenuItem.Enabled = false;
                aPServiceInvoiceToolStripMenuItem.Enabled = false;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = false;
                barCodeToolStripMenuItem.Enabled = false;
                binLocationToolStripMenuItem1.Enabled = false;
                itemManagementToolStripMenuItem.Enabled = false;
                alternativeItemsToolStripMenuItem.Enabled = false;
                businessPartnerCatalogToolStripMenuItem.Enabled = false;
                inventoryValuationMethodToolStripMenuItem.Enabled = false;
                inventoryTransactionToolStripMenuItem1.Enabled = false;
                inventoryTransactionToolStripMenuItem.Enabled = false;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = false;
                inventoryCountRecommendationToolStripMenuItem.Enabled = false;
                inventoryRevaluationToolStripMenuItem.Enabled = false;
                priceListToolStripMenuItem.Enabled = false;

                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = true;
                billOfMaterialToolStripMenuItem.Enabled = true;
                receiptFromProductionToolStripMenuItem.Enabled = true;
                issueForProductionToolStripMenuItem.Enabled = true;
                updateParentItemPriceToolStripMenuItem.Enabled = true;
                manufactureringOrderToolStripMenuItem.Enabled = true;
                productionSchedulerToolStripMenuItem.Enabled = true;
                billOfMaterialComponentsToolStripMenuItem.Enabled = true;

                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   
                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;

                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }

            //-------------------------
            else if (bb == 50)
            {
                // Admin tool Strip
                
                
                usersToolStripMenuItem.Enabled = false;
                dataBackupsToolStripMenuItem.Enabled = false;
                systemInitializationToolStripMenuItem1.Enabled = false;
                approvalManagerToolStripMenuItem.Enabled = false;
                authorizationToolStripMenuItem.Enabled = false;
                //------------------------------------General
                userToolStripMenuItem.Enabled = false;
                changePassWordToolStripMenuItem1.Enabled = false;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = false;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = false;
             
                saleTaxCodeToolStripMenuItem.Enabled = false;
                saleTaxDeterminationToolStripMenuItem.Enabled = false;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = false;
                houseBankAccountToolStripMenuItem.Enabled = false;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = false;
                warehouseSetupToolStripMenuItem.Enabled = false;
                uoMMeasureSetupToolStripMenuItem.Enabled = false;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = false;
                typeSetupToolStripMenuItem.Enabled = false;
                binLocationFieldActivationToolStripMenuItem.Enabled = false;
                binLocationAttributeCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = false;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = false;
                customsGroupToolStripMenuItem.Enabled = false;
                manufacturerFirmToolStripMenuItem.Enabled = false;
                inventoryCycleToolStripMenuItem.Enabled = false;
                                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = false;
                vendorGroupToolStripMenuItem.Enabled = false;
                paymentTermSetuipToolStripMenuItem.Enabled = false;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = false;
                // ---------------Resource
                resoursceGroupToolStripMenuItem.Enabled = false;
                resourscePropertiesToolStripMenuItem.Enabled = false;
                //------------Service
                contractTemplateToolStripMenuItem.Enabled = false;
                queuesToolStripMenuItem.Enabled = false;
                                //------------Finance
                toolStripMenuItem10.Enabled = false;
                chartOfAccToolStripMenuItem.Enabled = false;
                salesTaxCodeToolStripMenuItem.Enabled = false;
                fixedAssetsToolStripMenuItem.Enabled = false;
                projectCostingToolStripMenuItem.Enabled = false;
                costCentersToolStripMenuItem.Enabled = false;
                accountDeterminitionToolStripMenuItem.Enabled = false;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = false;
                toolStripMenuItem4.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = false;
                taxAgencyToolStripMenuItem.Enabled = false;
                createInvoiceToolStripMenuItem.Enabled = false;
                aPCrediMemoToolStripMenuItem.Enabled = false;
                deliveryToolStripMenuItem.Enabled = false;
                saleOrderToolStripMenuItem.Enabled = false;
                saleQuotationToolStripMenuItem.Enabled = false;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = false;
                createEstinateToolStripMenuItem.Enabled = false;
                createSaleInvoiceToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = false;
                invoiceRequestToolStripMenuItem.Enabled = false;
                aPCreditMemosToolStripMenuItem.Enabled = false;
                purchaseReturnToolStripMenuItem.Enabled = false;
                aPServiceInvoiceToolStripMenuItem.Enabled = false;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = false;
                barCodeToolStripMenuItem.Enabled = false;
                binLocationToolStripMenuItem1.Enabled = false;
                itemManagementToolStripMenuItem.Enabled = false;
                alternativeItemsToolStripMenuItem.Enabled = false;
                businessPartnerCatalogToolStripMenuItem.Enabled = false;
                inventoryValuationMethodToolStripMenuItem.Enabled = false;
                inventoryTransactionToolStripMenuItem1.Enabled = false;
                inventoryTransactionToolStripMenuItem.Enabled = false;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = false;
                inventoryCountRecommendationToolStripMenuItem.Enabled = false;
                inventoryRevaluationToolStripMenuItem.Enabled = false;
                priceListToolStripMenuItem.Enabled = false;

                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = true;
                billOfMaterialToolStripMenuItem.Enabled = true;
                receiptFromProductionToolStripMenuItem.Enabled = true;
                issueForProductionToolStripMenuItem.Enabled = true;
                updateParentItemPriceToolStripMenuItem.Enabled = true;
                manufactureringOrderToolStripMenuItem.Enabled = true;
                productionSchedulerToolStripMenuItem.Enabled = true;
                billOfMaterialComponentsToolStripMenuItem.Enabled = true;
                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   

                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;
                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }

            //--------------------
            if (bb == 10)
            {
                // Admin tool Strip

                usersToolStripMenuItem.Enabled = true;
                dataBackupsToolStripMenuItem.Enabled = true;
                systemInitializationToolStripMenuItem1.Enabled = true;
                approvalManagerToolStripMenuItem.Enabled = true;
                authorizationToolStripMenuItem.Enabled = true;
                //------------------------------------General
                userToolStripMenuItem.Enabled = true;
                changePassWordToolStripMenuItem1.Enabled = true;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = true;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = true;
               
                saleTaxCodeToolStripMenuItem.Enabled = true;
                saleTaxDeterminationToolStripMenuItem.Enabled = true;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = true;
                houseBankAccountToolStripMenuItem.Enabled = true;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = true;
                warehouseSetupToolStripMenuItem.Enabled = true;
                uoMMeasureSetupToolStripMenuItem.Enabled = true;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = true;
                typeSetupToolStripMenuItem.Enabled = true;
                binLocationFieldActivationToolStripMenuItem.Enabled = true;
                binLocationAttributeCodeToolStripMenuItem.Enabled = true;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = true;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = true;
                customsGroupToolStripMenuItem.Enabled = true;
                manufacturerFirmToolStripMenuItem.Enabled = true;
                inventoryCycleToolStripMenuItem.Enabled = true;

                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = true;
                vendorGroupToolStripMenuItem.Enabled = true;
                paymentTermSetuipToolStripMenuItem.Enabled = true;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = true;
                // ---------------Resource
             //   resoursceGroupToolStripMenuItem.Enabled = true;
             //   resourscePropertiesToolStripMenuItem.Enabled = true;
                //------------Service
             //   contractTemplateToolStripMenuItem.Enabled = true;
             //   queuesToolStripMenuItem.Enabled = true;
                //------------Finance
                toolStripMenuItem10.Enabled = true;
                chartOfAccToolStripMenuItem.Enabled = true;
                salesTaxCodeToolStripMenuItem.Enabled = true;
                fixedAssetsToolStripMenuItem.Enabled = true;
                projectCostingToolStripMenuItem.Enabled = true;
                costCentersToolStripMenuItem.Enabled = true;
                accountDeterminitionToolStripMenuItem.Enabled = true;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = true;
                toolStripMenuItem4.Enabled = true;
                toolStripMenuItem3.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = true;
                taxAgencyToolStripMenuItem.Enabled = true;
                createInvoiceToolStripMenuItem.Enabled = true;
                aPCrediMemoToolStripMenuItem.Enabled = true;
                deliveryToolStripMenuItem.Enabled = true;
                saleOrderToolStripMenuItem.Enabled = true;
                saleQuotationToolStripMenuItem.Enabled = true;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = false;
                createEstinateToolStripMenuItem.Enabled = false;
                createSaleInvoiceToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = false;
                invoiceRequestToolStripMenuItem.Enabled = false;
                aPCreditMemosToolStripMenuItem.Enabled = false;
                purchaseReturnToolStripMenuItem.Enabled = false;
                aPServiceInvoiceToolStripMenuItem.Enabled = false;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = false;
                customerMgmntToolStripMenuItem.Enabled = false;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = false;
                recancilesToolStripMenuItem.Enabled = false;
                loanManagerToolStripMenuItem.Enabled = false;
                outgoingPaymentToolStripMenuItem.Enabled = false;
                incomingPaymentToolStripMenuItem.Enabled = false;
                depositeToolStripMenuItem.Enabled = false;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = true;
                barCodeToolStripMenuItem.Enabled = true;
                binLocationToolStripMenuItem1.Enabled = true;
                itemManagementToolStripMenuItem.Enabled = true;
                alternativeItemsToolStripMenuItem.Enabled = true;
                businessPartnerCatalogToolStripMenuItem.Enabled = true;
                inventoryValuationMethodToolStripMenuItem.Enabled = true;
                inventoryTransactionToolStripMenuItem1.Enabled = true;
                inventoryTransactionToolStripMenuItem.Enabled = true;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = true;
                inventoryCountRecommendationToolStripMenuItem.Enabled = true;
                inventoryRevaluationToolStripMenuItem.Enabled = true;
                priceListToolStripMenuItem.Enabled = true;
                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = false;
                billOfMaterialToolStripMenuItem.Enabled = false;
                receiptFromProductionToolStripMenuItem.Enabled = false;
                issueForProductionToolStripMenuItem.Enabled = false;
                updateParentItemPriceToolStripMenuItem.Enabled = false;
                manufactureringOrderToolStripMenuItem.Enabled = false;
                productionSchedulerToolStripMenuItem.Enabled = false;
                billOfMaterialComponentsToolStripMenuItem.Enabled = false;
                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = false;
                //--------------------------Services   
                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;


                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = false;
                toolStripMenuItem6.Enabled = false;
                enterEmployeesToolStripMenuItem.Enabled = false;
                toolStripMenuItem7.Enabled = false;
                wagesInfoToolStripMenuItem.Enabled = false;
                employeesLoanToolStripMenuItem.Enabled = false;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem1.Enabled = false;
                customerReportsToolStripMenuItem.Enabled = false;
                vendorToolStripMenuItem2.Enabled = false;
                saleToolStripMenuItem.Enabled = false;
                bankingReportToolStripMenuItem.Enabled = false;
                manufactureringToolStripMenuItem.Enabled = false;
                payrollToolStripMenuItem1.Enabled = false;
                administrationToolStripMenuItem.Enabled = false;
                openItemListToolStripMenuItem.Enabled = false;
            }

            else if (bb == 100)
            {
                // Admin tool Strip
               
                usersToolStripMenuItem.Enabled = true;
                dataBackupsToolStripMenuItem.Enabled = true;
                systemInitializationToolStripMenuItem1.Enabled = true;
                approvalManagerToolStripMenuItem.Enabled = true;
                authorizationToolStripMenuItem.Enabled = true;
                //------------------------------------General
                userToolStripMenuItem.Enabled = true;
                changePassWordToolStripMenuItem1.Enabled = true;
                /////////  Finance
                currencySetupToolStripMenuItem.Enabled = true;
                saleTaxJurisdictionTypeToolStripMenuItem.Enabled = true;
             
                saleTaxCodeToolStripMenuItem.Enabled = true;
                saleTaxDeterminationToolStripMenuItem.Enabled = true;
                //----------------------------Bank
                banksToolStripMenuItem.Enabled = true;
                houseBankAccountToolStripMenuItem.Enabled = true;
                //----------------------------Invenotry--------------
                itemGroupToolStripMenuItem.Enabled = true;
                warehouseSetupToolStripMenuItem.Enabled = true;
                uoMMeasureSetupToolStripMenuItem.Enabled = true;
                uoMMeasureGroupSetupToolStripMenuItem.Enabled = true;
                typeSetupToolStripMenuItem.Enabled = true;
                binLocationFieldActivationToolStripMenuItem.Enabled = true;
                binLocationAttributeCodeToolStripMenuItem.Enabled = true;
                binLocationWarehouseSublevelCodeToolStripMenuItem.Enabled = true;
                binLocationWarehouseSublevelManagementToolStripMenuItem.Enabled = true;
                customsGroupToolStripMenuItem.Enabled = true;
                manufacturerFirmToolStripMenuItem.Enabled = true;
                inventoryCycleToolStripMenuItem.Enabled = true;

                //----------------BP Pertnert
                customerGroupToolStripMenuItem.Enabled = true;
                vendorGroupToolStripMenuItem.Enabled = true;
                paymentTermSetuipToolStripMenuItem.Enabled = true;
                ///////////////////----------------
                landedCostsToolStripMenuItem.Enabled = true;
                // ---------------Resource
             //   resoursceGroupToolStripMenuItem.Enabled = true;
              //  resourscePropertiesToolStripMenuItem.Enabled = true;
                //------------Service
            ////    contractTemplateToolStripMenuItem.Enabled = true;
            //    queuesToolStripMenuItem.Enabled = true;


                //------------Finance
                toolStripMenuItem10.Enabled = true;
                chartOfAccToolStripMenuItem.Enabled = true;
                salesTaxCodeToolStripMenuItem.Enabled = true;
                fixedAssetsToolStripMenuItem.Enabled = true;
                projectCostingToolStripMenuItem.Enabled = true;
                costCentersToolStripMenuItem.Enabled = true;
                accountDeterminitionToolStripMenuItem.Enabled = true;
                //-----------------------------Sale opport
                companySnapShortToolStripMenuItem.Enabled = true;
                toolStripMenuItem4.Enabled = true;
                toolStripMenuItem3.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                //-------------------------------Sale
                taxCodeToolStripMenuItem.Enabled = true;
                taxAgencyToolStripMenuItem.Enabled = true;
                createInvoiceToolStripMenuItem.Enabled = true;
                aPCrediMemoToolStripMenuItem.Enabled = true;
                deliveryToolStripMenuItem.Enabled = true;
                saleOrderToolStripMenuItem.Enabled = true;
                saleQuotationToolStripMenuItem.Enabled = true;
                //--------------------------Purchase
                newCustomerToolStripMenuItem.Enabled = true;
                createEstinateToolStripMenuItem.Enabled = true;
                createSaleInvoiceToolStripMenuItem.Enabled = true;
                createToolStripMenuItem.Enabled = true;
                invoiceRequestToolStripMenuItem.Enabled = true;
                aPCreditMemosToolStripMenuItem.Enabled = true;
                purchaseReturnToolStripMenuItem.Enabled = true;
                aPServiceInvoiceToolStripMenuItem.Enabled = true;
                //------------------------------Business Partner
                vendorToolStripMenuItem1.Enabled = true;
                customerMgmntToolStripMenuItem.Enabled = true;
                //----------------------------Banking
                transferToolStripMenuItem.Enabled = true;
                recancilesToolStripMenuItem.Enabled = true;
                loanManagerToolStripMenuItem.Enabled = true;
                outgoingPaymentToolStripMenuItem.Enabled = true;
                incomingPaymentToolStripMenuItem.Enabled = true;
                depositeToolStripMenuItem.Enabled = true;
                //--------------------------------------Inventory
                itemListToolStripMenuItem1.Enabled = true;
                barCodeToolStripMenuItem.Enabled = true;
                binLocationToolStripMenuItem1.Enabled = true;
                itemManagementToolStripMenuItem.Enabled = true;
                alternativeItemsToolStripMenuItem.Enabled = true;
                businessPartnerCatalogToolStripMenuItem.Enabled = true;
                inventoryValuationMethodToolStripMenuItem.Enabled = true;
                inventoryTransactionToolStripMenuItem1.Enabled = true;
                inventoryTransactionToolStripMenuItem.Enabled = true;
                inventoryOpeningBalanceToolStripMenuItem.Enabled = true;
                inventoryCountRecommendationToolStripMenuItem.Enabled = true;
                inventoryRevaluationToolStripMenuItem.Enabled = true;
                priceListToolStripMenuItem.Enabled = true;
                //--------------------------------------------------Production
                productionOrderToolStripMenuItem.Enabled = true;
                billOfMaterialToolStripMenuItem.Enabled = true;
                receiptFromProductionToolStripMenuItem.Enabled = true;
                issueForProductionToolStripMenuItem.Enabled = true;
                updateParentItemPriceToolStripMenuItem.Enabled = true;
                manufactureringOrderToolStripMenuItem.Enabled = true;
                productionSchedulerToolStripMenuItem.Enabled = true;
                                billOfMaterialComponentsToolStripMenuItem.Enabled = true;
                ////////////-----------------------MRP
                ////////////-----------------------Resources
                resourseSetupToolStripMenuItem.Enabled = true;
                //--------------------------Services   
                serviceCallToolStripMenuItem.Enabled = false;
                customerEquipmentCardToolStripMenuItem.Enabled = false;
                serviceContractsToolStripMenuItem.Enabled = false;
                serviceCalendarToolStripMenuItem.Enabled = false;
                solutionKnowledgeBaseToolStripMenuItem.Enabled = false;

                //------------------------------------------Human Resources
                enterTimeToolStripMenuItem.Enabled = true;
                toolStripMenuItem6.Enabled = true;
                enterEmployeesToolStripMenuItem.Enabled = true;
                toolStripMenuItem7.Enabled = true;
                wagesInfoToolStripMenuItem.Enabled = true;
                employeesLoanToolStripMenuItem.Enabled = true;
                //--------------------------Report
                financialToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem1.Enabled = true;
                customerReportsToolStripMenuItem.Enabled = true;
                vendorToolStripMenuItem2.Enabled = true;
                saleToolStripMenuItem.Enabled = true;
                bankingReportToolStripMenuItem.Enabled = true;
                manufactureringToolStripMenuItem.Enabled = true;
                payrollToolStripMenuItem1.Enabled = true;
                administrationToolStripMenuItem.Enabled = true;
                openItemListToolStripMenuItem.Enabled = true;

            }
        }

        private void aPServiceInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APSrvInv frmpAPSrv = new APSrvInv();
            if (this.ActiveMdiChild != null || frmpAPSrv != null)
            {
                frmpAPSrv.MdiParent = this;
                ToolStripManager.Merge(frmpAPSrv.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmpAPSrv.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmpAPSrv.ChToolStrip1);
            };
            frmpAPSrv.Show();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string directory, sql;
            SqlConnection cnn = new SqlConnection(cnt.mycon());
            cnn.Open();
            sql = "select LedgerName ,Debit,Credit, Balance from trialbalnce";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "trialbalnce");
            cnn.Close();
            ReportDocument cryRpt = new ReportDocument();
            string urrnt = Directory.GetCurrentDirectory();
            urrnt = urrnt.Substring(0, urrnt.Length - 9);
            directory = Path.GetDirectoryName(urrnt);
            cryRpt.Load(directory + @"\Reports\TrialbalnRPT.rpt");
            cryRpt.SetDataSource(ds.Tables[0]);
            cryRpt.SetParameterValue(0, cnt.HdrName);
            cryRpt.SetParameterValue(1, "Trial Balance Report");
            Reports.FrmRptViewer frm2 = new Reports.FrmRptViewer();
            frm2.crystalReportViewer1.ReportSource = cryRpt;
            frm2.crystalReportViewer1.Refresh();
            frm2.Show();
        }

        private void uoMMeasureSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUomStUp frmuommeas = new FrmUomStUp();
            
            if (this.ActiveMdiChild != null || frmuommeas != null)
            {
                frmuommeas.MdiParent = this;
                ToolStripManager.Merge(frmuommeas.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmuommeas.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmuommeas.ChToolStrip1);
            };
            frmuommeas.Show();
        }

        private void typeSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpkgSetp frmtypestp = new frmpkgSetp();
           
            if (this.ActiveMdiChild != null || frmtypestp != null)
            {
                frmtypestp.MdiParent = this;
                ToolStripManager.Merge(frmtypestp.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmtypestp.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmtypestp.ChToolStrip1);
            };
            frmtypestp.Show();
        }

       

        
               

        private void priceListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrcList frmprclst = new FrmPrcList();
            
            if (this.ActiveMdiChild != null || frmprclst != null)
            {
                frmprclst.MdiParent = this;
                ToolStripManager.Merge(frmprclst.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmprclst.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmprclst.ChToolStrip1);
            };
            frmprclst.Show();
        }

        private void assemblyPandeingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleTaxCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsltTax_code Tax_code1 = new frmsltTax_code();

            if (this.ActiveMdiChild != null || Tax_code1 != null)
            {
                // salInv salInv1 = new salInv();

                Tax_code1.MdiParent = this;
                ToolStripManager.Merge(Tax_code1.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            Tax_code1.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, Tax_code1.ChToolStrip1);
            };
            Tax_code1.Show();
        }

        private void productionSchedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPdOschedul frmpdO = new FrmPdOschedul();
            frmpdO.MdiParent = this;
            frmpdO.Show();
        }

        private void houseBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankStUp bnkfrm = new BankStUp();
            if (this.ActiveMdiChild != null || bnkfrm != null)
            {
                bnkfrm.MdiParent = this;
                ToolStripManager.Merge(bnkfrm.ChToolStrip1, this.MDIToolStrp);
                // salInv1.ChToolStrip1.Hide();

                bnkfrm.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
                {
                    ToolStripManager.RevertMerge(this.MDIToolStrp, bnkfrm.ChToolStrip1);
                };

                bnkfrm.Show();
            }
        }

        private void uoMMeasureGroupSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUGrp frmuomStpGrp = new frmUGrp();
            frmuomStpGrp.MdiParent = this;
            frmuomStpGrp.Show();

        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanks frmbnks = new frmBanks();
            frmbnks.MdiParent = this;
            frmbnks.Show();
        }

        private void paymentTermSetuipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPymTrm frmpytrm = new frmPymTrm();
            frmpytrm.MdiParent = this;
            frmpytrm.Show();
        }

        private void accountDeterminitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            acc_deter frmdtr = new acc_deter();
            //  ToolStripManager.RevertMerge(toolStrip);
            //  ToolStripManager.RevertMerge(menuStrip);
            if (this.ActiveMdiChild != null || frmdtr != null)
            {
                frmdtr.MdiParent = this; ToolStripManager.Merge(frmdtr.ChToolStrip1, this.MDIToolStrp);
                // salInv1.ChToolStrip1.Hide();
                frmdtr.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
                {
                    ToolStripManager.RevertMerge(this.MDIToolStrp, frmdtr.ChToolStrip1);
                };
                frmdtr.MdiParent = this;
                frmdtr.Show();

            }
        }

        private void saleTaxJurisdictionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsltJurdSetUp sltxjurstp = new frmsltJurdSetUp();
            sltxjurstp.MdiParent = this;
            sltxjurstp.Show();
        }

        
        private void saleTaxDeterminationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsltcoddetrmin frmsltxdetr = new frmsltcoddetrmin();
            frmsltxdetr.MdiParent = this;
            frmsltxdetr.Show();
        }

        private void binLocationMasterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinLocation frmbibloc = new BinLocation();

            if (this.ActiveMdiChild != null || frmbibloc != null)
            {
                frmbibloc.MdiParent = this;
                ToolStripManager.Merge(frmbibloc.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmbibloc.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmbibloc.ChToolStrip1);
            };
            frmbibloc.Show();
        }

        private void discountGroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdisgrop frmdigrp = new frmdisgrop();
            if (this.ActiveMdiChild != null || frmdigrp != null)
            {
                frmdigrp.MdiParent = this;
                ToolStripManager.Merge(frmdigrp.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmdigrp.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmdigrp.ChToolStrip1);
            };
            frmdigrp.Show();
        }

        private void periodVolumeDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrdvolDis frmprvoldis = new frmPrdvolDis();
            if (this.ActiveMdiChild != null || frmprvoldis != null)
            {
                frmprvoldis.MdiParent = this;
                ToolStripManager.Merge(frmprvoldis.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmprvoldis.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmprvoldis.ChToolStrip1);
            };
            frmprvoldis.Show();
        }

        private void barCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarCode frmbrco = new frmBarCode();
                frmbrco.MdiParent = this;
                 frmbrco.Show();
        }

        private void goodsReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsRecpt frmgdsrecept = new frmGoodsRecpt();
                if (this.ActiveMdiChild != null || frmgdsrecept != null)
            {
                frmgdsrecept.MdiParent = this;
                ToolStripManager.Merge(frmgdsrecept.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmgdsrecept.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmgdsrecept.ChToolStrip1);
            };
            frmgdsrecept.Show();
        }

        private void goodsIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgdsIssue frmgdIssu = new frmgdsIssue();
            if (this.ActiveMdiChild != null || frmgdIssu != null)
            {
                frmgdIssu.MdiParent = this;
                ToolStripManager.Merge(frmgdIssu.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmgdIssu.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmgdIssu.ChToolStrip1);
            };
            frmgdIssu.Show();
        }

        private void inventoryTransferRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvTransReqst invtrnsreqst = new frmInvTransReqst();
            if (this.ActiveMdiChild != null || invtrnsreqst != null)
            {
                invtrnsreqst.MdiParent = this;
                ToolStripManager.Merge(invtrnsreqst.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            invtrnsreqst.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, invtrnsreqst.ChToolStrip1);
            };
            invtrnsreqst.Show();
        }

        private void inventoryTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvTransfr frminvtrns = new FrmInvTransfr();
            if (this.ActiveMdiChild != null || frminvtrns != null)
            {
                frminvtrns.MdiParent = this;
                ToolStripManager.Merge(frminvtrns.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frminvtrns.FormClosing += delegate (object sender2, FormClosingEventArgs fe) {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frminvtrns.ChToolStrip1);
            };
            frminvtrns.Show();
        }

        private void customerEquipmentCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustEquipCrd csteqpcrd = new CustEquipCrd();
            if (this.ActiveMdiChild != null || csteqpcrd != null)
            {
                csteqpcrd.MdiParent = this;
                ToolStripManager.Merge(csteqpcrd.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            csteqpcrd.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, csteqpcrd.ChToolStrip1);

            };
            csteqpcrd.Show();
        }

        private void billOfMaterialComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBomCompo frmBOMCompont = new frmBomCompo();
            frmBOMCompont.MdiParent = this;
            frmBOMCompont.Show();
        }

        private void inventoryCountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvCountng frmincont = new frmInvCountng();
            if (this.ActiveMdiChild != null || frmincont != null)
            {
                frmincont.MdiParent = this;
                ToolStripManager.Merge(frmincont.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmincont.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmincont.ChToolStrip1);

            };
            frmincont.Show();
        }

        private void inventoryOpeningBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvOB frminvOblnc = new frmInvOB();
            if (this.ActiveMdiChild != null || frminvOblnc != null)
            {
                frminvOblnc.MdiParent = this;
                ToolStripManager.Merge(frminvOblnc.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frminvOblnc.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frminvOblnc.ChToolStrip1);

            };
            frminvOblnc.Show();

        }

        private void billOfMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnBom frmbimtrl = new frnBom();
            if (this.ActiveMdiChild != null || frmbimtrl != null)
            {
                frmbimtrl.MdiParent = this;
                ToolStripManager.Merge(frmbimtrl.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmbimtrl.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmbimtrl.ChToolStrip1);

            };
            frmbimtrl.Show();
        }

        private void issueForProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmisutoprodun frmissupro = new frmisutoprodun();
            if (this.ActiveMdiChild != null || frmissupro != null)
            {
                frmissupro.MdiParent = this;
                ToolStripManager.Merge(frmissupro.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmissupro.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmissupro.ChToolStrip1);

            };
            frmissupro.Show();
        }

        private void receiptFromProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecvFrmProdn frmrceprod = new frmrecvFrmProdn();
            if (this.ActiveMdiChild != null || frmrceprod != null)
            {
                frmrceprod.MdiParent = this;
                ToolStripManager.Merge(frmrceprod.ChToolStrip1, this.MDIToolStrp);
            }
            // salInv1.ChToolStrip1.Hide();
            frmrceprod.FormClosing += delegate (object sender2, FormClosingEventArgs fe)
            {
                ToolStripManager.RevertMerge(this.MDIToolStrp, frmrceprod.ChToolStrip1);

            };
            frmrceprod.Show();
        }

        private void customsGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustmGrp fcustmGrp = new frmcustmGrp();
            fcustmGrp.MdiParent = this;
            fcustmGrp.Show();


        }

      
    }
    }
    

    


       