namespace RetailToserbaApps.Views.Pages
{
    partial class ViewProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVwProduct = new System.Windows.Forms.Button();
            this.btnTrnsHstry = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrcSales = new System.Windows.Forms.Button();
            this.pictureBoxViewProd = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCshId = new System.Windows.Forms.Label();
            this.lblCshName = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtSearchItem = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbSupplier = new MaterialSkin.Controls.MaterialComboBox();
            this.lvwViewProduct = new MaterialSkin.Controls.MaterialListView();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btn1 = new MaterialSkin.Controls.MaterialButton();
            this.btn2 = new MaterialSkin.Controls.MaterialButton();
            this.btn3 = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewProd)).BeginInit();
            this.panel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVwProduct);
            this.panel1.Controls.Add(this.btnTrnsHstry);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPrcSales);
            this.panel1.Controls.Add(this.pictureBoxViewProd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1013);
            this.panel1.TabIndex = 0;
            // 
            // btnVwProduct
            // 
            this.btnVwProduct.FlatAppearance.BorderSize = 0;
            this.btnVwProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwProduct.Image = global::RetailToserbaApps.Properties.Resources.icons8_view_32;
            this.btnVwProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVwProduct.Location = new System.Drawing.Point(3, 161);
            this.btnVwProduct.Name = "btnVwProduct";
            this.btnVwProduct.Size = new System.Drawing.Size(212, 46);
            this.btnVwProduct.TabIndex = 7;
            this.btnVwProduct.Text = "  View Product";
            this.btnVwProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVwProduct.UseVisualStyleBackColor = true;
            this.btnVwProduct.Click += new System.EventHandler(this.btnVwProduct_Click);
            // 
            // btnTrnsHstry
            // 
            this.btnTrnsHstry.FlatAppearance.BorderSize = 0;
            this.btnTrnsHstry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrnsHstry.Image = global::RetailToserbaApps.Properties.Resources.icons8_history_32;
            this.btnTrnsHstry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrnsHstry.Location = new System.Drawing.Point(3, 213);
            this.btnTrnsHstry.Name = "btnTrnsHstry";
            this.btnTrnsHstry.Size = new System.Drawing.Size(212, 46);
            this.btnTrnsHstry.TabIndex = 6;
            this.btnTrnsHstry.Text = "  Transaction History";
            this.btnTrnsHstry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrnsHstry.UseVisualStyleBackColor = true;
            this.btnTrnsHstry.Click += new System.EventHandler(this.btnTrnsHstry_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::RetailToserbaApps.Properties.Resources.icons8_logout_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 265);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 46);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPrcSales
            // 
            this.btnPrcSales.FlatAppearance.BorderSize = 0;
            this.btnPrcSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrcSales.Image = global::RetailToserbaApps.Properties.Resources.icons8_transaction_32;
            this.btnPrcSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrcSales.Location = new System.Drawing.Point(3, 109);
            this.btnPrcSales.Name = "btnPrcSales";
            this.btnPrcSales.Size = new System.Drawing.Size(212, 46);
            this.btnPrcSales.TabIndex = 4;
            this.btnPrcSales.Text = "  Process Sales";
            this.btnPrcSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrcSales.UseVisualStyleBackColor = true;
            this.btnPrcSales.Click += new System.EventHandler(this.btnPrcSales_Click);
            // 
            // pictureBoxViewProd
            // 
            this.pictureBoxViewProd.Image = global::RetailToserbaApps.Properties.Resources.icons8_user_80;
            this.pictureBoxViewProd.Location = new System.Drawing.Point(9, 23);
            this.pictureBoxViewProd.Name = "pictureBoxViewProd";
            this.pictureBoxViewProd.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxViewProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxViewProd.TabIndex = 0;
            this.pictureBoxViewProd.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.lblCshId);
            this.panel2.Controls.Add(this.lblCshName);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(77, 66);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 17);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Cashier";
            // 
            // lblCshId
            // 
            this.lblCshId.AutoSize = true;
            this.lblCshId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshId.Location = new System.Drawing.Point(78, 46);
            this.lblCshId.Name = "lblCshId";
            this.lblCshId.Size = new System.Drawing.Size(50, 17);
            this.lblCshId.TabIndex = 3;
            this.lblCshId.Text = "Cash00";
            // 
            // lblCshName
            // 
            this.lblCshName.AutoSize = true;
            this.lblCshName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshName.Location = new System.Drawing.Point(77, 25);
            this.lblCshName.Name = "lblCshName";
            this.lblCshName.Size = new System.Drawing.Size(82, 21);
            this.lblCshName.TabIndex = 1;
            this.lblCshName.Text = "John Doe";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSearchItem);
            this.materialCard1.Controls.Add(this.cmbCategory);
            this.materialCard1.Controls.Add(this.cmbSupplier);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(250, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1606, 92);
            this.materialCard1.TabIndex = 1;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.AnimateReadOnly = false;
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchItem.Depth = 0;
            this.txtSearchItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchItem.LeadingIcon = null;
            this.txtSearchItem.Location = new System.Drawing.Point(32, 25);
            this.txtSearchItem.MaxLength = 50;
            this.txtSearchItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchItem.Multiline = false;
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(838, 50);
            this.txtSearchItem.TabIndex = 3;
            this.txtSearchItem.Text = "";
            this.txtSearchItem.TrailingIcon = null;
            this.txtSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchItem_KeyDown);
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
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 43;
            this.cmbCategory.Location = new System.Drawing.Point(1116, 25);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(194, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 2;
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
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.IntegralHeight = false;
            this.cmbSupplier.ItemHeight = 43;
            this.cmbSupplier.Location = new System.Drawing.Point(1368, 25);
            this.cmbSupplier.MaxDropDownItems = 4;
            this.cmbSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(194, 49);
            this.cmbSupplier.StartIndex = 0;
            this.cmbSupplier.TabIndex = 1;
            // 
            // lvwViewProduct
            // 
            this.lvwViewProduct.AutoSizeTable = false;
            this.lvwViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvwViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwViewProduct.Depth = 0;
            this.lvwViewProduct.FullRowSelect = true;
            this.lvwViewProduct.HideSelection = false;
            this.lvwViewProduct.Location = new System.Drawing.Point(253, 194);
            this.lvwViewProduct.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvwViewProduct.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvwViewProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.lvwViewProduct.Name = "lvwViewProduct";
            this.lvwViewProduct.OwnerDraw = true;
            this.lvwViewProduct.Size = new System.Drawing.Size(1603, 539);
            this.lvwViewProduct.TabIndex = 2;
            this.lvwViewProduct.UseCompatibleStateImageBehavior = false;
            this.lvwViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(1454, 760);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(91, 36);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn1.Depth = 0;
            this.btn1.HighEmphasis = true;
            this.btn1.Icon = null;
            this.btn1.Location = new System.Drawing.Point(1564, 760);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn1.Size = new System.Drawing.Size(64, 36);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn1.UseAccentColor = false;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn2.Depth = 0;
            this.btn2.HighEmphasis = true;
            this.btn2.Icon = null;
            this.btn2.Location = new System.Drawing.Point(1636, 760);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn2.Name = "btn2";
            this.btn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn2.Size = new System.Drawing.Size(64, 36);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn2.UseAccentColor = false;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn3.Depth = 0;
            this.btn3.HighEmphasis = true;
            this.btn3.Icon = null;
            this.btn3.Location = new System.Drawing.Point(1708, 760);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn3.Name = "btn3";
            this.btn3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn3.Size = new System.Drawing.Size(64, 36);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn3.UseAccentColor = false;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(1791, 760);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(64, 36);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 751);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Showing 1 to 5 of 50 entries";
            // 
            // ViewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lvwViewProduct);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewProductForm";
            this.Text = "View Products";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewProd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCshId;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblCshName;
        private System.Windows.Forms.PictureBox pictureBoxViewProd;
        private System.Windows.Forms.Button btnPrcSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVwProduct;
        private System.Windows.Forms.Button btnTrnsHstry;
        private System.Windows.Forms.Button btnLogout;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtSearchItem;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialComboBox cmbSupplier;
        private MaterialSkin.Controls.MaterialListView lvwViewProduct;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btn1;
        private MaterialSkin.Controls.MaterialButton btn2;
        private MaterialSkin.Controls.MaterialButton btn3;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private System.Windows.Forms.Label label2;
    }
}