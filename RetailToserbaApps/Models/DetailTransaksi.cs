using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class DetailTransaksi
    {
        public int DetailId { get; set; }
        public int TransaksiId { get; set; }
        public int BarangId { get; set; }
        public int Quantity { get; set; }
        public long Subtotal { get; set; }
    }
}
