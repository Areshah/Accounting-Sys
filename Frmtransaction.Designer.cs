namespace Accounting_Sys
{
    partial class Frmtransaction
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
            this.grtrans = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRquntity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprname = new System.Windows.Forms.TextBox();
            this.btnfinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btntrans = new System.Windows.Forms.Button();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcus = new System.Windows.Forms.TextBox();
            this.lblheader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grtrans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grtrans
            // 
            this.grtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grtrans.Location = new System.Drawing.Point(175, 237);
            this.grtrans.Name = "grtrans";
            this.grtrans.Size = new System.Drawing.Size(521, 150);
            this.grtrans.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sub Total";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(491, 120);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(162, 20);
            this.txtsubtotal.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Required Quntity";
            // 
            // txtRquntity
            // 
            this.txtRquntity.Location = new System.Drawing.Point(491, 90);
            this.txtRquntity.Name = "txtRquntity";
            this.txtRquntity.Size = new System.Drawing.Size(162, 20);
            this.txtRquntity.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unit Price";
            // 
            // txtunitprice
            // 
            this.txtunitprice.Enabled = false;
            this.txtunitprice.Location = new System.Drawing.Point(491, 60);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(162, 20);
            this.txtunitprice.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock Quntity";
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Location = new System.Drawing.Point(491, 30);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(162, 20);
            this.txtstock.TabIndex = 6;
            // 
            // txtbillno
            // 
            this.txtbillno.Enabled = false;
            this.txtbillno.Location = new System.Drawing.Point(132, 30);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(162, 20);
            this.txtbillno.TabIndex = 1;
            // 
            // txtbalance
            // 
            this.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbalance.Enabled = false;
            this.txtbalance.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtbalance.Location = new System.Drawing.Point(534, 453);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(162, 20);
            this.txtbalance.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(446, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Balance";
            // 
            // txtcash
            // 
            this.txtcash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcash.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtcash.Location = new System.Drawing.Point(534, 427);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(162, 20);
            this.txtcash.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Cash";
            // 
            // txtotal
            // 
            this.txtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtotal.Enabled = false;
            this.txtotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtotal.Location = new System.Drawing.Point(534, 398);
            this.txtotal.Name = "txtotal";
            this.txtotal.Size = new System.Drawing.Size(162, 20);
            this.txtotal.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bill Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product ID";
            // 
            // txtprid
            // 
            this.txtprid.Enabled = false;
            this.txtprid.Location = new System.Drawing.Point(132, 146);
            this.txtprid.Name = "txtprid";
            this.txtprid.Size = new System.Drawing.Size(162, 20);
            this.txtprid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Total";
            // 
            // txtprname
            // 
            this.txtprname.Location = new System.Drawing.Point(132, 117);
            this.txtprname.Name = "txtprname";
            this.txtprname.Size = new System.Drawing.Size(224, 20);
            this.txtprname.TabIndex = 4;
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinish.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnfinish.Location = new System.Drawing.Point(708, 287);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(75, 32);
            this.btnfinish.TabIndex = 40;
            this.btnfinish.Text = "Confirm";
            this.btnfinish.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ID";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Navy;
            this.lbltime.Location = new System.Drawing.Point(699, 18);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(34, 13);
            this.lbltime.TabIndex = 36;
            this.lbltime.Text = "Date";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(610, 18);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(34, 13);
            this.lbldate.TabIndex = 33;
            this.lbldate.Text = "Date";
            // 
            // btntrans
            // 
            this.btntrans.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btntrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrans.ForeColor = System.Drawing.Color.Cornsilk;
            this.btntrans.Location = new System.Drawing.Point(708, 237);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(75, 32);
            this.btntrans.TabIndex = 34;
            this.btntrans.Text = "Add";
            this.btntrans.UseVisualStyleBackColor = false;
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Enabled = false;
            this.txtcustomerid.Location = new System.Drawing.Point(132, 88);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(162, 20);
            this.txtcustomerid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // txtcus
            // 
            this.txtcus.Location = new System.Drawing.Point(132, 59);
            this.txtcus.Name = "txtcus";
            this.txtcus.Size = new System.Drawing.Size(224, 20);
            this.txtcus.TabIndex = 2;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.Green;
            this.lblheader.Location = new System.Drawing.Point(314, 13);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(177, 18);
            this.lblheader.TabIndex = 44;
            this.lblheader.Text = "Create Transaction";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRquntity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtunitprice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtbillno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtprid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtprname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcus);
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 188);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // Frmtransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.grtrans);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmtransaction";
            this.Text = "Frmtransaction";
            ((System.ComponentModel.ISupportInitialize)(this.grtrans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grtrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRquntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtprname;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btntrans;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcus;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}