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
    public partial class TransactionHistoryForm : MaterialForm
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

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
            /*label6.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label7.Font = new Font("Segoe UI", 12, FontStyle.Bold); 
            label8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label10.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label11.Font = new Font("Segoe UI", 12, FontStyle.Bold);*/
        }

       
    }
}
