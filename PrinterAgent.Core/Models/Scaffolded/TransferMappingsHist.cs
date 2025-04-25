using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("TransferMappings_Hist")]
public partial class TransferMappingsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string? PmsDepartmentId { get; set; }

    [StringLength(250)]
    public string? PmsDepDescription { get; set; }

    public long? ProductId { get; set; }

    public long? SalesTypeId { get; set; }

    public double? VatPercentage { get; set; }

    public long? PosDepartmentId { get; set; }

    public long? PriceListId { get; set; }

    public int? VatCode { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? HotelId { get; set; }

    [StringLength(100)]
    public string? TipsPmsDepartmentId { get; set; }
}
