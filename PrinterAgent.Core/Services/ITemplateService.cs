using System.Collections.Generic;
using System.Threading.Tasks;
using PrinterAgent.Core.Models;

namespace PrinterAgent.Core.Services
{
    public interface ITemplateService
    {
        // Templates
        Task<IEnumerable<PrintTemplate>> GetAllTemplatesAsync();
        Task<PrintTemplate> GetTemplateAsync(int templateId);
        Task<PrintTemplate> CreateTemplateAsync(PrintTemplate template);
        Task UpdateTemplateAsync(PrintTemplate template);
        Task DeleteTemplateAsync(int templateId);

        // Sections
        Task<IEnumerable<TemplateSection>> GetSectionsAsync(int templateId);
        Task<TemplateSection> CreateSectionAsync(int templateId, TemplateSection section);
        Task UpdateSectionAsync(TemplateSection section);
        Task DeleteSectionAsync(int sectionId);

        // Printer Assignments
        Task<IEnumerable<PrinterAssignment>> GetAssignmentsAsync(int sectionId);
        Task<PrinterAssignment> CreateAssignmentAsync(int sectionId, PrinterAssignment assignment);
        Task DeleteAssignmentAsync(int assignmentId);

        // InvoiceQR (optional read/write)
        Task<InvoiceQR> GetInvoiceQrAsync(long invoiceId);
        Task<InvoiceQR> CreateInvoiceQrAsync(InvoiceQR qr);
    }
}
