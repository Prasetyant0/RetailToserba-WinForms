using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailToserbaApps.Helpers
{
    public static class FormatHelper
    {
        public static string ToRupiah(this long angka)
        {
            return string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "Rp {0:N0}", angka);
        }

        public static string ToRupiah(this int angka)
        {
            return string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "Rp {0:N0}", angka);
        }

        public static string ToRupiah(this decimal angka)
        {
            return string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "Rp {0:N0}", angka);
        }
    }
}
