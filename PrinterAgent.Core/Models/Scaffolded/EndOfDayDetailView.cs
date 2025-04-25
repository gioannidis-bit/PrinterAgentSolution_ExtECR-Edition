using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class EndOfDayDetailView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? EndOfdayId { get; set; }

    public long? VatId { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? VatAmount { get; set; }

    public long? TaxId { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? Discount { get; set; }
}
