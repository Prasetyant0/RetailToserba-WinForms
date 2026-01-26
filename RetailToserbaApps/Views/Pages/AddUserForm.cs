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
    public partial class AddUserForm : MaterialForm
    {
        private AdminController adminController;
        private int? userId;
        private bool isEditMode;

        public AddUserForm() : this(null)
        {
        }

        public AddUserForm(int? userId)
        {
            InitializeComponent();

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

            this.userId = userId;
            this.isEditMode = userId.HasValue;
            
            adminController = new AdminController();
            
            this.Text = isEditMode ? "Edit User" : "Add New User";
            
            txtNama.Hint = "Full Name";
            txtUsername.Hint = "Username (unique)";
            txtPassword.Hint = "Password (min 6 characters)";
            txtNoTelepon.Hint = "Phone Number (08xxxxxxxxxx)";
            
            txtPassword.Password = true;
            
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            PopulateRoleComboBox();
            PopulateStatusComboBox();
            
            if (isEditMode)
            {
                LoadUserData();
            }
        }

        private void PopulateRoleComboBox()
        {
            var roles = new List<string> { "Admin", "Gudang", "Kasir" };
            
            cmbRole.DataSource = roles;
            cmbRole.SelectedIndex = 0;
        }

        private void PopulateStatusComboBox()
        {
            var statuses = new List<string> { "Active", "Inactive" };
            
            cmbStatus.DataSource = statuses;
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadUserData()
        {
            try
            {
                User user = adminController.GetUserById(userId.Value);
                
                if (user != null)
                {
                    txtNama.Text = user.Nama;
                    txtUsername.Text = user.Username;
                    txtPassword.Text = user.Password;
                    txtNoTelepon.Text = user.NoTelepon;
                    cmbRole.SelectedItem = user.Role;
                    cmbStatus.SelectedItem = user.Status;
                    
                    txtUsername.Enabled = false;
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data user:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            
            try
            {
                User user = new User
                {
                    Nama = txtNama.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    NoTelepon = txtNoTelepon.Text.Trim(),
                    Role = cmbRole.SelectedItem.ToString(),
                    Status = cmbStatus.SelectedItem.ToString(),
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };
                
                if (isEditMode)
                {
                    user.UserId = userId.Value;
                    adminController.UpdateUser(user);
                    
                    this.DialogResult = DialogResult.OK;
                    
                    MessageBox.Show("User berhasil diperbarui!", "Sukses",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                else
                {
                    if (adminController.IsUsernameExists(user.Username))
                    {
                        MessageBox.Show("Username sudah digunakan! Silakan gunakan username lain.",
                                       "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                    
                    adminController.InsertUser(user);
                    
                    this.DialogResult = DialogResult.OK;
                    
                    MessageBox.Show("User berhasil ditambahkan!", "Sukses",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan user:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            
            if (txtUsername.Text.Trim().Length < 3)
            {
                MessageBox.Show("Username minimal 3 karakter!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            
            if (txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtNoTelepon.Text))
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelepon.Focus();
                return false;
            }
            
            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih role!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }
            
            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Silakan pilih status!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
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
