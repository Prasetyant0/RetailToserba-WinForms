using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Views.Pages
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();

            label1.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            lblGrandTtlValue.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);

            btnClose.Click += BtnClose_Click;
            btnPrint.Click += BtnPrint_Click;

            InitializeListViewColumns();
        }

        private void InitializeListViewColumns()
        {
            lvwInvoice.Columns.Clear();
            lvwInvoice.Columns.Add("No", 50);
            lvwInvoice.Columns.Add("Nama Barang", 140);
            lvwInvoice.Columns.Add("Harga", 80);
            lvwInvoice.Columns.Add("Qty", 60);
            lvwInvoice.Columns.Add("Subtotal", 90);
        }

        /// <summary>
        /// Populate invoice form fields and items. Call this from CashierForm after processing payment.
        /// </summary>
        public void LoadInvoice(string invoiceNumber, string cashierName, DateTime date, List<InvoiceItem> items, long grandTotal, long paid, long change)
        {
            if (items == null) items = new List<InvoiceItem>();

            lblInvoiceValue.Text = invoiceNumber;
            lblCshName.Text = cashierName;
            lblDateValue.Text = date.ToString("yyyy-MM-dd HH:mm:ss");

            lvwInvoice.Items.Clear();

            int no = 1;
            foreach (var it in items)
            {
                var lvi = new ListViewItem(no.ToString());
                lvi.SubItems.Add(it.NamaBarang);
                lvi.SubItems.Add(it.Harga.ToString("N0"));
                lvi.SubItems.Add(it.Quantity.ToString());
                lvi.SubItems.Add(it.Subtotal.ToString("N0"));
                lvwInvoice.Items.Add(lvi);
                no++;
            }

            lblGrandTtlValue.Text = grandTotal.ToString("Rp #,0");
            lblPaidValue.Text = paid.ToString("Rp #,0");
            lblChangeValue.Text = change.ToString("Rp #,0");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print feature belum diimplementasikan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
