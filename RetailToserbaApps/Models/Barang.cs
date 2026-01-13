using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class Barang
    {
        public int BarangId { get; set; }
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Satuan { get; set; }
        public long HargaBarang { get; set; }
        public string Expired { get; set; }
        public int StokTersedia { get; set; }
        public int StokMinimum { get; set; }
        public int BrgMasukTotal { get; set; }
        public int BrgKeluarTotal { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }

        // Foreign Keys
        public int? KategoriId { get; set; } 
        public int? SupplierId { get; set; }
        public int? UserId { get; set; }
    }
}
