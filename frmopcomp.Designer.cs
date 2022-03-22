namespace Accounting_Sys
{
    partial class frmopcomp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmopcomp));
            this.OKButton = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(493, 292);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 24);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Location = new System.Drawing.Point(212, 100);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(7, 4, 3, 4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(368, 184);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TabStop = false;
            this.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
            // 
            // LabelCompanyName
            // 
            this.LabelCompanyName.BackColor = System.Drawing.Color.Blue;
            this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCompanyName.Location = new System.Drawing.Point(212, 72);
            this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 22);
            this.LabelCompanyName.Name = "LabelCompanyName";
            this.LabelCompanyName.Size = new System.Drawing.Size(368, 22);
            this.LabelCompanyName.TabIndex = 0;
            this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVersion.Location = new System.Drawing.Point(212, 32);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 22);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(368, 22);
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = " Current User";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelProductName
            // 
            this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProductName.Location = new System.Drawing.Point(212, 0);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 22);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(368, 22);
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "Company Name";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 4);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            this.LogoPictureBox.Size = new System.Drawing.Size(199, 312);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Visible = false;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.20337F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.79663F));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(583, 320);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // frmopcomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 320);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmopcomp";
            this.Text = "frmopcomp";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label LabelCompanyName;
        internal System.Windows.Forms.Label LabelVersion;
        internal System.Windows.Forms.Label LabelProductName;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel;

    }
}