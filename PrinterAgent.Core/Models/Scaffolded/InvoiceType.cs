using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class InvoiceType
{
    [Key]
    public long Id { get; set; }

    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(50)]
    public string? Abbreviation { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public short? Type { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("InvoiceType")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("InvoicesType")]
    public virtual ICollection<PosInfoDetail> PosInfoDetails { get; set; } = new List<PosInfoDetail>();

    [InverseProperty("InvoiceType")]
    public virtual ICollection<PredefinedCredit> PredefinedCredits { get; set; } = new List<PredefinedCredit>();
}
