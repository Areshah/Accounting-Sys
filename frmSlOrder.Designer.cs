namespace Accounting_Sys
{
    partial class frmSlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlOrder));
            this.DGSLOrdr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitmdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxFreight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxRate = new System.Windows.Forms.TextBox();
            this.CmbTax = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPPurInv = new System.Windows.Forms.DateTimePicker();
            this.TxStatus = new System.Windows.Forms.TextBox();
            this.TxPuRInvNo = new System.Windows.Forms.TextBox();
            this.TxSuppRefN = new System.Windows.Forms.TextBox();
            this.CmBSuppInv = new System.Windows.Forms.ComboBox();
            this.TxCardID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbCur = new System.Windows.Forms.ComboBox();
            this.CmbDwPay = new System.Windows.Forms.ComboBox();
            this.TotAmtLbl = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxTotWoutDis = new System.Windows.Forms.TextBox();
            this.TxIncDowPay = new System.Windows.Forms.TextBox();
            this.TxIncFreight = new System.Windows.Forms.TextBox();
            this.TxWthDisc = new System.Windows.Forms.TextBox();
            this.TxInvAmt = new System.Windows.Forms.TextBox();
            this.TxTotAmAply = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGSLOrdr)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGSLOrdr
            // 
            this.DGSLOrdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSLOrdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colitmdesc,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9,
            this.Column11});
            this.DGSLOrdr.Location = new System.Drawing.Point(17, 117);
            this.DGSLOrdr.Name = "DGSLOrdr";
            this.DGSLOrdr.Size = new System.Drawing.Size(966, 205);
            this.DGSLOrdr.TabIndex = 562;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // colitmdesc
            // 
            this.colitmdesc.HeaderText = "Item Description";
            this.colitmdesc.Name = "colitmdesc";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No of Packages";
            this.Column2.Name = "Column2";
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
            // Column10
            // 
            this.Column10.HeaderText = "COGS Product Line";
            this.Column10.Name = "Column10";
            this.Column10.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Qty(Inventory UoM)";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UoM Code";
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Return Cost ";
            this.Column11.Name = "Column11";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(853, 95);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker3.TabIndex = 561;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(147, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 64);
            this.richTextBox1.TabIndex = 558;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 557;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 319);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 549;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 552;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 547;
            this.label11.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 546;
            this.label13.Text = "Payment Order Run";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 545;
            this.label14.Text = "Owner";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 544;
            this.label15.Text = "Sale Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 542;
            this.label9.Text = "Document Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 573;
            this.label20.Text = "Item / Service  Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(467, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 575;
            this.label21.Text = "ordr";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(404, 94);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 574;
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
            this.ChToolStrip1.TabIndex = 576;
            this.ChToolStrip1.Text = "toolStrip1";
            // 
            // TxFreight
            // 
            this.TxFreight.Location = new System.Drawing.Point(750, 344);
            this.TxFreight.Name = "TxFreight";
            this.TxFreight.ReadOnly = true;
            this.TxFreight.Size = new System.Drawing.Size(100, 20);
            this.TxFreight.TabIndex = 901;
            this.TxFreight.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 900;
            this.label2.Text = "Freight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(668, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 898;
            this.label12.Text = "Rate";
            // 
            // TxRate
            // 
            this.TxRate.Location = new System.Drawing.Point(749, 386);
            this.TxRate.Name = "TxRate";
            this.TxRate.ReadOnly = true;
            this.TxRate.Size = new System.Drawing.Size(50, 20);
            this.TxRate.TabIndex = 897;
            this.TxRate.Text = "0.00";
            // 
            // CmbTax
            // 
            this.CmbTax.FormattingEnabled = true;
            this.CmbTax.Location = new System.Drawing.Point(852, 35);
            this.CmbTax.Name = "CmbTax";
            this.CmbTax.Size = new System.Drawing.Size(130, 21);
            this.CmbTax.TabIndex = 896;
            this.CmbTax.SelectedIndexChanged += new System.EventHandler(this.CmbTax_SelectedIndexChanged);
            this.CmbTax.Enter += new System.EventHandler(this.CmbTax_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(761, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 895;
            this.label8.Text = "Tax Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(801, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 894;
            this.label7.Text = "Tax Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 893;
            this.label3.Text = "Total Without Dis";
            // 
            // DTPPurInv
            // 
            this.DTPPurInv.Location = new System.Drawing.Point(852, 75);
            this.DTPPurInv.Name = "DTPPurInv";
            this.DTPPurInv.Size = new System.Drawing.Size(130, 20);
            this.DTPPurInv.TabIndex = 886;
            // 
            // TxStatus
            // 
            this.TxStatus.Location = new System.Drawing.Point(852, 55);
            this.TxStatus.Name = "TxStatus";
            this.TxStatus.ReadOnly = true;
            this.TxStatus.Size = new System.Drawing.Size(130, 20);
            this.TxStatus.TabIndex = 884;
            this.TxStatus.Text = "Open";
            // 
            // TxPuRInvNo
            // 
            this.TxPuRInvNo.Location = new System.Drawing.Point(129, 38);
            this.TxPuRInvNo.Name = "TxPuRInvNo";
            this.TxPuRInvNo.Size = new System.Drawing.Size(130, 20);
            this.TxPuRInvNo.TabIndex = 883;
            // 
            // TxSuppRefN
            // 
            this.TxSuppRefN.Location = new System.Drawing.Point(129, 76);
            this.TxSuppRefN.Name = "TxSuppRefN";
            this.TxSuppRefN.Size = new System.Drawing.Size(130, 20);
            this.TxSuppRefN.TabIndex = 882;
            // 
            // CmBSuppInv
            // 
            this.CmBSuppInv.FormattingEnabled = true;
            this.CmBSuppInv.Location = new System.Drawing.Point(165, 57);
            this.CmBSuppInv.Name = "CmBSuppInv";
            this.CmBSuppInv.Size = new System.Drawing.Size(94, 21);
            this.CmBSuppInv.TabIndex = 875;
            // 
            // TxCardID
            // 
            this.TxCardID.Location = new System.Drawing.Point(129, 57);
            this.TxCardID.Name = "TxCardID";
            this.TxCardID.Size = new System.Drawing.Size(36, 20);
            this.TxCardID.TabIndex = 874;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(759, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 881;
            this.label10.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 880;
            this.label1.Text = "Delivery Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 879;
            this.label6.Text = "Invoice No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 878;
            this.label5.Text = "BP Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 877;
            this.label4.Text = "Customer Ref. No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 876;
            this.label16.Text = "Customer Code / Name";
            // 
            // CmbCur
            // 
            this.CmbCur.FormattingEnabled = true;
            this.CmbCur.Location = new System.Drawing.Point(129, 93);
            this.CmbCur.Name = "CmbCur";
            this.CmbCur.Size = new System.Drawing.Size(129, 21);
            this.CmbCur.TabIndex = 892;
            // 
            // CmbDwPay
            // 
            this.CmbDwPay.FormattingEnabled = true;
            this.CmbDwPay.Location = new System.Drawing.Point(750, 365);
            this.CmbDwPay.Name = "CmbDwPay";
            this.CmbDwPay.Size = new System.Drawing.Size(100, 21);
            this.CmbDwPay.TabIndex = 891;
            // 
            // TotAmtLbl
            // 
            this.TotAmtLbl.AutoSize = true;
            this.TotAmtLbl.Location = new System.Drawing.Point(723, 405);
            this.TotAmtLbl.Name = "TotAmtLbl";
            this.TotAmtLbl.Size = new System.Drawing.Size(0, 13);
            this.TotAmtLbl.TabIndex = 890;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(666, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 889;
            this.label17.Text = "Down Payment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(715, 368);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 888;
            // 
            // TxTotWoutDis
            // 
            this.TxTotWoutDis.Location = new System.Drawing.Point(750, 326);
            this.TxTotWoutDis.Name = "TxTotWoutDis";
            this.TxTotWoutDis.ReadOnly = true;
            this.TxTotWoutDis.Size = new System.Drawing.Size(100, 20);
            this.TxTotWoutDis.TabIndex = 908;
            this.TxTotWoutDis.Text = "0.00";
            // 
            // TxIncDowPay
            // 
            this.TxIncDowPay.Location = new System.Drawing.Point(879, 363);
            this.TxIncDowPay.Name = "TxIncDowPay";
            this.TxIncDowPay.ReadOnly = true;
            this.TxIncDowPay.Size = new System.Drawing.Size(100, 20);
            this.TxIncDowPay.TabIndex = 909;
            this.TxIncDowPay.Text = "0.00";
            // 
            // TxIncFreight
            // 
            this.TxIncFreight.Location = new System.Drawing.Point(879, 343);
            this.TxIncFreight.Name = "TxIncFreight";
            this.TxIncFreight.ReadOnly = true;
            this.TxIncFreight.Size = new System.Drawing.Size(100, 20);
            this.TxIncFreight.TabIndex = 910;
            this.TxIncFreight.Text = "0.00";
            // 
            // TxWthDisc
            // 
            this.TxWthDisc.Location = new System.Drawing.Point(879, 322);
            this.TxWthDisc.Name = "TxWthDisc";
            this.TxWthDisc.ReadOnly = true;
            this.TxWthDisc.Size = new System.Drawing.Size(100, 20);
            this.TxWthDisc.TabIndex = 911;
            this.TxWthDisc.Text = "0.00";
            // 
            // TxInvAmt
            // 
            this.TxInvAmt.Location = new System.Drawing.Point(879, 382);
            this.TxInvAmt.Name = "TxInvAmt";
            this.TxInvAmt.ReadOnly = true;
            this.TxInvAmt.Size = new System.Drawing.Size(100, 20);
            this.TxInvAmt.TabIndex = 912;
            this.TxInvAmt.Text = "0.00";
            // 
            // TxTotAmAply
            // 
            this.TxTotAmAply.Location = new System.Drawing.Point(879, 402);
            this.TxTotAmAply.Name = "TxTotAmAply";
            this.TxTotAmAply.ReadOnly = true;
            this.TxTotAmAply.Size = new System.Drawing.Size(100, 20);
            this.TxTotAmAply.TabIndex = 913;
            this.TxTotAmAply.Text = "0.00";
            // 
            // frmSlOrder
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
            this.Controls.Add(this.CmbTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPPurInv);
            this.Controls.Add(this.TxStatus);
            this.Controls.Add(this.TxPuRInvNo);
            this.Controls.Add(this.TxSuppRefN);
            this.Controls.Add(this.CmBSuppInv);
            this.Controls.Add(this.TxCardID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CmbCur);
            this.Controls.Add(this.CmbDwPay);
            this.Controls.Add(this.TotAmtLbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DGSLOrdr);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSlOrder";
            this.Text = "Sale Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSlOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGSLOrdr)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGSLOrdr;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.TextBox TxFreight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxRate;
        private System.Windows.Forms.ComboBox CmbTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPPurInv;
        private System.Windows.Forms.TextBox TxStatus;
        private System.Windows.Forms.TextBox TxPuRInvNo;
        private System.Windows.Forms.TextBox TxSuppRefN;
        private System.Windows.Forms.ComboBox CmBSuppInv;
        private System.Windows.Forms.TextBox TxCardID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbCur;
        private System.Windows.Forms.ComboBox CmbDwPay;
        private System.Windows.Forms.Label TotAmtLbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxTotWoutDis;
        private System.Windows.Forms.TextBox TxIncDowPay;
        private System.Windows.Forms.TextBox TxIncFreight;
        private System.Windows.Forms.TextBox TxWthDisc;
        private System.Windows.Forms.TextBox TxInvAmt;
        private System.Windows.Forms.TextBox TxTotAmAply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitmdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}