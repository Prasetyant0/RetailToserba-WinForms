using MaterialSkin.Controls;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailToserbaApps.Views.Pages
{
    public partial class AddStockForm : MaterialForm
    {
        private WarehouseController warehouseController;
        private BarangView _barang; // Gunakan satu variabel global saja

        public AddStockForm(BarangView barang)
        {
            InitializeComponent();

            // 1. Inisialisasi Controller
            warehouseController = new WarehouseController();

            // 2. Simpan data yang dikirim dari WarehouseForm ke variabel global
            this._barang = barang;

            // 3. Setup MaterialSkin
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // 4. Tampilkan data ke Label
            DisplayProduct(_barang);
        }

        private void DisplayProduct(BarangView barang)
        {
            if (barang != null)
            {
                lblNamaBarang.Text = barang.NamaBarang;
                lblKode.Text = barang.KodeBarang;
                lblStok.Text = barang.StokTersedia.ToString();
            }
        }

        // Tentukan aksi tombol SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
             
            try
            {
                int restock = int.Parse(txtTambahStock.Text);
                warehouseController.AddStock(_barang.BarangId, restock);

                MessageBox.Show($"Berhasil menambah {restock} stok untuk {_barang.NamaBarang}",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();

            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTambahStock.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTambahStock.Focus();
                return false;
            }
            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
