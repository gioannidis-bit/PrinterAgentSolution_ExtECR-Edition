using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PdaModule")]
public partial class PdaModule
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    public int? MaxActiveUsers { get; set; }

    public long? PosInfoId { get; set; }

    public long? PageSetId { get; set; }

    [StringLength(20)]
    public string? Code { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("PdaModule")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("PdaModule")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("PageSetId")]
    [InverseProperty("PdaModules")]
    public virtual PageSet? PageSet { get; set; }

    [InverseProperty("PdaModule")]
    public virtual ICollection<PdaModuleDetail> PdaModuleDetails { get; set; } = new List<PdaModuleDetail>();

    [ForeignKey("PosInfoId")]
    [InverseProperty("PdaModules")]
    public virtual PosInfo? PosInfo { get; set; }
}
