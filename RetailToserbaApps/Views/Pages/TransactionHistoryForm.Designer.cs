namespace RetailToserbaApps.Views.Pages
{
    partial class TransactionHistoryForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVwProduct = new System.Windows.Forms.Button();
            this.btnTrnsHstry = new System.Windows.Forms.Button();
            this.btnPrcSales = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.pictureBoxTrnsHistory = new System.Windows.Forms.PictureBox();
            this.lblCshId = new System.Windows.Forms.Label();
            this.lblCshName = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbAll = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblCshValue = new System.Windows.Forms.Label();
            this.lblPymntMthdValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTrnsIDValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClsDetail = new MaterialSkin.Controls.MaterialButton();
            this.btnPrntInvoice = new MaterialSkin.Controls.MaterialButton();
            this.lvwTrnsHistory = new MaterialSkin.Controls.MaterialListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrnsHistory)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnVwProduct);
            this.panel1.Controls.Add(this.btnTrnsHstry);
            this.panel1.Controls.Add(this.btnPrcSales);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1013);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::RetailToserbaApps.Properties.Resources.icons8_logout_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 253);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 42);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVwProduct
            // 
            this.btnVwProduct.FlatAppearance.BorderSize = 0;
            this.btnVwProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwProduct.Image = global::RetailToserbaApps.Properties.Resources.icons8_view_32;
            this.btnVwProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVwProduct.Location = new System.Drawing.Point(3, 157);
            this.btnVwProduct.Name = "btnVwProduct";
            this.btnVwProduct.Size = new System.Drawing.Size(212, 42);
            this.btnVwProduct.TabIndex = 2;
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
            this.btnTrnsHstry.Location = new System.Drawing.Point(3, 205);
            this.btnTrnsHstry.Name = "btnTrnsHstry";
            this.btnTrnsHstry.Size = new System.Drawing.Size(212, 42);
            this.btnTrnsHstry.TabIndex = 4;
            this.btnTrnsHstry.Text = "  Transaction History";
            this.btnTrnsHstry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrnsHstry.UseVisualStyleBackColor = true;
            this.btnTrnsHstry.Click += new System.EventHandler(this.btnTrnsHstry_Click);
            // 
            // btnPrcSales
            // 
            this.btnPrcSales.FlatAppearance.BorderSize = 0;
            this.btnPrcSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrcSales.Image = global::RetailToserbaApps.Properties.Resources.icons8_transaction_32;
            this.btnPrcSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrcSales.Location = new System.Drawing.Point(3, 109);
            this.btnPrcSales.Name = "btnPrcSales";
            this.btnPrcSales.Size = new System.Drawing.Size(212, 42);
            this.btnPrcSales.TabIndex = 1;
            this.btnPrcSales.Text = "  Process Sales";
            this.btnPrcSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrcSales.UseVisualStyleBackColor = true;
            this.btnPrcSales.Click += new System.EventHandler(this.btnPrcSales_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.pictureBoxTrnsHistory);
            this.panel2.Controls.Add(this.lblCshId);
            this.panel2.Controls.Add(this.lblCshName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(85, 64);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 17);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Cashier";
            // 
            // pictureBoxTrnsHistory
            // 
            this.pictureBoxTrnsHistory.Image = global::RetailToserbaApps.Properties.Resources.icons8_user_80;
            this.pictureBoxTrnsHistory.Location = new System.Drawing.Point(9, 23);
            this.pictureBoxTrnsHistory.Name = "pictureBoxTrnsHistory";
            this.pictureBoxTrnsHistory.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxTrnsHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrnsHistory.TabIndex = 0;
            this.pictureBoxTrnsHistory.TabStop = false;
            // 
            // lblCshId
            // 
            this.lblCshId.AutoSize = true;
            this.lblCshId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshId.Location = new System.Drawing.Point(85, 44);
            this.lblCshId.Name = "lblCshId";
            this.lblCshId.Size = new System.Drawing.Size(50, 17);
            this.lblCshId.TabIndex = 2;
            this.lblCshId.Text = "Cash00";
            // 
            // lblCshName
            // 
            this.lblCshName.AutoSize = true;
            this.lblCshName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshName.Location = new System.Drawing.Point(84, 23);
            this.lblCshName.Name = "lblCshName";
            this.lblCshName.Size = new System.Drawing.Size(82, 21);
            this.lblCshName.TabIndex = 1;
            this.lblCshName.Text = "John Doe";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cmbAll);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.dtpTo);
            this.materialCard1.Controls.Add(this.txtSearch);
            this.materialCard1.Controls.Add(this.dtpFrom);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(250, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1603, 100);
            this.materialCard1.TabIndex = 1;
            // 
            // cmbAll
            // 
            this.cmbAll.AutoResize = false;
            this.cmbAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAll.Depth = 0;
            this.cmbAll.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAll.DropDownHeight = 174;
            this.cmbAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAll.DropDownWidth = 121;
            this.cmbAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAll.FormattingEnabled = true;
            this.cmbAll.IntegralHeight = false;
            this.cmbAll.ItemHeight = 43;
            this.cmbAll.Location = new System.Drawing.Point(1433, 28);
            this.cmbAll.MaxDropDownItems = 4;
            this.cmbAll.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAll.Name = "cmbAll";
            this.cmbAll.Size = new System.Drawing.Size(121, 49);
            this.cmbAll.StartIndex = 0;
            this.cmbAll.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1112, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1172, 41);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(204, 29);
            this.dtpTo.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(33, 27);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(716, 50);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(872, 41);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(204, 29);
            this.dtpFrom.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialListView1);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.lblDateValue);
            this.materialCard2.Controls.Add(this.lblCshValue);
            this.materialCard2.Controls.Add(this.lblPymntMthdValue);
            this.materialCard2.Controls.Add(this.label11);
            this.materialCard2.Controls.Add(this.label10);
            this.materialCard2.Controls.Add(this.label9);
            this.materialCard2.Controls.Add(this.label8);
            this.materialCard2.Controls.Add(this.lblTrnsIDValue);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.btnClsDetail);
            this.materialCard2.Controls.Add(this.btnPrntInvoice);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(250, 500);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1603, 563);
            this.materialCard2.TabIndex = 2;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(33, 273);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1535, 208);
            this.materialListView1.TabIndex = 19;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Items";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateValue.Location = new System.Drawing.Point(80, 108);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(156, 21);
            this.lblDateValue.TabIndex = 17;
            this.lblDateValue.Text = "2025-01-09 9:23 AM";
            // 
            // lblCshValue
            // 
            this.lblCshValue.AutoSize = true;
            this.lblCshValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshValue.Location = new System.Drawing.Point(100, 139);
            this.lblCshValue.Name = "lblCshValue";
            this.lblCshValue.Size = new System.Drawing.Size(75, 21);
            this.lblCshValue.TabIndex = 16;
            this.lblCshValue.Text = "John Doe";
            // 
            // lblPymntMthdValue
            // 
            this.lblPymntMthdValue.AutoSize = true;
            this.lblPymntMthdValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPymntMthdValue.Location = new System.Drawing.Point(164, 170);
            this.lblPymntMthdValue.Name = "lblPymntMthdValue";
            this.lblPymntMthdValue.Size = new System.Drawing.Size(44, 21);
            this.lblPymntMthdValue.TabIndex = 15;
            this.lblPymntMthdValue.Text = "Cash";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Transaction ID: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cashier:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Payment Method:";
            // 
            // lblTrnsIDValue
            // 
            this.lblTrnsIDValue.AutoSize = true;
            this.lblTrnsIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrnsIDValue.Location = new System.Drawing.Point(133, 76);
            this.lblTrnsIDValue.Name = "lblTrnsIDValue";
            this.lblTrnsIDValue.Size = new System.Drawing.Size(64, 21);
            this.lblTrnsIDValue.TabIndex = 6;
            this.lblTrnsIDValue.Text = "TRX001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Transaction Details";
            // 
            // btnClsDetail
            // 
            this.btnClsDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClsDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClsDetail.Depth = 0;
            this.btnClsDetail.HighEmphasis = true;
            this.btnClsDetail.Icon = null;
            this.btnClsDetail.Location = new System.Drawing.Point(1449, 507);
            this.btnClsDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClsDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClsDetail.Name = "btnClsDetail";
            this.btnClsDetail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClsDetail.Size = new System.Drawing.Size(119, 36);
            this.btnClsDetail.TabIndex = 4;
            this.btnClsDetail.Text = "Close Detail";
            this.btnClsDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClsDetail.UseAccentColor = false;
            this.btnClsDetail.UseVisualStyleBackColor = true;
            // 
            // btnPrntInvoice
            // 
            this.btnPrntInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrntInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrntInvoice.Depth = 0;
            this.btnPrntInvoice.HighEmphasis = true;
            this.btnPrntInvoice.Icon = null;
            this.btnPrntInvoice.Location = new System.Drawing.Point(1281, 507);
            this.btnPrntInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrntInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrntInvoice.Name = "btnPrntInvoice";
            this.btnPrntInvoice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrntInvoice.Size = new System.Drawing.Size(124, 36);
            this.btnPrntInvoice.TabIndex = 0;
            this.btnPrntInvoice.Text = "Print Invoice";
            this.btnPrntInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrntInvoice.UseAccentColor = false;
            this.btnPrntInvoice.UseVisualStyleBackColor = true;
            // 
            // lvwTrnsHistory
            // 
            this.lvwTrnsHistory.AutoSizeTable = false;
            this.lvwTrnsHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvwTrnsHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwTrnsHistory.Depth = 0;
            this.lvwTrnsHistory.FullRowSelect = true;
            this.lvwTrnsHistory.HideSelection = false;
            this.lvwTrnsHistory.Location = new System.Drawing.Point(250, 221);
            this.lvwTrnsHistory.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvwTrnsHistory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvwTrnsHistory.MouseState = MaterialSkin.MouseState.OUT;
            this.lvwTrnsHistory.Name = "lvwTrnsHistory";
            this.lvwTrnsHistory.OwnerDraw = true;
            this.lvwTrnsHistory.Size = new System.Drawing.Size(1603, 225);
            this.lvwTrnsHistory.TabIndex = 3;
            this.lvwTrnsHistory.UseCompatibleStateImageBehavior = false;
            this.lvwTrnsHistory.View = System.Windows.Forms.View.Details;
            this.lvwTrnsHistory.SelectedIndexChanged += new System.EventHandler(this.LvwTrnsHistory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click a transaction to view details";
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwTrnsHistory);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransactionHistoryForm";
            this.Text = "Transaction History";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrnsHistory)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrcSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxTrnsHistory;
        private System.Windows.Forms.Label lblCshName;
        private System.Windows.Forms.Label lblCshId;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVwProduct;
        private System.Windows.Forms.Button btnTrnsHstry;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialListView lvwTrnsHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MaterialSkin.Controls.MaterialComboBox cmbAll;
        private MaterialSkin.Controls.MaterialButton btnPrntInvoice;
        private MaterialSkin.Controls.MaterialButton btnClsDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTrnsIDValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblCshValue;
        private System.Windows.Forms.Label lblPymntMthdValue;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.Label label5;
    }
}