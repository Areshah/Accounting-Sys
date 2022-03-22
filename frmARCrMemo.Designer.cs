namespace Accounting_Sys
{
    partial class frmARCrMemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmARCrMemo));
            this.DGCrMemo = new System.Windows.Forms.DataGridView();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.label20 = new System.Windows.Forms.Label();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.TxDiscount = new System.Windows.Forms.TextBox();
            this.CmbTax = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DTPPurInv = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TxStatus = new System.Windows.Forms.TextBox();
            this.TxPuRInvNo = new System.Windows.Forms.TextBox();
            this.TxSuppRefN = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CmBSuppInv = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxCardID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCur = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxTotAmAply = new System.Windows.Forms.TextBox();
            this.TxInvAmt = new System.Windows.Forms.TextBox();
            this.TxWthDisc = new System.Windows.Forms.TextBox();
            this.TxIncFreight = new System.Windows.Forms.TextBox();
            this.TxIncDowPay = new System.Windows.Forms.TextBox();
            this.TxTotWoutDis = new System.Windows.Forms.TextBox();
            this.TxFreight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDwPay = new System.Windows.Forms.ComboBox();
            this.TotAmtLbl = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCrMemo)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGCrMemo
            // 
            this.DGCrMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCrMemo.Location = new System.Drawing.Point(17, 109);
            this.DGCrMemo.Name = "DGCrMemo";
            this.DGCrMemo.Size = new System.Drawing.Size(970, 225);
            this.DGCrMemo.TabIndex = 820;
            // 
            // ChToolStrpLast
            // 
            this.ChToolStrpLast.AutoSize = false;
            this.ChToolStrpLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpLast.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpLast.Image")));
            this.ChToolStrpLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpLast.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpLast.Name = "ChToolStrpLast";
            this.ChToolStrpLast.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpLast.Text = "Last";
            // 
            // ChToolStrpPrev
            // 
            this.ChToolStrpPrev.AutoSize = false;
            this.ChToolStrpPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpPrev.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpPrev.Image")));
            this.ChToolStrpPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpPrev.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpPrev.Name = "ChToolStrpPrev";
            this.ChToolStrpPrev.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpPrev.Text = "Preview";
            // 
            // ChToolStrpNext
            // 
            this.ChToolStrpNext.AutoSize = false;
            this.ChToolStrpNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpNext.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpNext.Image")));
            this.ChToolStrpNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpNext.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpNext.Name = "ChToolStrpNext";
            this.ChToolStrpNext.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpNext.Text = "Next";
            // 
            // ChToolStrpFind
            // 
            this.ChToolStrpFind.AutoSize = false;
            this.ChToolStrpFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpFind.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpFind.Image")));
            this.ChToolStrpFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpFind.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpFind.Name = "ChToolStrpFind";
            this.ChToolStrpFind.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpFind.Text = "Find";
            // 
            // ChToolStrpPrevious
            // 
            this.ChToolStrpPrevious.AutoSize = false;
            this.ChToolStrpPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpPrevious.Image")));
            this.ChToolStrpPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpPrevious.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpPrevious.Name = "ChToolStrpPrevious";
            this.ChToolStrpPrevious.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpPrevious.Text = "Previous";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(291, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 831;
            this.label20.Text = "Item / Service  Type";
            // 
            // ChToolStrip1
            // 
            this.ChToolStrip1.BackColor = System.Drawing.Color.Gray;
            this.ChToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChToolStrpPrev,
            this.ChToolStrpAdd,
            this.ChToolStrpFirst,
            this.ChToolStrpNext,
            this.ChToolStrpPrevious,
            this.ChToolStrpLast,
            this.ChToolStrpFind});
            this.ChToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ChToolStrip1.Name = "ChToolStrip1";
            this.ChToolStrip1.Size = new System.Drawing.Size(1005, 43);
            this.ChToolStrip1.TabIndex = 834;
            this.ChToolStrip1.Text = "toolStrip1";
            // 
            // ChToolStrpAdd
            // 
            this.ChToolStrpAdd.AutoSize = false;
            this.ChToolStrpAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpAdd.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpAdd.Image")));
            this.ChToolStrpAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpAdd.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpAdd.Name = "ChToolStrpAdd";
            this.ChToolStrpAdd.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpAdd.Text = "Add";
            // 
            // ChToolStrpFirst
            // 
            this.ChToolStrpFirst.AutoSize = false;
            this.ChToolStrpFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChToolStrpFirst.Image = ((System.Drawing.Image)(resources.GetObject("ChToolStrpFirst.Image")));
            this.ChToolStrpFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChToolStrpFirst.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ChToolStrpFirst.Name = "ChToolStrpFirst";
            this.ChToolStrpFirst.Size = new System.Drawing.Size(70, 40);
            this.ChToolStrpFirst.Text = "First";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(467, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 833;
            this.label21.Text = "ordr";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(407, 86);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 832;
            // 
            // TxDiscount
            // 
            this.TxDiscount.Location = new System.Drawing.Point(857, 48);
            this.TxDiscount.Name = "TxDiscount";
            this.TxDiscount.Size = new System.Drawing.Size(130, 20);
            this.TxDiscount.TabIndex = 865;
            // 
            // CmbTax
            // 
            this.CmbTax.FormattingEnabled = true;
            this.CmbTax.Location = new System.Drawing.Point(856, 28);
            this.CmbTax.Name = "CmbTax";
            this.CmbTax.Size = new System.Drawing.Size(130, 21);
            this.CmbTax.TabIndex = 862;
            this.CmbTax.SelectedIndexChanged += new System.EventHandler(this.CmbTax_SelectedIndexChanged);
            this.CmbTax.Enter += new System.EventHandler(this.CmbTax_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(765, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 861;
            this.label8.Text = "Tax Code";
            // 
            // DTPPurInv
            // 
            this.DTPPurInv.Location = new System.Drawing.Point(856, 87);
            this.DTPPurInv.Name = "DTPPurInv";
            this.DTPPurInv.Size = new System.Drawing.Size(130, 20);
            this.DTPPurInv.TabIndex = 852;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(144, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 35);
            this.richTextBox1.TabIndex = 851;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 850;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TxStatus
            // 
            this.TxStatus.Location = new System.Drawing.Point(856, 67);
            this.TxStatus.Name = "TxStatus";
            this.TxStatus.Size = new System.Drawing.Size(130, 20);
            this.TxStatus.TabIndex = 849;
            // 
            // TxPuRInvNo
            // 
            this.TxPuRInvNo.Location = new System.Drawing.Point(133, 31);
            this.TxPuRInvNo.Name = "TxPuRInvNo";
            this.TxPuRInvNo.Size = new System.Drawing.Size(130, 20);
            this.TxPuRInvNo.TabIndex = 848;
            // 
            // TxSuppRefN
            // 
            this.TxSuppRefN.Location = new System.Drawing.Point(133, 69);
            this.TxSuppRefN.Name = "TxSuppRefN";
            this.TxSuppRefN.Size = new System.Drawing.Size(130, 20);
            this.TxSuppRefN.TabIndex = 847;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 336);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 846;
            // 
            // CmBSuppInv
            // 
            this.CmBSuppInv.FormattingEnabled = true;
            this.CmBSuppInv.Location = new System.Drawing.Point(169, 50);
            this.CmBSuppInv.Name = "CmBSuppInv";
            this.CmBSuppInv.Size = new System.Drawing.Size(94, 21);
            this.CmBSuppInv.TabIndex = 836;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 845;
            this.label11.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 844;
            this.label13.Text = "Payment Order Run";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 843;
            this.label15.Text = "Sale Employee";
            // 
            // TxCardID
            // 
            this.TxCardID.Location = new System.Drawing.Point(133, 50);
            this.TxCardID.Name = "TxCardID";
            this.TxCardID.Size = new System.Drawing.Size(36, 20);
            this.TxCardID.TabIndex = 835;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 842;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 841;
            this.label9.Text = "Document Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 840;
            this.label6.Text = "Invoice No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 839;
            this.label5.Text = "BP Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 838;
            this.label4.Text = "Customer Ref. No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 837;
            this.label1.Text = "Customer Code / Name";
            // 
            // CmbCur
            // 
            this.CmbCur.FormattingEnabled = true;
            this.CmbCur.Location = new System.Drawing.Point(133, 86);
            this.CmbCur.Name = "CmbCur";
            this.CmbCur.Size = new System.Drawing.Size(129, 21);
            this.CmbCur.TabIndex = 858;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(765, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 853;
            this.label19.Text = "Discount %";
            // 
            // TxTotAmAply
            // 
            this.TxTotAmAply.Location = new System.Drawing.Point(885, 413);
            this.TxTotAmAply.Name = "TxTotAmAply";
            this.TxTotAmAply.ReadOnly = true;
            this.TxTotAmAply.Size = new System.Drawing.Size(100, 20);
            this.TxTotAmAply.TabIndex = 929;
            this.TxTotAmAply.Text = "0.00";
            // 
            // TxInvAmt
            // 
            this.TxInvAmt.Location = new System.Drawing.Point(885, 393);
            this.TxInvAmt.Name = "TxInvAmt";
            this.TxInvAmt.ReadOnly = true;
            this.TxInvAmt.Size = new System.Drawing.Size(100, 20);
            this.TxInvAmt.TabIndex = 928;
            this.TxInvAmt.Text = "0.00";
            // 
            // TxWthDisc
            // 
            this.TxWthDisc.Location = new System.Drawing.Point(885, 333);
            this.TxWthDisc.Name = "TxWthDisc";
            this.TxWthDisc.ReadOnly = true;
            this.TxWthDisc.Size = new System.Drawing.Size(100, 20);
            this.TxWthDisc.TabIndex = 927;
            this.TxWthDisc.Text = "0.00";
            // 
            // TxIncFreight
            // 
            this.TxIncFreight.Location = new System.Drawing.Point(885, 354);
            this.TxIncFreight.Name = "TxIncFreight";
            this.TxIncFreight.ReadOnly = true;
            this.TxIncFreight.Size = new System.Drawing.Size(100, 20);
            this.TxIncFreight.TabIndex = 926;
            this.TxIncFreight.Text = "0.00";
            // 
            // TxIncDowPay
            // 
            this.TxIncDowPay.Location = new System.Drawing.Point(885, 374);
            this.TxIncDowPay.Name = "TxIncDowPay";
            this.TxIncDowPay.ReadOnly = true;
            this.TxIncDowPay.Size = new System.Drawing.Size(100, 20);
            this.TxIncDowPay.TabIndex = 925;
            this.TxIncDowPay.Text = "0.00";
            // 
            // TxTotWoutDis
            // 
            this.TxTotWoutDis.Location = new System.Drawing.Point(756, 334);
            this.TxTotWoutDis.Name = "TxTotWoutDis";
            this.TxTotWoutDis.ReadOnly = true;
            this.TxTotWoutDis.Size = new System.Drawing.Size(100, 20);
            this.TxTotWoutDis.TabIndex = 924;
            this.TxTotWoutDis.Text = "0.00";
            // 
            // TxFreight
            // 
            this.TxFreight.Location = new System.Drawing.Point(756, 352);
            this.TxFreight.Name = "TxFreight";
            this.TxFreight.ReadOnly = true;
            this.TxFreight.Size = new System.Drawing.Size(100, 20);
            this.TxFreight.TabIndex = 923;
            this.TxFreight.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 922;
            this.label2.Text = "Freight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 921;
            this.label12.Text = "Rate";
            // 
            // TxRate
            // 
            this.TxRate.Location = new System.Drawing.Point(755, 394);
            this.TxRate.Name = "TxRate";
            this.TxRate.ReadOnly = true;
            this.TxRate.Size = new System.Drawing.Size(50, 20);
            this.TxRate.TabIndex = 920;
            this.TxRate.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 919;
            this.label7.Text = "Tax Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 918;
            this.label3.Text = "Total Without Dis";
            // 
            // CmbDwPay
            // 
            this.CmbDwPay.FormattingEnabled = true;
            this.CmbDwPay.Location = new System.Drawing.Point(756, 373);
            this.CmbDwPay.Name = "CmbDwPay";
            this.CmbDwPay.Size = new System.Drawing.Size(100, 21);
            this.CmbDwPay.TabIndex = 917;
            // 
            // TotAmtLbl
            // 
            this.TotAmtLbl.AutoSize = true;
            this.TotAmtLbl.Location = new System.Drawing.Point(729, 413);
            this.TotAmtLbl.Name = "TotAmtLbl";
            this.TotAmtLbl.Size = new System.Drawing.Size(0, 13);
            this.TotAmtLbl.TabIndex = 916;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(672, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 915;
            this.label17.Text = "Down Payment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(721, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 914;
            // 
            // frmARCrMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 434);
            this.Controls.Add(this.TxTotAmAply);
            this.Controls.Add(this.TxInvAmt);
            this.Controls.Add(this.TxWthDisc);
            this.Controls.Add(this.TxIncFreight);
            this.Controls.Add(this.TxIncDowPay);
            this.Controls.Add(this.TxTotWoutDis);
            this.Controls.Add(this.TxFreight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbDwPay);
            this.Controls.Add(this.TotAmtLbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxDiscount);
            this.Controls.Add(this.CmbTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTPPurInv);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxStatus);
            this.Controls.Add(this.TxPuRInvNo);
            this.Controls.Add(this.TxSuppRefN);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CmBSuppInv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxCardID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCur);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.DGCrMemo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmARCrMemo";
            this.Text = "AR Credit Memo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAPCrMemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCrMemo)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCrMemo;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox TxDiscount;
        private System.Windows.Forms.ComboBox CmbTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTPPurInv;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TxStatus;
        private System.Windows.Forms.TextBox TxPuRInvNo;
        private System.Windows.Forms.TextBox TxSuppRefN;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox CmBSuppInv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxCardID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCur;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxTotAmAply;
        private System.Windows.Forms.TextBox TxInvAmt;
        private System.Windows.Forms.TextBox TxWthDisc;
        private System.Windows.Forms.TextBox TxIncFreight;
        private System.Windows.Forms.TextBox TxIncDowPay;
        private System.Windows.Forms.TextBox TxTotWoutDis;
        private System.Windows.Forms.TextBox TxFreight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDwPay;
        private System.Windows.Forms.Label TotAmtLbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}