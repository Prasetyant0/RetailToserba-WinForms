using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RetailToserbaApps.Controllers;
using RetailToserbaApps.Models;
using RetailToserbaApps.Views.Dashboard;

namespace RetailToserbaApps.Views.Auth
{
    public partial class LoginForm : MaterialForm
    {
        private AuthController authController;

        public LoginForm()
        {
            InitializeComponent();

            InitializeMaterialSkin();
            InitializeController();
            ConfigureControls();
            AttachEventHandlers();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, 
                Primary.Blue700, 
                Primary.BlueGrey500, 
                Accent.LightBlue400, 
                TextShade.WHITE
            );
        }

        private void InitializeController()
        {
            authController = new AuthController();
        }

        private void ConfigureControls()
        {
            lbl1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            textBox2.PasswordChar = '•';
            
            this.AcceptButton = btnLogin;
        }

        private void AttachEventHandlers()
        {
            btnLogin.Click += BtnLogin_Click;
            textBox2.KeyDown += TextBox2_KeyDown;
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PerformLogin();
            }
        }

        private void PerformLogin()
        {
            if (!ValidateInputs())
            {
                return;
            }

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            btnLogin.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                User user = authController.Login(username, password);

                if (user != null)
                {
                    ShowSuccessMessage($"Login Berhasil!\nSelamat datang, {user.Nama}");
                    OpenDashboard(user);
                }
                else
                {
                    ShowErrorMessage("Username atau Password salah!\nSilakan coba lagi.");
                    HandleFailedLogin();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Terjadi kesalahan saat login:\n{ex.Message}");
            }
            finally
            {
                btnLogin.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private bool ValidateInputs()
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                ShowWarningMessage("Username tidak boleh kosong!");
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowWarningMessage("Password tidak boleh kosong!");
                textBox2.Focus();
                return false;
            }

            return true;
        }

        private void OpenDashboard(User user)
        {
            Form dashboardForm = CreateDashboardForm(user.Role);

            if (dashboardForm == null)
            {
                ShowErrorMessage($"Role '{user.Role}' tidak dikenali!");
                return;
            }

            dashboardForm.FormClosed += DashboardForm_FormClosed;
            dashboardForm.Show();
            this.Hide();
            ClearInputs();
        }

        private Form CreateDashboardForm(string role)
        {
            switch (role)
            {
                case "Admin":
                    return new MainForm();
                case "Kasir":
                    return new CashierForm();
                case "Gudang":
                    return new WarehouseForm();
                default:
                    return null;
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            textBox1.Focus();
        }

        private void HandleFailedLogin()
        {
            textBox2.Clear();
            textBox1.Focus();
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
