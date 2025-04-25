using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("CategoriesForBox")]
public partial class CategoriesForBox
{
    [Key]
    public long Id { get; set; }

    public string? Description { get; set; }

    public bool? IsEnable { get; set; }

    public long? Code { get; set; }

    public int? CategoryIndex { get; set; }

    public bool? IsCoolChicks { get; set; }

    [InverseProperty("CategoriesForBox")]
    public virtual ICollection<MainProductForBox> MainProductForBoxes { get; set; } = new List<MainProductForBox>();
}
