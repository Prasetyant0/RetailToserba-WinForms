using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Models
{
    public class LogActivity
    {
        public int ActivityId { get; set; }
        public string Username { get; set; }
        public string Aktivitas { get; set; }
        public string Keterangan { get; set; }
        public string CreatedAt { get; set; }
        public int? UserId { get; set; }
    }
}
