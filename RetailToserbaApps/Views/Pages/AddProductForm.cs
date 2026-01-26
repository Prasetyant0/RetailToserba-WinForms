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

namespace RetailToserbaApps.Views.Pages
{
    public partial class AddProductForm : MaterialForm
    {
        private WarehouseController warehouseController;
        private int? barangId;
        private bool isEditMode;

        public AddProductForm() : this(null)
        {
        }

        public AddProductForm(int? barangId)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.barangId = barangId;
            this.isEditMode = barangId.HasValue;

            warehouseController = new WarehouseController();

            this.Text = isEditMode ? "Edit Product" : "Add New Product";

            txtItemCode.Hint = "e.g., P001";
            txtItemName.Hint = "Product Name";
            txtQuantity.Hint = "e.g., 100";
            txtUnit.Hint = "e.g., Pcs, Kg, Box";
            txtSellPrice.Hint = "e.g., 15000";
            txtMinimStock.Hint = "e.g., 10";

            dtpExpired.Enabled = false;
            chkExpDate.CheckedChanged += ChkExpDate_CheckedChanged;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadCategories();
            LoadSuppliers();

            if (isEditMode)
            {
                LoadProductData();
            }
        }

        private void LoadCategories()
        {
            try
            {
                var categories = warehouseController.GetAllKategori();

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
                var suppliers = warehouseController.GetAllSupplier();

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

        private void LoadProductData()
        {
            try
            {
                Barang product = warehouseController.GetBarangById(barangId.Value);

                if (product != null)
                {
                    txtItemCode.Text = product.KodeBarang;
                    txtItemName.Text = product.NamaBarang;
                    txtQuantity.Text = product.StokTersedia.ToString();
                    txtUnit.Text = product.Satuan;
                    txtSellPrice.Text = product.HargaBarang.ToString();
                    txtMinimStock.Text = product.StokMinimum.ToString();

                    if (product.KategoriId.HasValue)
                    {
                        cmbCategory.SelectedValue = product.KategoriId.Value;
                    }

                    if (product.SupplierId.HasValue)
                    {
                        cmbSupplier.SelectedValue = product.SupplierId.Value;
                    }

                    if (!string.IsNullOrEmpty(product.Expired) && product.Expired != "-")
                    {
                        DateTime expiredDate;
                        if (DateTime.TryParse(product.Expired, out expiredDate))
                        {
                            chkExpDate.Checked = true;
                            dtpExpired.Value = expiredDate;
                        }
                    }

                    txtItemCode.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ChkExpDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpExpired.Enabled = chkExpDate.Checked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                Barang product = new Barang
                {
                    KodeBarang = txtItemCode.Text.Trim(),
                    NamaBarang = txtItemName.Text.Trim(),
                    Satuan = txtUnit.Text.Trim(),
                    HargaBarang = long.Parse(txtSellPrice.Text.Trim()),
                    StokTersedia = int.Parse(txtQuantity.Text.Trim()),
                    StokMinimum = int.Parse(txtMinimStock.Text.Trim()),
                    KategoriId = (int)cmbCategory.SelectedValue,
                    SupplierId = (int)cmbSupplier.SelectedValue,
                    Expired = chkExpDate.Checked ? dtpExpired.Value.ToString("yyyy-MM-dd") : "-",
                    Status = "Available"
                };

                if (isEditMode)
                {
                    product.BarangId = barangId.Value;
                    warehouseController.UpdateBarang(product);
                    MessageBox.Show("Produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    product.UserId = 1;
                    warehouseController.InsertBarang(product);
                    MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format input tidak valid! Pastikan angka diisi dengan benar.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan produk:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtItemCode.Text))
            {
                MessageBox.Show("Kode barang tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Nama barang tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih kategori!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (cmbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih supplier!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupplier.Focus();
                return false;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity harus berupa angka valid (≥ 0)!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Satuan tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnit.Focus();
                return false;
            }

            long price;
            if (!long.TryParse(txtSellPrice.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show("Harga harus berupa angka valid (> 0)!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSellPrice.Focus();
                return false;
            }

            int minStock;
            if (!int.TryParse(txtMinimStock.Text.Trim(), out minStock) || minStock < 0)
            {
                MessageBox.Show("Stok minimum harus berupa angka valid (≥ 0)!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinimStock.Focus();
                return false;
            }

            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
