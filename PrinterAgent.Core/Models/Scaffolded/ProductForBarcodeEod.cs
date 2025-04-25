using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ProductForBarcodeEod")]
public partial class ProductForBarcodeEod
{
    [Key]
    public long Id { get; set; }

    public long ProductId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductForBarcodeEods")]
    public virtual Product Product { get; set; } = null!;
}
