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
    public partial class AddSupplierForm : MaterialForm
    {
        private WarehouseController warehouseController;
        private MaterialTextBox txtNamaSupplier;
        private MaterialTextBox txtPerusahaan;
        private MaterialTextBox txtAlamat;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtNoTelepon;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;

        public AddSupplierForm()
        {
            InitializeComponent();
            ConfigureMaterialSkin();
            InitializeControls();
            warehouseController = new WarehouseController();
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

        private void InitializeControls()
        {
            this.Text = "Add Supplier";
            this.Size = new Size(550, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label
            {
                Text = "Add New Supplier",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 80),
                AutoSize = true
            };

            txtNamaSupplier = new MaterialTextBox
            {
                Location = new Point(20, 130),
                Size = new Size(490, 50),
                Hint = "Supplier Name"
            };

            txtPerusahaan = new MaterialTextBox
            {
                Location = new Point(20, 190),
                Size = new Size(490, 50),
                Hint = "Company Name"
            };

            txtAlamat = new MaterialTextBox
            {
                Location = new Point(20, 250),
                Size = new Size(490, 50),
                Hint = "Address"
            };

            txtEmail = new MaterialTextBox
            {
                Location = new Point(20, 310),
                Size = new Size(490, 50),
                Hint = "Email Address"
            };

            txtNoTelepon = new MaterialTextBox
            {
                Location = new Point(20, 370),
                Size = new Size(490, 50),
                Hint = "Phone Number"
            };

            btnSave = new MaterialButton
            {
                Text = "SAVE",
                Location = new Point(20, 450),
                Size = new Size(220, 40),
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = false
            };
            btnSave.Click += BtnSave_Click;

            btnCancel = new MaterialButton
            {
                Text = "CANCEL",
                Location = new Point(290, 450),
                Size = new Size(220, 40),
                Type = MaterialButton.MaterialButtonType.Text
            };
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(txtNamaSupplier);
            this.Controls.Add(txtPerusahaan);
            this.Controls.Add(txtAlamat);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtNoTelepon);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                Supplier supplier = new Supplier
                {
                    NamaSupplier = txtNamaSupplier.Text.Trim(),
                    NamaPerusahaan = txtPerusahaan.Text.Trim(),
                    Alamat = txtAlamat.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    NoTelepon = txtNoTelepon.Text.Trim()
                };

                warehouseController.InsertSupplier(supplier);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan supplier:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNamaSupplier.Text))
            {
                MessageBox.Show("Nama supplier tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaSupplier.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPerusahaan.Text))
            {
                MessageBox.Show("Nama perusahaan tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPerusahaan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNoTelepon.Text))
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelepon.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
