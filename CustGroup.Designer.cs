namespace Accounting_Sys
{
    partial class CustGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvCstGrp = new System.Windows.Forms.DataGridView();
            this.ColGrpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPricList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxCstGrpName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCstGrp)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Indigo;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(313, 57);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(107, 27);
            this.BtnAdd.TabIndex = 407;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvCstGrp
            // 
            this.DgvCstGrp.AllowUserToAddRows = false;
            this.DgvCstGrp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCstGrp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCstGrp.BackgroundColor = System.Drawing.Color.White;
            this.DgvCstGrp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCstGrp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCstGrp.ColumnHeadersHeight = 24;
            this.DgvCstGrp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGrpCode,
            this.ColGrpName,
            this.ColPricList});
            this.DgvCstGrp.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCstGrp.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCstGrp.EnableHeadersVisualStyles = false;
            this.DgvCstGrp.GridColor = System.Drawing.Color.White;
            this.DgvCstGrp.Location = new System.Drawing.Point(22, 91);
            this.DgvCstGrp.MultiSelect = false;
            this.DgvCstGrp.Name = "DgvCstGrp";
            this.DgvCstGrp.ReadOnly = true;
            this.DgvCstGrp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCstGrp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCstGrp.RowHeadersWidth = 25;
            this.DgvCstGrp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCstGrp.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCstGrp.RowTemplate.Height = 25;
            this.DgvCstGrp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCstGrp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCstGrp.Size = new System.Drawing.Size(387, 241);
            this.DgvCstGrp.TabIndex = 411;
            // 
            // ColGrpCode
            // 
            this.ColGrpCode.DataPropertyName = "GroupCode";
            this.ColGrpCode.HeaderText = "Group Code";
            this.ColGrpCode.Name = "ColGrpCode";
            this.ColGrpCode.ReadOnly = true;
            // 
            // ColGrpName
            // 
            this.ColGrpName.DataPropertyName = "GroupName";
            this.ColGrpName.HeaderText = "Group Name";
            this.ColGrpName.Name = "ColGrpName";
            this.ColGrpName.ReadOnly = true;
            this.ColGrpName.Width = 200;
            // 
            // ColPricList
            // 
            this.ColPricList.DataPropertyName = "PriceList";
            this.ColPricList.HeaderText = "Price List";
            this.ColPricList.Name = "ColPricList";
            this.ColPricList.ReadOnly = true;
            this.ColPricList.Width = 180;
            // 
            // TxCstGrpName
            // 
            this.TxCstGrpName.Location = new System.Drawing.Point(197, 7);
            this.TxCstGrpName.Name = "TxCstGrpName";
            this.TxCstGrpName.Size = new System.Drawing.Size(169, 20);
            this.TxCstGrpName.TabIndex = 409;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(27, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(136, 15);
            this.Label5.TabIndex = 408;
            this.Label5.Text = "Enter Customers Group";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 27);
            this.groupBox1.TabIndex = 410;
            this.groupBox1.TabStop = false;
            // 
            // CustGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvCstGrp);
            this.Controls.Add(this.TxCstGrpName);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Group";
            this.Load += new System.EventHandler(this.CustGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCstGrp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnAdd;
        internal System.Windows.Forms.DataGridView DgvCstGrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPricList;
        private System.Windows.Forms.TextBox TxCstGrpName;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}