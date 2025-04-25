using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class PredefinedCredit
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    public long? InvoiceTypeId { get; set; }

    [ForeignKey("InvoiceTypeId")]
    [InverseProperty("PredefinedCredits")]
    public virtual InvoiceType? InvoiceType { get; set; }
}
