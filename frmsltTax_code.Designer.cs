namespace Accounting_Sys
{
    partial class frmsltTax_code
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
            System.Windows.Forms.Label Label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsltTax_code));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUserType = new System.Windows.Forms.Label();
            this.txttxrt = new System.Windows.Forms.TextBox();
            this.cmbTaxType = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.taxcode = new System.Windows.Forms.TextBox();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tax = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltxtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVldfAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVldFAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmLevlTx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltaxoNtax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEffectiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkItmLevl = new System.Windows.Forms.CheckBox();
            this.ChkLock = new System.Windows.Forms.CheckBox();
            this.ChkvldfAR = new System.Windows.Forms.CheckBox();
            this.ChkvldfAP = new System.Windows.Forms.CheckBox();
            Label5 = new System.Windows.Forms.Label();
            this.ChToolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tax)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.Black;
            Label5.Location = new System.Drawing.Point(248, 42);
            Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(65, 17);
            Label5.TabIndex = 394;
            Label5.Text = "Tax Code :";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(802, 49);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 13);
            this.lblUserType.TabIndex = 396;
            this.lblUserType.Text = "User Type";
            this.lblUserType.Visible = false;
            // 
            // txttxrt
            // 
            this.txttxrt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttxrt.Location = new System.Drawing.Point(341, 56);
            this.txttxrt.Name = "txttxrt";
            this.txttxrt.Size = new System.Drawing.Size(147, 24);
            this.txttxrt.TabIndex = 1;
            this.txttxrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttxrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttxrt_KeyPress);
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTaxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTaxType.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaxType.FormattingEnabled = true;
            this.cmbTaxType.Items.AddRange(new object[] {
            "Sales Tax",
            "Further Tax",
            "Withholding Tax (ITax )",
            "Withholding Tax (STax )"});
            this.cmbTaxType.Location = new System.Drawing.Point(341, 76);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Size = new System.Drawing.Size(147, 25);
            this.cmbTaxType.TabIndex = 2;
            this.cmbTaxType.Text = "Select Tax Type";
            this.cmbTaxType.Enter += new System.EventHandler(this.cmbTaxType_Enter);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(250, 60);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(36, 17);
            this.Label12.TabIndex = 398;
            this.Label12.Text = "Rate ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(250, 82);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 17);
            this.Label6.TabIndex = 397;
            this.Label6.Text = "Tax Type :";
            // 
            // taxcode
            // 
            this.taxcode.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxcode.Location = new System.Drawing.Point(341, 38);
            this.taxcode.Name = "taxcode";
            this.taxcode.ReadOnly = true;
            this.taxcode.Size = new System.Drawing.Size(147, 24);
            this.taxcode.TabIndex = 0;
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
            this.ChToolStrip1.TabIndex = 403;
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
            this.ChToolStrpAdd.Click += new System.EventHandler(this.ChToolStrpAdd_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 18);
            this.panel1.TabIndex = 405;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(751, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Label8";
            this.label11.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 18);
            this.panel2.TabIndex = 406;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Label8";
            this.label2.Visible = false;
            // 
            // dgv_tax
            // 
            this.dgv_tax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.coltxtype,
            this.ColTc,
            this.ColVldfAP,
            this.ColVldFAR,
            this.ColItmLevlTx,
            this.ColLock,
            this.coltaxoNtax,
            this.colEffectiv});
            this.dgv_tax.Location = new System.Drawing.Point(90, 116);
            this.dgv_tax.Name = "dgv_tax";
            this.dgv_tax.Size = new System.Drawing.Size(833, 295);
            this.dgv_tax.TabIndex = 407;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // coltxtype
            // 
            this.coltxtype.DataPropertyName = "Name";
            this.coltxtype.HeaderText = "Type";
            this.coltxtype.Name = "coltxtype";
            // 
            // ColTc
            // 
            this.ColTc.DataPropertyName = "Rate";
            this.ColTc.HeaderText = "Rate";
            this.ColTc.Name = "ColTc";
            // 
            // ColVldfAP
            // 
            this.ColVldfAP.DataPropertyName = "ValidforAP";
            this.ColVldfAP.HeaderText = "Valid For AP";
            this.ColVldfAP.Name = "ColVldfAP";
            // 
            // ColVldFAR
            // 
            this.ColVldFAR.DataPropertyName = "ValidforAR";
            this.ColVldFAR.HeaderText = "Valid For AR";
            this.ColVldFAR.Name = "ColVldFAR";
            // 
            // ColItmLevlTx
            // 
            this.ColItmLevlTx.DataPropertyName = "IsItmLevel";
            this.ColItmLevlTx.HeaderText = "Item Level Tax";
            this.ColItmLevlTx.Name = "ColItmLevlTx";
            // 
            // ColLock
            // 
            this.ColLock.DataPropertyName = "Lock";
            this.ColLock.HeaderText = "Lock";
            this.ColLock.Name = "ColLock";
            // 
            // coltaxoNtax
            // 
            this.coltaxoNtax.HeaderText = "Tax On Tax";
            this.coltaxoNtax.Name = "coltaxoNtax";
            // 
            // colEffectiv
            // 
            this.colEffectiv.HeaderText = "Effective From";
            this.colEffectiv.Name = "colEffectiv";
            // 
            // ChkItmLevl
            // 
            this.ChkItmLevl.AutoSize = true;
            this.ChkItmLevl.Location = new System.Drawing.Point(525, 46);
            this.ChkItmLevl.Name = "ChkItmLevl";
            this.ChkItmLevl.Size = new System.Drawing.Size(96, 17);
            this.ChkItmLevl.TabIndex = 3;
            this.ChkItmLevl.Text = "Item Level Tax";
            this.ChkItmLevl.UseVisualStyleBackColor = true;
            // 
            // ChkLock
            // 
            this.ChkLock.AutoSize = true;
            this.ChkLock.Location = new System.Drawing.Point(693, 46);
            this.ChkLock.Name = "ChkLock";
            this.ChkLock.Size = new System.Drawing.Size(50, 17);
            this.ChkLock.TabIndex = 6;
            this.ChkLock.Text = "Lock";
            this.ChkLock.UseVisualStyleBackColor = true;
            // 
            // ChkvldfAR
            // 
            this.ChkvldfAR.AutoSize = true;
            this.ChkvldfAR.Location = new System.Drawing.Point(526, 77);
            this.ChkvldfAR.Name = "ChkvldfAR";
            this.ChkvldfAR.Size = new System.Drawing.Size(90, 17);
            this.ChkvldfAR.TabIndex = 5;
            this.ChkvldfAR.Text = "Valid For A/R";
            this.ChkvldfAR.UseVisualStyleBackColor = true;
            // 
            // ChkvldfAP
            // 
            this.ChkvldfAP.AutoSize = true;
            this.ChkvldfAP.Location = new System.Drawing.Point(526, 61);
            this.ChkvldfAP.Name = "ChkvldfAP";
            this.ChkvldfAP.Size = new System.Drawing.Size(89, 17);
            this.ChkvldfAP.TabIndex = 4;
            this.ChkvldfAP.Text = "Valid For A/P";
            this.ChkvldfAP.UseVisualStyleBackColor = true;
            // 
            // frmsltTax_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1005, 434);
            this.Controls.Add(this.ChkvldfAP);
            this.Controls.Add(this.ChkvldfAR);
            this.Controls.Add(this.ChkLock);
            this.Controls.Add(this.ChkItmLevl);
            this.Controls.Add(this.dgv_tax);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txttxrt);
            this.Controls.Add(this.cmbTaxType);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.taxcode);
            this.Controls.Add(Label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmsltTax_code";
            this.Text = "Tax_code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tax_code_Load);
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Label lblUserType;
        internal System.Windows.Forms.TextBox txttxrt;
        internal System.Windows.Forms.ComboBox cmbTaxType;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox taxcode;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tax;
        private System.Windows.Forms.CheckBox ChkItmLevl;
        private System.Windows.Forms.CheckBox ChkvldfAR;
        private System.Windows.Forms.CheckBox ChkvldfAP;
        private System.Windows.Forms.CheckBox ChkLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltxtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVldfAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVldFAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmLevlTx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltaxoNtax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffectiv;
    }
}