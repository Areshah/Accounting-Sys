namespace Accounting_Sys
{
    partial class custledger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custledger));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLedgeAcct = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.BtnLdger = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GroupBox2.Controls.Add(this.cmbLedgeAcct);
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(36, 43);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(573, 81);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search by Customer Name and Date";
            // 
            // cmbLedgeAcct
            // 
            this.cmbLedgeAcct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLedgeAcct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLedgeAcct.FormattingEnabled = true;
            this.cmbLedgeAcct.Items.AddRange(new object[] {
            "AAA Ltd",
            "Bank JFK",
            "Sales",
            "Sun Ltd"});
            this.cmbLedgeAcct.Location = new System.Drawing.Point(53, 35);
            this.cmbLedgeAcct.Name = "cmbLedgeAcct";
            this.cmbLedgeAcct.Size = new System.Drawing.Size(234, 25);
            this.cmbLedgeAcct.TabIndex = 0;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(409, 35);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(100, 24);
            this.dtpDateTo.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(413, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 17);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "To :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(301, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 17);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "From :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(304, 36);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(98, 24);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // BtnLdger
            // 
            this.BtnLdger.Image = ((System.Drawing.Image)(resources.GetObject("BtnLdger.Image")));
            this.BtnLdger.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnLdger.Location = new System.Drawing.Point(637, 59);
            this.BtnLdger.Name = "BtnLdger";
            this.BtnLdger.Size = new System.Drawing.Size(75, 23);
            this.BtnLdger.TabIndex = 8;
            this.BtnLdger.Text = "Show Ledger";
            this.BtnLdger.UseVisualStyleBackColor = true;
            this.BtnLdger.Click += new System.EventHandler(this.BtnLdger_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCancel.Location = new System.Drawing.Point(637, 91);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // custledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(767, 162);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLdger);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "custledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Report";
            this.Load += new System.EventHandler(this.custledger_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cmbLedgeAcct;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button BtnLdger;
        private System.Windows.Forms.Button BtnCancel;
    }
}