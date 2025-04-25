using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EndOfDayPaymentAnalysis")]
public partial class EndOfDayPaymentAnalysis
{
    [Key]
    public long Id { get; set; }

    public long? EndOfDayId { get; set; }

    public long? AccountId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public short? AccountType { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("EndOfDayPaymentAnalyses")]
    public virtual Account? Account { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("EndOfDayPaymentAnalyses")]
    public virtual EndOfDay? EndOfDay { get; set; }
}
