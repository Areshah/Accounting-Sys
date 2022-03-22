namespace Accounting_Sys
{
    partial class frmBanks
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
            this.DGvBnks = new System.Windows.Forms.DataGridView();
            this.ColBnk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBnkDifinition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGvBnks)).BeginInit();
            this.SuspendLayout();
            // 
            // DGvBnks
            // 
            this.DGvBnks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvBnks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBnk,
            this.ColBnkDifinition});
            this.DGvBnks.Location = new System.Drawing.Point(27, 34);
            this.DGvBnks.Name = "DGvBnks";
            this.DGvBnks.Size = new System.Drawing.Size(374, 271);
            this.DGvBnks.TabIndex = 1;
            // 
            // ColBnk
            // 
            this.ColBnk.HeaderText = "Banks";
            this.ColBnk.Name = "ColBnk";
            this.ColBnk.Width = 220;
            // 
            // ColBnkDifinition
            // 
            this.ColBnkDifinition.HeaderText = "Bank Definition";
            this.ColBnkDifinition.Name = "ColBnkDifinition";
            this.ColBnkDifinition.Width = 220;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(27, 311);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // frmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DGvBnks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks ";
            this.Load += new System.EventHandler(this.frmBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGvBnks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGvBnks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBnk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBnkDifinition;
        private System.Windows.Forms.Button BtnSave;
    }
}