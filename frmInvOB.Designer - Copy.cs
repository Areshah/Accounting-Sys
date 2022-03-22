namespace Accounting_Sys
{
    partial class frmInvOB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvOB));
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.DGvInvOB = new System.Windows.Forms.DataGridView();
            this.RichRemks = new System.Windows.Forms.RichTextBox();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.dtpConutDtTm = new System.Windows.Forms.DateTimePicker();
            this.TxItemName = new System.Windows.Forms.TextBox();
            this.TxRef2 = new System.Windows.Forms.TextBox();
            this.TxSNo = new System.Windows.Forms.TextBox();
            this.BtnAdItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbWhse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colItmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWhse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBinLOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWhseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGvInvOB)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // DGvInvOB
            // 
            this.DGvInvOB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvInvOB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItmNo,
            this.ColItmDesc,
            this.ColWhse,
            this.ColBinLOc,
            this.ColWhseQty,
            this.ColOB,
            this.ColUPrice});
            this.DGvInvOB.Location = new System.Drawing.Point(38, 119);
            this.DGvInvOB.Name = "DGvInvOB";
            this.DGvInvOB.Size = new System.Drawing.Size(951, 230);
            this.DGvInvOB.TabIndex = 391;
            // 
            // RichRemks
            // 
            this.RichRemks.Location = new System.Drawing.Point(125, 350);
            this.RichRemks.Name = "RichRemks";
            this.RichRemks.Size = new System.Drawing.Size(191, 53);
            this.RichRemks.TabIndex = 390;
            this.RichRemks.Text = "";
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
            this.ChToolStrip1.TabIndex = 392;
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
            // dtpConutDtTm
            // 
            this.dtpConutDtTm.Location = new System.Drawing.Point(125, 52);
            this.dtpConutDtTm.Name = "dtpConutDtTm";
            this.dtpConutDtTm.Size = new System.Drawing.Size(170, 20);
            this.dtpConutDtTm.TabIndex = 389;
            this.dtpConutDtTm.Value = new System.DateTime(2018, 9, 20, 2, 54, 26, 0);
            // 
            // TxItemName
            // 
            this.TxItemName.Location = new System.Drawing.Point(269, 98);
            this.TxItemName.Name = "TxItemName";
            this.TxItemName.Size = new System.Drawing.Size(117, 20);
            this.TxItemName.TabIndex = 387;
            this.TxItemName.Text = "OITM Obin";
            // 
            // TxRef2
            // 
            this.TxRef2.Location = new System.Drawing.Point(845, 63);
            this.TxRef2.Name = "TxRef2";
            this.TxRef2.Size = new System.Drawing.Size(144, 20);
            this.TxRef2.TabIndex = 386;
            // 
            // TxSNo
            // 
            this.TxSNo.Location = new System.Drawing.Point(845, 44);
            this.TxSNo.Name = "TxSNo";
            this.TxSNo.Size = new System.Drawing.Size(144, 20);
            this.TxSNo.TabIndex = 384;
            // 
            // BtnAdItem
            // 
            this.BtnAdItem.Location = new System.Drawing.Point(914, 400);
            this.BtnAdItem.Name = "BtnAdItem";
            this.BtnAdItem.Size = new System.Drawing.Size(75, 23);
            this.BtnAdItem.TabIndex = 377;
            this.BtnAdItem.Text = "Add Items";
            this.BtnAdItem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 375;
            this.label7.Text = "No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 373;
            this.label5.Text = "Ref. 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 372;
            this.label4.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 371;
            this.label3.Text = "Item  No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 370;
            this.label1.Text = "Doc  Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 393;
            this.label2.Text = "Posting Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 394;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 20, 2, 54, 26, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 396;
            this.label8.Text = "Find";
            // 
            // CmbWhse
            // 
            this.CmbWhse.FormattingEnabled = true;
            this.CmbWhse.Location = new System.Drawing.Point(467, 97);
            this.CmbWhse.Name = "CmbWhse";
            this.CmbWhse.Size = new System.Drawing.Size(174, 21);
            this.CmbWhse.TabIndex = 397;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 398;
            this.label9.Text = "Warehouse ";
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
            // ColOB
            // 
            this.ColOB.HeaderText = "Opening Balance";
            this.ColOB.Name = "ColOB";
            this.ColOB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColUPrice
            // 
            this.ColUPrice.HeaderText = "Unit Price";
            this.ColUPrice.Name = "ColUPrice";
            this.ColUPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 399;
            this.label6.Text = "Oiql";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 400;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 401;
            this.label10.Text = "Journal Remarks";
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(647, 96);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(57, 23);
            this.BtnPrev.TabIndex = 402;
            this.BtnPrev.Text = "<<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            // 
            // BtnNxt
            // 
            this.BtnNxt.Location = new System.Drawing.Point(710, 96);
            this.BtnNxt.Name = "BtnNxt";
            this.BtnNxt.Size = new System.Drawing.Size(57, 23);
            this.BtnNxt.TabIndex = 403;
            this.BtnNxt.Text = ">>";
            this.BtnNxt.UseVisualStyleBackColor = true;
            // 
            // frmInvOB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.BtnNxt);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbWhse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGvInvOB);
            this.Controls.Add(this.RichRemks);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.dtpConutDtTm);
            this.Controls.Add(this.TxItemName);
            this.Controls.Add(this.TxRef2);
            this.Controls.Add(this.TxSNo);
            this.Controls.Add(this.BtnAdItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInvOB";
            this.Text = "Inventory Opening Balance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvOB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGvInvOB)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.DataGridView DGvInvOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWhse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBinLOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWhseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUPrice;
        private System.Windows.Forms.RichTextBox RichRemks;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.DateTimePicker dtpConutDtTm;
        private System.Windows.Forms.TextBox TxItemName;
        private System.Windows.Forms.TextBox TxRef2;
        private System.Windows.Forms.TextBox TxSNo;
        private System.Windows.Forms.Button BtnAdItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbWhse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNxt;
    }
}