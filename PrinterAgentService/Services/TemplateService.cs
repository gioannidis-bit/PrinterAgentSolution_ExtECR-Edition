using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrinterAgent.Core.Data;
using PrinterAgent.Core.Models;
using PrinterAgent.Core.Services;

namespace PrinterAgentService.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly AppDbContext _ctx;

        public TemplateService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        // —— Templates ——
        public async Task<IEnumerable<PrintTemplate>> GetAllTemplatesAsync()
            => await _ctx.PrintTemplates
                          .Include(t => t.Sections)
                          .ToListAsync();

        public async Task<PrintTemplate> GetTemplateAsync(int id)
            => await _ctx.PrintTemplates
                          .Include(t => t.Sections)
                          .ThenInclude(s => s.Printers)
                          .FirstOrDefaultAsync(t => t.Id == id);

        public async Task<PrintTemplate> CreateTemplateAsync(PrintTemplate template)
        {
            template.CreatedAt = System.DateTime.UtcNow;
            _ctx.PrintTemplates.Add(template);
            await _ctx.SaveChangesAsync();
            return template;
        }

        public async Task UpdateTemplateAsync(PrintTemplate template)
        {
            _ctx.PrintTemplates.Update(template);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteTemplateAsync(int id)
        {
            var tpl = await _ctx.PrintTemplates.FindAsync(id);
            if (tpl != null)
            {
                _ctx.PrintTemplates.Remove(tpl);
                await _ctx.SaveChangesAsync();
            }
        }

        // —— Sections ——
        public async Task<IEnumerable<TemplateSection>> GetSectionsAsync(int templateId)
            => await _ctx.TemplateSections
                          .Where(s => s.PrintTemplateId == templateId)
                          .Include(s => s.Printers)
                          .ToListAsync();

        public async Task<TemplateSection> CreateSectionAsync(int templateId, TemplateSection section)
        {
            section.PrintTemplateId = templateId;
            _ctx.TemplateSections.Add(section);
            await _ctx.SaveChangesAsync();
            return section;
        }

        public async Task UpdateSectionAsync(TemplateSection section)
        {
            _ctx.TemplateSections.Update(section);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteSectionAsync(int sectionId)
        {
            var sec = await _ctx.TemplateSections.FindAsync(sectionId);
            if (sec != null)
            {
                _ctx.TemplateSections.Remove(sec);
                await _ctx.SaveChangesAsync();
            }
        }

        // —— Assignments ——
        public async Task<IEnumerable<PrinterAssignment>> GetAssignmentsAsync(int sectionId)
            => await _ctx.PrinterAssignments
                          .Where(a => a.TemplateSectionId == sectionId)
                          .ToListAsync();

        public async Task<PrinterAssignment> CreateAssignmentAsync(int sectionId, PrinterAssignment assignment)
        {
            assignment.TemplateSectionId = sectionId;
            _ctx.PrinterAssignments.Add(assignment);
            await _ctx.SaveChangesAsync();
            return assignment;
        }

        public async Task DeleteAssignmentAsync(int assignmentId)
        {
            var a = await _ctx.PrinterAssignments.FindAsync(assignmentId);
            if (a != null)
            {
                _ctx.PrinterAssignments.Remove(a);
                await _ctx.SaveChangesAsync();
            }
        }

        // —— InvoiceQR ——
        public async Task<InvoiceQR> GetInvoiceQrAsync(long invoiceId)
            => await _ctx.InvoiceQR.FindAsync(invoiceId);

        public async Task<InvoiceQR> CreateInvoiceQrAsync(InvoiceQR qr)
        {
            _ctx.InvoiceQR.Add(qr);
            await _ctx.SaveChangesAsync();
            return qr;
        }
    }
}
