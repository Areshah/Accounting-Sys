namespace Accounting_Sys
{
    partial class frmrecvFrmProdn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrecvFrmProdn));
            this.TxRef2 = new System.Windows.Forms.TextBox();
            this.DtpcDocDt = new System.Windows.Forms.DateTimePicker();
            this.CmbPrcLst = new System.Windows.Forms.ComboBox();
            this.Txnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvsRecevProdunc = new System.Windows.Forms.DataGridView();
            this.colordr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colseries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COlItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COlqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUntPric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBinLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIjnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUomOcde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBrprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvsRecevProdunc)).BeginInit();
            this.SuspendLayout();
            // 
            // TxRef2
            // 
            this.TxRef2.Location = new System.Drawing.Point(842, 82);
            this.TxRef2.Name = "TxRef2";
            this.TxRef2.Size = new System.Drawing.Size(157, 20);
            this.TxRef2.TabIndex = 430;
            // 
            // DtpcDocDt
            // 
            this.DtpcDocDt.Location = new System.Drawing.Point(842, 62);
            this.DtpcDocDt.Name = "DtpcDocDt";
            this.DtpcDocDt.Size = new System.Drawing.Size(157, 20);
            this.DtpcDocDt.TabIndex = 429;
            // 
            // CmbPrcLst
            // 
            this.CmbPrcLst.FormattingEnabled = true;
            this.CmbPrcLst.Location = new System.Drawing.Point(95, 82);
            this.CmbPrcLst.Name = "CmbPrcLst";
            this.CmbPrcLst.Size = new System.Drawing.Size(154, 21);
            this.CmbPrcLst.TabIndex = 428;
            // 
            // Txnum
            // 
            this.Txnum.Location = new System.Drawing.Point(95, 63);
            this.Txnum.Name = "Txnum";
            this.Txnum.Size = new System.Drawing.Size(100, 20);
            this.Txnum.TabIndex = 427;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 426;
            this.label5.Text = "Price List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 425;
            this.label4.Text = "Document Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 424;
            this.label3.Text = "Ref 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 422;
            this.label1.Text = "Number";
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
            this.ChToolStrip1.TabIndex = 432;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 423;
            this.label2.Text = "Series";
            // 
            // DgvsRecevProdunc
            // 
            this.DgvsRecevProdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvsRecevProdunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colordr,
            this.colseries,
            this.COlItem,
            this.ColItmDesc,
            this.colTransTyp,
            this.COlqty,
            this.ColUntPric,
            this.ColBinLoc,
            this.ColItmCost,
            this.ColIjnv,
            this.ColIssu,
            this.ColUomOcde,
            this.ColUomName,
            this.ColBr,
            this.ColProdLine,
            this.ColBrprod});
            this.DgvsRecevProdunc.Location = new System.Drawing.Point(33, 103);
            this.DgvsRecevProdunc.Name = "DgvsRecevProdunc";
            this.DgvsRecevProdunc.Size = new System.Drawing.Size(966, 340);
            this.DgvsRecevProdunc.TabIndex = 443;
            // 
            // colordr
            // 
            this.colordr.HeaderText = "Order No";
            this.colordr.Name = "colordr";
            // 
            // colseries
            // 
            this.colseries.HeaderText = "Series No";
            this.colseries.Name = "colseries";
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
            // colTransTyp
            // 
            this.colTransTyp.HeaderText = "Trans Type";
            this.colTransTyp.Name = "colTransTyp";
            // 
            // COlqty
            // 
            this.COlqty.HeaderText = "Quantity";
            this.COlqty.Name = "COlqty";
            // 
            // ColUntPric
            // 
            this.ColUntPric.HeaderText = "Unit Price";
            this.ColUntPric.Name = "ColUntPric";
            // 
            // ColBinLoc
            // 
            this.ColBinLoc.HeaderText = "Bin Location";
            this.ColBinLoc.Name = "ColBinLoc";
            // 
            // ColItmCost
            // 
            this.ColItmCost.HeaderText = "Item Cost";
            this.ColItmCost.Name = "ColItmCost";
            // 
            // ColIjnv
            // 
            this.ColIjnv.HeaderText = "Planned";
            this.ColIjnv.Name = "ColIjnv";
            // 
            // ColIssu
            // 
            this.ColIssu.HeaderText = "Completed";
            this.ColIssu.Name = "ColIssu";
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
            // ColBrprod
            // 
            this.ColBrprod.HeaderText = "By-Product";
            this.ColBrprod.Name = "ColBrprod";
            // 
            // frmrecvFrmProdn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.DgvsRecevProdunc);
            this.Controls.Add(this.TxRef2);
            this.Controls.Add(this.DtpcDocDt);
            this.Controls.Add(this.CmbPrcLst);
            this.Controls.Add(this.Txnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmrecvFrmProdn";
            this.Text = "Receipt From Productiom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmrecvFrmProdn_Load);
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvsRecevProdunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxRef2;
        private System.Windows.Forms.DateTimePicker DtpcDocDt;
        private System.Windows.Forms.ComboBox CmbPrcLst;
        private System.Windows.Forms.TextBox Txnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStrip ChToolStrip1;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrev;
        private System.Windows.Forms.ToolStripButton ChToolStrpAdd;
        private System.Windows.Forms.ToolStripButton ChToolStrpFirst;
        private System.Windows.Forms.ToolStripButton ChToolStrpNext;
        private System.Windows.Forms.ToolStripButton ChToolStrpPrevious;
        private System.Windows.Forms.ToolStripButton ChToolStrpLast;
        private System.Windows.Forms.ToolStripButton ChToolStrpFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvsRecevProdunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colseries;
        private System.Windows.Forms.DataGridViewTextBoxColumn COlItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn COlqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUntPric;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBinLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItmCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIjnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIssu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUomOcde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBrprod;
    }
}