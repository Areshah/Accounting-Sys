namespace Accounting_Sys
{
    partial class frmUGrp
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
            this.DGvUoMStpGrp = new System.Windows.Forms.DataGridView();
            this.ColSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrpDifinition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDefinition = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpgEntry = new System.Windows.Forms.TextBox();
            this.UgpCode = new System.Windows.Forms.TextBox();
            this.UgpName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGvUoMStpGrp)).BeginInit();
            this.SuspendLayout();
            // 
            // DGvUoMStpGrp
            // 
            this.DGvUoMStpGrp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvUoMStpGrp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSno,
            this.ColGrp,
            this.ColGrpDifinition});
            this.DGvUoMStpGrp.Location = new System.Drawing.Point(75, 44);
            this.DGvUoMStpGrp.Name = "DGvUoMStpGrp";
            this.DGvUoMStpGrp.ReadOnly = true;
            this.DGvUoMStpGrp.Size = new System.Drawing.Size(410, 254);
            this.DGvUoMStpGrp.TabIndex = 0;
            // 
            // ColSno
            // 
            this.ColSno.DataPropertyName = "UgpEntry";
            this.ColSno.HeaderText = "Grp No";
            this.ColSno.Name = "ColSno";
            this.ColSno.ReadOnly = true;
            this.ColSno.Width = 60;
            // 
            // ColGrp
            // 
            this.ColGrp.DataPropertyName = "ugpCode";
            this.ColGrp.HeaderText = "Group";
            this.ColGrp.Name = "ColGrp";
            this.ColGrp.ReadOnly = true;
            this.ColGrp.Width = 150;
            // 
            // ColGrpDifinition
            // 
            this.ColGrpDifinition.DataPropertyName = "UgpName";
            this.ColGrpDifinition.HeaderText = "Group Definition";
            this.ColGrpDifinition.Name = "ColGrpDifinition";
            this.ColGrpDifinition.ReadOnly = true;
            this.ColGrpDifinition.Width = 150;
            // 
            // BtnDefinition
            // 
            this.BtnDefinition.Location = new System.Drawing.Point(289, 304);
            this.BtnDefinition.Name = "BtnDefinition";
            this.BtnDefinition.Size = new System.Drawing.Size(109, 23);
            this.BtnDefinition.TabIndex = 1;
            this.BtnDefinition.Text = "Group Definition";
            this.BtnDefinition.UseVisualStyleBackColor = true;
            this.BtnDefinition.Click += new System.EventHandler(this.BtnDefinition_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(28, 304);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group Definition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group";
            // 
            // UpgEntry
            // 
            this.UpgEntry.Location = new System.Drawing.Point(129, 18);
            this.UpgEntry.Name = "UpgEntry";
            this.UpgEntry.Size = new System.Drawing.Size(41, 20);
            this.UpgEntry.TabIndex = 5;
            // 
            // UgpCode
            // 
            this.UgpCode.Location = new System.Drawing.Point(178, 18);
            this.UgpCode.Name = "UgpCode";
            this.UgpCode.Size = new System.Drawing.Size(100, 20);
            this.UgpCode.TabIndex = 6;
            // 
            // UgpName
            // 
            this.UgpName.Location = new System.Drawing.Point(308, 18);
            this.UgpName.Name = "UgpName";
            this.UgpName.Size = new System.Drawing.Size(100, 20);
            this.UgpName.TabIndex = 7;
            // 
            // frmUGrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 339);
            this.Controls.Add(this.UgpName);
            this.Controls.Add(this.UgpCode);
            this.Controls.Add(this.UpgEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDefinition);
            this.Controls.Add(this.DGvUoMStpGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUGrp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit of Measure Group  Setup ";
            this.Load += new System.EventHandler(this.frmUoMesurStupGrp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGvUoMStpGrp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGvUoMStpGrp;
        private System.Windows.Forms.Button BtnDefinition;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpgEntry;
        private System.Windows.Forms.TextBox UgpCode;
        private System.Windows.Forms.TextBox UgpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrpDifinition;
    }
}