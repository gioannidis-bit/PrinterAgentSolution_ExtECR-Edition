using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderDetailVatAnal")]
public partial class OrderDetailVatAnal
{
    [Key]
    public long Id { get; set; }

    public long? OrderDetailId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(8, 4)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? VatAmount { get; set; }

    public long? VatId { get; set; }

    public long? TaxId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TaxAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [ForeignKey("OrderDetailId")]
    [InverseProperty("OrderDetailVatAnals")]
    public virtual OrderDetail? OrderDetail { get; set; }

    [ForeignKey("TaxId")]
    [InverseProperty("OrderDetailVatAnals")]
    public virtual Tax? Tax { get; set; }
}
