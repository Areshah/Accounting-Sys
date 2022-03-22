namespace Accounting_Sys
{
    partial class frmInvCountng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvCountng));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAdItem = new System.Windows.Forms.Button();
            this.BtnAdjstQty = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCpyToPost = new System.Windows.Forms.Button();
            this.CmbContr2 = new System.Windows.Forms.ComboBox();
            this.CmbContr = new System.Windows.Forms.ComboBox();
            this.CmbNoCountr = new System.Windows.Forms.ComboBox();
            this.TxSNo = new System.Windows.Forms.TextBox();
            this.TxStatus = new System.Windows.Forms.TextBox();
            this.TxRef2 = new System.Windows.Forms.TextBox();
            this.TxCountrName2 = new System.Windows.Forms.TextBox();
            this.TxCountrName = new System.Windows.Forms.TextBox();
            this.dtpConutDtTm = new System.Windows.Forms.DateTimePicker();
            this.RichRemks = new System.Windows.Forms.RichTextBox();
            this.DGvInvCountr = new System.Windows.Forms.DataGridView();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.colItmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colfreez = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColWhse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBinLOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWhseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCountr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcountr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGvInvCountr)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Counter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remarks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ref. 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "No of Counter";
            // 
            // BtnAdItem
            // 
            this.BtnAdItem.Location = new System.Drawing.Point(528, 401);
            this.BtnAdItem.Name = "BtnAdItem";
            this.BtnAdItem.Size = new System.Drawing.Size(75, 23);
            this.BtnAdItem.TabIndex = 8;
            this.BtnAdItem.Text = "Add Items";
            this.BtnAdItem.UseVisualStyleBackColor = true;
            // 
            // BtnAdjstQty
            // 
            this.BtnAdjstQty.Location = new System.Drawing.Point(638, 401);
            this.BtnAdjstQty.Name = "BtnAdjstQty";
            this.BtnAdjstQty.Size = new System.Drawing.Size(156, 23);
            this.BtnAdjstQty.TabIndex = 9;
            this.BtnAdjstQty.Text = "Adjust Counted  Quantity";
            this.BtnAdjstQty.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(152, 401);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Clear";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCpyToPost
            // 
            this.BtnCpyToPost.Location = new System.Drawing.Point(845, 401);
            this.BtnCpyToPost.Name = "BtnCpyToPost";
            this.BtnCpyToPost.Size = new System.Drawing.Size(144, 23);
            this.BtnCpyToPost.TabIndex = 12;
            this.BtnCpyToPost.Text = "Copy to Inventory Posting";
            this.BtnCpyToPost.UseVisualStyleBackColor = true;
            // 
            // CmbContr2
            // 
            this.CmbContr2.FormattingEnabled = true;
            this.CmbContr2.Location = new System.Drawing.Point(125, 97);
            this.CmbContr2.Name = "CmbContr2";
            this.CmbContr2.Size = new System.Drawing.Size(53, 21);
            this.CmbContr2.TabIndex = 13;
            // 
            // CmbContr
            // 
            this.CmbContr.FormattingEnabled = true;
            this.CmbContr.Location = new System.Drawing.Point(125, 77);
            this.CmbContr.Name = "CmbContr";
            this.CmbContr.Size = new System.Drawing.Size(53, 21);
            this.CmbContr.TabIndex = 14;
            // 
            // CmbNoCountr
            // 
            this.CmbNoCountr.FormattingEnabled = true;
            this.CmbNoCountr.Location = new System.Drawing.Point(125, 57);
            this.CmbNoCountr.Name = "CmbNoCountr";
            this.CmbNoCountr.Size = new System.Drawing.Size(170, 21);
            this.CmbNoCountr.TabIndex = 15;
            // 
            // TxSNo
            // 
            this.TxSNo.Location = new System.Drawing.Point(845, 30);
            this.TxSNo.Name = "TxSNo";
            this.TxSNo.Size = new System.Drawing.Size(144, 20);
            this.TxSNo.TabIndex = 17;
            // 
            // TxStatus
            // 
            this.TxStatus.Location = new System.Drawing.Point(845, 49);
            this.TxStatus.Name = "TxStatus";
            this.TxStatus.ReadOnly = true;
            this.TxStatus.Size = new System.Drawing.Size(144, 20);
            this.TxStatus.TabIndex = 18;
            this.TxStatus.Text = "Open";
            // 
            // TxRef2
            // 
            this.TxRef2.Location = new System.Drawing.Point(845, 68);
            this.TxRef2.Name = "TxRef2";
            this.TxRef2.Size = new System.Drawing.Size(144, 20);
            this.TxRef2.TabIndex = 19;
            // 
            // TxCountrName2
            // 
            this.TxCountrName2.Location = new System.Drawing.Point(178, 96);
            this.TxCountrName2.Name = "TxCountrName2";
            this.TxCountrName2.Size = new System.Drawing.Size(117, 20);
            this.TxCountrName2.TabIndex = 22;
            // 
            // TxCountrName
            // 
            this.TxCountrName.Location = new System.Drawing.Point(178, 77);
            this.TxCountrName.Name = "TxCountrName";
            this.TxCountrName.Size = new System.Drawing.Size(117, 20);
            this.TxCountrName.TabIndex = 23;
            // 
            // dtpConutDtTm
            // 
            this.dtpConutDtTm.Location = new System.Drawing.Point(125, 38);
            this.dtpConutDtTm.Name = "dtpConutDtTm";
            this.dtpConutDtTm.Size = new System.Drawing.Size(270, 20);
            this.dtpConutDtTm.TabIndex = 24;
            this.dtpConutDtTm.Value = new System.DateTime(2018, 9, 20, 2, 54, 26, 0);
            // 
            // RichRemks
            // 
            this.RichRemks.Location = new System.Drawing.Point(125, 346);
            this.RichRemks.Name = "RichRemks";
            this.RichRemks.Size = new System.Drawing.Size(191, 53);
            this.RichRemks.TabIndex = 25;
            this.RichRemks.Text = "";
            // 
            // DGvInvCountr
            // 
            this.DGvInvCountr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvInvCountr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItmNo,
            this.ColItmDesc,
            this.Colfreez,
            this.ColWhse,
            this.ColBinLOc,
            this.ColWhseQty,
            this.ColCount,
            this.ColCountr1,
            this.Colcountr2});
            this.DGvInvCountr.Location = new System.Drawing.Point(38, 115);
            this.DGvInvCountr.Name = "DGvInvCountr";
            this.DGvInvCountr.Size = new System.Drawing.Size(951, 230);
            this.DGvInvCountr.TabIndex = 26;
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
            this.ChToolStrip1.Size = new System.Drawing.Size(1024, 43);
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
            // colItmNo
            // 
            this.colItmNo.HeaderText = "Item No";
            this.colItmNo.Name = "colItmNo";
            this.colItmNo.Width = 70;
            // 
            // ColItmDesc
            // 
            this.ColItmDesc.HeaderText = "Item Description";
            this.ColItmDesc.Name = "ColItmDesc";
            this.ColItmDesc.Width = 200;
            // 
            // Colfreez
            // 
            this.Colfreez.HeaderText = "Freeze";
            this.Colfreez.Name = "Colfreez";
            this.Colfreez.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colfreez.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Colfreez.Width = 70;
            // 
            // ColWhse
            // 
            this.ColWhse.HeaderText = "Warehouse";
            this.ColWhse.Name = "ColWhse";
            this.ColWhse.Width = 200;
            // 
            // ColBinLOc
            // 
            this.ColBinLOc.HeaderText = "Bin Location";
            this.ColBinLOc.Name = "ColBinLOc";
            this.ColBinLOc.Width = 200;
            // 
            // ColWhseQty
            // 
            this.ColWhseQty.HeaderText = "In Whse QTY On Count Date";
            this.ColWhseQty.Name = "ColWhseQty";
            this.ColWhseQty.Width = 200;
            // 
            // ColCount
            // 
            this.ColCount.HeaderText = "Counted";
            this.ColCount.Name = "ColCount";
            this.ColCount.Width = 70;
            // 
            // ColCountr1
            // 
            this.ColCountr1.HeaderText = "Counter 1 Count";
            this.ColCountr1.Name = "ColCountr1";
            this.ColCountr1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCountr1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Colcountr2
            // 
            this.Colcountr2.HeaderText = "Counter 2 Count";
            this.Colcountr2.Name = "Colcountr2";
            this.Colcountr2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colcountr2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmInvCountng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.DGvInvCountr);
            this.Controls.Add(this.RichRemks);
            this.Controls.Add(this.dtpConutDtTm);
            this.Controls.Add(this.TxCountrName);
            this.Controls.Add(this.TxCountrName2);
            this.Controls.Add(this.TxRef2);
            this.Controls.Add(this.TxStatus);
            this.Controls.Add(this.TxSNo);
            this.Controls.Add(this.CmbNoCountr);
            this.Controls.Add(this.CmbContr);
            this.Controls.Add(this.CmbContr2);
            this.Controls.Add(this.BtnCpyToPost);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdjstQty);
            this.Controls.Add(this.BtnAdItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInvCountng";
            this.Text = "Inventory Countng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvCountng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGvInvCountr)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAdItem;
        private System.Windows.Forms.Button BtnAdjstQty;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCpyToPost;
        private System.Windows.Forms.ComboBox CmbContr2;
        private System.Windows.Forms.ComboBox CmbContr;
        private System.Windows.Forms.ComboBox CmbNoCountr;
        private System.Windows.Forms.TextBox TxSNo;
        private System.Windows.Forms.TextBox TxStatus;
        private System.Windows.Forms.TextBox TxRef2;
        private System.Windows.Forms.TextBox TxCountrName2;
        private System.Windows.Forms.TextBox TxCountrName;
        private System.Windows.Forms.DateTimePicker dtpConutDtTm;
        private System.Windows.Forms.RichTextBox RichRemks;
        private System.Windows.Forms.DataGridView DGvInvCountr;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmDesc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Colfreez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWhse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBinLOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWhseQty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcountr2;
    }
}