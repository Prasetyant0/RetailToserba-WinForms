namespace RetailToserbaApps.Views.Dashboard
{
    partial class CashierForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCshId = new System.Windows.Forms.Label();
            this.lblCshName = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.txtQty = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSearchItem = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbSelectItem = new MaterialSkin.Controls.MaterialComboBox();
            this.lblItmSelect = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.cardChange = new MaterialSkin.Controls.MaterialCard();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPymntMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustCash = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPymntSum = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnClearCart = new MaterialSkin.Controls.MaterialButton();
            this.btnProcess = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintInv = new MaterialSkin.Controls.MaterialButton();
            this.lblPaymentValue = new System.Windows.Forms.Label();
            this.lblItemsValue = new System.Windows.Forms.Label();
            this.lvwCart = new MaterialSkin.Controls.MaterialListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTrnsHstry = new System.Windows.Forms.Button();
            this.btnVwProduct = new System.Windows.Forms.Button();
            this.btnPrcSales = new System.Windows.Forms.Button();
            this.pictureBoxCashier = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.cardChange.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnTrnsHstry);
            this.panelLeft.Controls.Add(this.btnVwProduct);
            this.panelLeft.Controls.Add(this.btnPrcSales);
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(218, 1013);
            this.panelLeft.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblRole);
            this.panel4.Controls.Add(this.pictureBoxCashier);
            this.panel4.Controls.Add(this.lblCshId);
            this.panel4.Controls.Add(this.lblCshName);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 100);
            this.panel4.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(78, 66);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 17);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Cashier";
            // 
            // lblCshId
            // 
            this.lblCshId.AutoSize = true;
            this.lblCshId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshId.Location = new System.Drawing.Point(77, 46);
            this.lblCshId.Name = "lblCshId";
            this.lblCshId.Size = new System.Drawing.Size(50, 17);
            this.lblCshId.TabIndex = 1;
            this.lblCshId.Text = "Cash00";
            // 
            // lblCshName
            // 
            this.lblCshName.AutoSize = true;
            this.lblCshName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCshName.Location = new System.Drawing.Point(77, 25);
            this.lblCshName.Name = "lblCshName";
            this.lblCshName.Size = new System.Drawing.Size(82, 21);
            this.lblCshName.TabIndex = 0;
            this.lblCshName.Text = "John Doe";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnAdd);
            this.materialCard1.Controls.Add(this.txtQty);
            this.materialCard1.Controls.Add(this.txtSearchItem);
            this.materialCard1.Controls.Add(this.cmbSelectItem);
            this.materialCard1.Controls.Add(this.lblItmSelect);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(238, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1071, 141);
            this.materialCard1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(909, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.AnimateReadOnly = false;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Depth = 0;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.LeadingIcon = null;
            this.txtQty.Location = new System.Drawing.Point(790, 55);
            this.txtQty.MaxLength = 50;
            this.txtQty.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(85, 50);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "";
            this.txtQty.TrailingIcon = null;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.AnimateReadOnly = false;
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchItem.Depth = 0;
            this.txtSearchItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.LeadingIcon = null;
            this.txtSearchItem.Location = new System.Drawing.Point(21, 55);
            this.txtSearchItem.MaxLength = 50;
            this.txtSearchItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchItem.Multiline = false;
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(497, 50);
            this.txtSearchItem.TabIndex = 2;
            this.txtSearchItem.Text = "";
            this.txtSearchItem.TrailingIcon = null;
            // 
            // cmbSelectItem
            // 
            this.cmbSelectItem.AutoResize = false;
            this.cmbSelectItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSelectItem.Depth = 0;
            this.cmbSelectItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSelectItem.DropDownHeight = 174;
            this.cmbSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectItem.DropDownWidth = 121;
            this.cmbSelectItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSelectItem.FormattingEnabled = true;
            this.cmbSelectItem.IntegralHeight = false;
            this.cmbSelectItem.ItemHeight = 43;
            this.cmbSelectItem.Location = new System.Drawing.Point(553, 56);
            this.cmbSelectItem.MaxDropDownItems = 4;
            this.cmbSelectItem.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSelectItem.Name = "cmbSelectItem";
            this.cmbSelectItem.Size = new System.Drawing.Size(200, 49);
            this.cmbSelectItem.StartIndex = 0;
            this.cmbSelectItem.TabIndex = 1;
            // 
            // lblItmSelect
            // 
            this.lblItmSelect.AutoSize = true;
            this.lblItmSelect.Location = new System.Drawing.Point(17, 14);
            this.lblItmSelect.Name = "lblItmSelect";
            this.lblItmSelect.Size = new System.Drawing.Size(108, 21);
            this.lblItmSelect.TabIndex = 0;
            this.lblItmSelect.Text = "Item Selection";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblItemsValue);
            this.materialCard2.Controls.Add(this.lblPaymentValue);
            this.materialCard2.Controls.Add(this.btnPrintInv);
            this.materialCard2.Controls.Add(this.btnProcess);
            this.materialCard2.Controls.Add(this.btnClearCart);
            this.materialCard2.Controls.Add(this.cardChange);
            this.materialCard2.Controls.Add(this.cmbPymntMethod);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.txtCustCash);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.lblPymntSum);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(1363, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(444, 936);
            this.materialCard2.TabIndex = 3;
            // 
            // cardChange
            // 
            this.cardChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardChange.Controls.Add(this.lblChangeValue);
            this.cardChange.Controls.Add(this.label6);
            this.cardChange.Depth = 0;
            this.cardChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardChange.Location = new System.Drawing.Point(41, 434);
            this.cardChange.Margin = new System.Windows.Forms.Padding(14);
            this.cardChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardChange.Name = "cardChange";
            this.cardChange.Padding = new System.Windows.Forms.Padding(14);
            this.cardChange.Size = new System.Drawing.Size(355, 90);
            this.cardChange.TabIndex = 7;
            this.cardChange.Paint += new System.Windows.Forms.PaintEventHandler(this.cardChange_Paint);
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.Location = new System.Drawing.Point(173, 34);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(144, 28);
            this.lblChangeValue.TabIndex = 1;
            this.lblChangeValue.Text = "Rp0";
            this.lblChangeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Change:";
            // 
            // cmbPymntMethod
            // 
            this.cmbPymntMethod.AutoResize = false;
            this.cmbPymntMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPymntMethod.Depth = 0;
            this.cmbPymntMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPymntMethod.DropDownHeight = 174;
            this.cmbPymntMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPymntMethod.DropDownWidth = 121;
            this.cmbPymntMethod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPymntMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPymntMethod.FormattingEnabled = true;
            this.cmbPymntMethod.IntegralHeight = false;
            this.cmbPymntMethod.ItemHeight = 43;
            this.cmbPymntMethod.Location = new System.Drawing.Point(41, 340);
            this.cmbPymntMethod.MaxDropDownItems = 4;
            this.cmbPymntMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPymntMethod.Name = "cmbPymntMethod";
            this.cmbPymntMethod.Size = new System.Drawing.Size(355, 49);
            this.cmbPymntMethod.StartIndex = 0;
            this.cmbPymntMethod.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Payment Method";
            // 
            // txtCustCash
            // 
            this.txtCustCash.AnimateReadOnly = false;
            this.txtCustCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustCash.Depth = 0;
            this.txtCustCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCash.LeadingIcon = null;
            this.txtCustCash.Location = new System.Drawing.Point(41, 228);
            this.txtCustCash.MaxLength = 50;
            this.txtCustCash.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustCash.Multiline = false;
            this.txtCustCash.Name = "txtCustCash";
            this.txtCustCash.Size = new System.Drawing.Size(355, 50);
            this.txtCustCash.TabIndex = 4;
            this.txtCustCash.Text = "";
            this.txtCustCash.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Cash (Rp)";
            // 
            // lblPymntSum
            // 
            this.lblPymntSum.AutoSize = true;
            this.lblPymntSum.Location = new System.Drawing.Point(37, 35);
            this.lblPymntSum.Name = "lblPymntSum";
            this.lblPymntSum.Size = new System.Drawing.Size(142, 21);
            this.lblPymntSum.TabIndex = 0;
            this.lblPymntSum.Text = "Payment Summary";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lvwCart);
            this.materialCard3.Controls.Add(this.lblCart);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(238, 247);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1071, 767);
            this.materialCard3.TabIndex = 4;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(17, 30);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(39, 21);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "Cart";
            // 
            // btnClearCart
            // 
            this.btnClearCart.AutoSize = false;
            this.btnClearCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearCart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearCart.Depth = 0;
            this.btnClearCart.HighEmphasis = true;
            this.btnClearCart.Icon = null;
            this.btnClearCart.Location = new System.Drawing.Point(41, 676);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearCart.Size = new System.Drawing.Size(355, 51);
            this.btnClearCart.TabIndex = 9;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearCart.UseAccentColor = false;
            this.btnClearCart.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.AutoSize = false;
            this.btnProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcess.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcess.Depth = 0;
            this.btnProcess.HighEmphasis = true;
            this.btnProcess.Icon = null;
            this.btnProcess.Location = new System.Drawing.Point(41, 758);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcess.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcess.Size = new System.Drawing.Size(355, 51);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process Payment";
            this.btnProcess.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcess.UseAccentColor = false;
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnPrintInv
            // 
            this.btnPrintInv.AutoSize = false;
            this.btnPrintInv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintInv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintInv.Depth = 0;
            this.btnPrintInv.HighEmphasis = true;
            this.btnPrintInv.Icon = null;
            this.btnPrintInv.Location = new System.Drawing.Point(41, 840);
            this.btnPrintInv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintInv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintInv.Size = new System.Drawing.Size(355, 51);
            this.btnPrintInv.TabIndex = 11;
            this.btnPrintInv.Text = "Print Invoice";
            this.btnPrintInv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintInv.UseAccentColor = false;
            this.btnPrintInv.UseVisualStyleBackColor = true;
            // 
            // lblPaymentValue
            // 
            this.lblPaymentValue.Location = new System.Drawing.Point(214, 137);
            this.lblPaymentValue.Name = "lblPaymentValue";
            this.lblPaymentValue.Size = new System.Drawing.Size(158, 31);
            this.lblPaymentValue.TabIndex = 12;
            this.lblPaymentValue.Text = "Rp70.000";
            this.lblPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemsValue
            // 
            this.lblItemsValue.Location = new System.Drawing.Point(210, 103);
            this.lblItemsValue.Name = "lblItemsValue";
            this.lblItemsValue.Size = new System.Drawing.Size(162, 21);
            this.lblItemsValue.TabIndex = 13;
            this.lblItemsValue.Text = "9";
            this.lblItemsValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvwCart
            // 
            this.lvwCart.AutoSizeTable = false;
            this.lvwCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvwCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwCart.Depth = 0;
            this.lvwCart.FullRowSelect = true;
            this.lvwCart.HideSelection = false;
            this.lvwCart.Location = new System.Drawing.Point(19, 79);
            this.lvwCart.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvwCart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvwCart.MouseState = MaterialSkin.MouseState.OUT;
            this.lvwCart.Name = "lvwCart";
            this.lvwCart.OwnerDraw = true;
            this.lvwCart.Size = new System.Drawing.Size(1035, 643);
            this.lvwCart.TabIndex = 1;
            this.lvwCart.UseCompatibleStateImageBehavior = false;
            this.lvwCart.View = System.Windows.Forms.View.Details;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::RetailToserbaApps.Properties.Resources.icons8_logout_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 265);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnTrnsHstry
            // 
            this.btnTrnsHstry.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrnsHstry.FlatAppearance.BorderSize = 0;
            this.btnTrnsHstry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrnsHstry.Image = global::RetailToserbaApps.Properties.Resources.icons8_history_32;
            this.btnTrnsHstry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrnsHstry.Location = new System.Drawing.Point(3, 213);
            this.btnTrnsHstry.Name = "btnTrnsHstry";
            this.btnTrnsHstry.Size = new System.Drawing.Size(212, 46);
            this.btnTrnsHstry.TabIndex = 3;
            this.btnTrnsHstry.Text = "  Transaction History";
            this.btnTrnsHstry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrnsHstry.UseVisualStyleBackColor = false;
            // 
            // btnVwProduct
            // 
            this.btnVwProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnVwProduct.FlatAppearance.BorderSize = 0;
            this.btnVwProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVwProduct.Image = global::RetailToserbaApps.Properties.Resources.icons8_view_32;
            this.btnVwProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVwProduct.Location = new System.Drawing.Point(3, 161);
            this.btnVwProduct.Name = "btnVwProduct";
            this.btnVwProduct.Size = new System.Drawing.Size(212, 46);
            this.btnVwProduct.TabIndex = 2;
            this.btnVwProduct.Text = "  View Product";
            this.btnVwProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVwProduct.UseVisualStyleBackColor = false;
            // 
            // btnPrcSales
            // 
            this.btnPrcSales.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrcSales.FlatAppearance.BorderSize = 0;
            this.btnPrcSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrcSales.Image = global::RetailToserbaApps.Properties.Resources.icons8_transaction_32;
            this.btnPrcSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrcSales.Location = new System.Drawing.Point(3, 109);
            this.btnPrcSales.Name = "btnPrcSales";
            this.btnPrcSales.Size = new System.Drawing.Size(212, 46);
            this.btnPrcSales.TabIndex = 1;
            this.btnPrcSales.Text = "  Process Sales";
            this.btnPrcSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrcSales.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCashier
            // 
            this.pictureBoxCashier.Image = global::RetailToserbaApps.Properties.Resources.icons8_user_80;
            this.pictureBoxCashier.Location = new System.Drawing.Point(9, 23);
            this.pictureBoxCashier.Name = "pictureBoxCashier";
            this.pictureBoxCashier.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCashier.TabIndex = 2;
            this.pictureBoxCashier.TabStop = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cardChange_Paint);
            this.panelLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.cardChange.ResumeLayout(false);
            this.cardChange.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblCshId;
        private System.Windows.Forms.Label lblCshName;
        private System.Windows.Forms.PictureBox pictureBoxCashier;
        private System.Windows.Forms.Button btnPrcSales;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTrnsHstry;
        private System.Windows.Forms.Button btnVwProduct;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label lblItmSelect;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtQty;
        private MaterialSkin.Controls.MaterialTextBox txtSearchItem;
        private MaterialSkin.Controls.MaterialComboBox cmbSelectItem;
        private System.Windows.Forms.Label lblCart;
        private MaterialSkin.Controls.MaterialComboBox cmbPymntMethod;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtCustCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPymntSum;
        private MaterialSkin.Controls.MaterialCard cardChange;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton btnClearCart;
        private MaterialSkin.Controls.MaterialButton btnPrintInv;
        private MaterialSkin.Controls.MaterialButton btnProcess;
        private System.Windows.Forms.Label lblItemsValue;
        private System.Windows.Forms.Label lblPaymentValue;
        private MaterialSkin.Controls.MaterialListView lvwCart;
    }
}