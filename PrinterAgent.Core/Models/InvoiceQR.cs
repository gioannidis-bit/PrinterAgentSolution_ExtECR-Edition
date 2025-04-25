namespace PrinterAgent.Core.Models
{
    public class InvoiceQR
    {
        public long InvoiceId { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
