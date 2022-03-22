namespace Accounting_Sys
{
    partial class frmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrency));
            this.dttmpic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtCurrCode = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.TxForgnName = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAbbr = new System.Windows.Forms.Label();
            this.txtAbbr = new System.Windows.Forms.TextBox();
            this.lblCurrCode = new System.Windows.Forms.Label();
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
            this.dgvcurr = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkLocked = new System.Windows.Forms.CheckBox();
            this.ChToolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcurr)).BeginInit();
            this.SuspendLayout();
            // 
            // dttmpic
            // 
            this.dttmpic.Location = new System.Drawing.Point(850, 38);
            this.dttmpic.Name = "dttmpic";
            this.dttmpic.Size = new System.Drawing.Size(140, 20);
            this.dttmpic.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(792, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Date";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Location = new System.Drawing.Point(792, 62);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 97;
            this.lblRate.Text = "Rate";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Location = new System.Drawing.Point(792, 98);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 96;
            this.lblCountry.Text = "Country";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbol.Location = new System.Drawing.Point(792, 79);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 95;
            this.lblSymbol.Text = "Symbol";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(849, 76);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(141, 20);
            this.txtSymbol.TabIndex = 6;
            // 
            // txtCurrCode
            // 
            this.txtCurrCode.Location = new System.Drawing.Point(86, 40);
            this.txtCurrCode.Name = "txtCurrCode";
            this.txtCurrCode.Size = new System.Drawing.Size(131, 20);
            this.txtCurrCode.TabIndex = 0;
            this.txtCurrCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrCode_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(849, 57);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(140, 20);
            this.txtRate.TabIndex = 4;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // TxForgnName
            // 
            this.TxForgnName.Location = new System.Drawing.Point(849, 95);
            this.TxForgnName.Name = "TxForgnName";
            this.TxForgnName.Size = new System.Drawing.Size(140, 20);
            this.TxForgnName.TabIndex = 5;
            this.TxForgnName.Tag = "A";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(86, 60);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(131, 20);
            this.txtCurrency.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrency.Location = new System.Drawing.Point(12, 63);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 89;
            this.lblCurrency.Text = "Currency";
            // 
            // lblAbbr
            // 
            this.lblAbbr.AutoSize = true;
            this.lblAbbr.BackColor = System.Drawing.Color.Transparent;
            this.lblAbbr.Location = new System.Drawing.Point(12, 79);
            this.lblAbbr.Name = "lblAbbr";
            this.lblAbbr.Size = new System.Drawing.Size(29, 13);
            this.lblAbbr.TabIndex = 88;
            this.lblAbbr.Text = "Abbr";
            // 
            // txtAbbr
            // 
            this.txtAbbr.Location = new System.Drawing.Point(86, 78);
            this.txtAbbr.Name = "txtAbbr";
            this.txtAbbr.Size = new System.Drawing.Size(131, 20);
            this.txtAbbr.TabIndex = 2;
            this.txtAbbr.Tag = "A";
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrCode.Location = new System.Drawing.Point(12, 44);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(54, 13);
            this.lblCurrCode.TabIndex = 86;
            this.lblCurrCode.Text = "Curr Code";
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
            this.ChToolStrip1.TabIndex = 369;
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
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 18);
            this.panel1.TabIndex = 396;
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
            this.panel2.Location = new System.Drawing.Point(2, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 18);
            this.panel2.TabIndex = 397;
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
            // dgvcurr
            // 
            this.dgvcurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcurr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvcurr.Location = new System.Drawing.Point(86, 130);
            this.dgvcurr.Name = "dgvcurr";
            this.dgvcurr.ReadOnly = true;
            this.dgvcurr.Size = new System.Drawing.Size(833, 295);
            this.dgvcurr.TabIndex = 398;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ID";
            this.Column10.HeaderText = "ID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "curcode";
            this.Column1.HeaderText = "Currency Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CurName";
            this.Column2.HeaderText = "Cur Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Rate";
            this.Column3.HeaderText = "Rate";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChkName";
            this.Column4.HeaderText = "Chk Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DocCode";
            this.Column5.HeaderText = "Abbr";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ForgnName";
            this.Column6.HeaderText = "Foreign Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "F100Name";
            this.Column7.HeaderText = "F100 Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Locked";
            this.Column8.HeaderText = "Locked";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DateSure";
            this.Column9.HeaderText = "Date Sure";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 160;
            // 
            // ChkLocked
            // 
            this.ChkLocked.AutoSize = true;
            this.ChkLocked.Location = new System.Drawing.Point(86, 98);
            this.ChkLocked.Name = "ChkLocked";
            this.ChkLocked.Size = new System.Drawing.Size(62, 17);
            this.ChkLocked.TabIndex = 399;
            this.ChkLocked.Text = "Locked";
            this.ChkLocked.UseVisualStyleBackColor = true;
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1005, 434);
            this.Controls.Add(this.ChkLocked);
            this.Controls.Add(this.dgvcurr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.dttmpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txtCurrCode);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.TxForgnName);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblAbbr);
            this.Controls.Add(this.txtAbbr);
            this.Controls.Add(this.lblCurrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCurrency";
            this.Text = "Currency Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcurr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dttmpic;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblRate;
        internal System.Windows.Forms.Label lblCountry;
        internal System.Windows.Forms.Label lblSymbol;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.TextBox txtCurrCode;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox TxForgnName;
        internal System.Windows.Forms.TextBox txtCurrency;
        internal System.Windows.Forms.Label lblCurrency;
        internal System.Windows.Forms.Label lblAbbr;
        internal System.Windows.Forms.TextBox txtAbbr;
        internal System.Windows.Forms.Label lblCurrCode;
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
        private System.Windows.Forms.DataGridView dgvcurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.CheckBox ChkLocked;
    }
}