using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ProductsForEOD")]
public partial class ProductsForEod
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductsForEods")]
    public virtual Product? Product { get; set; }
}
