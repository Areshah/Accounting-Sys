namespace Accounting_Sys
{
    partial class frmsltJurdSetUp
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
            this.DgvSltxJuridStp = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Colsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColtypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSltxJuridStp)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSltxJuridStp
            // 
            this.DgvSltxJuridStp.AllowUserToDeleteRows = false;
            this.DgvSltxJuridStp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSltxJuridStp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colsno,
            this.ColtypeName});
            this.DgvSltxJuridStp.Location = new System.Drawing.Point(12, 29);
            this.DgvSltxJuridStp.Name = "DgvSltxJuridStp";
            this.DgvSltxJuridStp.Size = new System.Drawing.Size(405, 257);
            this.DgvSltxJuridStp.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 304);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ostt";
            // 
            // Colsno
            // 
            this.Colsno.DataPropertyName = "absid";
            this.Colsno.HeaderText = "S.No";
            this.Colsno.Name = "Colsno";
            // 
            // ColtypeName
            // 
            this.ColtypeName.DataPropertyName = "name";
            this.ColtypeName.HeaderText = "Type Name";
            this.ColtypeName.Name = "ColtypeName";
            this.ColtypeName.Width = 380;
            // 
            // frmsltJurdSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DgvSltxJuridStp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsltJurdSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Tax Jurisdition Setup";
            this.Load += new System.EventHandler(this.StaxJurisdiSetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSltxJuridStp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSltxJuridStp;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColtypeName;
    }
}