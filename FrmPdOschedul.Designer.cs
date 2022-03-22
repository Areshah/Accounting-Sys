namespace Accounting_Sys
{
    partial class FrmPdOschedul
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabSched = new System.Windows.Forms.TabPage();
            this.DGvPdoSchdul = new System.Windows.Forms.DataGridView();
            this.ColPdO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPriort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemrks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOlCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabOption = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TxPdOThrou = new System.Windows.Forms.TextBox();
            this.BtnRels = new System.Windows.Forms.Button();
            this.BtnRefeh = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCrtNew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabSched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGvPdoSchdul)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabSched);
            this.tabControl1.Controls.Add(this.TabOption);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // TabSched
            // 
            this.TabSched.Controls.Add(this.DGvPdoSchdul);
            this.TabSched.Location = new System.Drawing.Point(4, 22);
            this.TabSched.Name = "TabSched";
            this.TabSched.Padding = new System.Windows.Forms.Padding(3);
            this.TabSched.Size = new System.Drawing.Size(1004, 360);
            this.TabSched.TabIndex = 0;
            this.TabSched.Text = "Schedule";
            this.TabSched.UseVisualStyleBackColor = true;
            // 
            // DGvPdoSchdul
            // 
            this.DGvPdoSchdul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvPdoSchdul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPdO,
            this.ColPriort,
            this.ColItemNo,
            this.ColJobName,
            this.ColRemrks,
            this.ColCust,
            this.cOlCustName});
            this.DGvPdoSchdul.Location = new System.Drawing.Point(6, 3);
            this.DGvPdoSchdul.Name = "DGvPdoSchdul";
            this.DGvPdoSchdul.Size = new System.Drawing.Size(995, 363);
            this.DGvPdoSchdul.TabIndex = 0;
            // 
            // ColPdO
            // 
            this.ColPdO.HeaderText = "PdO No";
            this.ColPdO.Name = "ColPdO";
            // 
            // ColPriort
            // 
            this.ColPriort.HeaderText = "Priorty By";
            this.ColPriort.Name = "ColPriort";
            // 
            // ColItemNo
            // 
            this.ColItemNo.HeaderText = "Item No";
            this.ColItemNo.Name = "ColItemNo";
            // 
            // ColJobName
            // 
            this.ColJobName.HeaderText = "Job Name";
            this.ColJobName.Name = "ColJobName";
            // 
            // ColRemrks
            // 
            this.ColRemrks.HeaderText = "Remarks";
            this.ColRemrks.Name = "ColRemrks";
            // 
            // ColCust
            // 
            this.ColCust.HeaderText = "Cust Code";
            this.ColCust.Name = "ColCust";
            // 
            // cOlCustName
            // 
            this.cOlCustName.HeaderText = "Cust Name";
            this.cOlCustName.Name = "cOlCustName";
            // 
            // TabOption
            // 
            this.TabOption.Location = new System.Drawing.Point(4, 22);
            this.TabOption.Name = "TabOption";
            this.TabOption.Padding = new System.Windows.Forms.Padding(3);
            this.TabOption.Size = new System.Drawing.Size(1004, 360);
            this.TabOption.TabIndex = 1;
            this.TabOption.Text = "Option";
            this.TabOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(371, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production Order Through";
            // 
            // TxPdOThrou
            // 
            this.TxPdOThrou.Location = new System.Drawing.Point(510, 401);
            this.TxPdOThrou.Name = "TxPdOThrou";
            this.TxPdOThrou.Size = new System.Drawing.Size(100, 20);
            this.TxPdOThrou.TabIndex = 1;
            // 
            // BtnRels
            // 
            this.BtnRels.Location = new System.Drawing.Point(632, 401);
            this.BtnRels.Name = "BtnRels";
            this.BtnRels.Size = new System.Drawing.Size(75, 23);
            this.BtnRels.TabIndex = 2;
            this.BtnRels.Text = "Release";
            this.BtnRels.UseVisualStyleBackColor = true;
            // 
            // BtnRefeh
            // 
            this.BtnRefeh.Location = new System.Drawing.Point(202, 399);
            this.BtnRefeh.Name = "BtnRefeh";
            this.BtnRefeh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefeh.TabIndex = 3;
            this.BtnRefeh.Text = "Refresh";
            this.BtnRefeh.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(110, 399);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCrtNew
            // 
            this.BtnCrtNew.Location = new System.Drawing.Point(283, 398);
            this.BtnCrtNew.Name = "BtnCrtNew";
            this.BtnCrtNew.Size = new System.Drawing.Size(75, 23);
            this.BtnCrtNew.TabIndex = 5;
            this.BtnCrtNew.Text = "Create New Sched";
            this.BtnCrtNew.UseVisualStyleBackColor = true;
            // 
            // FrmPdOschedul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 452);
            this.Controls.Add(this.BtnCrtNew);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnRefeh);
            this.Controls.Add(this.BtnRels);
            this.Controls.Add(this.TxPdOThrou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPdOschedul";
            this.Text = "Production Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPdOschedul_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabSched.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGvPdoSchdul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabSched;
        private System.Windows.Forms.DataGridView DGvPdoSchdul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPdO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPriort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemrks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOlCustName;
        private System.Windows.Forms.TabPage TabOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxPdOThrou;
        private System.Windows.Forms.Button BtnRels;
        private System.Windows.Forms.Button BtnRefeh;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCrtNew;
    }
}