using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DiscountType")]
public partial class DiscountType
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? Priority { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActiveTo { get; set; }

    public long? PosId { get; set; }

    [InverseProperty("DiscountType")]
    public virtual ICollection<DiscountTypeResult> DiscountTypeResults { get; set; } = new List<DiscountTypeResult>();

    [InverseProperty("DiscountType")]
    public virtual ICollection<DiscountTypeRule> DiscountTypeRules { get; set; } = new List<DiscountTypeRule>();
}
