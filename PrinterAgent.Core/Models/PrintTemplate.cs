namespace PrinterAgent.Core.Models
{
    public class PrintTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }         // π.χ. "ReceiptWithQR"
        public string FileName { get; set; }     // .rpt ή HTML template reference
        public string DataSourceType { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<TemplateSection> Sections { get; set; }
    }
}
