namespace Accounting_Sys
{
    partial class ServCard
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cmbAccHeader = new System.Windows.Forms.ComboBox();
            this.tblHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.txtClear = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.tblSubHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTN = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtNTN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAccCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCntName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderBindingSource)).BeginInit();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(793, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(712, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Website:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mobile:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWebsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Website", true));
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(540, 77);
            this.txtWebsite.MaxLength = 15;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(180, 22);
            this.txtWebsite.TabIndex = 3;
            // 
            // tblAccountsBindingSource
            // 
            this.tblAccountsBindingSource.DataMember = "tblAccounts";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 52);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fax:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Fax", true));
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(540, 50);
            this.txtFax.MaxLength = 15;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(180, 22);
            this.txtFax.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(241, 104);
            this.txtEmail.MaxLength = 15;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Mobile", true));
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(241, 77);
            this.txtMobile.MaxLength = 15;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(180, 22);
            this.txtMobile.TabIndex = 2;
            // 
            // cmbAccHeader
            // 
            this.cmbAccHeader.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbAccHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Header", true));
            this.cmbAccHeader.DataSource = this.tblHeaderBindingSource;
            this.cmbAccHeader.DisplayMember = "Header";
            this.cmbAccHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccHeader.FormattingEnabled = true;
            this.cmbAccHeader.Location = new System.Drawing.Point(240, 23);
            this.cmbAccHeader.Name = "cmbAccHeader";
            this.cmbAccHeader.Size = new System.Drawing.Size(180, 24);
            this.cmbAccHeader.TabIndex = 0;
            this.cmbAccHeader.ValueMember = "ID";
            // 
            // tblHeaderBindingSource
            // 
            this.tblHeaderBindingSource.DataMember = "tblHeader";
            // 
            // grbFilter
            // 
            this.grbFilter.BackColor = System.Drawing.Color.Transparent;
            this.grbFilter.Controls.Add(this.txtClear);
            this.grbFilter.Controls.Add(this.cmbFilter);
            this.grbFilter.Controls.Add(this.txtFilter);
            this.grbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFilter.Location = new System.Drawing.Point(13, 11);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(891, 53);
            this.grbFilter.TabIndex = 8;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "FILTER";
            // 
            // txtClear
            // 
            this.txtClear.BackColor = System.Drawing.Color.White;
            this.txtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClear.Location = new System.Drawing.Point(355, 18);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(108, 29);
            this.txtClear.TabIndex = 2;
            this.txtClear.Text = "&Clear Fields";
            this.txtClear.UseVisualStyleBackColor = false;
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "By Account Name",
            "By Account Code",
            "By City",
            "By Phone",
            "By Mobile"});
            this.cmbFilter.Location = new System.Drawing.Point(32, 21);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(153, 24);
            this.cmbFilter.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(191, 21);
            this.txtFilter.MaxLength = 35;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(158, 22);
            this.txtFilter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(812, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(495, 579);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(396, 579);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(296, 579);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 34);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Status", true));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbStatus.Location = new System.Drawing.Point(240, 53);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 24);
            this.cmbStatus.TabIndex = 2;
            // 
            // cmbAccType
            // 
            this.cmbAccType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbAccType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "HeaderType", true));
            this.cmbAccType.DataSource = this.tblSubHeaderBindingSource;
            this.cmbAccType.DisplayMember = "HeaderType";
            this.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Location = new System.Drawing.Point(539, 23);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(180, 24);
            this.cmbAccType.TabIndex = 1;
            this.cmbAccType.ValueMember = "ID";
            // 
            // tblSubHeaderBindingSource
            // 
            this.tblSubHeaderBindingSource.DataMember = "tblSubHeader";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.DataSource = this.tblAccountsBindingSource;
            this.dgvMain.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMain.Location = new System.Drawing.Point(104, -21);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(789, 44);
            this.dgvMain.TabIndex = 11;
            this.dgvMain.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contact Person:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvMain);
            this.groupBox1.Controls.Add(this.txtSTN);
            this.groupBox1.Controls.Add(this.txtAccName);
            this.groupBox1.Controls.Add(this.txtNTN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAccCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(14, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "STN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "NTN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone:";
            // 
            // txtSTN
            // 
            this.txtSTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "STN", true));
            this.txtSTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTN.Location = new System.Drawing.Point(694, 99);
            this.txtSTN.MaxLength = 15;
            this.txtSTN.Name = "txtSTN";
            this.txtSTN.Size = new System.Drawing.Size(88, 22);
            this.txtSTN.TabIndex = 6;
            // 
            // txtAccName
            // 
            this.txtAccName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "AccountName", true));
            this.txtAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccName.Location = new System.Drawing.Point(539, 41);
            this.txtAccName.MaxLength = 35;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(243, 22);
            this.txtAccName.TabIndex = 1;
            // 
            // txtNTN
            // 
            this.txtNTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "NTN", true));
            this.txtNTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTN.Location = new System.Drawing.Point(539, 100);
            this.txtNTN.MaxLength = 15;
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.Size = new System.Drawing.Size(88, 22);
            this.txtNTN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Address", true));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(240, 131);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 55);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPhone2
            // 
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Phone2", true));
            this.txtPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(539, 70);
            this.txtPhone2.MaxLength = 15;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(105, 22);
            this.txtPhone2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phone 2:";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "City", true));
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(240, 100);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(105, 22);
            this.txtCity.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Phone1", true));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(240, 72);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(105, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAccCode
            // 
            this.txtAccCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAccCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccCode.Location = new System.Drawing.Point(240, 41);
            this.txtAccCode.MaxLength = 5;
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Size = new System.Drawing.Size(105, 22);
            this.txtAccCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Code:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtWebsite);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCntName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(13, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // txtCntName
            // 
            this.txtCntName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCntName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "ContactPerson", true));
            this.txtCntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCntName.Location = new System.Drawing.Point(241, 50);
            this.txtCntName.MaxLength = 35;
            this.txtCntName.Name = "txtCntName";
            this.txtCntName.Size = new System.Drawing.Size(180, 22);
            this.txtCntName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbAccType);
            this.groupBox3.Controls.Add(this.cmbStatus);
            this.groupBox3.Controls.Add(this.cmbAccHeader);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(14, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 95);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status Information";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(163, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Acc Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Acc Header:";
            // 
            // ServCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 625);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ServCard";
            this.Text = "ServCard";
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderBindingSource)).EndInit();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cmbAccHeader;
        private System.Windows.Forms.BindingSource tblHeaderBindingSource;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.BindingSource tblSubHeaderBindingSource;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSTN;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtNTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAccCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCntName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}