using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class BarangView
    {
        public int BarangId { get; set; }
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string NamaSupplier { get; set; }
        public int BrgMasukTotal { get; set; }
        public int StokTersedia { get; set; }
        public string CreatedAt { get; set; }
        public string NamaUser { get; set; }
    }
}
