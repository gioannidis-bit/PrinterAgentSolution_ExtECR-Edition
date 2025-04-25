using System.Text.Json.Serialization;

namespace PrinterAgent.Core.Models
{
    public class PrinterAssignment
    {
        public int Id { get; set; }
        public int TemplateSectionId { get; set; }
        public string PrinterName { get; set; }
        public string PaperSize { get; set; }

        [JsonIgnore]
        public TemplateSection? TemplateSection { get; set; }
    }
}
