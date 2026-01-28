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
       

        public AddSupplierForm()
        {
            InitializeComponent();
            ConfigureMaterialSkin();
            //InitializeControls();
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

        /*private void InitializeControls()
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

            materialTxtSuppName = new MaterialTextBox
            {
                Location = new Point(20, 130),
                Size = new Size(490, 50),
                Hint = "Supplier Name"
            };

            materialTxtCompName = new MaterialTextBox
            {
                Location = new Point(20, 190),
                Size = new Size(490, 50),
                Hint = "Company Name"
            };

            richTxtAddress = new MaterialTextBox
            {
                Location = new Point(20, 250),
                Size = new Size(490, 50),
                Hint = "Address"
            };

            materialTxtEmail = new MaterialTextBox
            {
                Location = new Point(20, 310),
                Size = new Size(490, 50),
                Hint = "Email Address"
            };

            materialTxtPhone = new MaterialTextBox
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
            this.Controls.Add(materialTxtSuppName);
            this.Controls.Add(materialTxtCompName);
            this.Controls.Add(richTxtAddress);
            this.Controls.Add(materialTxtEmail);
            this.Controls.Add(materialTxtPhone);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
        }
        */
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
                    NamaSupplier = materialTxtSuppName.Text.Trim(),
                    NamaPerusahaan = materialTxtCompName.Text.Trim(),
                    Alamat = richTxtAddress.Text.Trim(),
                    Email = materialTxtEmail.Text.Trim(),
                    NoTelepon = materialTxtPhone.Text.Trim()
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
            if (string.IsNullOrWhiteSpace(materialTxtSuppName.Text))
            {
                MessageBox.Show("Nama supplier tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialTxtSuppName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialTxtCompName.Text))
            {
                MessageBox.Show("Nama perusahaan tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialTxtCompName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(richTxtAddress.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTxtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialTxtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialTxtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(materialTxtEmail.Text.Trim()))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialTxtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(materialTxtPhone.Text))
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialTxtPhone.Focus();
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
