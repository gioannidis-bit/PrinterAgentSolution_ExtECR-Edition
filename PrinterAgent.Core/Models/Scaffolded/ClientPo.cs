using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ClientPo
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public long? PosInfoId { get; set; }

    [StringLength(50)]
    public string? Theme { get; set; }

    public bool? LogInToOrder { get; set; }

    public int? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("ClientPos")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [ForeignKey("PosInfoId")]
    [InverseProperty("ClientPos")]
    public virtual PosInfo? PosInfo { get; set; }
}
