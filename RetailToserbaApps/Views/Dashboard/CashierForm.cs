using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class CashierForm : MaterialForm
    {
        public CashierForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

            pictureBoxCashier.BackColor = Color.White;
            lblCshName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblCshName.BackColor = Color.White;
            lblCshId.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCshId.BackColor = Color.White;
            lblRole.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            lblRole.BackColor = Color.White;
            panelLeft.BackColor = Color.White;
            panel4.BackColor = Color.White;
            btnPrcSales.BackColor = Color.White;
            btnVwProduct.BackColor = Color.White;
            btnTrnsHstry.BackColor = Color.White;
            btnLogout.BackColor = Color.White;

            lblItmSelect.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            txtSearchItem.Hint = "Search Item by Name or Code";
            txtQty.Hint = "Qty";
            cmbSelectItem.Hint = "Select Item";

            lblCart.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            lblItemsValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPaymentValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPymntSum.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label6.BackColor = Color.FromArgb(101, 207, 104);
            label6.ForeColor = Color.White;
            lblChangeValue.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblChangeValue.BackColor = Color.FromArgb(101, 207, 104);
            lblChangeValue.ForeColor = Color.White;
            
        }

        private void cardChange_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(101, 207, 104)))
            {

                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }

            Graphics v = e.Graphics;
            v.SmoothingMode = SmoothingMode.AntiAlias; 

            int radius = 10;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(cardChange.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(cardChange.Width - radius, cardChange.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, cardChange.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();

            cardChange.Region = new Region(gp);
        }

       
    }
}
