﻿using System.Collections.Generic;
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
            // 1) Φόρτωσε την υπάρχουσα εγγραφή από τη βάση:
            var existing = await _ctx.PrintTemplates.FindAsync(template.Id);
            if (existing == null)
                return;

            // 2) Ενημέρωσε ΜΟΝΟ τα επιτρεπόμενα πεδία:
            existing.Name = template.Name;
            existing.FileName = template.FileName;
            existing.DataSourceType = template.DataSourceType;
            // **ΜΗΝ ΑΓΓΙΖΕΙΣ** το existing.CreatedAt

            // 3) Αποθήκευσε τις αλλαγές
            await _ctx.SaveChangesAsync();
        }


        public async Task DeleteTemplateAsync(int templateId)
        {
            // 1) Φόρτωσε όλες τις sections αυτού του template
            var sections = await _ctx.TemplateSections
                                     .Where(s => s.PrintTemplateId == templateId)
                                     .ToListAsync();

            // 2) Για κάθε section, διέγραψε πρώτα τα assignments
            foreach (var sec in sections)
            {
                var assigns = await _ctx.PrinterAssignments
                                        .Where(a => a.TemplateSectionId == sec.Id)
                                        .ToListAsync();
                _ctx.PrinterAssignments.RemoveRange(assigns);
            }

            // 3) Διέγραψε τις sections
            _ctx.TemplateSections.RemoveRange(sections);

            // 4) Τέλος, διέγραψε το ίδιο το printTemplate
            var tpl = await _ctx.PrintTemplates.FindAsync(templateId);
            if (tpl != null)
                _ctx.PrintTemplates.Remove(tpl);

            // 5) Αποθήκευση
            await _ctx.SaveChangesAsync();
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
            var existing = await _ctx.TemplateSections.FindAsync(section.Id);
            if (existing == null) throw new KeyNotFoundException($"Section {section.Id} not found");
            existing.Name = section.Name;
            existing.Order = section.Order;
            // **ΔΕΝ** αγγίζεις εδώ το existing.PrintTemplateId
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
