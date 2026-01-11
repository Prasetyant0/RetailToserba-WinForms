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

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue400, TextShade.WHITE);

            // Dashboard
            lblAdmin.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label1.BackColor = Color.FromArgb(223, 252, 232);
            label1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label2.BackColor = Color.FromArgb(221, 234, 253);
            label2.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblStock.BackColor = Color.FromArgb(253, 248, 197);
            lblStock.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblActivities.BackColor = Color.FromArgb(242, 232, 254);
            lblActivities.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            lblTtlTransaction.BackColor = Color.FromArgb(223, 252, 232);
            lblTtlTransaction.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblTtlUsers.BackColor = Color.FromArgb(221, 234, 253);
            lblTtlUsers.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblTtlStock.BackColor = Color.FromArgb(253, 248, 197);
            lblTtlStock.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblRecentAct.BackColor = Color.FromArgb(242, 232, 254);
            lblRecentAct.Font = new Font("Segoe UI", 14, FontStyle.Regular);


            // Manage Users
            lblManageUsr.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            panel1.BackColor = Color.White;
            lblUsrDetails.BackColor = Color.FromArgb(255,255,255); 
            lblUsrDetails.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // User Details
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            lblUsrname.BackColor = Color.White;
            lblRole.BackColor = Color.White;
            lblLstLogin.BackColor = Color.White;
            lblStatus.BackColor = Color.White;

            // Activity Logs
            lblActLog.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label7.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label10.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTtlLogs.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblTtlLogsMonth.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblMostFrqAct.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtSearchByUsrnm.Hint = "Search by Username or Activities";
            btn2.BackColor = Color.White;
        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(253, 248, 197)))
            {
                
                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            using(SolidBrush brush = new SolidBrush(Color.FromArgb(223, 252, 232)))
            {
               
                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(221, 234, 253)))
            {
                
                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }
        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(242, 232, 254)))
            {

                e.Graphics.FillRectangle(brush, 0, 0, materialCard3.Width, materialCard3.Height);
            }
        }

      
    }
}
