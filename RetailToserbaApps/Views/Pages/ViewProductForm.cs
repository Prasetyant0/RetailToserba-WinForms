using MaterialSkin.Controls;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Helpers;
using RetailToserbaApps.Models;
using RetailToserbaApps.Views.Auth;
using RetailToserbaApps.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailToserbaApps.Views.Pages
{
    public partial class ViewProductForm : MaterialForm
    {
        private CashierController cashierController;
        private WarehouseController warehouseController;
        private List<Barang> productList;
        private List<Kategori> category;
        private Dictionary<int, string> kategoriDict;
        private Dictionary<int, string> supplierDict;
        private User currentUser;
        private int currentUserId;
        private string currentUsername;

        public ViewProductForm()
        {
            InitializeComponent();
            ConfigureMaterialSkin();
            InitializeControllers();
            ConfigureUiStyles();
            InitializeListView();
           
            LoadProductList();

            txtSearchItem.Hint = "Search Item by Name or Code";
            cmbCategory.Hint = "Filter by Category";
            cmbSupplier.Hint = "Filter by Supplier";

            lblCshName.Text = "Loading...";
            lblCshId.Text = "---";
            lblRole.Text = "---";


            this.Load += CashierForm_Load;
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                UpdateUserInterface();
            }
        }
        private void UpdateUserInterface()
        {
            if (currentUser == null) return;

            lblCshName.Text = currentUser.Nama;
            lblCshId.Text = currentUser.Username;
            lblRole.Text = currentUser.Role;


            lblCshName.Refresh();
            lblCshId.Refresh();
            lblRole.Refresh();
        }

        public void SetCurrentUser(User user)
        {
            if (user != null)
            {
                currentUser = user;
                currentUserId = user.UserId;
                currentUsername = user.Username;
                if (this.IsHandleCreated)
                {
                    UpdateUserInterface();
                }
            }
        }
        private void InitializeControllers()
        {
            cashierController = new CashierController();
            warehouseController = new WarehouseController();
        }
        private void ConfigureMaterialSkin()
        {

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

        }
        private void ConfigureUiStyles()
        {
            pictureBoxViewProd.BackColor = Color.White;
            lblCshName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblCshName.BackColor = Color.White;
            lblCshId.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCshId.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            lblRole.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            btnPrcSales.BackColor = Color.White;
            btnVwProduct.BackColor = Color.White;
            btnTrnsHstry.BackColor = Color.White;
            btnLogout.BackColor = Color.White;
        }
        private void InitializeListView()
        {
            lvwViewProduct.Columns.Clear();
            lvwViewProduct.Columns.Add("No", 50);
            lvwViewProduct.Columns.Add("Kode Barang", 120);
            lvwViewProduct.Columns.Add("Nama Barang", 250);
            lvwViewProduct.Columns.Add("Kategori", 150);
            lvwViewProduct.Columns.Add("Supplier", 150);
            lvwViewProduct.Columns.Add("Stok", 80);
            lvwViewProduct.Columns.Add("Harga", 120);
            lvwViewProduct.Columns.Add("Status", 100);
            lvwViewProduct.FullRowSelect = true;
            lvwViewProduct.GridLines = true;
        }
       
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadLookupData();
            productList = warehouseController.GetAllBarang();

            LoadCategories();
            LoadSuppliers();

            cmbCategory.SelectedIndexChanged += FilterComboBox_Changed;
            cmbSupplier.SelectedIndexChanged += FilterComboBox_Changed;
            txtSearchItem.TextChanged += FilterComboBox_Changed;

            ApplyFilters();
        }

        private void LoadCategories()
        {
            try
            {
                var categories = cashierController.GetAllKategori();

                categories.Insert(0, new Kategori { KategoriId = -1, NamaKategori = "-- Semua Kategori --" });
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "NamaKategori";
                cmbCategory.ValueMember = "KategoriId";

                if (categories.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                var suppliers = cashierController.GetAllSupplier();

                suppliers.Insert(0, new Supplier { SupplierId = -1, NamaSupplier = "-- Semua Supplier --" });
                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "NamaSupplier";
                cmbSupplier.ValueMember = "SupplierId";

                if (suppliers.Count > 0)
                {
                    cmbSupplier.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat supplier:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyFilters()
        {
            // Pastikan list produk sudah terisi dari database
            if (productList == null || !productList.Any()) return;

            var filteredList = productList.AsEnumerable();

            // --- FILTER KATEGORI ---
            if (cmbCategory.SelectedValue != null)
            {
                // Gunakan try parse atau conversion yang lebih aman
                int catId = Convert.ToInt32(cmbCategory.SelectedValue);

                // Hanya filter jika ID > 0 (Artinya bukan "-1" atau "Semua")
                if (catId > 0)
                {
                    filteredList = filteredList.Where(p => p.KategoriId == catId);
                }
            }

            // --- FILTER SUPPLIER ---
            if (cmbSupplier.SelectedValue != null)
            {
                int supId = Convert.ToInt32(cmbSupplier.SelectedValue);

                if (supId > 0)
                {
                    filteredList = filteredList.Where(p => p.SupplierId == supId);
                }
            }

            // --- FILTER SEARCH TEXT ---
            string search = txtSearchItem.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                filteredList = filteredList.Where(p =>
                    p.NamaBarang.ToLower().Contains(search) ||
                    p.KodeBarang.ToLower().Contains(search)
                );
            }
            var finalResult = filteredList.OrderBy(p => p.BarangId).ToList();

            // Eksekusi tampilan
            DisplayProducts(finalResult);
        }

        // Event yang memicu filter
        private void FilterComboBox_Changed(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void LoadProductList()
        {
            try
            {
                productList = warehouseController.GetAllBarang() ?? new List<Barang>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal load data: {ex.Message}");
            }
            /*try
            {
                productList = warehouseController.GetAllBarang();
                DisplayProducts(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void LoadLookupData()
        {
            try
            {
                kategoriDict = new Dictionary<int, string>();
                var kategoriList = warehouseController.GetAllKategori();
                foreach (var kategori in kategoriList)
                {
                    kategoriDict[kategori.KategoriId] = kategori.NamaKategori;
                }

                supplierDict = new Dictionary<int, string>();
                var supplierList = warehouseController.GetAllSupplier();
                foreach (var supplier in supplierList)
                {
                    supplierDict[supplier.SupplierId] = supplier.NamaSupplier;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data lookup:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayProducts(List<Barang> products)
        {
            lvwViewProduct.Items.Clear();

            int rowNumber = 1;
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(rowNumber.ToString());
                item.SubItems.Add(product.KodeBarang);
                item.SubItems.Add(product.NamaBarang);

                string kategoriName = "-";
                if (product.KategoriId.HasValue && kategoriDict.ContainsKey(product.KategoriId.Value))
                {
                    kategoriName = kategoriDict[product.KategoriId.Value];
                }
                item.SubItems.Add(kategoriName);

                string supplierName = "-";
                if (product.SupplierId.HasValue && supplierDict.ContainsKey(product.SupplierId.Value))
                {
                    supplierName = supplierDict[product.SupplierId.Value];
                }
                item.SubItems.Add(supplierName);

                item.SubItems.Add(product.StokTersedia.ToString());
                item.SubItems.Add(product.HargaBarang.ToRupiah());
                item.SubItems.Add(product.Status);
                item.Tag = product;

                if (product.StokTersedia <= 0)
                {
                    item.BackColor = Color.FromArgb(255, 220, 220);
                }
                else if (product.StokTersedia <= product.StokMinimum)
                {
                    item.BackColor = Color.FromArgb(255, 250, 205);
                }

                lvwViewProduct.Items.Add(item);
                rowNumber++;
            }

        }
        private void LoadInitialData()
        {
           // LoadAvailableProducts();
        }

       /* private void LoadAvailableProducts()
        {
            try
            {
                category = cashierController.GetAvailableBarang();

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
        }*/
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

                txtSearchItem.Clear();
                txtSearchItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencari produk:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrcSales_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm();
            cashierForm.SetCurrentUser(this.currentUser);
            cashierForm.Show();
            this.Hide();
        }

        private void btnVwProduct_Click(object sender, EventArgs e)
        {
            txtSearchItem.Focus();
        }
        private void btnTrnsHstry_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm();
            transactionHistoryForm.SetCurrentUser(this.currentUser);
            transactionHistoryForm.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
