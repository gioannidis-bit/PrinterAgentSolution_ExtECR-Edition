using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("EndOfDayVoidsAnalysis_Hist")]
public partial class EndOfDayVoidsAnalysisHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? EndOfDayId { get; set; }

    public long? AccountId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Total { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public short? AccountType { get; set; }
}
