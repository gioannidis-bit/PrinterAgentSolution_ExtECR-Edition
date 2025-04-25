using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("KitchenInstruction_Hist")]
public partial class KitchenInstructionHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? KitchenId { get; set; }

    [StringLength(300)]
    public string? Message { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }
}
