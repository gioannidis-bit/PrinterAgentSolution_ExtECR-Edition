using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EndOfYear")]
public partial class EndOfYear
{
    [Key]
    public long Id { get; set; }

    public int? ClosedYear { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDate { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }
}
