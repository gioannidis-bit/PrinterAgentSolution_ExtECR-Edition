using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Vat")]
public partial class Vat
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(8, 4)")]
    public decimal? Percentage { get; set; }

    public int? Code { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    public long? ProtelAirVatId { get; set; }

    [InverseProperty("Vat")]
    public virtual ICollection<EndOfDayDetail> EndOfDayDetails { get; set; } = new List<EndOfDayDetail>();

    [InverseProperty("Vat")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    [InverseProperty("Vat")]
    public virtual ICollection<PricelistDetail> PricelistDetails { get; set; } = new List<PricelistDetail>();
}
