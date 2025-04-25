using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("KitchenRegion")]
public partial class KitchenRegion
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? ItemRegion { get; set; }

    public int? RegionPosition { get; set; }

    [StringLength(5)]
    public string? Abbr { get; set; }

    [InverseProperty("KitchenRegion")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
