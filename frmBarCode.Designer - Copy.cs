namespace Accounting_Sys
{
    partial class frmBarCode
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Setupuom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barcde = new System.Windows.Forms.Label();
            this.TxItem = new System.Windows.Forms.TextBox();
            this.TxItemDesc = new System.Windows.Forms.TextBox();
            this.TxuomGrp = new System.Windows.Forms.TextBox();
            this.DgvUomGrp = new System.Windows.Forms.DataGridView();
            this.DgvTxBarcd = new System.Windows.Forms.DataGridView();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colfreetxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.coluom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUomGrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTxBarcd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 978;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 979;
            this.label3.Text = "UoM Group";
            // 
            // Setupuom
            // 
            this.Setupuom.AutoSize = true;
            this.Setupuom.Location = new System.Drawing.Point(27, 35);
            this.Setupuom.Name = "Setupuom";
            this.Setupuom.Size = new System.Drawing.Size(35, 13);
            this.Setupuom.TabIndex = 980;
            this.Setupuom.Text = "Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 981;
            this.label5.Text = "Item Description";
            // 
            // barcde
            // 
            this.barcde.AutoSize = true;
            this.barcde.Location = new System.Drawing.Point(471, 54);
            this.barcde.Name = "barcde";
            this.barcde.Size = new System.Drawing.Size(51, 13);
            this.barcde.TabIndex = 982;
            this.barcde.Text = "Bar Code";
            // 
            // TxItem
            // 
            this.TxItem.Location = new System.Drawing.Point(48, 3);
            this.TxItem.Name = "TxItem";
            this.TxItem.Size = new System.Drawing.Size(102, 20);
            this.TxItem.TabIndex = 983;
            // 
            // TxItemDesc
            // 
            this.TxItemDesc.Location = new System.Drawing.Point(250, 6);
            this.TxItemDesc.Name = "TxItemDesc";
            this.TxItemDesc.Size = new System.Drawing.Size(144, 20);
            this.TxItemDesc.TabIndex = 984;
            // 
            // TxuomGrp
            // 
            this.TxuomGrp.Location = new System.Drawing.Point(87, 32);
            this.TxuomGrp.Name = "TxuomGrp";
            this.TxuomGrp.Size = new System.Drawing.Size(193, 20);
            this.TxuomGrp.TabIndex = 985;
            // 
            // DgvUomGrp
            // 
            this.DgvUomGrp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUomGrp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluom});
            this.DgvUomGrp.Location = new System.Drawing.Point(12, 71);
            this.DgvUomGrp.Name = "DgvUomGrp";
            this.DgvUomGrp.Size = new System.Drawing.Size(138, 237);
            this.DgvUomGrp.TabIndex = 986;
            // 
            // DgvTxBarcd
            // 
            this.DgvTxBarcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTxBarcd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarcode,
            this.Colfreetxt});
            this.DgvTxBarcd.Location = new System.Drawing.Point(154, 72);
            this.DgvTxBarcd.Name = "DgvTxBarcd";
            this.DgvTxBarcd.Size = new System.Drawing.Size(265, 237);
            this.DgvTxBarcd.TabIndex = 987;
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "Bar Code";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Width = 150;
            // 
            // Colfreetxt
            // 
            this.Colfreetxt.HeaderText = "Free Text";
            this.Colfreetxt.Name = "Colfreetxt";
            this.Colfreetxt.Width = 150;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 313);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 988;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // coluom
            // 
            this.coluom.HeaderText = "UoM";
            this.coluom.Name = "coluom";
            this.coluom.Width = 135;
            // 
            // frmBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DgvTxBarcd);
            this.Controls.Add(this.DgvUomGrp);
            this.Controls.Add(this.TxuomGrp);
            this.Controls.Add(this.TxItemDesc);
            this.Controls.Add(this.TxItem);
            this.Controls.Add(this.barcde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Setupuom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Bar Code";
            this.Load += new System.EventHandler(this.frmBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUomGrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTxBarcd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Setupuom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label barcde;
        private System.Windows.Forms.TextBox TxItem;
        private System.Windows.Forms.TextBox TxItemDesc;
        private System.Windows.Forms.TextBox TxuomGrp;
        private System.Windows.Forms.DataGridView DgvUomGrp;
        private System.Windows.Forms.DataGridView DgvTxBarcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colfreetxt;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluom;
    }
}