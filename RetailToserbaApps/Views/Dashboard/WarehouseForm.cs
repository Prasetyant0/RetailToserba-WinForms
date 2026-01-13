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

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class WarehouseForm : MaterialForm
    {
        public WarehouseForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            // Dashboard
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

            // Supplier Management
            lblSupplier.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            txtSearchSupplier.Hint = "Search Supplier by Name or Company";
            cmbCityRegion.Hint = "City/Region";

            // Product Categories
            lblProd.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            // Stock In History
            lblStockHistory.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        }


    }
}
