namespace Accounting_Sys
{
    partial class frmPrdvolDis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrdvolDis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbPricList = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgPrdVolDis = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSourprc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChToolStrpPrev = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpAdd = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFirst = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpNext = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpPrevious = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpLast = new System.Windows.Forms.ToolStripButton();
            this.ChToolStrpFind = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgPrdVolDis)).BeginInit();
            this.ChToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find ";
            // 
            // CmbPricList
            // 
            this.CmbPricList.FormattingEnabled = true;
            this.CmbPricList.Location = new System.Drawing.Point(375, 62);
            this.CmbPricList.Name = "CmbPricList";
            this.CmbPricList.Size = new System.Drawing.Size(212, 21);
            this.CmbPricList.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 3;
            // 
            // DgPrdVolDis
            // 
            this.DgPrdVolDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPrdVolDis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColDesc,
            this.ColCurrency,
            this.ColSourprc,
            this.Coluom});
            this.DgPrdVolDis.Location = new System.Drawing.Point(113, 135);
            this.DgPrdVolDis.Name = "DgPrdVolDis";
            this.DgPrdVolDis.Size = new System.Drawing.Size(830, 230);
            this.DgPrdVolDis.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item No";
            this.Column1.Name = "Column1";
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "Item Description";
            this.ColDesc.Name = "ColDesc";
            // 
            // ColCurrency
            // 
            this.ColCurrency.HeaderText = "Primary Currency";
            this.ColCurrency.Name = "ColCurrency";
            // 
            // ColSourprc
            // 
            this.ColSourprc.HeaderText = "Source Price";
            this.ColSourprc.Name = "ColSourprc";
            // 
            // Coluom
            // 
            this.Coluom.HeaderText = "UoM";
            this.Coluom.Name = "Coluom";
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
            this.ChToolStrip1.TabIndex = 977;
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
            // frmPrdvolDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.ChToolStrip1);
            this.Controls.Add(this.DgPrdVolDis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CmbPricList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrdvolDis";
            this.Text = "Period and Volume Discount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrdvolDis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPrdVolDis)).EndInit();
            this.ChToolStrip1.ResumeLayout(false);
            this.ChToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbPricList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DgPrdVolDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSourprc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluom;
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