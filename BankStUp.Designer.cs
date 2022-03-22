namespace Accounting_Sys
{
    partial class BankStUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankStUp));
            this.cmbcurny = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxCountryCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.TxCurrn = new System.Windows.Forms.Label();
            this.TxSwiftCode = new System.Windows.Forms.TextBox();
            this.TxBnkName = new System.Windows.Forms.TextBox();
            this.TxNxtChq = new System.Windows.Forms.TextBox();
            this.TxBrnCode = new System.Windows.Forms.TextBox();
            this.lblAbbr = new System.Windows.Forms.Label();
            this.TxAccNo = new System.Windows.Forms.TextBox();
            this.lblCurrCode = new System.Windows.Forms.Label();
            this.bnkdgv = new System.Windows.Forms.DataGridView();
            this.Bnk1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brnch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSwift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bnkdgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbcurny
            // 
            this.cmbcurny.FormattingEnabled = true;
            this.cmbcurny.Location = new System.Drawing.Point(866, 73);
            this.cmbcurny.Name = "cmbcurny";
            this.cmbcurny.Size = new System.Drawing.Size(131, 21);
            this.cmbcurny.TabIndex = 6;
            this.cmbcurny.SelectedIndexChanged += new System.EventHandler(this.cmbcurny_SelectedIndexChanged);
            this.cmbcurny.Enter += new System.EventHandler(this.cmbcurny_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(746, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Working Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 95;
            this.label3.Text = " Branch Code";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(866, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 7;
            // 
            // TxCountryCode
            // 
            this.TxCountryCode.Location = new System.Drawing.Point(866, 36);
            this.TxCountryCode.Name = "TxCountryCode";
            this.TxCountryCode.Size = new System.Drawing.Size(131, 20);
            this.TxCountryCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(746, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Next Cheque No ";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRate.Location = new System.Drawing.Point(746, 97);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(66, 15);
            this.lblRate.TabIndex = 91;
            this.lblRate.Text = "Post Office";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCountry.Location = new System.Drawing.Point(13, 97);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(62, 15);
            this.lblCountry.TabIndex = 90;
            this.lblCountry.Text = "Swit Code";
            // 
            // TxCurrn
            // 
            this.TxCurrn.AutoSize = true;
            this.TxCurrn.BackColor = System.Drawing.Color.Transparent;
            this.TxCurrn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCurrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxCurrn.Location = new System.Drawing.Point(11, 77);
            this.TxCurrn.Name = "TxCurrn";
            this.TxCurrn.Size = new System.Drawing.Size(70, 15);
            this.TxCurrn.TabIndex = 89;
            this.TxCurrn.Text = "Account No";
            // 
            // TxSwiftCode
            // 
            this.TxSwiftCode.Location = new System.Drawing.Point(107, 93);
            this.TxSwiftCode.Name = "TxSwiftCode";
            this.TxSwiftCode.Size = new System.Drawing.Size(131, 20);
            this.TxSwiftCode.TabIndex = 3;
            // 
            // TxBnkName
            // 
            this.TxBnkName.Location = new System.Drawing.Point(107, 37);
            this.TxBnkName.Name = "TxBnkName";
            this.TxBnkName.Size = new System.Drawing.Size(131, 20);
            this.TxBnkName.TabIndex = 0;
            // 
            // TxNxtChq
            // 
            this.TxNxtChq.Location = new System.Drawing.Point(866, 54);
            this.TxNxtChq.Name = "TxNxtChq";
            this.TxNxtChq.Size = new System.Drawing.Size(131, 20);
            this.TxNxtChq.TabIndex = 5;
            // 
            // TxBrnCode
            // 
            this.TxBrnCode.Location = new System.Drawing.Point(107, 55);
            this.TxBrnCode.Name = "TxBrnCode";
            this.TxBrnCode.Size = new System.Drawing.Size(131, 20);
            this.TxBrnCode.TabIndex = 1;
            // 
            // lblAbbr
            // 
            this.lblAbbr.AutoSize = true;
            this.lblAbbr.BackColor = System.Drawing.Color.Transparent;
            this.lblAbbr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbbr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAbbr.Location = new System.Drawing.Point(14, 41);
            this.lblAbbr.Name = "lblAbbr";
            this.lblAbbr.Size = new System.Drawing.Size(69, 15);
            this.lblAbbr.TabIndex = 84;
            this.lblAbbr.Text = "Bank Name";
            // 
            // TxAccNo
            // 
            this.TxAccNo.Location = new System.Drawing.Point(107, 74);
            this.TxAccNo.Name = "TxAccNo";
            this.TxAccNo.Size = new System.Drawing.Size(131, 20);
            this.TxAccNo.TabIndex = 2;
            this.TxAccNo.Tag = "A";
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrCode.Location = new System.Drawing.Point(746, 39);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(82, 15);
            this.lblCurrCode.TabIndex = 82;
            this.lblCurrCode.Text = "Country Code";
            // 
            // bnkdgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bnkdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bnkdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnkdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bnk1,
            this.Brnch,
            this.Acct,
            this.ColSwift,
            this.ColCountry,
            this.ColNxt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bnkdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.bnkdgv.Location = new System.Drawing.Point(89, 131);
            this.bnkdgv.Name = "bnkdgv";
            this.bnkdgv.Size = new System.Drawing.Size(833, 295);
            this.bnkdgv.TabIndex = 98;
            // 
            // Bnk1
            // 
            this.Bnk1.DataPropertyName = "BankName";
            this.Bnk1.HeaderText = "Babk Name";
            this.Bnk1.Name = "Bnk1";
            this.Bnk1.Width = 200;
            // 
            // Brnch
            // 
            this.Brnch.DataPropertyName = "Branch";
            this.Brnch.HeaderText = "Branch Code";
            this.Brnch.Name = "Brnch";
            this.Brnch.Width = 200;
            // 
            // Acct
            // 
            this.Acct.DataPropertyName = "Account";
            this.Acct.HeaderText = "Account No";
            this.Acct.Name = "Acct";
            this.Acct.Width = 200;
            // 
            // ColSwift
            // 
            this.ColSwift.DataPropertyName = "SwiftCode";
            this.ColSwift.HeaderText = "Swift Code";
            this.ColSwift.Name = "ColSwift";
            this.ColSwift.Width = 200;
            // 
            // ColCountry
            // 
            this.ColCountry.DataPropertyName = "Country";
            this.ColCountry.HeaderText = "Country";
            this.ColCountry.Name = "ColCountry";
            this.ColCountry.Width = 110;
            // 
            // ColNxt
            // 
            this.ColNxt.DataPropertyName = "NextChequeNo";
            this.ColNxt.HeaderText = "Next Cheque";
            this.ColNxt.Name = "ColNxt";
            this.ColNxt.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 19);
            this.panel2.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Label8";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 19);
            this.panel1.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Label8";
            this.label5.Visible = false;
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
            this.ChToolStrip1.TabIndex = 368;
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
            // BankStUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1005, 434);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bnkdgv);
            this.Controls.Add(this.cmbcurny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxCountryCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.TxCurrn);
            this.Controls.Add(this.TxSwiftCode);
            this.Controls.Add(this.TxBnkName);
            this.Controls.Add(this.TxNxtChq);
            this.Controls.Add(this.TxBrnCode);
            this.Controls.Add(this.lblAbbr);
            this.Controls.Add(this.TxAccNo);
            this.Controls.Add(this.lblCurrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BankStUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Bank Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BankStUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnkdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcurny;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox TxCountryCode;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblRate;
        internal System.Windows.Forms.Label lblCountry;
        internal System.Windows.Forms.Label TxCurrn;
        internal System.Windows.Forms.TextBox TxSwiftCode;
        internal System.Windows.Forms.TextBox TxBnkName;
        internal System.Windows.Forms.TextBox TxNxtChq;
        internal System.Windows.Forms.TextBox TxBrnCode;
        internal System.Windows.Forms.Label lblAbbr;
        internal System.Windows.Forms.TextBox TxAccNo;
        internal System.Windows.Forms.Label lblCurrCode;
        private System.Windows.Forms.DataGridView bnkdgv;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bnk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brnch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSwift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNxt;
    }
}