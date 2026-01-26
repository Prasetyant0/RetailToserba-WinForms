using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Models;
using RetailToserbaApps.Helpers;
using RetailToserbaApps.Views.Auth;

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class CashierForm : MaterialForm
    {
        private CashierController cashierController;
        private WarehouseController warehouseController;
        private AuthController authController;
        private List<CartItem> currentCart;
        private List<Barang> availableProducts;
        private int currentUserId = 1; 
        private string currentUsername = "kasir"; 

        private class CartItem
        {
            public int BarangId { get; set; }
            public int Quantity { get; set; }
            public long Subtotal { get; set; }
            public string NamaBarang { get; set; }
            public long HargaBarang { get; set; }
        }

        public CashierForm()
        {
            InitializeComponent();
            
            InitializeMaterialSkin();
            InitializeControllers();
            InitializeUI();
            LoadInitialData();
            AttachAllEventHandlers();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Green500,
                MaterialSkin.Primary.Green700,
                MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.Green700,
                MaterialSkin.TextShade.WHITE
            );
        }

        private void InitializeControllers()
        {
            cashierController = new CashierController();
            warehouseController = new WarehouseController();
            authController = new AuthController();
            currentCart = new List<CartItem>();
        }

        private void InitializeUI()
        {
            ConfigureUI();
            InitializeCartListView();
            InitializePaymentMethod();
        }

        private void ConfigureUI()
        {
            pictureBoxCashier.BackColor = Color.White;
            lblCshName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblCshName.BackColor = Color.White;
            lblCshId.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCshId.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            lblRole.BackColor = Color.White;
            panelLeft.BackColor = Color.White;
            panel4.BackColor = Color.White;
            btnPrcSales.BackColor = Color.White;
            btnVwProduct.BackColor = Color.White;
            btnTrnsHstry.BackColor = Color.White;
            btnLogout.BackColor = Color.White;

            lblItmSelect.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            txtSearchItem.Hint = "Search Item by Name or Code";
            txtQty.Hint = "Qty";
            txtQty.Text = "1";
            cmbSelectItem.Hint = "Select Item";

            lblCart.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            lblItemsValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPaymentValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPymntSum.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label6.BackColor = Color.FromArgb(101, 207, 104);
            label6.ForeColor = Color.White;
            lblChangeValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblChangeValue.BackColor = Color.FromArgb(101, 207, 104);
            lblChangeValue.ForeColor = Color.White;
            
            txtCustCash.Hint = "Enter amount...";
        }

        private void InitializeCartListView()
        {
            lvwCart.Columns.Clear();
            lvwCart.Columns.Add("Nama", 400);
            lvwCart.Columns.Add("Harga", 150);
            lvwCart.Columns.Add("Qty", 80);
            lvwCart.Columns.Add("Subtotal", 150);
            lvwCart.FullRowSelect = true;
            lvwCart.GridLines = true;
        }

        private void InitializePaymentMethod()
        {
            var paymentMethods = new List<string> { "Cash", "Debit Card", "Credit Card", "E-Wallet" };
            cmbPymntMethod.DataSource = paymentMethods;
            cmbPymntMethod.SelectedIndex = 0;
        }

        private void LoadInitialData()
        {
            LoadAvailableProducts();
        }

        private void LoadAvailableProducts()
        {
            try
            {
                availableProducts = cashierController.GetAvailableBarang();
                
                cmbSelectItem.DataSource = null;
                cmbSelectItem.DataSource = availableProducts;
                cmbSelectItem.DisplayMember = "NamaBarang";
                cmbSelectItem.ValueMember = "BarangId";
                
                if (availableProducts.Count > 0)
                {
                    cmbSelectItem.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat produk:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttachAllEventHandlers()
        {
            txtSearchItem.KeyDown += TxtSearchItem_KeyDown;
            btnAdd.Click += BtnAdd_Click;
            btnClearCart.Click += BtnClearCart_Click;
            btnProcess.Click += BtnProcess_Click;
            txtCustCash.TextChanged += TxtCustCash_TextChanged;
            lvwCart.KeyDown += LvwCart_KeyDown;
            btnLogout.Click += BtnLogout_Click;
            btnPrcSales.Click += BtnPrcSales_Click;
            btnVwProduct.Click += BtnVwProduct_Click;
            btnTrnsHstry.Click += BtnTrnsHstry_Click;
        }

        private void BtnPrcSales_Click(object sender, EventArgs e)
        {
            txtSearchItem.Focus();
        }

        private void BtnVwProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Product feature will be available soon!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTrnsHstry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction History feature will be available soon!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "Apakah Anda yakin ingin logout?",
                    "Konfirmasi Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan logout:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void TxtSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string barcode = txtSearchItem.Text.Trim();
                
                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Masukkan kode barang!", "Validasi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                ScanBarcode(barcode);
            }
        }

        private void ScanBarcode(string barcode)
        {
            try
            {
                Barang product = cashierController.SearchBarangByCode(barcode);
                
                if (product == null)
                {
                    MessageBox.Show($"Produk dengan kode '{barcode}' tidak ditemukan!",
                                   "Produk Tidak Ditemukan",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchItem.Clear();
                    txtSearchItem.Focus();
                    return;
                }
                
                if (product.StokTersedia <= 0)
                {
                    MessageBox.Show($"Stok produk '{product.NamaBarang}' habis!",
                                   "Stok Habis",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchItem.Clear();
                    txtSearchItem.Focus();
                    return;
                }
                
                int quantity = 1;
                if (!int.TryParse(txtQty.Text.Trim(), out quantity) || quantity <= 0)
                {
                    quantity = 1;
                }
                
                if (quantity > product.StokTersedia)
                {
                    MessageBox.Show($"Stok tidak mencukupi! Stok tersedia: {product.StokTersedia}",
                                   "Stok Tidak Cukup",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                AddToCart(product, quantity);
                
                txtSearchItem.Clear();
                txtQty.Text = "1";
                txtSearchItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencari produk:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSelectItem.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih produk terlebih dahulu!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Barang selectedProduct = (Barang)cmbSelectItem.SelectedItem;
            
            if (selectedProduct.StokTersedia <= 0)
            {
                MessageBox.Show($"Stok produk '{selectedProduct.NamaBarang}' habis!",
                               "Stok Habis",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int quantity = 1;
            if (!int.TryParse(txtQty.Text.Trim(), out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity harus berupa angka valid (> 0)!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return;
            }
            
            if (quantity > selectedProduct.StokTersedia)
            {
                MessageBox.Show($"Stok tidak mencukupi! Stok tersedia: {selectedProduct.StokTersedia}",
                               "Stok Tidak Cukup",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            AddToCart(selectedProduct, quantity);
            
            cmbSelectItem.SelectedIndex = -1;
            txtQty.Text = "1";
        }

        private void AddToCart(Barang product, int quantity)
        {
            var existingItem = currentCart.FirstOrDefault(d => d.BarangId == product.BarangId);
            
            if (existingItem != null)
            {
                int newQuantity = existingItem.Quantity + quantity;
                
                if (newQuantity > product.StokTersedia)
                {
                    MessageBox.Show($"Total quantity melebihi stok! Stok tersedia: {product.StokTersedia}",
                                   "Stok Tidak Cukup",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                existingItem.Quantity = newQuantity;
                existingItem.Subtotal = existingItem.Quantity * product.HargaBarang;
            }
            else
            {
                CartItem newItem = new CartItem
                {
                    BarangId = product.BarangId,
                    Quantity = quantity,
                    Subtotal = quantity * product.HargaBarang,
                    NamaBarang = product.NamaBarang,
                    HargaBarang = product.HargaBarang
                };
                
                currentCart.Add(newItem);
            }
            
            RefreshCart();
        }

        private void RefreshCart()
        {
            lvwCart.Items.Clear();
            
            foreach (var item in currentCart)
            {
                ListViewItem lvItem = new ListViewItem(item.NamaBarang);
                lvItem.SubItems.Add(item.HargaBarang.ToRupiah());
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.Subtotal.ToRupiah());
                lvItem.Tag = item;
                lvwCart.Items.Add(lvItem);
            }
            
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            long grandTotal = currentCart.Sum(d => d.Subtotal);
            int totalItems = currentCart.Sum(d => d.Quantity);
            
            lblItemsValue.Text = totalItems.ToString();
            lblPaymentValue.Text = grandTotal.ToRupiah();
            
            CalculateChange();
        }

        private void LvwCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvwCart.SelectedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show(
                    "Hapus item dari cart?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                
                if (confirmResult == DialogResult.Yes)
                {
                    CartItem selectedItem = (CartItem)lvwCart.SelectedItems[0].Tag;
                    currentCart.Remove(selectedItem);
                    RefreshCart();
                }
            }
        }

        private void TxtCustCash_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            long grandTotal = currentCart.Sum(d => d.Subtotal);
            
            if (long.TryParse(txtCustCash.Text.Trim(), out long customerCash))
            {
                long change = customerCash - grandTotal;
                lblChangeValue.Text = change.ToRupiah();
                
                if (change < 0)
                {
                    lblChangeValue.ForeColor = Color.Red;
                }
                else
                {
                    lblChangeValue.ForeColor = Color.White;
                }
            }
            else
            {
                lblChangeValue.Text = "Rp0";
                lblChangeValue.ForeColor = Color.White;
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (currentCart.Count == 0)
            {
                MessageBox.Show("Cart masih kosong! Tambahkan produk terlebih dahulu.",
                               "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            long grandTotal = currentCart.Sum(d => d.Subtotal);
            
            if (!long.TryParse(txtCustCash.Text.Trim(), out long customerCash))
            {
                MessageBox.Show("Masukkan jumlah uang customer!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustCash.Focus();
                return;
            }
            
            if (customerCash < grandTotal)
            {
                MessageBox.Show($"Uang customer tidak cukup!\nTotal: {grandTotal.ToRupiah()}\nBayar: {customerCash.ToRupiah()}",
                               "Pembayaran Tidak Cukup",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustCash.Focus();
                return;
            }
            
            ProcessPayment(grandTotal, customerCash);
        }

        private void ProcessPayment(long grandTotal, long customerCash)
        {
            try
            {
                btnProcess.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                
                string invoiceNumber = cashierController.GenerateInvoiceNumber();
                long change = customerCash - grandTotal;
                
                Transaksi transaction = new Transaksi
                {
                    NoInvoice = invoiceNumber,
                    Tanggal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Total = grandTotal,
                    UserId = currentUserId
                };
                
                List<DetailTransaksi> details = currentCart.Select(c => new DetailTransaksi
                {
                    BarangId = c.BarangId,
                    Quantity = c.Quantity,
                    Subtotal = c.Subtotal
                }).ToList();
                
                cashierController.SimpanTransaksi(transaction, details, currentUsername);
                
                string successMessage = $"Transaksi Berhasil!\n\n" +
                                      $"Invoice: {invoiceNumber}\n" +
                                      $"Total: {grandTotal.ToRupiah()}\n" +
                                      $"Bayar: {customerCash.ToRupiah()}\n" +
                                      $"Kembalian: {change.ToRupiah()}";
                
                MessageBox.Show(successMessage, "Transaksi Berhasil",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ClearTransaction();
                LoadAvailableProducts();
                txtSearchItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Transaksi gagal!\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProcess.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (currentCart.Count == 0)
            {
                return;
            }
            
            var confirmResult = MessageBox.Show(
                "Hapus semua item dari cart?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            
            if (confirmResult == DialogResult.Yes)
            {
                ClearTransaction();
            }
        }

        private void ClearTransaction()
        {
            currentCart.Clear();
            RefreshCart();
            txtCustCash.Clear();
            txtSearchItem.Clear();
            txtQty.Text = "1";
            cmbSelectItem.SelectedIndex = -1;
            lblChangeValue.Text = "Rp0";
            lblChangeValue.ForeColor = Color.White;
        }

        private void cardChange_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(101, 207, 104)))
            {
                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }

            Graphics v = e.Graphics;
            v.SmoothingMode = SmoothingMode.AntiAlias; 

            int radius = 10;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(cardChange.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(cardChange.Width - radius, cardChange.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, cardChange.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();

            cardChange.Region = new Region(gp);
        }
    }
}
