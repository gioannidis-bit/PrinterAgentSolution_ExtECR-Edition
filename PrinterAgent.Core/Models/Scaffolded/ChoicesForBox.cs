using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ChoicesForBox")]
public partial class ChoicesForBox
{
    [Key]
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? Code { get; set; }

    [Column(TypeName = "money")]
    public decimal? ChangeInPrice { get; set; }

    [Column(TypeName = "money")]
    public decimal? EnvFee { get; set; }

    public bool? IsAvailable { get; set; }

    public bool? IsChecked { get; set; }

    public bool? IsIngredient { get; set; }

    public long? SelectionsForBoxId { get; set; }

    public string? DisableSelections { get; set; }

    public int? ChoiceIndex { get; set; }

    [ForeignKey("SelectionsForBoxId")]
    [InverseProperty("ChoicesForBoxes")]
    public virtual SelectionsForBox? SelectionsForBox { get; set; }
}
