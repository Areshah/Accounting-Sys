namespace Accounting_Sys
{
    partial class Frmadduser
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(117, 44);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(169, 20);
            this.txtuid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(117, 83);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(169, 20);
            this.txtuname.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(117, 123);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 20);
            this.txtname.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 41;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.Green;
            this.lblheader.Location = new System.Drawing.Point(322, 67);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(189, 18);
            this.lblheader.TabIndex = 40;
            this.lblheader.Text = "Create User Account";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(85, 354);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 30);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.cmb1.Location = new System.Drawing.Point(502, 240);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(169, 21);
            this.cmb1.TabIndex = 35;
            this.cmb1.Text = "-- Select --";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Privilage Level";
            // 
            // txtvpass
            // 
            this.txtvpass.Location = new System.Drawing.Point(502, 200);
            this.txtvpass.Name = "txtvpass";
            this.txtvpass.Size = new System.Drawing.Size(169, 20);
            this.txtvpass.TabIndex = 34;
            this.txtvpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Varify Password";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(502, 164);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(169, 20);
            this.txtpass.TabIndex = 33;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtuname);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(70, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 212);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // Frmadduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmadduser";
            this.Text = "Frmadduser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}