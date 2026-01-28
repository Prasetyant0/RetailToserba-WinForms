namespace RetailToserbaApps.Views.Pages
{
    partial class AddStockForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTambahStock = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.btnSimpan = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Saat Ini";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tambah Stok";
            // 
            // txtTambahStock
            // 
            this.txtTambahStock.AnimateReadOnly = false;
            this.txtTambahStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTambahStock.Depth = 0;
            this.txtTambahStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTambahStock.LeadingIcon = null;
            this.txtTambahStock.Location = new System.Drawing.Point(144, 210);
            this.txtTambahStock.MaxLength = 50;
            this.txtTambahStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTambahStock.Multiline = false;
            this.txtTambahStock.Name = "txtTambahStock";
            this.txtTambahStock.Size = new System.Drawing.Size(149, 50);
            this.txtTambahStock.TabIndex = 4;
            this.txtTambahStock.Text = "";
            this.txtTambahStock.TrailingIcon = null;
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBarang.Location = new System.Drawing.Point(223, 93);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(70, 21);
            this.lblNamaBarang.TabIndex = 7;
            this.lblNamaBarang.Text = "0";
            this.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStok
            // 
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStok.Location = new System.Drawing.Point(223, 173);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(70, 21);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "0";
            this.lblStok.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKode
            // 
            this.lblKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKode.Location = new System.Drawing.Point(223, 133);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(70, 21);
            this.lblKode.TabIndex = 9;
            this.lblKode.Text = "0";
            this.lblKode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSimpan.Depth = 0;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.HighEmphasis = true;
            this.btnSimpan.Icon = null;
            this.btnSimpan.Location = new System.Drawing.Point(226, 312);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSimpan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSimpan.Size = new System.Drawing.Size(77, 36);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSimpan.UseAccentColor = false;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(124, 312);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblNamaBarang);
            this.Controls.Add(this.txtTambahStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtTambahStock;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblKode;
        private MaterialSkin.Controls.MaterialButton btnSimpan;
        private MaterialSkin.Controls.MaterialButton btnCancel;
    }
}