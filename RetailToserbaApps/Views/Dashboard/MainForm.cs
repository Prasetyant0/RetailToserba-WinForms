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
using RetailToserbaApps.Views.Pages;
using RetailToserbaApps.Views.Auth;

namespace RetailToserbaApps.Views.Dashboard
{
    public partial class MainForm : MaterialForm
    {
        private AdminController adminController;
        private AuthController authController;
        private List<User> userList;
        private List<LogActivity> activityLogList;

        public MainForm()
        {
            InitializeComponent();
            
            adminController = new AdminController();
            authController = new AuthController();

            ConfigureMaterialSkin();
            ConfigureUIStyles();
            InitializeListViews();
            LoadInitialData();
            AttachEventHandlers();
        }

        private void ConfigureMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue400, TextShade.WHITE);
        }

        private void ConfigureUIStyles()
        {
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

            lblManageUsr.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            panel1.BackColor = Color.White;
            lblUsrDetails.BackColor = Color.FromArgb(255,255,255); 
            lblUsrDetails.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            lblUsrname.BackColor = Color.White;
            lblRole.BackColor = Color.White;
            lblLstLogin.BackColor = Color.White;
            lblStatus.BackColor = Color.White;

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

        private void InitializeListViews()
        {
            lvwManUsers.Columns.Clear();
            lvwManUsers.Columns.Add("No", 50);
            lvwManUsers.Columns.Add("Nama", 200);
            lvwManUsers.Columns.Add("Username", 150);
            lvwManUsers.Columns.Add("Role", 100);
            lvwManUsers.Columns.Add("Status", 100);
            lvwManUsers.FullRowSelect = true;
            lvwManUsers.GridLines = true;

            materialListView1.Columns.Clear();
            materialListView1.Columns.Add("No", 50);
            materialListView1.Columns.Add("Username", 150);
            materialListView1.Columns.Add("Aktivitas", 150);
            materialListView1.Columns.Add("Keterangan", 300);
            materialListView1.Columns.Add("Tanggal", 200);
            materialListView1.FullRowSelect = true;
            materialListView1.GridLines = true;
        }

        private void LoadInitialData()
        {
            LoadDashboardStatistics();
            LoadUserList();
            LoadActivityLogs();
        }

        private void AttachEventHandlers()
        {
            materialButton1.Click += BtnAddUser_Click;
            materialButton2.Click += BtnEditUser_Click;
            materialButton3.Click += BtnDeleteUser_Click;
            lvwManUsers.SelectedIndexChanged += LvwManUsers_SelectedIndexChanged;
            btnSearch.Click += BtnSearch_Click;
            txtSearchByUsrnm.TextChanged += TxtSearchByUsrnm_TextChanged;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            materialTabControl.Selecting += MaterialTabControl_Selecting;
        }

        private void LoadUserList()
        {
            try
            {
                userList = adminController.GetAllUsers();
                DisplayUsers(userList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data user:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUsers(List<User> users)
        {
            lvwManUsers.Items.Clear();
            
            int rowNumber = 1;
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(rowNumber.ToString());
                item.SubItems.Add(user.Nama);
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Role);
                item.SubItems.Add(user.Status);
                item.Tag = user;
                
                if (user.Status == "Inactive")
                {
                    item.BackColor = Color.FromArgb(255, 230, 230);
                }
                
                lvwManUsers.Items.Add(item);
                rowNumber++;
            }
        }

        private void LvwManUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwManUsers.SelectedItems.Count > 0)
            {
                User selectedUser = (User)lvwManUsers.SelectedItems[0].Tag;
                DisplayUserDetails(selectedUser);
            }
            else
            {
                ClearUserDetails();
            }
        }

        private void DisplayUserDetails(User user)
        {
            lblUsrname.Text = user.Username;
            lblRole.Text = user.Role;
            lblLstLogin.Text = user.CreatedAt;
            lblStatus.Text = user.Status;
        }

        private void ClearUserDetails()
        {
            lblUsrname.Text = "-";
            lblRole.Text = "-";
            lblLstLogin.Text = "-";
            lblStatus.Text = "-";
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            using (var form = new AddUserForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadUserList();
                    LoadDashboardStatistics();
                }
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (lvwManUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih user yang ingin diedit!", "Peringatan", 
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            User selectedUser = (User)lvwManUsers.SelectedItems[0].Tag;
            
            using (var form = new AddUserForm(selectedUser.UserId))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadUserList();
                    LoadDashboardStatistics();
                }
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lvwManUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih user yang ingin dihapus!", "Peringatan", 
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            User selectedUser = (User)lvwManUsers.SelectedItems[0].Tag;
            
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus user '{selectedUser.Nama}'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    adminController.DeleteUser(selectedUser.UserId);
                    LoadUserList();
                    LoadDashboardStatistics();
                    ClearUserDetails();
                    MessageBox.Show("User berhasil dihapus!", "Sukses", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus user:\n{ex.Message}", "Error", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadActivityLogs()
        {
            try
            {
                activityLogList = adminController.GetAllLogActivities();
                DisplayActivityLogs(activityLogList);
                UpdateActivityLogStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat log aktivitas:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayActivityLogs(List<LogActivity> logs)
        {
            materialListView1.Items.Clear();
            
            int rowNumber = 1;
            foreach (var log in logs.Take(100))
            {
                ListViewItem item = new ListViewItem(rowNumber.ToString());
                item.SubItems.Add(log.Username);
                item.SubItems.Add(log.Aktivitas);
                item.SubItems.Add(log.Keterangan);
                item.SubItems.Add(log.CreatedAt);
                item.Tag = log;
                materialListView1.Items.Add(item);
                rowNumber++;
            }
        }

        private void UpdateActivityLogStatistics()
        {
            try
            {
                if (activityLogList == null) return;
                
                DateTime today = DateTime.Today;
                DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                
                int totalLogsToday = activityLogList.Count(l => 
                    DateTime.TryParse(l.CreatedAt, out DateTime date) && date.Date == today);
                
                int totalLogsThisMonth = activityLogList.Count(l => 
                    DateTime.TryParse(l.CreatedAt, out DateTime date) && date >= firstDayOfMonth);
                
                var mostFrequent = activityLogList
                    .GroupBy(l => l.Aktivitas)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();
                
                lblTtlLogs.Text = totalLogsToday.ToString();
                lblTtlLogsMonth.Text = totalLogsThisMonth.ToString();
                lblMostFrqAct.Text = mostFrequent != null ? mostFrequent.Key : "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghitung statistik log:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PerformCombinedSearch();
        }

        private void TxtSearchByUsrnm_TextChanged(object sender, EventArgs e)
        {
            PerformCombinedSearch();
        }

        private void PerformCombinedSearch()
        {
            string keyword = txtSearchByUsrnm.Text.Trim();
            
            try
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    var searchResults = adminController.SearchLogActivities(keyword);
                    DisplayActivityLogs(searchResults);
                }
                else if (dateTimePicker1.Value.Date != DateTime.Today)
                {
                    var dateResults = adminController.GetLogsByDate(dateTimePicker1.Value);
                    DisplayActivityLogs(dateResults);
                }
                else
                {
                    DisplayActivityLogs(activityLogList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencari log:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearchByUsrnm.Text))
                {
                    return;
                }
                
                var filteredLogs = adminController.GetLogsByDate(dateTimePicker1.Value);
                DisplayActivityLogs(filteredLogs);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memfilter log berdasarkan tanggal:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                var stats = adminController.GetDashboardStatistics();
                
                lblTtlUsers.Text = stats["TotalUsers"].ToString();
                lblTtlTransaction.Text = stats["TotalTransactions"].ToString();
                lblTtlStock.Text = stats["LowStock"].ToString();
                lblRecentAct.Text = stats["TotalLogs"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat statistik dashboard:\n{ex.Message}", "Error", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaterialTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 3)
            {
                e.Cancel = true;
                
                DialogResult confirm = MessageBox.Show(
                    "Apakah Anda yakin ingin logout?",
                    "Konfirmasi Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                
                if (confirm == DialogResult.Yes)
                {
                    PerformLogout();
                }
            }
        }

        private void PerformLogout()
        {
            try
            {
                this.Hide();
                
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, e) => this.Close();
                loginForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan logout:\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(253, 248, 197)))
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
