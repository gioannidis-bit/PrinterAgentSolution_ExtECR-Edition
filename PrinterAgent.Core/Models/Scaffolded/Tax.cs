using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Tax")]
public partial class Tax
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(8, 4)")]
    public decimal? Percentage { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("Tax")]
    public virtual ICollection<EndOfDayDetail> EndOfDayDetails { get; set; } = new List<EndOfDayDetail>();

    [InverseProperty("Tax")]
    public virtual ICollection<OrderDetailIgredientVatAnal> OrderDetailIgredientVatAnals { get; set; } = new List<OrderDetailIgredientVatAnal>();

    [InverseProperty("Tax")]
    public virtual ICollection<OrderDetailVatAnal> OrderDetailVatAnals { get; set; } = new List<OrderDetailVatAnal>();

    [InverseProperty("Tax")]
    public virtual ICollection<PricelistDetail> PricelistDetails { get; set; } = new List<PricelistDetail>();
}
