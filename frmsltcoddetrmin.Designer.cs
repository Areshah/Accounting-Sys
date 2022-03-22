namespace Accounting_Sys
{
    partial class frmsltcoddetrmin
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
            this.BtnshAll = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.TxFindCode = new System.Windows.Forms.TextBox();
            this.DgvSlTaxJurdDertmin = new System.Windows.Forms.DataGridView();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBusArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCond1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colval1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCondit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCond3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLineTaxcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLinFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhedrFreghttax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSlTaxJurdDertmin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnshAll
            // 
            this.BtnshAll.Location = new System.Drawing.Point(309, 8);
            this.BtnshAll.Name = "BtnshAll";
            this.BtnshAll.Size = new System.Drawing.Size(75, 23);
            this.BtnshAll.TabIndex = 2;
            this.BtnshAll.Text = "Show All";
            this.BtnshAll.UseVisualStyleBackColor = true;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(223, 8);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(75, 23);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            // 
            // TxFindCode
            // 
            this.TxFindCode.Location = new System.Drawing.Point(30, 10);
            this.TxFindCode.Name = "TxFindCode";
            this.TxFindCode.Size = new System.Drawing.Size(180, 20);
            this.TxFindCode.TabIndex = 0;
            // 
            // DgvSlTaxJurdDertmin
            // 
            this.DgvSlTaxJurdDertmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSlTaxJurdDertmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocType,
            this.ColBusArea,
            this.colCond1,
            this.Colval1,
            this.ColCondit2,
            this.ColVal2,
            this.ColCond3,
            this.ColVal3,
            this.ColDesc,
            this.ColLineTaxcd,
            this.ColLinFreight,
            this.colhedrFreghttax});
            this.DgvSlTaxJurdDertmin.Location = new System.Drawing.Point(30, 39);
            this.DgvSlTaxJurdDertmin.Name = "DgvSlTaxJurdDertmin";
            this.DgvSlTaxJurdDertmin.Size = new System.Drawing.Size(966, 340);
            this.DgvSlTaxJurdDertmin.TabIndex = 3;
            // 
            // colDocType
            // 
            this.colDocType.HeaderText = "Document Type";
            this.colDocType.Name = "colDocType";
            // 
            // ColBusArea
            // 
            this.ColBusArea.HeaderText = "Business Area";
            this.ColBusArea.Name = "ColBusArea";
            // 
            // colCond1
            // 
            this.colCond1.HeaderText = "Condition 1";
            this.colCond1.Name = "colCond1";
            // 
            // Colval1
            // 
            this.Colval1.HeaderText = "Value 1";
            this.Colval1.Name = "Colval1";
            // 
            // ColCondit2
            // 
            this.ColCondit2.HeaderText = "Condition 2";
            this.ColCondit2.Name = "ColCondit2";
            // 
            // ColVal2
            // 
            this.ColVal2.HeaderText = "Value 2";
            this.ColVal2.Name = "ColVal2";
            // 
            // ColCond3
            // 
            this.ColCond3.HeaderText = "Condition 3";
            this.ColCond3.Name = "ColCond3";
            // 
            // ColVal3
            // 
            this.ColVal3.HeaderText = "Value 3";
            this.ColVal3.Name = "ColVal3";
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "Description";
            this.ColDesc.Name = "ColDesc";
            // 
            // ColLineTaxcd
            // 
            this.ColLineTaxcd.HeaderText = "Line Tax Code";
            this.ColLineTaxcd.Name = "ColLineTaxcd";
            // 
            // ColLinFreight
            // 
            this.ColLinFreight.HeaderText = "Line Freight Tax";
            this.ColLinFreight.Name = "ColLinFreight";
            // 
            // colhedrFreghttax
            // 
            this.colhedrFreghttax.HeaderText = "Header Freight Tax";
            this.colhedrFreghttax.Name = "colhedrFreghttax";
            this.colhedrFreghttax.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "otcx";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(30, 404);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // frmsltcoddetrmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvSlTaxJurdDertmin);
            this.Controls.Add(this.TxFindCode);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnshAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmsltcoddetrmin";
            this.Text = "Sale Tax Code Determination";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmsltcoddetrmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSlTaxJurdDertmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnshAll;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TxFindCode;
        private System.Windows.Forms.DataGridView DgvSlTaxJurdDertmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBusArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCond1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colval1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCondit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCond3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLineTaxcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLinFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhedrFreghttax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
    }
}