using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("MainProductForBox")]
public partial class MainProductForBox
{
    [Key]
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? Code { get; set; }

    public int? EnvFee { get; set; }

    [Column(TypeName = "money")]
    public decimal? InitialPrice { get; set; }

    public int? ProductIndex { get; set; }

    public string? InfoEl { get; set; }

    public bool? IsEnable { get; set; }

    public bool? IsAvailable { get; set; }

    public long? CategoriesForBoxId { get; set; }

    public bool? IsCoolChicks { get; set; }

    [ForeignKey("CategoriesForBoxId")]
    [InverseProperty("MainProductForBoxes")]
    public virtual CategoriesForBox? CategoriesForBox { get; set; }

    [InverseProperty("MainProductForBox")]
    public virtual ICollection<SelectionsForBox> SelectionsForBoxes { get; set; } = new List<SelectionsForBox>();
}
