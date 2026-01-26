using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class Transaksi
    {
        public int TransaksiId { get; set; }
        public string NoInvoice { get; set; }
        public string Tanggal { get; set; }
        public long Total { get; set; }
        public int UserId { get; set; }
    }
}
