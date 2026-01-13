namespace RetailToserbaApps.Views.Pages
{
    partial class AddProductForm
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
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.txtItemName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbSupplier = new MaterialSkin.Controls.MaterialComboBox();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSellPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMinimStock = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkExpDate = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(575, 628);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(460, 628);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtItemCode
            // 
            this.txtItemCode.AnimateReadOnly = false;
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Depth = 0;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.LeadingIcon = null;
            this.txtItemCode.Location = new System.Drawing.Point(41, 132);
            this.txtItemCode.MaxLength = 50;
            this.txtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItemCode.Multiline = false;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(254, 50);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.Text = "";
            this.txtItemCode.TrailingIcon = null;
            // 
            // txtItemName
            // 
            this.txtItemName.AnimateReadOnly = false;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Depth = 0;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.LeadingIcon = null;
            this.txtItemName.Location = new System.Drawing.Point(385, 131);
            this.txtItemName.MaxLength = 50;
            this.txtItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItemName.Multiline = false;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(254, 50);
            this.txtItemName.TabIndex = 7;
            this.txtItemName.Text = "";
            this.txtItemName.TrailingIcon = null;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoResize = false;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategory.Depth = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownHeight = 174;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 121;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 43;
            this.cmbCategory.Location = new System.Drawing.Point(41, 235);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(254, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 9;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoResize = false;
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSupplier.Depth = 0;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownHeight = 174;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.DropDownWidth = 121;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.IntegralHeight = false;
            this.cmbSupplier.ItemHeight = 43;
            this.cmbSupplier.Location = new System.Drawing.Point(385, 235);
            this.cmbSupplier.MaxDropDownItems = 4;
            this.cmbSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(254, 49);
            this.cmbSupplier.StartIndex = 0;
            this.cmbSupplier.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(41, 337);
            this.txtQuantity.MaxLength = 50;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(254, 50);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.Text = "";
            this.txtQuantity.TrailingIcon = null;
            // 
            // txtUnit
            // 
            this.txtUnit.AnimateReadOnly = false;
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit.Depth = 0;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.LeadingIcon = null;
            this.txtUnit.Location = new System.Drawing.Point(385, 337);
            this.txtUnit.MaxLength = 50;
            this.txtUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnit.Multiline = false;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(254, 50);
            this.txtUnit.TabIndex = 12;
            this.txtUnit.Text = "";
            this.txtUnit.TrailingIcon = null;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.AnimateReadOnly = false;
            this.txtSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellPrice.Depth = 0;
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellPrice.LeadingIcon = null;
            this.txtSellPrice.Location = new System.Drawing.Point(41, 441);
            this.txtSellPrice.MaxLength = 50;
            this.txtSellPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSellPrice.Multiline = false;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(254, 50);
            this.txtSellPrice.TabIndex = 13;
            this.txtSellPrice.Text = "";
            this.txtSellPrice.TrailingIcon = null;
            // 
            // txtMinimStock
            // 
            this.txtMinimStock.AnimateReadOnly = false;
            this.txtMinimStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinimStock.Depth = 0;
            this.txtMinimStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimStock.LeadingIcon = null;
            this.txtMinimStock.Location = new System.Drawing.Point(385, 441);
            this.txtMinimStock.MaxLength = 50;
            this.txtMinimStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinimStock.Multiline = false;
            this.txtMinimStock.Name = "txtMinimStock";
            this.txtMinimStock.Size = new System.Drawing.Size(254, 50);
            this.txtMinimStock.TabIndex = 14;
            this.txtMinimStock.Text = "";
            this.txtMinimStock.TrailingIcon = null;
            // 
            // dtpExpired
            // 
            this.dtpExpired.Location = new System.Drawing.Point(41, 565);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.Size = new System.Drawing.Size(200, 29);
            this.dtpExpired.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Initial Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selling Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Minimum Stock";
            // 
            // chkExpDate
            // 
            this.chkExpDate.AutoSize = true;
            this.chkExpDate.Depth = 0;
            this.chkExpDate.Location = new System.Drawing.Point(41, 525);
            this.chkExpDate.Margin = new System.Windows.Forms.Padding(0);
            this.chkExpDate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkExpDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkExpDate.Name = "chkExpDate";
            this.chkExpDate.ReadOnly = false;
            this.chkExpDate.Ripple = true;
            this.chkExpDate.Size = new System.Drawing.Size(124, 37);
            this.chkExpDate.TabIndex = 25;
            this.chkExpDate.Text = "Expired Date";
            this.chkExpDate.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 695);
            this.Controls.Add(this.chkExpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpExpired);
            this.Controls.Add(this.txtMinimStock);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox txtItemCode;
        private MaterialSkin.Controls.MaterialTextBox txtItemName;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialComboBox cmbSupplier;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtUnit;
        private MaterialSkin.Controls.MaterialTextBox txtSellPrice;
        private MaterialSkin.Controls.MaterialTextBox txtMinimStock;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialCheckbox chkExpDate;
    }
}