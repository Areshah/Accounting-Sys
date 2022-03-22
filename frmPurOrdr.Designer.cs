namespace Accounting_Sys
{
    partial class frmPurOrdr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurOrdr));
            this.DGPrPO = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPDocDt = new System.Windows.Forms.DateTimePicker();
            this.DTPDlvDT = new System.Windows.Forms.DateTimePicker();
            this.DTPPostDt = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.TxTotAmAply = new System.Windows.Forms.TextBox();
            this.TxInvAmt = new System.Windows.Forms.TextBox();
            this.TxWthDisc = new System.Windows.Forms.TextBox();
            this.TxIncFreight = new System.Windows.Forms.TextBox();
            this.TxIncDowPay = new System.Windows.Forms.TextBox();
            this.TxTotWoutDis = new System.Windows.Forms.TextBox();
            this.TxFreight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxRate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CmbDwPay = new System.Windows.Forms.ComboBox();
            this.TotAmtLbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxPuRPONo = new System.Windows.Forms.TextBox();
            this.TxSuppRefN = new System.Windows.Forms.TextBox();
            this.CmBSuppInv = new System.Windows.Forms.ComboBox();
            this.TxCardID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxContPrsn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTax = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGPrPO)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGPrPO
            // 
            this.DGPrPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPrPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DGPrPO.Location = new System.Drawing.Point(17, 132);
            this.DGPrPO.Name = "DGPrPO";
            this.DGPrPO.Size = new System.Drawing.Size(966, 180);
            this.DGPrPO.TabIndex = 691;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Catalog No";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Discount %";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tax Code";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total (LC)";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bin Location";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UoM Code";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "COGS Product Line";
            this.Column10.Name = "Column10";
            this.Column10.Width = 170;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Return Cost ";
            this.Column11.Name = "Column11";
            // 
            // DTPDocDt
            // 
            this.DTPDocDt.Location = new System.Drawing.Point(853, 107);
            this.DTPDocDt.Name = "DTPDocDt";
            this.DTPDocDt.Size = new System.Drawing.Size(130, 20);
            this.DTPDocDt.TabIndex = 690;
            // 
            // DTPDlvDT
            // 
            this.DTPDlvDT.Location = new System.Drawing.Point(853, 87);
            this.DTPDlvDT.Name = "DTPDlvDT";
            this.DTPDlvDT.Size = new System.Drawing.Size(130, 20);
            this.DTPDlvDT.TabIndex = 689;
            // 
            // DTPPostDt
            // 
            this.DTPPostDt.Location = new System.Drawing.Point(853, 68);
            this.DTPPostDt.Name = "DTPPostDt";
            this.DTPPostDt.Size = new System.Drawing.Size(130, 20);
            this.DTPPostDt.TabIndex = 688;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(147, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 64);
            this.richTextBox1.TabIndex = 687;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 356);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 686;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 678;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(853, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(130, 20);
            this.textBox6.TabIndex = 685;
            this.textBox6.Text = "OPen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 681;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 673;
            this.label15.Text = "Sale Employee";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 682;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 676;
            this.label11.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 675;
            this.label13.Text = "Payment Order Run";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 674;
            this.label14.Text = "Owner";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(760, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 672;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 671;
            this.label9.Text = "Document Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(760, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 670;
            this.label8.Text = "Delivery Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 669;
            this.label7.Text = "Posting Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 667;
            this.label5.Text = "BP Currency";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(291, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 702;
            this.label20.Text = "Item / Service  Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(467, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 704;
            this.label21.Text = "ordr";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(407, 109);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 703;
            // 
            // TxTotAmAply
            // 
            this.TxTotAmAply.Location = new System.Drawing.Point(884, 393);
            this.TxTotAmAply.Name = "TxTotAmAply";
            this.TxTotAmAply.ReadOnly = true;
            this.TxTotAmAply.Size = new System.Drawing.Size(100, 20);
            this.TxTotAmAply.TabIndex = 929;
            this.TxTotAmAply.Text = "0.00";
            // 
            // TxInvAmt
            // 
            this.TxInvAmt.Location = new System.Drawing.Point(884, 373);
            this.TxInvAmt.Name = "TxInvAmt";
            this.TxInvAmt.ReadOnly = true;
            this.TxInvAmt.Size = new System.Drawing.Size(100, 20);
            this.TxInvAmt.TabIndex = 928;
            this.TxInvAmt.Text = "0.00";
            // 
            // TxWthDisc
            // 
            this.TxWthDisc.Location = new System.Drawing.Point(884, 313);
            this.TxWthDisc.Name = "TxWthDisc";
            this.TxWthDisc.ReadOnly = true;
            this.TxWthDisc.Size = new System.Drawing.Size(100, 20);
            this.TxWthDisc.TabIndex = 927;
            this.TxWthDisc.Text = "0.00";
            // 
            // TxIncFreight
            // 
            this.TxIncFreight.Location = new System.Drawing.Point(884, 334);
            this.TxIncFreight.Name = "TxIncFreight";
            this.TxIncFreight.ReadOnly = true;
            this.TxIncFreight.Size = new System.Drawing.Size(100, 20);
            this.TxIncFreight.TabIndex = 926;
            this.TxIncFreight.Text = "0.00";
            // 
            // TxIncDowPay
            // 
            this.TxIncDowPay.Location = new System.Drawing.Point(884, 354);
            this.TxIncDowPay.Name = "TxIncDowPay";
            this.TxIncDowPay.ReadOnly = true;
            this.TxIncDowPay.Size = new System.Drawing.Size(100, 20);
            this.TxIncDowPay.TabIndex = 925;
            this.TxIncDowPay.Text = "0.00";
            // 
            // TxTotWoutDis
            // 
            this.TxTotWoutDis.Location = new System.Drawing.Point(755, 317);
            this.TxTotWoutDis.Name = "TxTotWoutDis";
            this.TxTotWoutDis.ReadOnly = true;
            this.TxTotWoutDis.Size = new System.Drawing.Size(100, 20);
            this.TxTotWoutDis.TabIndex = 924;
            this.TxTotWoutDis.Text = "0.00";
            // 
            // TxFreight
            // 
            this.TxFreight.Location = new System.Drawing.Point(755, 335);
            this.TxFreight.Name = "TxFreight";
            this.TxFreight.ReadOnly = true;
            this.TxFreight.Size = new System.Drawing.Size(100, 20);
            this.TxFreight.TabIndex = 923;
            this.TxFreight.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 922;
            this.label12.Text = "Freight";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(673, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 921;
            this.label16.Text = "Rate";
            // 
            // TxRate
            // 
            this.TxRate.Location = new System.Drawing.Point(754, 377);
            this.TxRate.Name = "TxRate";
            this.TxRate.ReadOnly = true;
            this.TxRate.Size = new System.Drawing.Size(50, 20);
            this.TxRate.TabIndex = 920;
            this.TxRate.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(806, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 919;
            this.label17.Text = "Tax Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(669, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 918;
            this.label18.Text = "Total Without Dis";
            // 
            // CmbDwPay
            // 
            this.CmbDwPay.FormattingEnabled = true;
            this.CmbDwPay.Location = new System.Drawing.Point(755, 356);
            this.CmbDwPay.Name = "CmbDwPay";
            this.CmbDwPay.Size = new System.Drawing.Size(100, 21);
            this.CmbDwPay.TabIndex = 917;
            // 
            // TotAmtLbl
            // 
            this.TotAmtLbl.AutoSize = true;
            this.TotAmtLbl.Location = new System.Drawing.Point(728, 396);
            this.TotAmtLbl.Name = "TotAmtLbl";
            this.TotAmtLbl.Size = new System.Drawing.Size(0, 13);
            this.TotAmtLbl.TabIndex = 916;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(671, 358);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 915;
            this.label19.Text = "Down Payment";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(720, 359);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 914;
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
            this.ChToolStrip1.TabIndex = 705;
            this.ChToolStrip1.Text = "toolStrip1";
            // 
            // TxPuRPONo
            // 
            this.TxPuRPONo.Location = new System.Drawing.Point(136, 32);
            this.TxPuRPONo.Name = "TxPuRPONo";
            this.TxPuRPONo.Size = new System.Drawing.Size(130, 20);
            this.TxPuRPONo.TabIndex = 936;
            // 
            // TxSuppRefN
            // 
            this.TxSuppRefN.Location = new System.Drawing.Point(136, 92);
            this.TxSuppRefN.Name = "TxSuppRefN";
            this.TxSuppRefN.Size = new System.Drawing.Size(130, 20);
            this.TxSuppRefN.TabIndex = 935;
            // 
            // CmBSuppInv
            // 
            this.CmBSuppInv.FormattingEnabled = true;
            this.CmBSuppInv.Location = new System.Drawing.Point(172, 51);
            this.CmBSuppInv.Name = "CmBSuppInv";
            this.CmBSuppInv.Size = new System.Drawing.Size(94, 21);
            this.CmBSuppInv.TabIndex = 931;
            // 
            // TxCardID
            // 
            this.TxCardID.Location = new System.Drawing.Point(136, 51);
            this.TxCardID.Name = "TxCardID";
            this.TxCardID.Size = new System.Drawing.Size(36, 20);
            this.TxCardID.TabIndex = 930;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 934;
            this.label1.Text = "Invoice No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 933;
            this.label4.Text = "Supplier Ref. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 932;
            this.label2.Text = "Supplier Code / Name";
            // 
            // TxContPrsn
            // 
            this.TxContPrsn.Location = new System.Drawing.Point(136, 72);
            this.TxContPrsn.Name = "TxContPrsn";
            this.TxContPrsn.Size = new System.Drawing.Size(130, 20);
            this.TxContPrsn.TabIndex = 938;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 937;
            this.label3.Text = "Contact Person";
            // 
            // CmbTax
            // 
            this.CmbTax.FormattingEnabled = true;
            this.CmbTax.Location = new System.Drawing.Point(853, 30);
            this.CmbTax.Name = "CmbTax";
            this.CmbTax.Size = new System.Drawing.Size(130, 21);
            this.CmbTax.TabIndex = 940;
            this.CmbTax.SelectedIndexChanged += new System.EventHandler(this.CmbTax_SelectedIndexChanged);
            this.CmbTax.Enter += new System.EventHandler(this.CmbTax_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 939;
            this.label6.Text = "Tax Code";
            // 
            // frmPurOrdr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 434);
            this.Controls.Add(this.CmbTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxContPrsn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxPuRPONo);
            this.Controls.Add(this.TxSuppRefN);
            this.Controls.Add(this.CmBSuppInv);
            this.Controls.Add(this.TxCardID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxTotAmAply);
            this.Controls.Add(this.TxInvAmt);
            this.Controls.Add(this.TxWthDisc);
            this.Controls.Add(this.TxIncFreight);
            this.Controls.Add(this.TxIncDowPay);
            this.Controls.Add(this.TxTotWoutDis);
            this.Controls.Add(this.TxFreight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxRate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmbDwPay);
            this.Controls.Add(this.TotAmtLbl);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.DGPrPO);
            this.Controls.Add(this.DTPDocDt);
            this.Controls.Add(this.DTPDlvDT);
            this.Controls.Add(this.DTPPostDt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurOrdr";
            this.Text = "Purchase Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frnPurOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPrPO)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGPrPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DateTimePicker DTPDocDt;
        private System.Windows.Forms.DateTimePicker DTPDlvDT;
        private System.Windows.Forms.DateTimePicker DTPPostDt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox TxTotAmAply;
        private System.Windows.Forms.TextBox TxInvAmt;
        private System.Windows.Forms.TextBox TxWthDisc;
        private System.Windows.Forms.TextBox TxIncFreight;
        private System.Windows.Forms.TextBox TxIncDowPay;
        private System.Windows.Forms.TextBox TxTotWoutDis;
        private System.Windows.Forms.TextBox TxFreight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CmbDwPay;
        private System.Windows.Forms.Label TotAmtLbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.TextBox TxPuRPONo;
        private System.Windows.Forms.TextBox TxSuppRefN;
        private System.Windows.Forms.ComboBox CmBSuppInv;
        private System.Windows.Forms.TextBox TxCardID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxContPrsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTax;
        private System.Windows.Forms.Label label6;
    }
}