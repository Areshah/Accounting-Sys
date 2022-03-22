namespace Accounting_Sys
{
    partial class frmPurchaseOrderReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrderReturn));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSearch = new System.Windows.Forms.ToolStripButton();
            this.side4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.side3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.side2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.side1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "MAIN_i16x160.ico");
            this.imageList1.Images.SetKeyName(1, "MAIN_i16x161.ico");
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qty Returned";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Debit Memo Date";
            this.columnHeader5.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Debit Memo No";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Invoice No.";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PO No.";
            this.columnHeader1.Width = 110;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvList.ContextMenuStrip = this.contextMenuStrip1;
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(0, 39);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(1081, 567);
            this.lvList.TabIndex = 38;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.modifyEntryToolStripMenuItem,
            this.deleteEToolStripMenuItem,
            this.toolStripSeparator5,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 98);
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addEntryToolStripMenuItem.Text = "&Add Entry";
            // 
            // modifyEntryToolStripMenuItem
            // 
            this.modifyEntryToolStripMenuItem.Name = "modifyEntryToolStripMenuItem";
            this.modifyEntryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modifyEntryToolStripMenuItem.Text = "&Modify Entry";
            // 
            // deleteEToolStripMenuItem
            // 
            this.deleteEToolStripMenuItem.Name = "deleteEToolStripMenuItem";
            this.deleteEToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteEToolStripMenuItem.Text = "&Delete Entry";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(139, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // btn_close
            // 
            this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 36);
            this.btn_close.Text = "&Close";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // cmdSearch
            // 
            this.cmdSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.Image")));
            this.cmdSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSearch.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(36, 36);
            this.cmdSearch.Text = "Search";
            // 
            // side4
            // 
            this.side4.Name = "side4";
            this.side4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Lastname",
            "Customer No"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 36);
            this.toolStripLabel1.Text = "Search";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(28, 36);
            this.btn_Refresh.Text = "&Refresh";
            // 
            // side3
            // 
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(28, 36);
            this.btn_Delete.Text = "&Void";
            this.btn_Delete.ToolTipText = "Delete";
            // 
            // side2
            // 
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(28, 36);
            this.btn_Edit.Text = "&View";
            // 
            // side1
            // 
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(28, 36);
            this.btn_Add.Text = "&Add ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.side1,
            this.btn_Edit,
            this.side2,
            this.btn_Delete,
            this.side3,
            this.btn_Refresh,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtSearch,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.side4,
            this.cmdSearch,
            this.toolStripSeparator3,
            this.btn_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1081, 39);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmPurchaseOrderReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 606);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPurchaseOrderReturn";
            this.Text = "frmPurchaseOrderReturn";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cmdSearch;
        private System.Windows.Forms.ToolStripSeparator side4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripSeparator side3;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripSeparator side2;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripSeparator side1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}