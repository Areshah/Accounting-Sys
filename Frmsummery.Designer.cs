namespace Accounting_Sys
{
    partial class Frmsummery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr = new System.Windows.Forms.DataGridView();
            this.dte = new System.Windows.Forms.DateTimePicker();
            this.dts = new System.Windows.Forms.DateTimePicker();
            this.lblheader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfind);
            this.groupBox1.Location = new System.Drawing.Point(468, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 125);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "By Name";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(87, 34);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(198, 20);
            this.txtfind.TabIndex = 0;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(304, 167);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(85, 31);
            this.btnfind.TabIndex = 37;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Start Date";
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(15, 216);
            this.dgr.Name = "dgr";
            this.dgr.Size = new System.Drawing.Size(603, 219);
            this.dgr.TabIndex = 34;
            // 
            // dte
            // 
            this.dte.Location = new System.Drawing.Point(98, 182);
            this.dte.Name = "dte";
            this.dte.Size = new System.Drawing.Size(148, 20);
            this.dte.TabIndex = 33;
            // 
            // dts
            // 
            this.dts.Location = new System.Drawing.Point(98, 136);
            this.dts.Name = "dts";
            this.dts.Size = new System.Drawing.Size(148, 20);
            this.dts.TabIndex = 32;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.Green;
            this.lblheader.Location = new System.Drawing.Point(267, 27);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(155, 18);
            this.lblheader.TabIndex = 39;
            this.lblheader.Text = "Summery Details";
            // 
            // Frmsummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgr);
            this.Controls.Add(this.dte);
            this.Controls.Add(this.dts);
            this.Controls.Add(this.lblheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmsummery";
            this.Text = "Frmsummery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.DateTimePicker dte;
        private System.Windows.Forms.DateTimePicker dts;
        private System.Windows.Forms.Label lblheader;
    }
}