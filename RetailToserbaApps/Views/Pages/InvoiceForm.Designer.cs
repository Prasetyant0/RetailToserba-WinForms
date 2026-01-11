namespace RetailToserbaApps.Views.Pages
{
    partial class InvoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblCshName = new System.Windows.Forms.Label();
            this.lblInvoiceValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvwInvoice = new MaterialSkin.Controls.MaterialListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGrandTtlValue = new System.Windows.Forms.Label();
            this.lblPaidValue = new System.Windows.Forms.Label();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jannah Toserba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 571);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total:";
            // 
            // lblDateValue
            // 
            this.lblDateValue.Location = new System.Drawing.Point(210, 217);
            this.lblDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(183, 21);
            this.lblDateValue.TabIndex = 3;
            this.lblDateValue.Text = "2026-01-09 9:23 AM";
            this.lblDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCshName
            // 
            this.lblCshName.Location = new System.Drawing.Point(214, 179);
            this.lblCshName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCshName.Name = "lblCshName";
            this.lblCshName.Size = new System.Drawing.Size(179, 21);
            this.lblCshName.TabIndex = 4;
            this.lblCshName.Text = "John Doe";
            this.lblCshName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInvoiceValue
            // 
            this.lblInvoiceValue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInvoiceValue.Location = new System.Drawing.Point(218, 143);
            this.lblInvoiceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceValue.Name = "lblInvoiceValue";
            this.lblInvoiceValue.Size = new System.Drawing.Size(175, 21);
            this.lblInvoiceValue.TabIndex = 5;
            this.lblInvoiceValue.Text = "INV003";
            this.lblInvoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cashier Name";
            // 
            // lvwInvoice
            // 
            this.lvwInvoice.AutoSizeTable = false;
            this.lvwInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvwInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwInvoice.Depth = 0;
            this.lvwInvoice.FullRowSelect = true;
            this.lvwInvoice.HideSelection = false;
            this.lvwInvoice.Location = new System.Drawing.Point(35, 270);
            this.lvwInvoice.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvwInvoice.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvwInvoice.MouseState = MaterialSkin.MouseState.OUT;
            this.lvwInvoice.Name = "lvwInvoice";
            this.lvwInvoice.OwnerDraw = true;
            this.lvwInvoice.Size = new System.Drawing.Size(357, 277);
            this.lvwInvoice.TabIndex = 8;
            this.lvwInvoice.UseCompatibleStateImageBehavior = false;
            this.lvwInvoice.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 633);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 602);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Paid: ";
            // 
            // lblGrandTtlValue
            // 
            this.lblGrandTtlValue.Location = new System.Drawing.Point(254, 571);
            this.lblGrandTtlValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTtlValue.Name = "lblGrandTtlValue";
            this.lblGrandTtlValue.Size = new System.Drawing.Size(139, 21);
            this.lblGrandTtlValue.TabIndex = 11;
            this.lblGrandTtlValue.Text = "Rp70.000";
            this.lblGrandTtlValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPaidValue
            // 
            this.lblPaidValue.Location = new System.Drawing.Point(254, 602);
            this.lblPaidValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaidValue.Name = "lblPaidValue";
            this.lblPaidValue.Size = new System.Drawing.Size(138, 21);
            this.lblPaidValue.TabIndex = 13;
            this.lblPaidValue.Text = "Rp.70.000";
            this.lblPaidValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.Location = new System.Drawing.Point(254, 633);
            this.lblChangeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(138, 21);
            this.lblChangeValue.TabIndex = 14;
            this.lblChangeValue.Text = "Rp0";
            this.lblChangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jl. Malioboro No. 17, Kec. Danurejan, ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kota Yogyakarta, Daerah Istimewa Yogyakarta, ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "55213";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(235, 703);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(64, 36);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(328, 703);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 769);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblChangeValue);
            this.Controls.Add(this.lblPaidValue);
            this.Controls.Add(this.lblGrandTtlValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblInvoiceValue);
            this.Controls.Add(this.lblCshName);
            this.Controls.Add(this.lblDateValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblCshName;
        private System.Windows.Forms.Label lblInvoiceValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialListView lvwInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGrandTtlValue;
        private System.Windows.Forms.Label lblPaidValue;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}