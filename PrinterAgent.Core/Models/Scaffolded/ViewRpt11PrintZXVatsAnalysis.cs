using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt11PrintZXVatsAnalysis
{
    public long? VatId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Tax { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? VatAmount { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Net { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }
}
