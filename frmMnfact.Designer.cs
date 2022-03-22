namespace Accounting_Sys
{
    partial class frmMnfact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMnfact));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxFirmName = new System.Windows.Forms.TextBox();
            this.dgwmanu = new System.Windows.Forms.DataGridView();
            this.colFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwmanu)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(56, 6);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(121, 15);
            this.Label5.TabIndex = 348;
            this.Label5.Text = "Enter Manufactuere:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Indigo;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(312, 52);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(107, 27);
            this.BtnAdd.TabIndex = 345;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 27);
            this.groupBox1.TabIndex = 355;
            this.groupBox1.TabStop = false;
            // 
            // TxFirmName
            // 
            this.TxFirmName.Location = new System.Drawing.Point(170, 2);
            this.TxFirmName.Name = "TxFirmName";
            this.TxFirmName.Size = new System.Drawing.Size(169, 20);
            this.TxFirmName.TabIndex = 351;
            // 
            // dgwmanu
            // 
            this.dgwmanu.AllowUserToAddRows = false;
            this.dgwmanu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwmanu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwmanu.BackgroundColor = System.Drawing.Color.White;
            this.dgwmanu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwmanu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwmanu.ColumnHeadersHeight = 24;
            this.dgwmanu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirm,
            this.colFrmName});
            this.dgwmanu.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwmanu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwmanu.EnableHeadersVisualStyles = false;
            this.dgwmanu.GridColor = System.Drawing.Color.White;
            this.dgwmanu.Location = new System.Drawing.Point(21, 86);
            this.dgwmanu.MultiSelect = false;
            this.dgwmanu.Name = "dgwmanu";
            this.dgwmanu.ReadOnly = true;
            this.dgwmanu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwmanu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwmanu.RowHeadersWidth = 25;
            this.dgwmanu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwmanu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwmanu.RowTemplate.Height = 25;
            this.dgwmanu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwmanu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwmanu.Size = new System.Drawing.Size(387, 241);
            this.dgwmanu.TabIndex = 401;
            // 
            // colFirm
            // 
            this.colFirm.DataPropertyName = "firmcode";
            this.colFirm.HeaderText = "Firm Code";
            this.colFirm.Name = "colFirm";
            this.colFirm.ReadOnly = true;
            // 
            // colFrmName
            // 
            this.colFrmName.DataPropertyName = "firmName";
            this.colFrmName.HeaderText = "Firm Name";
            this.colFrmName.Name = "colFrmName";
            this.colFrmName.ReadOnly = true;
            this.colFrmName.Width = 360;
            // 
            // frmMnfact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dgwmanu);
            this.Controls.Add(this.TxFirmName);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMnfact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Munfacturer Firm";
            this.Load += new System.EventHandler(this.firmMunfactr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwmanu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxFirmName;
        internal System.Windows.Forms.DataGridView dgwmanu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrmName;
    }
}