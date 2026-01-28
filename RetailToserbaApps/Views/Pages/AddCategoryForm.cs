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
    public partial class AddCategoryForm : MaterialForm
    {
        private WarehouseController warehouseController;
        
        //private List<>
        

        public AddCategoryForm()
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

       /* private void InitializeControls()
        {
            this.Text = "Add Category";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label
            {
                Text = "Add New Category",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 80),
                AutoSize = true
            };

            materialNmKategori = new MaterialTextBox
            {
                Location = new Point(20, 130),
                Size = new Size(440, 50),
                Hint = "Category Name"
            };

            txtDeskripsi = new MaterialTextBox
            {
                Location = new Point(20, 200),
                Size = new Size(440, 50),
                Hint = "Description (Optional)"
            };

            btnSave = new MaterialButton
            {
                Text = "SAVE",
                Location = new Point(20, 280),
                Size = new Size(200, 40),
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = false
            };
            btnSave.Click += BtnSave_Click;

            btnCancel = new MaterialButton
            {
                Text = "CANCEL",
                Location = new Point(260, 280),
                Size = new Size(200, 40),
                Type = MaterialButton.MaterialButtonType.Text
            };
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(materialNmKategori);
            this.Controls.Add(txtDeskripsi);
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
                Kategori kategori = new Kategori
                {
                    NamaKategori = materialNmKategori.Text.Trim(),
                    Deskripsi = string.IsNullOrWhiteSpace(richTxtDeskripsi.Text) ? "-" : richTxtDeskripsi.Text.Trim()
                };

                warehouseController.InsertKategori(kategori);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan kategori:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(materialNmKategori.Text))
            {
                MessageBox.Show("Nama kategori tidak boleh kosong!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialNmKategori.Focus();
                return false;
            }

            if (materialNmKategori.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nama kategori minimal 3 karakter!", "Validasi",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialNmKategori.Focus();
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
