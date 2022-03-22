namespace Accounting_Sys
{
    partial class frmSalesOrderReturnAE
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
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.Item_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.cmdModificationHistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoldTo = new System.Windows.Forms.TextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtSONo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGrosse = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtTaxBase = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtAcknowledgedBy = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPostedBy = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpCreditMemoDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditMemoDate = new System.Windows.Forms.TextBox();
            this.txtPreparedBy = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditMemoNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.picPurchase = new System.Windows.Forms.GroupBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.picPurchase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 200;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(637, 25);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 21);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Update";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Items/Stocks";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(14, 26);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(244, 20);
            this.txtStock.TabIndex = 17;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtNetAmount.Location = new System.Drawing.Point(546, 25);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(85, 20);
            this.txtNetAmount.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unit Qty";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Net Amount";
            this.Amount.MinimumWidth = 50;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 110;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(264, 25);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 20);
            this.txtQty.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(318, 25);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(78, 20);
            this.txtUnitPrice.TabIndex = 22;
            this.txtUnitPrice.Text = "0.00";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(492, 25);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(48, 20);
            this.txtDisc.TabIndex = 26;
            this.txtDisc.Text = "0";
            // 
            // Gross
            // 
            this.Gross.HeaderText = "Gross";
            this.Gross.Name = "Gross";
            this.Gross.ReadOnly = true;
            // 
            // RentPrice
            // 
            this.RentPrice.HeaderText = "Sales Price";
            this.RentPrice.Name = "RentPrice";
            this.RentPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Net Amount";
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
            // txtStockNo
            // 
            this.txtStockNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtStockNo.Location = new System.Drawing.Point(854, 244);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(85, 20);
            this.txtStockNo.TabIndex = 229;
            // 
            // cmdModificationHistory
            // 
            this.cmdModificationHistory.Location = new System.Drawing.Point(102, 549);
            this.cmdModificationHistory.Name = "cmdModificationHistory";
            this.cmdModificationHistory.Size = new System.Drawing.Size(137, 31);
            this.cmdModificationHistory.TabIndex = 230;
            this.cmdModificationHistory.Text = "Modification History";
            this.cmdModificationHistory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 234;
            this.label2.Text = "Vendor:";
            // 
            // txtSoldTo
            // 
            this.txtSoldTo.Location = new System.Drawing.Point(168, 45);
            this.txtSoldTo.Name = "txtSoldTo";
            this.txtSoldTo.Size = new System.Drawing.Size(187, 20);
            this.txtSoldTo.TabIndex = 235;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(487, 42);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(187, 20);
            this.txtDeliveryDate.TabIndex = 236;
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(168, 19);
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(187, 20);
            this.txtSONo.TabIndex = 232;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(638, 518);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 252;
            this.label19.Text = "Net:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 231;
            this.label1.Text = "SO No.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(613, 444);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 246;
            this.label16.Text = "Discount:";
            // 
            // txtGrosse
            // 
            this.txtGrosse.BackColor = System.Drawing.SystemColors.Info;
            this.txtGrosse.Location = new System.Drawing.Point(677, 422);
            this.txtGrosse.Name = "txtGrosse";
            this.txtGrosse.ReadOnly = true;
            this.txtGrosse.Size = new System.Drawing.Size(121, 20);
            this.txtGrosse.TabIndex = 245;
            this.txtGrosse.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(628, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 244;
            this.label15.Text = "Gross:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 243;
            this.label14.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 237;
            this.label4.Text = "Delivery Date:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(102, 438);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(338, 108);
            this.txtRemarks.TabIndex = 242;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(604, 492);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 250;
            this.label17.Text = "VAT (0.12):";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.SystemColors.Info;
            this.txtVAT.Location = new System.Drawing.Point(677, 492);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(121, 20);
            this.txtVAT.TabIndex = 251;
            // 
            // txtTaxBase
            // 
            this.txtTaxBase.BackColor = System.Drawing.SystemColors.Info;
            this.txtTaxBase.Location = new System.Drawing.Point(677, 470);
            this.txtTaxBase.Name = "txtTaxBase";
            this.txtTaxBase.ReadOnly = true;
            this.txtTaxBase.Size = new System.Drawing.Size(121, 20);
            this.txtTaxBase.TabIndex = 249;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(607, 473);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 248;
            this.label18.Text = "Tax Base:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Info;
            this.txtDiscount.Location = new System.Drawing.Point(677, 444);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 247;
            this.txtDiscount.Text = "0.00";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(714, 549);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(93, 31);
            this.cmdCancel.TabIndex = 241;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(594, 549);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(114, 31);
            this.cmdSave.TabIndex = 240;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Location = new System.Drawing.Point(487, 16);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(190, 20);
            this.txtDeliveryNo.TabIndex = 239;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gross";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(633, 132);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 13);
            this.label27.TabIndex = 275;
            this.label27.Text = "Acknowledged By:";
            // 
            // txtAcknowledgedBy
            // 
            this.txtAcknowledgedBy.Location = new System.Drawing.Point(636, 148);
            this.txtAcknowledgedBy.Name = "txtAcknowledgedBy";
            this.txtAcknowledgedBy.Size = new System.Drawing.Size(166, 20);
            this.txtAcknowledgedBy.TabIndex = 274;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(395, 162);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 273;
            this.label26.Text = "Approved By:";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(473, 162);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(141, 20);
            this.txtApprovedBy.TabIndex = 272;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(408, 136);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 271;
            this.label25.Text = "Posted By:";
            // 
            // txtPostedBy
            // 
            this.txtPostedBy.Location = new System.Drawing.Point(473, 136);
            this.txtPostedBy.Name = "txtPostedBy";
            this.txtPostedBy.Size = new System.Drawing.Size(141, 20);
            this.txtPostedBy.TabIndex = 270;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(395, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 269;
            this.label24.Text = "Received By:";
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Location = new System.Drawing.Point(473, 110);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(141, 20);
            this.txtReceivedBy.TabIndex = 268;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(398, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 267;
            this.label23.Text = "Prepared By:";
            // 
            // dtpCreditMemoDate
            // 
            this.dtpCreditMemoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreditMemoDate.Location = new System.Drawing.Point(191, 106);
            this.dtpCreditMemoDate.Name = "dtpCreditMemoDate";
            this.dtpCreditMemoDate.Size = new System.Drawing.Size(134, 20);
            this.dtpCreditMemoDate.TabIndex = 266;
            // 
            // txtCreditMemoDate
            // 
            this.txtCreditMemoDate.Location = new System.Drawing.Point(191, 106);
            this.txtCreditMemoDate.Name = "txtCreditMemoDate";
            this.txtCreditMemoDate.Size = new System.Drawing.Size(134, 20);
            this.txtCreditMemoDate.TabIndex = 265;
            // 
            // txtPreparedBy
            // 
            this.txtPreparedBy.Location = new System.Drawing.Point(473, 84);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.Size = new System.Drawing.Size(141, 20);
            this.txtPreparedBy.TabIndex = 263;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(191, 166);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(187, 20);
            this.txtReference.TabIndex = 261;
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
            this.dgView.Location = new System.Drawing.Point(7, 58);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(699, 166);
            this.dgView.TabIndex = 64;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(191, 129);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(187, 35);
            this.txtReason.TabIndex = 254;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 262;
            this.label20.Text = "Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 255;
            this.label3.Text = "Credit Memo Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(634, 100);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(139, 20);
            this.dtpDate.TabIndex = 260;
            // 
            // txtCreditMemoNo
            // 
            this.txtCreditMemoNo.Location = new System.Drawing.Point(191, 84);
            this.txtCreditMemoNo.Name = "txtCreditMemoNo";
            this.txtCreditMemoNo.Size = new System.Drawing.Size(187, 20);
            this.txtCreditMemoNo.TabIndex = 257;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 256;
            this.label6.Text = "Credit Memo No.:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(636, 100);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(137, 20);
            this.txtDate.TabIndex = 259;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(633, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 258;
            this.label21.Text = "Dated:";
            // 
            // txtNet
            // 
            this.txtNet.BackColor = System.Drawing.SystemColors.Info;
            this.txtNet.Location = new System.Drawing.Point(677, 518);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(121, 20);
            this.txtNet.TabIndex = 253;
            this.txtNet.Text = "0.00";
            // 
            // picPurchase
            // 
            this.picPurchase.Controls.Add(this.cmdAdd);
            this.picPurchase.Controls.Add(this.label7);
            this.picPurchase.Controls.Add(this.txtStock);
            this.picPurchase.Controls.Add(this.txtNetAmount);
            this.picPurchase.Controls.Add(this.label8);
            this.picPurchase.Controls.Add(this.txtQty);
            this.picPurchase.Controls.Add(this.label13);
            this.picPurchase.Controls.Add(this.label9);
            this.picPurchase.Controls.Add(this.txtUnitPrice);
            this.picPurchase.Controls.Add(this.txtDisc);
            this.picPurchase.Controls.Add(this.label10);
            this.picPurchase.Controls.Add(this.txtGross);
            this.picPurchase.Controls.Add(this.label11);
            this.picPurchase.Location = new System.Drawing.Point(0, 0);
            this.picPurchase.Name = "picPurchase";
            this.picPurchase.Size = new System.Drawing.Size(711, 52);
            this.picPurchase.TabIndex = 65;
            this.picPurchase.TabStop = false;
            // 
            // txtGross
            // 
            this.txtGross.BackColor = System.Drawing.SystemColors.Info;
            this.txtGross.Location = new System.Drawing.Point(402, 26);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(84, 20);
            this.txtGross.TabIndex = 24;
            this.txtGross.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Disc. %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 238;
            this.label5.Text = " Delivery No.:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(125, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 264;
            this.label22.Text = "Referrence:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picPurchase);
            this.groupBox1.Controls.Add(this.dgView);
            this.groupBox1.Location = new System.Drawing.Point(96, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 233);
            this.groupBox1.TabIndex = 233;
            this.groupBox1.TabStop = false;
            // 
            // frmSalesOrderReturnAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 597);
            this.Controls.Add(this.txtStockNo);
            this.Controls.Add(this.cmdModificationHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoldTo);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.txtSONo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGrosse);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtTaxBase);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtAcknowledgedBy);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtApprovedBy);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtPostedBy);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dtpCreditMemoDate);
            this.Controls.Add(this.txtCreditMemoDate);
            this.Controls.Add(this.txtPreparedBy);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCreditMemoNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSalesOrderReturnAE";
            this.Text = "frmSalesOrderReturnAE";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.picPurchase.ResumeLayout(false);
            this.picPurchase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_No;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Button cmdModificationHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoldTo;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox txtSONo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGrosse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtTaxBase;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtAcknowledgedBy;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPostedBy;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpCreditMemoDate;
        private System.Windows.Forms.TextBox txtCreditMemoDate;
        private System.Windows.Forms.TextBox txtPreparedBy;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtCreditMemoNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.GroupBox picPurchase;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}