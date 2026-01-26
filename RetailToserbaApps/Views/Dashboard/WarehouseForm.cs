using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Models;
using RetailToserbaApps.Helpers;
using RetailToserbaApps.Views.Pages;
using RetailToserbaApps.Views.Auth;

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class WarehouseForm : MaterialForm
    {
        private WarehouseController warehouseController;
        private AuthController authController;
        private List<Barang> productList;
        private Dictionary<int, string> kategoriDict;
        private Dictionary<int, string> supplierDict;

        public WarehouseForm()
        {
            InitializeComponent();
            ConfigureMaterialSkin();
            ConfigureUIStyles();
            InitializeControllers();
            InitializeListView();
            LoadInitialData();
            AttachEventHandlers();
        }

        private void ConfigureMaterialSkin()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue500, 
                MaterialSkin.Primary.Blue700, 
                MaterialSkin.Primary.BlueGrey500, 
                MaterialSkin.Accent.LightBlue400, 
                MaterialSkin.TextShade.WHITE
            );
        }

        private void ConfigureUIStyles()
        {
            lblWhDashboard.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblPrdList.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            txtSearchProduct.Hint = "Search Product";
            label2.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTtlProductValue.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblInStockValue.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblLowStockValue.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblOutStockValue.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblSupplier.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            txtSearchSupplier.Hint = "Search Supplier by Name or Company";
            cmbCityRegion.Hint = "City/Region";
            lblProd.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblStockHistory.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        }

        private void InitializeControllers()
        {
            warehouseController = new WarehouseController();
            authController = new AuthController();
        }

        private void InitializeListView()
        {
            materialListView1.Columns.Clear();
            materialListView1.Columns.Add("No", 50);
            materialListView1.Columns.Add("Kode Barang", 120);
            materialListView1.Columns.Add("Nama Barang", 250);
            materialListView1.Columns.Add("Kategori", 150);
            materialListView1.Columns.Add("Supplier", 150);
            materialListView1.Columns.Add("Stok", 80);
            materialListView1.Columns.Add("Harga", 120);
            materialListView1.Columns.Add("Status", 100);
            materialListView1.FullRowSelect = true;
            materialListView1.GridLines = true;
        }

        private void LoadInitialData()
        {
            LoadLookupData();
            LoadProductList();
            LoadDashboardStatistics();
        }

        private void AttachEventHandlers()
        {
            btnAddProduct.Click += BtnAddProduct_Click;
            txtSearchProduct.TextChanged += TxtSearchProduct_TextChanged;
            materialListView1.DoubleClick += MaterialListView1_DoubleClick;
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

        private void LoadProductList()
        {
            try
            {
                productList = warehouseController.GetAllBarang();
                DisplayProducts(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProducts(List<Barang> products)
        {
            materialListView1.Items.Clear();

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

                materialListView1.Items.Add(item);
                rowNumber++;
            }

            LoadDashboardStatistics();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                if (productList == null) return;

                int totalProducts = productList.Count;
                int inStock = productList.Count(p => p.StokTersedia > p.StokMinimum);
                int lowStock = productList.Count(p => p.StokTersedia > 0 && p.StokTersedia <= p.StokMinimum);
                int outOfStock = productList.Count(p => p.StokTersedia <= 0);

                lblTtlProductValue.Text = totalProducts.ToString();
                lblInStockValue.Text = inStock.ToString();
                lblLowStockValue.Text = lowStock.ToString();
                lblOutStockValue.Text = outOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat statistik:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchProduct.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(searchKeyword))
                {
                    DisplayProducts(productList);
                }
                else
                {
                    var searchResults = warehouseController.SearchBarang(searchKeyword);
                    DisplayProducts(searchResults);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencari produk:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryExists())
            {
                return;
            }

            try
            {
                using (var form = new AddProductForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadLookupData();
                        LoadProductList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka form tambah produk:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaterialListView1_DoubleClick(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListView1.SelectedItems[0];
                Barang selectedProduct = (Barang)selectedItem.Tag;

                using (var form = new AddProductForm(selectedProduct.BarangId))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadLookupData();
                        LoadProductList();
                    }
                }
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new AddSupplierForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadLookupData();
                        LoadProductList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka form tambah supplier:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new AddCategoryForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadLookupData();
                        LoadProductList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka form tambah kategori:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewStock_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryExists())
            {
                return;
            }

            try
            {
                using (var form = new AddProductForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadLookupData();
                        LoadProductList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka form tambah stok:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCategoryExists()
        {
            try
            {
                var categories = warehouseController.GetAllKategori();
                
                if (categories == null || categories.Count == 0)
                {
                    MessageBox.Show(
                        "Harap tambah Kategori terlebih dahulu!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memeriksa kategori:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void MaterialTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 3)
            {
                e.Cancel = true;

                DialogResult confirm = MessageBox.Show(
                    "Apakah Anda yakin ingin logout?",
                    "Konfirmasi Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    PerformLogout();
                }
            }
        }

        private void PerformLogout()
        {
            try
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, e) => this.Close();
                loginForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan logout:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
