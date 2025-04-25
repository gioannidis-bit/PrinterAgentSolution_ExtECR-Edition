using System;
using Microsoft.EntityFrameworkCore;
using PrinterAgent.Core.Models;

namespace PrinterAgent.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // ——— Test DbSets ———
        public DbSet<PrintTemplate> PrintTemplates { get; set; }
        public DbSet<TemplateSection> TemplateSections { get; set; }
        public DbSet<PrinterAssignment> PrinterAssignments { get; set; }
        public DbSet<InvoiceQR> InvoiceQR { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PrintTemplate
            modelBuilder.Entity<PrintTemplate>(entity =>
            {
                entity.ToTable("PrintTemplates");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(200);
                entity.Property(e => e.FileName)
                      .IsRequired()
                      .HasMaxLength(200);
                entity.Property(e => e.DataSourceType)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("GETUTCDATE()");
            });

            // TemplateSection
            modelBuilder.Entity<TemplateSection>(entity =>
            {
                entity.ToTable("TemplateSections");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(e => e.Order)
                      .HasColumnName("Order");
                entity.HasOne(e => e.PrintTemplate)
                      .WithMany(t => t.Sections)
                      .HasForeignKey(e => e.PrintTemplateId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // PrinterAssignment
            modelBuilder.Entity<PrinterAssignment>(entity =>
            {
                entity.ToTable("PrinterAssignments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PrinterName)
                      .IsRequired()
                      .HasMaxLength(200);
                entity.Property(e => e.PaperSize)
                      .HasMaxLength(50);
                entity.HasOne(e => e.TemplateSection)
                      .WithMany(s => s.Printers)
                      .HasForeignKey(e => e.TemplateSectionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // InvoiceQR
            modelBuilder.Entity<InvoiceQR>(entity =>
            {
                entity.ToTable("InvoiceQR");
                entity.HasKey(e => e.InvoiceId);
                entity.Property(e => e.Url)
                      .IsRequired()
                      .HasMaxLength(500);
                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("GETUTCDATE()");
            });
        }
    }
}
