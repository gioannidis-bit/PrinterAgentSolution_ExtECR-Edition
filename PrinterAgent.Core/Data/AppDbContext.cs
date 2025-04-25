using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrinterAgent.Core.Models;

namespace PrinterAgent.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        // ——— Νέα DbSets ———
        public DbSet<PrintTemplate> PrintTemplates { get; set; }
        public DbSet<TemplateSection> TemplateSections { get; set; }
        public DbSet<PrinterAssignment> PrinterAssignments { get; set; }
        public DbSet<InvoiceQR> InvoiceQrs { get; set; }
    }

}
