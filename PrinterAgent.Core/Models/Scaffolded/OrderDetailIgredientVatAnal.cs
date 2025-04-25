using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderDetailIgredientVatAnal")]
public partial class OrderDetailIgredientVatAnal
{
    [Key]
    public long Id { get; set; }

    public long? OrderDetailIgredientsId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Gross { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Net { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? VatRate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? VatAmount { get; set; }

    public long? VatId { get; set; }

    public long? TaxId { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TaxAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [ForeignKey("OrderDetailIgredientsId")]
    [InverseProperty("OrderDetailIgredientVatAnals")]
    public virtual OrderDetailIgredient? OrderDetailIgredients { get; set; }

    [ForeignKey("TaxId")]
    [InverseProperty("OrderDetailIgredientVatAnals")]
    public virtual Tax? Tax { get; set; }
}
