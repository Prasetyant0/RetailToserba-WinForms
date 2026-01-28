using MaterialSkin.Controls;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Models;
using RetailToserbaApps.Views.Auth;
using RetailToserbaApps.Views.Dashboard;
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
    public partial class TransactionHistoryForm : MaterialForm
    {
        private WarehouseController warehouseController;
        private CashierController cashierController;
        private User currentUser;
        private int currentUserId;
        private string currentUsername;
        private List<Transaksi> allTransactions;

        public TransactionHistoryForm()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            InitializeControllers();
            UiStyles();
            InitializeListView();

            lblCshName.Text = "Loading...";
            lblCshId.Text = "---";
            lblRole.Text = "---";

            if (currentUser == null)
            {
                currentUserId = 1; // ID admin/user di database kamu
                currentUsername = "Developer";
            }

            this.Load += CashierForm_Load;
            LoadTransactionData();
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
        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

        }
        private void UiStyles()
        {
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            pictureBoxTrnsHistory.BackColor = Color.White;
            lblCshName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblCshName.BackColor = Color.White;
            lblCshId.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCshId.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            lblRole.BackColor = Color.White;
            btnPrcSales.BackColor = Color.White;
            btnVwProduct.BackColor = Color.White;
            btnTrnsHstry.BackColor = Color.White;
            btnLogout.BackColor = Color.White;

            label4.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtSearch.Hint = "Search Item by Name or Code";
        }
        private void InitializeControllers()
        {
            warehouseController = new WarehouseController();
            cashierController = new CashierController();
        }
        private void InitializeListView()
        {
            lvwTrnsHistory.Columns.Clear();
             lvwTrnsHistory.Columns.Add("No", 50);
             lvwTrnsHistory.Columns.Add("Kode Transaksi", 150);
             lvwTrnsHistory.Columns.Add("Tanggal", 250);
             lvwTrnsHistory.Columns.Add("Total Item", 150);
             lvwTrnsHistory.Columns.Add("Total", 150);
             lvwTrnsHistory.Columns.Add("Metode Pembayaran", 180);
             lvwTrnsHistory.Columns.Add("Kasir", 120);
             lvwTrnsHistory.Columns.Add("Status", 100);
             lvwTrnsHistory.FullRowSelect = true;
             lvwTrnsHistory.GridLines = true;

            materialListView1.Columns.Clear();
           materialListView1.Columns.Add("No", 50);
           materialListView1.Columns.Add("Nama Produk", 250);
           materialListView1.Columns.Add("Quantity", 100);
           materialListView1.Columns.Add("Harga Satuan", 150);
           materialListView1.Columns.Add("Subtotal", 150);
           materialListView1.FullRowSelect = true;
           materialListView1.GridLines = true;
        }
        private void LoadTransactionData()
        {
            try
            {
                // Kita ambil data berdasarkan User yang sedang login
                allTransactions = cashierController.GetTransaksiByKasir(currentUserId);
                DisplayTransactions(allTransactions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTransactions(List<Transaksi> list)
        {
            lvwTrnsHistory.Items.Clear();
            int no = 1;

            foreach (var tr in list)
            {
                ListViewItem item = new ListViewItem(no++.ToString());
                item.SubItems.Add(tr.TransaksiId.ToString());
                item.SubItems.Add(tr.Tanggal);
                item.SubItems.Add("-"); // Jika model Transaksi tidak punya TotalItem, isi "-" dulu
                item.SubItems.Add(string.Format("Rp {0:N0}", tr.Total));
                item.SubItems.Add("Cash"); // Default
                item.SubItems.Add(currentUsername);
                item.SubItems.Add(tr.Status);

                item.Tag = tr; // Simpan objek transaksi di Tag untuk diambil saat diklik
                lvwTrnsHistory.Items.Add(item);
            }
        }
        private void LvwTrnsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTrnsHistory.SelectedItems.Count > 0)
            {
                // Ambil objek Transaksi dari Tag
                ListViewItem itemTabel = lvwTrnsHistory.SelectedItems[0];
                var selectedTr = (Transaksi)itemTabel.Tag;

                lblTrnsIDValue.Text = itemTabel.SubItems[1].Text;
                lblDateValue.Text = itemTabel.SubItems[2].Text;
                lblCshValue.Text = itemTabel.SubItems[6].Text;
                lblPymntMthdValue.Text = itemTabel.SubItems[5].Text;


                LoadDetails(selectedTr.TransaksiId);
            }
        }

        private void LoadDetails(int transaksiId)
        {
            materialListView1.Items.Clear();
            try
            {
                var details = cashierController.GetDetailTransaksi(transaksiId);
                var allBarang = cashierController.GetAllBarang(); // Untuk cari Nama Barang

                int no = 1;
                foreach (var d in details)
                {
                    // Cari nama barang berdasarkan BarangId
                    var barang = allBarang.FirstOrDefault(b => b.BarangId == d.BarangId);
                    string namaBarang = barang != null ? barang.NamaBarang : "Produk Dihapus";

                    ListViewItem item = new ListViewItem(no++.ToString());
                    item.SubItems.Add(namaBarang);
                    item.SubItems.Add(d.Quantity.ToString());
                    item.SubItems.Add(string.Format("Rp {0:N0}", d.HargaSatuan));
                    item.SubItems.Add(string.Format("Rp {0:N0}", d.Subtotal));

                    materialListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail: " + ex.Message);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (allTransactions == null) return;

            string keyword = txtSearch.Text.ToLower();
            var filtered = allTransactions.Where(t =>
                t.NoInvoice.ToLower().Contains(keyword)
            ).ToList();

            DisplayTransactions(filtered);
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
            ViewProductForm viewProductForm = new ViewProductForm();
            viewProductForm.SetCurrentUser(this.currentUser);
            viewProductForm.Show();
            this.Hide();
        }

        private void btnTrnsHstry_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
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
