namespace RetailToserbaApps.Models
{
    public class InvoiceItem
    {
        public string NamaBarang { get; set; }
        public long Harga { get; set; }
        public int Quantity { get; set; }
        public long Subtotal { get; set; }
    }
}