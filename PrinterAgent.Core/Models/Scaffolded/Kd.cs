using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Kd
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public byte? Status { get; set; }

    public long? PosInfoId { get; set; }

    public bool? IsDeleted { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("Kds")]
    public virtual PosInfo? PosInfo { get; set; }

    [InverseProperty("Kds")]
    public virtual ICollection<PosInfoKdsAssoc> PosInfoKdsAssocs { get; set; } = new List<PosInfoKdsAssoc>();

    [InverseProperty("Kds")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
