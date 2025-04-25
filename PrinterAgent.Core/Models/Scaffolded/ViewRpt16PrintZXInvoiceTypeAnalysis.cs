using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt16PrintZXInvoiceTypeAnalysis
{
    public long? InvoiceTypeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? VatAmount { get; set; }

    public int? TotalInvoices { get; set; }

    public bool? IsVoided { get; set; }

    [Column(TypeName = "money")]
    public decimal? Total { get; set; }

    [Column("minCount")]
    public int? MinCount { get; set; }

    [Column("maxCounter")]
    public int? MaxCounter { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }
}
