namespace Accounting_Sys
{
    partial class FrmProdionOrdr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdionOrdr));
            this.TxProdDesc = new System.Windows.Forms.TextBox();
            this.CMBWhse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxOrigin = new System.Windows.Forms.TextBox();
            this.TxProject = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmbDsitRul = new System.Windows.Forms.ComboBox();
            this.CmbUser = new System.Windows.Forms.ComboBox();
            this.CmBSalOrder = new System.Windows.Forms.ComboBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.DTPOrdDT = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpStrtDt = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxPdONo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbComponent = new System.Windows.Forms.TabPage();
            this.DGvPrdnOrdr = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlanQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbSummary = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbUomName = new System.Windows.Forms.ComboBox();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.TxPlanQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmBProduNo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGvPrdnOrdr)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxProdDesc
            // 
            this.TxProdDesc.Location = new System.Drawing.Point(161, 85);
            this.TxProdDesc.Name = "TxProdDesc";
            this.TxProdDesc.ReadOnly = true;
            this.TxProdDesc.Size = new System.Drawing.Size(284, 20);
            this.TxProdDesc.TabIndex = 505;
            // 
            // CMBWhse
            // 
            this.CMBWhse.FormattingEnabled = true;
            this.CMBWhse.Items.AddRange(new object[] {
            "Assembly",
            "Production",
            "Sales",
            "Template"});
            this.CMBWhse.Location = new System.Drawing.Point(162, 122);
            this.CMBWhse.Name = "CMBWhse";
            this.CMBWhse.Size = new System.Drawing.Size(121, 21);
            this.CMBWhse.TabIndex = 503;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(807, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 502;
            this.label10.Text = "Sale Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 501;
            this.label9.Text = "Project";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 500;
            this.label8.Text = "Distr. Rules";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 499;
            this.label7.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(808, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 498;
            this.label6.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 495;
            this.label3.Text = "Product No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 494;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 493;
            this.label1.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 497;
            this.label5.Text = "Warehouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 496;
            this.label4.Text = "Product Description";
            // 
            // TxOrigin
            // 
            this.TxOrigin.Location = new System.Drawing.Point(883, 102);
            this.TxOrigin.Name = "TxOrigin";
            this.TxOrigin.Size = new System.Drawing.Size(121, 20);
            this.TxOrigin.TabIndex = 514;
            // 
            // TxProject
            // 
            this.TxProject.Location = new System.Drawing.Point(653, 50);
            this.TxProject.Name = "TxProject";
            this.TxProject.Size = new System.Drawing.Size(121, 20);
            this.TxProject.TabIndex = 513;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(481, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 13);
            this.label21.TabIndex = 517;
            this.label21.Text = "oitt";
            // 
            // CmbDsitRul
            // 
            this.CmbDsitRul.FormattingEnabled = true;
            this.CmbDsitRul.Location = new System.Drawing.Point(653, 68);
            this.CmbDsitRul.Name = "CmbDsitRul";
            this.CmbDsitRul.Size = new System.Drawing.Size(121, 21);
            this.CmbDsitRul.TabIndex = 516;
            // 
            // CmbUser
            // 
            this.CmbUser.FormattingEnabled = true;
            this.CmbUser.Location = new System.Drawing.Point(883, 82);
            this.CmbUser.Name = "CmbUser";
            this.CmbUser.Size = new System.Drawing.Size(121, 21);
            this.CmbUser.TabIndex = 511;
            // 
            // CmBSalOrder
            // 
            this.CmBSalOrder.FormattingEnabled = true;
            this.CmBSalOrder.Location = new System.Drawing.Point(883, 119);
            this.CmBSalOrder.Name = "CmBSalOrder";
            this.CmBSalOrder.Size = new System.Drawing.Size(121, 21);
            this.CmBSalOrder.TabIndex = 510;
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(162, 29);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(121, 21);
            this.CmbType.TabIndex = 0;
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(161, 47);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(121, 21);
            this.CmbStatus.TabIndex = 521;
            // 
            // DTPOrdDT
            // 
            this.DTPOrdDT.Location = new System.Drawing.Point(885, 64);
            this.DTPOrdDT.Name = "DTPOrdDT";
            this.DTPOrdDT.Size = new System.Drawing.Size(120, 20);
            this.DTPOrdDT.TabIndex = 525;
            this.DTPOrdDT.Value = new System.DateTime(2018, 9, 20, 2, 54, 26, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(807, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 524;
            this.label11.Text = "Order Date";
            // 
            // dtpStrtDt
            // 
            this.dtpStrtDt.Location = new System.Drawing.Point(885, 47);
            this.dtpStrtDt.Name = "dtpStrtDt";
            this.dtpStrtDt.Size = new System.Drawing.Size(120, 20);
            this.dtpStrtDt.TabIndex = 523;
            this.dtpStrtDt.Value = new System.DateTime(2018, 9, 20, 2, 54, 26, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(808, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 522;
            this.label12.Text = "Start Date";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(653, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 526;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(575, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 527;
            this.label14.Text = "Customer";
            // 
            // TxPdONo
            // 
            this.TxPdONo.Location = new System.Drawing.Point(885, 28);
            this.TxPdONo.Name = "TxPdONo";
            this.TxPdONo.Size = new System.Drawing.Size(121, 20);
            this.TxPdONo.TabIndex = 529;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(808, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 528;
            this.label13.Text = "P_Order No";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbComponent);
            this.tabControl1.Controls.Add(this.TbSummary);
            this.tabControl1.Location = new System.Drawing.Point(16, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 309);
            this.tabControl1.TabIndex = 531;
            // 
            // tbComponent
            // 
            this.tbComponent.Controls.Add(this.DGvPrdnOrdr);
            this.tbComponent.Location = new System.Drawing.Point(4, 22);
            this.tbComponent.Name = "tbComponent";
            this.tbComponent.Padding = new System.Windows.Forms.Padding(3);
            this.tbComponent.Size = new System.Drawing.Size(987, 283);
            this.tbComponent.TabIndex = 0;
            this.tbComponent.Text = "Components";
            this.tbComponent.UseVisualStyleBackColor = true;
            // 
            // DGvPrdnOrdr
            // 
            this.DGvPrdnOrdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvPrdnOrdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column5,
            this.Column3,
            this.ColPlanQty,
            this.ColIssue,
            this.ColAvail,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9,
            this.Column11});
            this.DGvPrdnOrdr.Location = new System.Drawing.Point(10, 5);
            this.DGvPrdnOrdr.Name = "DGvPrdnOrdr";
            this.DGvPrdnOrdr.Size = new System.Drawing.Size(966, 252);
            this.DGvPrdnOrdr.TabIndex = 509;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Base Quantity";
            this.Column3.Name = "Column3";
            // 
            // ColPlanQty
            // 
            this.ColPlanQty.HeaderText = "Planned Quantity";
            this.ColPlanQty.Name = "ColPlanQty";
            // 
            // ColIssue
            // 
            this.ColIssue.HeaderText = "Issue";
            this.ColIssue.Name = "ColIssue";
            // 
            // ColAvail
            // 
            this.ColAvail.HeaderText = "Available";
            this.ColAvail.Name = "ColAvail";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "UoM Name";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Warehouse";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Issue Method";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Branch";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Product Line";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UoM Code";
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "WIP Account";
            this.Column11.Name = "Column11";
            // 
            // TbSummary
            // 
            this.TbSummary.Location = new System.Drawing.Point(4, 22);
            this.TbSummary.Name = "TbSummary";
            this.TbSummary.Padding = new System.Windows.Forms.Padding(3);
            this.TbSummary.Size = new System.Drawing.Size(987, 283);
            this.TbSummary.TabIndex = 1;
            this.TbSummary.Text = "Summary";
            this.TbSummary.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 536;
            this.label15.Text = "UoM Name";
            // 
            // CmbUomName
            // 
            this.CmbUomName.FormattingEnabled = true;
            this.CmbUomName.Location = new System.Drawing.Point(344, 104);
            this.CmbUomName.Name = "CmbUomName";
            this.CmbUomName.Size = new System.Drawing.Size(101, 21);
            this.CmbUomName.TabIndex = 537;
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
            this.ChToolStrip1.Size = new System.Drawing.Size(1055, 43);
            this.ChToolStrip1.TabIndex = 538;
            this.ChToolStrip1.Text = "toolStrip1";
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
            // TxPlanQty
            // 
            this.TxPlanQty.Location = new System.Drawing.Point(161, 103);
            this.TxPlanQty.Name = "TxPlanQty";
            this.TxPlanQty.Size = new System.Drawing.Size(121, 20);
            this.TxPlanQty.TabIndex = 540;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 539;
            this.label16.Text = "Planned Quantity";
            // 
            // CmBProduNo
            // 
            this.CmBProduNo.FormattingEnabled = true;
            this.CmBProduNo.Location = new System.Drawing.Point(161, 65);
            this.CmBProduNo.Name = "CmBProduNo";
            this.CmBProduNo.Size = new System.Drawing.Size(121, 21);
            this.CmBProduNo.TabIndex = 541;
            // 
            // FrmProdionOrdr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 434);
            this.Controls.Add(this.CmBProduNo);
            this.Controls.Add(this.TxPlanQty);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CmbUomName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TxPdONo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DTPOrdDT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpStrtDt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.TxProdDesc);
            this.Controls.Add(this.CMBWhse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxOrigin);
            this.Controls.Add(this.TxProject);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.CmbDsitRul);
            this.Controls.Add(this.CmbUser);
            this.Controls.Add(this.CmBSalOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProdionOrdr";
            this.Text = "Production Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdionOrdr_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGvPrdnOrdr)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxProdDesc;
        private System.Windows.Forms.ComboBox CMBWhse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxOrigin;
        private System.Windows.Forms.TextBox TxProject;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CmbDsitRul;
        private System.Windows.Forms.ComboBox CmbUser;
        private System.Windows.Forms.ComboBox CmBSalOrder;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.DateTimePicker DTPOrdDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpStrtDt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxPdONo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbComponent;
        private System.Windows.Forms.DataGridView DGvPrdnOrdr;
        private System.Windows.Forms.TabPage TbSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlanQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbUomName;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.TextBox TxPlanQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmBProduNo;
    }
}