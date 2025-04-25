using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class ProductBarcode
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Barcode { get; set; }

    public long? ProductId { get; set; }

    public byte? Type { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductBarcodes")]
    public virtual Product? Product { get; set; }
}
