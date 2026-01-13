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

namespace RetailToserbaApps.Views.Pages
{
    public partial class ViewProductForm : MaterialForm
    {
        public ViewProductForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

            pictureBoxViewProd.BackColor = Color.White;
            lblCshName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblCshName.BackColor = Color.White;
            lblCshId.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCshId.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            lblRole.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            btnPrcSales.BackColor = Color.White;
            btnVwProduct.BackColor = Color.White;
            btnTrnsHstry.BackColor = Color.White;
            btnLogout.BackColor = Color.White;

           
            txtSearchItem.Hint = "Search Item by Name or Code";
            cmbCategory.Hint = "Select Category";
            cmbSupplier.Hint = "Select Supplier";
        }

       
    }
}
