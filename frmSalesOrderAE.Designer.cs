namespace Accounting_Sys
{
    partial class frmSalesOrderAE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.txtSalesman = new System.Windows.Forms.TextBox();
            this.CmdReceiveItem = new System.Windows.Forms.Button();
            this.cmdPrintPreview = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picPurchase = new System.Windows.Forms.GroupBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtSONo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTaxBase = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGrosse = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmdModificationHistory = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDispatched = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoldTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.picPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(687, 515);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(121, 20);
            this.txtNet.TabIndex = 145;
            this.txtNet.Text = "0.00";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(846, 203);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(85, 20);
            this.txtCustomerID.TabIndex = 151;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(846, 233);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(85, 20);
            this.txtStockNo.TabIndex = 150;
            // 
            // txtSalesman
            // 
            this.txtSalesman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSalesman.Location = new System.Drawing.Point(175, 130);
            this.txtSalesman.Name = "txtSalesman";
            this.txtSalesman.Size = new System.Drawing.Size(187, 20);
            this.txtSalesman.TabIndex = 153;
            // 
            // CmdReceiveItem
            // 
            this.CmdReceiveItem.Location = new System.Drawing.Point(408, 550);
            this.CmdReceiveItem.Name = "CmdReceiveItem";
            this.CmdReceiveItem.Size = new System.Drawing.Size(101, 27);
            this.CmdReceiveItem.TabIndex = 149;
            this.CmdReceiveItem.Text = "Receive Item";
            this.CmdReceiveItem.UseVisualStyleBackColor = true;
            this.CmdReceiveItem.Visible = false;
            // 
            // cmdPrintPreview
            // 
            this.cmdPrintPreview.Location = new System.Drawing.Point(515, 549);
            this.cmdPrintPreview.Name = "cmdPrintPreview";
            this.cmdPrintPreview.Size = new System.Drawing.Size(99, 28);
            this.cmdPrintPreview.TabIndex = 148;
            this.cmdPrintPreview.Text = "Print Preview";
            this.cmdPrintPreview.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Disc. %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Unit Price";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(417, 33);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(84, 20);
            this.txtGross.TabIndex = 24;
            this.txtGross.Text = "0.00";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitPrice.Location = new System.Drawing.Point(333, 32);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(78, 20);
            this.txtUnitPrice.TabIndex = 22;
            this.txtUnitPrice.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gross";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picPurchase);
            this.groupBox1.Controls.Add(this.dgView);
            this.groupBox1.Location = new System.Drawing.Point(103, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 246);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            // 
            // picPurchase
            // 
            this.picPurchase.Controls.Add(this.cmdAdd);
            this.picPurchase.Controls.Add(this.label7);
            this.picPurchase.Controls.Add(this.txtNetAmount);
            this.picPurchase.Controls.Add(this.txtStock);
            this.picPurchase.Controls.Add(this.label13);
            this.picPurchase.Controls.Add(this.label8);
            this.picPurchase.Controls.Add(this.txtQty);
            this.picPurchase.Controls.Add(this.txtDisc);
            this.picPurchase.Controls.Add(this.label11);
            this.picPurchase.Controls.Add(this.label9);
            this.picPurchase.Controls.Add(this.txtGross);
            this.picPurchase.Controls.Add(this.txtUnitPrice);
            this.picPurchase.Controls.Add(this.label10);
            this.picPurchase.Location = new System.Drawing.Point(0, 0);
            this.picPurchase.Name = "picPurchase";
            this.picPurchase.Size = new System.Drawing.Size(712, 65);
            this.picPurchase.TabIndex = 117;
            this.picPurchase.TabStop = false;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(656, 31);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(46, 21);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Items/Stocks";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(561, 32);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(85, 20);
            this.txtNetAmount.TabIndex = 29;
            // 
            // txtStock
            // 
            this.txtStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStock.Location = new System.Drawing.Point(6, 31);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(267, 20);
            this.txtStock.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Net Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unit Qty";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.Info;
            this.txtQty.Location = new System.Drawing.Point(279, 31);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 20);
            this.txtQty.TabIndex = 19;
            // 
            // txtDisc
            // 
            this.txtDisc.BackColor = System.Drawing.SystemColors.Info;
            this.txtDisc.Location = new System.Drawing.Point(507, 32);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(48, 20);
            this.txtDisc.TabIndex = 26;
            this.txtDisc.Text = "0";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_No,
            this.Description,
            this.Quantity,
            this.RentPrice,
            this.Gross,
            this.Discount,
            this.Amount});
            this.dgView.Location = new System.Drawing.Point(6, 71);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(699, 169);
            this.dgView.TabIndex = 63;
            // 
            // Item_No
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Item_No.DefaultCellStyle = dataGridViewCellStyle1;
            this.Item_No.HeaderText = "Item No./ Barcode";
            this.Item_No.MinimumWidth = 20;
            this.Item_No.Name = "Item_No";
            this.Item_No.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 200;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // RentPrice
            // 
            this.RentPrice.HeaderText = "Sales Price";
            this.RentPrice.Name = "RentPrice";
            this.RentPrice.ReadOnly = true;
            // 
            // Gross
            // 
            this.Gross.HeaderText = "Gross";
            this.Gross.Name = "Gross";
            this.Gross.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Net Amount";
            this.Amount.MinimumWidth = 50;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 110;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(389, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 13);
            this.label20.TabIndex = 147;
            this.label20.Text = "Delivery Instructions:";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(499, 108);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(190, 53);
            this.txtInstructions.TabIndex = 146;
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(175, 37);
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(187, 20);
            this.txtSONo.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "SO No.:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(648, 515);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 144;
            this.label19.Text = "Net:";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(687, 489);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(121, 20);
            this.txtVAT.TabIndex = 143;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(614, 489);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 142;
            this.label17.Text = "VAT (0.12):";
            // 
            // txtTaxBase
            // 
            this.txtTaxBase.Location = new System.Drawing.Point(687, 467);
            this.txtTaxBase.Name = "txtTaxBase";
            this.txtTaxBase.ReadOnly = true;
            this.txtTaxBase.Size = new System.Drawing.Size(121, 20);
            this.txtTaxBase.TabIndex = 141;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(620, 467);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 140;
            this.label18.Text = "Tax Base:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(687, 441);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 139;
            this.txtDiscount.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(623, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 138;
            this.label16.Text = "Discount:";
            // 
            // txtGrosse
            // 
            this.txtGrosse.Location = new System.Drawing.Point(687, 419);
            this.txtGrosse.Name = "txtGrosse";
            this.txtGrosse.ReadOnly = true;
            this.txtGrosse.Size = new System.Drawing.Size(121, 20);
            this.txtGrosse.TabIndex = 137;
            this.txtGrosse.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(638, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 136;
            this.label15.Text = "Gross:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(109, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 135;
            this.label14.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(112, 438);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(338, 105);
            this.txtRemarks.TabIndex = 134;
            // 
            // cmdModificationHistory
            // 
            this.cmdModificationHistory.Location = new System.Drawing.Point(112, 549);
            this.cmdModificationHistory.Name = "cmdModificationHistory";
            this.cmdModificationHistory.Size = new System.Drawing.Size(137, 28);
            this.cmdModificationHistory.TabIndex = 117;
            this.cmdModificationHistory.Text = "Modification History";
            this.cmdModificationHistory.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(724, 549);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(93, 28);
            this.cmdCancel.TabIndex = 133;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(109, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 152;
            this.label21.Text = "Salesman:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(620, 550);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(98, 28);
            this.cmdSave.TabIndex = 132;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(499, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 20);
            this.dtpDate.TabIndex = 131;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(499, 31);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(190, 20);
            this.txtDate.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Date:";
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(499, 56);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(190, 20);
            this.txtOrderedBy.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Ordered By:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(175, 86);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 38);
            this.txtAddress.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 125;
            this.label4.Text = "Dispatched By:";
            // 
            // txtDispatched
            // 
            this.txtDispatched.Location = new System.Drawing.Point(499, 82);
            this.txtDispatched.Name = "txtDispatched";
            this.txtDispatched.Size = new System.Drawing.Size(190, 20);
            this.txtDispatched.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Address:";
            // 
            // txtSoldTo
            // 
            this.txtSoldTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSoldTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSoldTo.Location = new System.Drawing.Point(175, 63);
            this.txtSoldTo.Name = "txtSoldTo";
            this.txtSoldTo.Size = new System.Drawing.Size(187, 20);
            this.txtSoldTo.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Customer:";
            // 
            // frmSalesOrderAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 609);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtStockNo);
            this.Controls.Add(this.txtSalesman);
            this.Controls.Add(this.CmdReceiveItem);
            this.Controls.Add(this.cmdPrintPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtSONo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTaxBase);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGrosse);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmdModificationHistory);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrderedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDispatched);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoldTo);
            this.Controls.Add(this.label2);
            this.Name = "frmSalesOrderAE";
            this.Text = "frmSalesOrderAE";
            this.groupBox1.ResumeLayout(false);
            this.picPurchase.ResumeLayout(false);
            this.picPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNet;
        public System.Windows.Forms.TextBox txtCustomerID;
        public System.Windows.Forms.TextBox txtStockNo;
        public System.Windows.Forms.TextBox txtSalesman;
        public System.Windows.Forms.Button CmdReceiveItem;
        public System.Windows.Forms.Button cmdPrintPreview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtGross;
        public System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox picPurchase;
        public System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNetAmount;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtInstructions;
        public System.Windows.Forms.TextBox txtSONo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtTaxBase;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtGrosse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtRemarks;
        public System.Windows.Forms.Button cmdModificationHistory;
        public System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Button cmdSave;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDispatched;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSoldTo;
        private System.Windows.Forms.Label label2;
    }
}