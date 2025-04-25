using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt09PrintZXMaster
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Day { get; set; }

    [Column("dtDateTime", TypeName = "datetime")]
    public DateTime DtDateTime { get; set; }

    [StringLength(50)]
    public string? PosCode { get; set; }

    [StringLength(250)]
    public string? PosDescription { get; set; }

    public int? ReportNo { get; set; }

    [Column(TypeName = "money")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? VatAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Net { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    public int? TicketCount { get; set; }

    public int? ItemsCount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Barcodes { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }
}
