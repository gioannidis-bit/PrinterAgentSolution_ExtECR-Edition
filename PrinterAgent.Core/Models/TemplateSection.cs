using System.Text.Json.Serialization;

namespace PrinterAgent.Core.Models
{
    public class TemplateSection
    {
        public int Id { get; set; }
        public int PrintTemplateId { get; set; }
        public string Name { get; set; }         // π.χ. "Header", "Body", "Footer"
        public int Order { get; set; }

        [JsonIgnore] 
        public PrintTemplate? PrintTemplate { get; set; }
        public ICollection<PrinterAssignment> Printers { get; set; } = new List<PrinterAssignment>();
    }
}