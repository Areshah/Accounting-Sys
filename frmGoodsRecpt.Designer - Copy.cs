﻿namespace Accounting_Sys
{
    partial class frmGoodsRecpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsRecpt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txnum = new System.Windows.Forms.TextBox();
            this.CmbPrcLst = new System.Windows.Forms.ComboBox();
            this.DtpcDocDt = new System.Windows.Forms.DateTimePicker();
            this.TxRef2 = new System.Windows.Forms.TextBox();
            this.DgvGoodsRecpt = new System.Windows.Forms.DataGridView();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.COlItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COlqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COluPric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBinLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIjnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUomOcde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodsRecpt)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ref 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Document Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price List";
            // 
            // Txnum
            // 
            this.Txnum.Location = new System.Drawing.Point(95, 42);
            this.Txnum.Name = "Txnum";
            this.Txnum.Size = new System.Drawing.Size(100, 20);
            this.Txnum.TabIndex = 5;
            // 
            // CmbPrcLst
            // 
            this.CmbPrcLst.FormattingEnabled = true;
            this.CmbPrcLst.Location = new System.Drawing.Point(95, 61);
            this.CmbPrcLst.Name = "CmbPrcLst";
            this.CmbPrcLst.Size = new System.Drawing.Size(154, 21);
            this.CmbPrcLst.TabIndex = 6;
            // 
            // DtpcDocDt
            // 
            this.DtpcDocDt.Location = new System.Drawing.Point(842, 41);
            this.DtpcDocDt.Name = "DtpcDocDt";
            this.DtpcDocDt.Size = new System.Drawing.Size(157, 20);
            this.DtpcDocDt.TabIndex = 7;
            // 
            // TxRef2
            // 
            this.TxRef2.Location = new System.Drawing.Point(842, 61);
            this.TxRef2.Name = "TxRef2";
            this.TxRef2.Size = new System.Drawing.Size(157, 20);
            this.TxRef2.TabIndex = 8;
            // 
            // DgvGoodsRecpt
            // 
            this.DgvGoodsRecpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodsRecpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COlItem,
            this.ColItmDesc,
            this.COlqty,
            this.COluPric,
            this.ColTot,
            this.ColBinLoc,
            this.ColIjnv,
            this.ColItmCost,
            this.ColUomOcde,
            this.ColUomName,
            this.ColBr,
            this.ColProdLine});
            this.DgvGoodsRecpt.Location = new System.Drawing.Point(33, 84);
            this.DgvGoodsRecpt.Name = "DgvGoodsRecpt";
            this.DgvGoodsRecpt.Size = new System.Drawing.Size(966, 340);
            this.DgvGoodsRecpt.TabIndex = 9;
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
            this.ChToolStrip1.TabIndex = 410;
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
            // COlItem
            // 
            this.COlItem.HeaderText = "Item No";
            this.COlItem.Name = "COlItem";
            // 
            // ColItmDesc
            // 
            this.ColItmDesc.HeaderText = "Item Description";
            this.ColItmDesc.Name = "ColItmDesc";
            // 
            // COlqty
            // 
            this.COlqty.HeaderText = "Quantity";
            this.COlqty.Name = "COlqty";
            // 
            // COluPric
            // 
            this.COluPric.HeaderText = "Unit Price";
            this.COluPric.Name = "COluPric";
            // 
            // ColTot
            // 
            this.ColTot.HeaderText = "Total";
            this.ColTot.Name = "ColTot";
            // 
            // ColBinLoc
            // 
            this.ColBinLoc.HeaderText = "Bin Location";
            this.ColBinLoc.Name = "ColBinLoc";
            // 
            // ColIjnv
            // 
            this.ColIjnv.HeaderText = "Inventory";
            this.ColIjnv.Name = "ColIjnv";
            // 
            // ColItmCost
            // 
            this.ColItmCost.HeaderText = "Item Cost";
            this.ColItmCost.Name = "ColItmCost";
            // 
            // ColUomOcde
            // 
            this.ColUomOcde.HeaderText = "UoM Code";
            this.ColUomOcde.Name = "ColUomOcde";
            // 
            // ColUomName
            // 
            this.ColUomName.HeaderText = "UoM Name";
            this.ColUomName.Name = "ColUomName";
            // 
            // ColBr
            // 
            this.ColBr.HeaderText = "Branch";
            this.ColBr.Name = "ColBr";
            // 
            // ColProdLine
            // 
            this.ColProdLine.HeaderText = "Product Line ";
            this.ColProdLine.Name = "ColProdLine";
            // 
            // frmGoodsRecpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.DgvGoodsRecpt);
            this.Controls.Add(this.TxRef2);
            this.Controls.Add(this.DtpcDocDt);
            this.Controls.Add(this.CmbPrcLst);
            this.Controls.Add(this.Txnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGoodsRecpt";
            this.Text = "Goods Receipt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGoodsRecpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodsRecpt)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txnum;
        private System.Windows.Forms.ComboBox CmbPrcLst;
        private System.Windows.Forms.DateTimePicker DtpcDocDt;
        private System.Windows.Forms.TextBox TxRef2;
        private System.Windows.Forms.DataGridView DgvGoodsRecpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn COlItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn COlqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn COluPric;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBinLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIjnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUomOcde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdLine;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
    }
}