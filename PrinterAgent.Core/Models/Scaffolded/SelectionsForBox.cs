using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("SelectionsForBox")]
public partial class SelectionsForBox
{
    [Key]
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? Code { get; set; }

    public bool? IsMultiple { get; set; }

    public bool? IsNecessary { get; set; }

    public bool? IsReplacePrice { get; set; }

    public long? MainProductForBoxId { get; set; }

    public int? MaxItems { get; set; }

    public int? SelectionIndex { get; set; }

    [InverseProperty("SelectionsForBox")]
    public virtual ICollection<ChoicesForBox> ChoicesForBoxes { get; set; } = new List<ChoicesForBox>();

    [ForeignKey("MainProductForBoxId")]
    [InverseProperty("SelectionsForBoxes")]
    public virtual MainProductForBox? MainProductForBox { get; set; }
}
