using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Combo")]
public partial class Combo
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public long? ProductComboId { get; set; }

    public long? DepartmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [InverseProperty("Combo")]
    public virtual ICollection<ComboDetail> ComboDetails { get; set; } = new List<ComboDetail>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Combos")]
    public virtual Department? Department { get; set; }

    [ForeignKey("ProductComboId")]
    [InverseProperty("Combos")]
    public virtual Product? ProductCombo { get; set; }
}
